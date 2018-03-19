using System.Linq;
using ITextFunctionalLib.Constans;
using iTextSharp.text;

namespace ITextFunctionalLib.Helppers.Paragraphs
{
    public static class ParagraphHelpper
    {
        public static Paragraph NewInBlank(int count) => new Paragraph(string.Join(string.Empty, Enumerable.Repeat(Constants.BLANK_LINE_CHARACTER, count)));
    }
}
