using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ReviewsTests
    {
        private readonly TestConfiguration _config;

        public ReviewsTests()
        {
            _config = new TestConfiguration();
        }

        [TestMethod]
        public void Review_List_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Review.List(_config.Trkref, "en", "AIPTPDV5700");

            response.reviews.Count.ShouldBe(6);
        }

        [TestMethod]
        public void Review_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Review.Detail(_config.Trkref, 314609);

            response.overall_score.ShouldBeGreaterThan(0);
        }
    }
}
