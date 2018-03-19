using ITextFunctionalLib.Constans;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ITextFunctionalLib.Utils
{
    public static class Utils
    {
        public static PdfPTable NewTable(int ColumNum = Constants.DEFAULT_NUM_COLUMNS_TABLE) => new PdfPTable(ColumNum);

        public static byte[] AddPagination(byte[] pdf)
        {
            var ms = new MemoryStream();
            var reader = new PdfReader(pdf);
            var n = reader.NumberOfPages;
            var document = new Document(PageSize.A4, 5f, 5f, 30f, 40f);
            var writer = PdfWriter.GetInstance(document, ms);
            document.Open();

            var cb = writer.DirectContent;
            int p = 0;

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                document.NewPage();
                p++;

                var importedPage = writer.GetImportedPage(reader, page);
                cb.AddTemplate(importedPage, 0, 0);

                var bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.BeginText();
                cb.SetFontAndSize(bf, 10);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, +p + " de " + n, 550, 10, 0);
                cb.EndText();
            }

            document.Close();
            return ms.ToArray();
        }
    }
}
