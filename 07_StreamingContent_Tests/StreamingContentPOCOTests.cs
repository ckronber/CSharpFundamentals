using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentPOCOTests
    {
        [DataTestMethod]
        [DataRow(MaturityRating.G,true)]
        [DataRow(MaturityRating.PG,true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMatureityRating_ShouldgetCorrectIsFamilyFriendly(MaturityRating rating,bool expectedIsFamilyFriendly)
        {
            StreamingContent newContent = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years", 4.4, GenreType.SciFi, rating);

            bool actual = newContent.isFamilyFriendly;
            bool expected = expectedIsFamilyFriendly;

            Assert.AreEqual(actual, expected);
        }
    }
}
