using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class OrganisationTests
    {
        private readonly TestConfiguration _config;

        public OrganisationTests()
        {
            _config = new TestConfiguration();
        }

        [TestMethod]
        public void Review_List_ExpectResults()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Organisation.List();

            response.organisations.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void Review_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            var response = reevooApi.Organisation.Detail(_config.Trkref);

            response.name.ShouldBe("Demo Org 10");
        }

        [TestMethod]
        public void Review_Detail_WithBranchCode_ExpectResult()
        {
            var reevooApi = new ReevooApi(_config.Key, _config.Secret, _config.BaseUri);

            // TODO: find a valid branch code
            var response = reevooApi.Organisation.Detail(_config.Trkref, "A");

            response.name.ShouldBe("Demo Org 10");
        }
    }
}
