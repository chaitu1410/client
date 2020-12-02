using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace client.Data
{
    public class TotalSaleRepository
    {

        public async Task<IEnumerable<TotalSale>> GetAll()
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => _db.TotalSales.OrderByDescending(row => row.Date).ToList());
        }

        public async Task<IEnumerable<TotalSale>> GetByDate(DateTime date)
        {
            AppDbContext _db = new AppDbContext();
            await CreateTotalSale(date);
            return await Task.Run(() => _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).ToList());
            //return _db.Transactions.Where(t => new DateTime(t.Date.Year, t.Date.Month, t.Date.Day) == new DateTime(date.Year, date.Month, date.Day));
        }

        private async Task<TotalSale> FindByDate(DateTime date)
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => _db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).FirstOrDefault());
        }

        private async Task Add(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);
            if (!isValid)
            {
                return;
            }
            _db.TotalSales.Add(totalSale);
            await _db.SaveChangesAsync();
        }

        public async Task<TotalSale> Find(int id)
        {
            AppDbContext _db = new AppDbContext();
            return await _db.TotalSales.FindAsync(id);
        }

        private async Task Update(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            ValidationContext context = new ValidationContext(totalSale, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(totalSale, context, validationResults);

            if (!isValid)
            {
                return;
            }
            _db.TotalSales.Update(totalSale);
            await _db.SaveChangesAsync();
        }

        public async Task Remove(TotalSale totalSale)
        {
            AppDbContext _db = new AppDbContext();
            _db.TotalSales.Remove(totalSale);
            await _db.SaveChangesAsync();
        }

        private async Task<TotalSale> CalculateTotalSale(DateTime date)
        {
            TransactionRepository transactionRepository = new TransactionRepository();
            BorrowRepository borrowRepository = new BorrowRepository();
            SaleReturnRepository saleReturnRepository = new SaleReturnRepository();

            IEnumerable<Transaction> transactions = await transactionRepository.GetAllByDate(date);
            List<Borrow> borrowsUndeposited = await borrowRepository.GetAllUndepositedByDate(date);
            List<Borrow> borrowsDeposited = await borrowRepository.GetAllDepositedByDate(date);
            IEnumerable<SaleReturn> saleReturns = saleReturnRepository.GetAllByDate(date);

            double CashPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Cash).Sum(row => row.Amount));
            double CardPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Card).Sum(row => row.Amount));
            double UPIPayment = await Task.Run(() => (double)transactions.Where(row => row.PaymentMethod == PaymentMethods.Online).Sum(row => row.Amount));
            double ExtraAmount = await Task.Run(() => (double)transactions.Sum(row => row.Extras));
            double SaleReturnAmount = await Task.Run(() => (double)saleReturns.Sum(row => row.Amount));
            double BorrowingBalanceAmount = await Task.Run(() => (double)borrowsUndeposited.Sum(row => row.Amount));
            double CreditDepositAmount = await Task.Run(() => (double)borrowsDeposited.Sum(row => row.Amount));

            double TotalSaleAmount = await Task.Run(() => (CashPayment + CardPayment + UPIPayment + SaleReturnAmount + BorrowingBalanceAmount - CreditDepositAmount - ExtraAmount));

            TotalSale totalSale = new TotalSale
            {
                CashAmount = (decimal)CashPayment,
                CardAmount = (decimal)CardPayment,
                OnlineAmount = (decimal)UPIPayment,
                SaleReturnAmount = (decimal)SaleReturnAmount,
                ExtraAmount = (decimal)ExtraAmount,
                BorrowingBalanceAmount = (decimal)BorrowingBalanceAmount,
                CreditDepositAmount = (decimal)CreditDepositAmount,
                TotalSaleAmount = (decimal)TotalSaleAmount,
                Date = date
            };
            return totalSale;       
        }


        private async Task CreateTotalSale(DateTime date)
        {
            if (await isNotAvailable(date))
            {
                TotalSale totalSale = await CalculateTotalSale(date);
                await Add(totalSale);
            }
            else if (date.Date.Equals(DateTime.Today))
            {
                TotalSale calculatedTotalSale = await CalculateTotalSale(date);
                TotalSale totalSale = await FindByDate(date);
                totalSale.CashAmount = calculatedTotalSale.CashAmount;
                totalSale.CardAmount = calculatedTotalSale.CardAmount;
                totalSale.OnlineAmount = calculatedTotalSale.OnlineAmount;
                totalSale.SaleReturnAmount = calculatedTotalSale.SaleReturnAmount;
                totalSale.ExtraAmount = calculatedTotalSale.ExtraAmount;
                totalSale.BorrowingBalanceAmount = calculatedTotalSale.BorrowingBalanceAmount;
                totalSale.CreditDepositAmount = calculatedTotalSale.CreditDepositAmount;
                totalSale.TotalSaleAmount = calculatedTotalSale.TotalSaleAmount;
                await Update(totalSale);
            }
        }

        private async Task<bool> isNotAvailable(DateTime date) 
        {
            AppDbContext _db = new AppDbContext();
            return await Task.Run(() => !_db.TotalSales.Where(row => row.Date.Date.Equals(date.Date)).Any());
        }


        /*
        public TotalSale GetCurrentTotalSale() 
        {
            //_db.TotalSales.Where(row => row.Date.Date.Equals())
            //CalculateTotalSale();
            IEnumerable<TotalSale> totalSales = GetByDate(DateTime.Now);
            if(totalSales != null)
            {
                if (totalSales.Any())
                {
                    return totalSales.First();
                }
            }
            return null;
        }
        */

        public async Task GeneratePdf(TotalSale totalSale)
        {
            Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            try
            {
                BorrowRepository borrowRepository = new BorrowRepository();
                List<Borrow> borrowsUndeposited = await borrowRepository.GetAllUndepositedByDate(totalSale.Date);
                List<Borrow> borrowsDeposited = await borrowRepository.GetAllDepositedByDate(totalSale.Date);

                
                //Create new PDF document
                string fileName = totalSale.Date.ToString();
                fileName = fileName.Replace("-", "");
                fileName = fileName.Replace(":", "");
                fileName = fileName.Replace(" ", "");
                fileName += ".pdf";
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\Client\\{fileName}";
                PdfWriter.GetInstance(document, new FileStream(path, FileMode.OpenOrCreate));

                document.Open();
                //Report Header
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 16, BaseColor.Black);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk("Client", fntHead));
                document.Add(prgHeading);

                //Author
                Paragraph prgAuthor = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntAuthor = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.Black);
                prgAuthor.Alignment = Element.ALIGN_RIGHT;
                prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
                prgAuthor.Add(new Chunk("\nDate : " + totalSale.Date.ToShortDateString(), fntAuthor));
                document.Add(prgAuthor);

                //Add a line seperation
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.Black, Element.ALIGN_LEFT, 1)));
                document.Add(p);

                ///////////////////////////////////////// START Total Sale Table ////////////////////////////////////////////

                document.Add(new Chunk("\n", fntHead));
                Paragraph prg = new Paragraph();
                prg.Alignment = Element.ALIGN_CENTER;
                Font fntHeading = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 13, BaseColor.Black);
                Chunk totalSaleLabel = new Chunk("Total Sale", fntHeading);
                prg.Add(totalSaleLabel);
                document.Add(prg);

                //Write the table
                PdfPTable table = new PdfPTable(8);
                table.TotalWidth = 550f;
                //fix the absolute width of the table
                table.LockedWidth = true;
                float[] widths = new float[] { 2f, 2f, 2f, 2f, 2f, 2f, 2f, 2f };
                table.SetWidths(widths);
                table.HorizontalAlignment = 1;
                //leave a gap before and after the table
                table.SpacingBefore = 10f;
                table.SpacingAfter = 20f;

                Font fntColumnHeader = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.Black);
                for (int i = 0; i < 8; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.Gray;
                    cell.AddElement(new Chunk(totalSale.Columns[i], fntColumnHeader));
                    table.AddCell(cell);
                }
                //table Data
                for (int i = 0; i < 8; i++)
                {

                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.White;
                    cell.AddElement(new Chunk(totalSale.GetByString(totalSale.Columns[i]), fntColumnHeader));
                    table.AddCell(cell);
                }
                document.Add(table);
                /////////////////////////////////////////// END Total Sale Table ////////////////////////////////////////
                ///

                ///////////////////////////////////////// START Borrowing Balance Table ////////////////////////////////////////////

                document.Add(new Chunk("\n", fntHead));
                Paragraph prg2 = new Paragraph();
                prg2.Alignment = Element.ALIGN_CENTER;
                Chunk bbLabel = new Chunk("Borrowing Balance", fntHeading);
                prg2.Add(bbLabel);
                document.Add(prg2);

                //Write the table
                PdfPTable bbTable = new PdfPTable(2);
                bbTable.TotalWidth = 400f;
                //fix the absolute width of the table
                bbTable.LockedWidth = true;
                float[] bbWidths = new float[] { 5f, 2f };
                bbTable.SetWidths(bbWidths);
                bbTable.HorizontalAlignment = 1;
                //leave a gap before and after the table
                bbTable.SpacingBefore = 10f;
                bbTable.SpacingAfter = 20f;
                for (int i = 0; i < 2; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.Gray;
                    cell.AddElement(new Chunk(Borrow.PdfColumnsName[i], fntColumnHeader));
                    bbTable.AddCell(cell);
                }
                //table Data
                for (int i = 0; i < borrowsUndeposited.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.BackgroundColor = BaseColor.White;
                        cell.AddElement(new Chunk(borrowsUndeposited[i].GetByString(Borrow.PdfColumnsName[j]), fntColumnHeader));
                        bbTable.AddCell(cell);
                    }
                }
                document.Add(bbTable);
                /////////////////////////////////////////// END Borrowing Balance Table ////////////////////////////////////////
                ///


                ///////////////////////////////////////// START Credit Deposit Table ////////////////////////////////////////////

                document.Add(new Chunk("\n", fntHead));
                Paragraph prg3 = new Paragraph();
                prg3.Alignment = Element.ALIGN_CENTER;
                Chunk cdLabel = new Chunk("Credit Deposite", fntHeading);
                prg3.Add(cdLabel);
                document.Add(prg3);

                //Write the table
                PdfPTable cdTable = new PdfPTable(2);
                cdTable.TotalWidth = 400f;
                //fix the absolute width of the table
                cdTable.LockedWidth = true;
                float[] cdWidths = new float[] { 5f, 2f };
                cdTable.SetWidths(cdWidths);
                cdTable.HorizontalAlignment = 1;
                //leave a gap before and after the table
                cdTable.SpacingBefore = 10f;
                cdTable.SpacingAfter = 20f;
                for (int i = 0; i < 2; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.Gray;
                    cell.AddElement(new Chunk(Borrow.PdfColumnsName[i], fntColumnHeader));
                    cdTable.AddCell(cell);
                }
                //table Data
                for (int i = 0; i < borrowsDeposited.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        PdfPCell cell = new PdfPCell();
                        cell.BackgroundColor = BaseColor.White;
                        cell.AddElement(new Chunk(borrowsDeposited[i].GetByString(Borrow.PdfColumnsName[j]), fntColumnHeader));
                        cdTable.AddCell(cell);
                    }
                }
                await Task.Run(() => document.Add(cdTable));
                /////////////////////////////////////////// END Credit Deposit Table ////////////////////////////////////////
                document.Close();
            }
            catch (DirectoryNotFoundException)
            {
                throw new PdfGenerationException("Please Create Folder Named Client in yout Documents Folder.");
            }
            catch (Exception)
            {
                throw new PdfGenerationException("Failed to generate Pdf.");
            }
            finally
            {
                if(document != null)
                {
                    if (document.IsOpen())
                    {
                        document.Close();
                    }
                }
            }
        }
    }
}
