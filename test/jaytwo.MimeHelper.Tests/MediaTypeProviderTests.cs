using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace jaytwo.MimeHelper.Tests
{
    public class MediaTypeProviderTests
    {
        [Theory]
        [InlineData("TXT", MediaType.text_plain)]
        [InlineData("txt", MediaType.text_plain)]
        [InlineData("TxT", MediaType.text_plain)]
        public void WorksAnyCase(string fileExtension, string expectedMediaType)
        {
            // arrange

            // act
            var actualMediaType = MediaTypeProvider.GetMediaTypeFromExtension(fileExtension);

            // assert
            Assert.Equal(expectedMediaType, actualMediaType);
        }

        [Theory]
        [InlineData("txt", MediaType.text_plain)]
        [InlineData(".txt", MediaType.text_plain)]
        public void WorksCaseWithWithoutDot(string fileExtension, string expectedMediaType)
        {
            // arrange

            // act
            var actualMediaType = MediaTypeProvider.GetMediaTypeFromExtension(fileExtension);

            // assert
            Assert.Equal(expectedMediaType, actualMediaType);
        }

        [Theory]
        [InlineData("txt", MediaType.text_plain)]
        [InlineData("json", MediaType.application_json)]
        [InlineData("xml", MediaType.text_xml)]
        [InlineData("html", MediaType.text_html)]
        [InlineData("jpg", MediaType.image_jpeg)]
        [InlineData("png", MediaType.image_png)]
        public void CommonCases(string fileExtension, string expectedMediaType)
        {
            // arrange

            // act
            var actualMediaType = MediaTypeProvider.GetMediaTypeFromExtension(fileExtension);

            // assert
            Assert.Equal(expectedMediaType, actualMediaType);
        }
    }
}
