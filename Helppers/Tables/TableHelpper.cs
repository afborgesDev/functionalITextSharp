using ITextFunctionalLib.Helppers.Paragraphs;
using ITextFunctionalLib.InputParams;
using ITextFunctionalLib.Kinds;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ITextFunctionalLib.Helppers.Tables
{
    public static class TableHelpper
    {
        public static PdfPTable AddText(this PdfPTable @this, Content content)
        {
            @this.AddCell(new PdfPCell(new Paragraph(content.Text, content.Font)
            {
                Alignment = content.Alignment
            })
            {
                HorizontalAlignment = content.HorizontalAlignment,
                Border = content.Border,
                PaddingTop = content.Padding.Top,
                PaddingBottom = content.Padding.Botton,
                PaddingLeft = content.Padding.Left,
                PaddingRight = content.Padding.Right
            });

            return @this;
        }

        public static PdfPTable AddTextFormated(this PdfPTable @this, Content content, params object[] args)
        {
            content.Text = string.Format(content.Text, args);
            return AddText(@this, content);
        }

        public static PdfPTable AddTextWhen(this PdfPTable @this, Content content, bool condition, string textTrue, string textFalse)
        {
            content.Text = condition ? textTrue : textFalse;
            return AddText(@this, content);
        }

        public static PdfPTable AddTextWhenFormated(this PdfPTable @this, Content content, bool condition, string textTrue, string textFalse, params object[] args)
        {
            content.Text = condition ? string.Format(textTrue, args) : string.Format(textFalse, args);
            return AddText(@this, content);
        }

        public static PdfPTable AddBlankLine(this PdfPTable @this, int numberOfLines = 1)
        {
            @this.AddCell(new PdfPCell(ParagraphHelpper.NewInBlank(numberOfLines)));
            return @this;
        }

        public static PdfPTable AddCells(this PdfPTable @this, params PdfPCell[] cells)
        {
            foreach (var cell in cells)
            {
                @this.AddCell(cell);
            }

            return @this;
        }

        public static PdfPTable AddCellWhen(this PdfPTable @this, bool condition, PdfPCell cellTrue, PdfPCell cellFalse)
        {
            @this.AddCell(condition ? cellTrue : cellFalse);
            return @this;
        }

        public static PdfPTable PushCell(this PdfPTable @this, PdfPCell cell)
        {
            @this.AddCell(cell);
            return @this;
        }

        public static PdfPTable DefineGridHeaderColumns(this PdfPTable @this, CellColumns cellsParams, params string[] columns)
        {
            if (columns.Length <= 0)
            {
                return @this;
            }

            if (cellsParams == null)
            {
                cellsParams = new CellColumns();
            }

            var cells = new PdfPCell[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                cells[i] = new PdfPCell(new Paragraph(columns[i], Fonts.Bold09))
                {
                    HorizontalAlignment = cellsParams.HorizontalAlignment,
                    VerticalAlignment = cellsParams.VerticalAlignment,
                    BackgroundColor = cellsParams.BackgroundColor
                };
            }

            @this.AddCells(cells);
            return @this;
        }

        public static void AddImageBorderLess(this PdfPTable @this, Image img) => @this.AddCell(new PdfPCell(img) { Border = 0 });
    }
}
