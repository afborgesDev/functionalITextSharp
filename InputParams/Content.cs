using ITextFunctionalLib.Constans;
using ITextFunctionalLib.Kinds;
using iTextSharp.text;

namespace ITextFunctionalLib.InputParams
{
    public class Content
    {
        public string Text { get; set; }
        public Font Font { get; set; } = Fonts.Normal;
        public int HorizontalAlignment { get; set; } = Element.ALIGN_UNDEFINED;
        public int Alignment { get; set; } = Element.ALIGN_UNDEFINED;
        public int Border { get; set; } = Constants.DEFAULT_BORDER;
        public Padding Padding { get; set; } = new Padding { Top = Constants.DEFAULT_PADDING, Botton = Constants.DEFAULT_PADDING, Left = Constants.DEFAULT_PADDING, Right = Constants.DEFAULT_PADDING };
    }
}
