namespace ISCC.Interfaces
{
    public interface IContentIdTextBuilder
    {
        byte GetTextContentId(string text, int version = 0);
    }
}