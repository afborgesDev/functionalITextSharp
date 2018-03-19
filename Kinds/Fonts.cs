using ITextFunctionalLib.Constans;
using iTextSharp.text;

namespace ITextFunctionalLib.Kinds
{
    public static class Fonts
    {
        public static Font Normal { get; set; } = new Font(FontFactory.GetFont(Constants.DEFAULT_FONT, Constants.DEFAULT_NORMAL_FONT_SIZE, Font.NORMAL));
        public static Font Normal10 { get; set; } = new Font(FontFactory.GetFont(Constants.DEFAULT_FONT, Constants.FONT_SIZE_09, Font.NORMAL));
        public static Font Bold { get; set; } = new Font(FontFactory.GetFont(Constants.DEFAULT_FONT, Constants.DEFAULT_NORMAL_FONT_SIZE, Font.BOLD));
        public static Font Bold10 { get; set; } = new Font(FontFactory.GetFont(Constants.DEFAULT_FONT, Constants.FONT_SIZE_10, Font.BOLD));
        public static Font Bold09 { get; set; } = new Font(FontFactory.GetFont(Constants.DEFAULT_FONT, Constants.FONT_SIZE_09, Font.BOLD));
    }
}
