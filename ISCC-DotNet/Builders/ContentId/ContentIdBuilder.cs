using System;

namespace ISCC.Builders.ContentId
{
    using Interfaces;

    public class ContentIdBuilder : IContentIdBuilder
    {
        private IContentIdTextBuilder contentIdTextBuilder;
        private IContentIdImageBuilder contentIdImageBuilder;
        private IContentIdVideoBuilder contentIdVideoBuilder;
        private IContentIdAudioBuilder contentIdAudioBuilder;
        private IContentIdMixedBuilder contentIdMixedBuilder;

        public ContentIdBuilder()
        {
            contentIdTextBuilder = new ContentIdTextBuilder();
            contentIdImageBuilder = new ContentIdImageBuilder();
            contentIdVideoBuilder = new ContentIdVideoBuilder();
            contentIdAudioBuilder = new ContentIdAudioBuilder();
            contentIdMixedBuilder = new ContentIdMixedBuilder();
        }



        public byte GetContentId(object text, bool partial = false)
        {
            throw new NotImplementedException();
        }
    }
}
