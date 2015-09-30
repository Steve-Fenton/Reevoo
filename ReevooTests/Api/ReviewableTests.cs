using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ReviewableTests
    {
        private readonly TestConfiguration _config;

        public ReviewableTests()
        {
            _config = new TestConfiguration();
        }

        [TestMethod]
        public void Reviewable_List_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Reviewable.List(_config.Trkref);

            response.reviewables.Count.ShouldBe(30);
        }

        [TestMethod]
        public void Reviewable_ShortFormatList_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Reviewable.ShortFormatList(_config.Trkref);

            response.reviewables.Count.ShouldBe(89);
        }

        [TestMethod]
        public void Reviewable_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Reviewable.Detail(_config.Trkref, "en", "AIPTPDV5700");

            response.name.ShouldBe("Aiptek DV5700");
        }

        [TestMethod]
        public void Reviewable_ShortFormatDetail_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Reviewable.ShortFormatDetail(_config.Trkref, "en", "AIPTPDV5700");

            response.sku.ShouldBe("AIPTPDV5700");
        }
    }
}
