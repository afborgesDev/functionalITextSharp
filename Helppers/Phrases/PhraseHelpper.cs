using iTextSharp.text;

namespace ITextFunctionalLib.Helppers.Phrases
{
    public static class PhraseHelpper
    {
        public static Phrase AddChunk(this Phrase @this, string Text, Font Font)
        {
            @this.Add(new Chunk(Text, Font));
            return @this;
        }
    }
}
