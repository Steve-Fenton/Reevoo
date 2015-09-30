using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class CustomerExperienceReviewsTests
    {
        private readonly TestConfiguration _config;

        public CustomerExperienceReviewsTests()
        {
            _config = new TestConfiguration();
        }

        [TestMethod]
        public void CustomerExperienceReview_List_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            // TODO: find a trkref that returns results
            var response = reevooApi.CustomerExperienceReview.List(_config.Trkref);

            response.customer_experience_reviews.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void CustomerExperienceReview_Detail_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            // TODO: find a valid review id
            var response = reevooApi.CustomerExperienceReview.Detail(_config.Trkref, 2774063);

            response.ShouldNotBeNull();
        }
    }
}
