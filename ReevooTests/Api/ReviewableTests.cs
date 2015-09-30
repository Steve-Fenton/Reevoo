using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class ReviewableTests
    {
        [TestMethod]
        public void Reviewable_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Reviewable.List("D10");

            response.Reviewables.Count.ShouldBe(30);
        }

        [TestMethod]
        public void Reviewable_ShortFormatList_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Reviewable.ShortFormatList("D10");

            response.Reviewables.Count.ShouldBe(89);
        }

        [TestMethod]
        public void Reviewable_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Reviewable.Detail("D10", "en", "AIPTPDV5700");

            response.Name.ShouldBe("Aiptek DV5700");
        }

        [TestMethod]
        public void Reviewable_ShortFormatDetail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Reviewable.ShortFormatDetail("D10", "en", "AIPTPDV5700");

            response.Sku.ShouldBe("AIPTPDV5700");
        }
    }
}
