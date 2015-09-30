using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class CustomerExperienceReviewsTests
    {
        [TestMethod]
        public void CustomerExperienceReview_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            // TODO: find a trkref that returns results
            var response = reevooApi.CustomerExperienceReview.List("D10");

            response.CustomerExperienceReviews.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void CustomerExperienceReview_Detail_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            // TODO: find a valid review id
            var response = reevooApi.CustomerExperienceReview.Detail("D10", 2774063);

            response.ShouldNotBeNull();
        }
    }
}
