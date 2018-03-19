using ITextFunctionalLib.Helppers.Paragraphs;
using iTextSharp.text;

namespace ITextFunctionalLib.Helppers.Documents
{
    public static class DocumentoHelpper
    {
        public static void AddParagraphWithBlank(this Document @this, int count) => @this.Add(ParagraphHelpper.NewInBlank(count));
    }
}
