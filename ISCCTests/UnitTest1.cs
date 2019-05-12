using System;
using Moq;
using Xunit;
using ISCC.Interfaces;
using ISCC.Builders.ContentId;
namespace ISCCTests
{
    public class ISCCTests
    {
        private IContentIdBuilder contentBuilder;
        private IContentIdTextBuilder contentTextBuilder;

        public ISCCTests()
        {
            contentTextBuilder = new Mock<IContentIdTextBuilder>( new ContentIdTextBuilder()).Object;
        }

        [Theory, InlineData("")]
        //[JsonFileData("test_data.json")]
        public void TestContentIdText(string text)
        {
            var cid_i = contentTextBuilder.GetTextContentId(text);

            Assert.True(cid_i == 0x1);
        }
    }
}
