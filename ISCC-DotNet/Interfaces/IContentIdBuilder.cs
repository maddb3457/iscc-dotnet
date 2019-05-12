namespace ISCC.Interfaces
{
    public interface IContentIdBuilder
    {
        byte ContentIdText(string text, bool partial = false);
    }
}