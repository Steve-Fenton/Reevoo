using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ReviewsTests
    {
        [TestMethod]
        public void Review_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Review.List("D10", "en", "AIPTPDV5700");

            response.Reviews.Count.ShouldBe(6);
        }

        [TestMethod]
        public void Review_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Review.Detail("D10", 314609);

            response.OverallScore.ShouldBeGreaterThan(0);
        }
    }
}
