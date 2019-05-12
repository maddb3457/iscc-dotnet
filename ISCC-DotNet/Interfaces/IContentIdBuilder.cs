namespace ISCC.Interfaces
{
    public interface IContentIdBuilder
    {
        byte GetContentId(object content, bool partial = false);
    }
}