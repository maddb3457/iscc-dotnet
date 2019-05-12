using System;
using ISCC.Interfaces;
namespace ISCC.Builders.ContentId
{
    public class ContentIdTextBuilder : IContentIdTextBuilder
    {
        public ContentIdTextBuilder()
        {
        }

        public byte GetTextContentId(string text, int version = 0)
        {
            return 0x1;
        }
    }
}
