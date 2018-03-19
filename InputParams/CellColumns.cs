using ITextFunctionalLib.Constans;
using iTextSharp.text;
using System.Drawing;

namespace ITextFunctionalLib.InputParams
{
    public class CellColumns
    {
        public int HorizontalAlignment { get; set; } = Element.ALIGN_CENTER;
        public int VerticalAlignment { get; set; } = Element.ALIGN_MIDDLE;
        public BaseColor BackgroundColor { get; set; } = new BaseColor(ColorTranslator.FromHtml(Constants.DEFAULT_GRAY_GRID_HEADER_COLOR));
    }
}

