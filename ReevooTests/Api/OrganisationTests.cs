using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class OrganisationTests
    {
        [TestMethod]
        public void Review_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Organisation.List();

            response.organisations.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void Review_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Organisation.Detail("D10");

            response.name.ShouldBe("Demo Org 10");
        }

        [TestMethod]
        public void Review_Detail_WithBranchCode_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            // TODO: find a valid branch code
            var response = reevooApi.Organisation.Detail("D10", "A");

            response.name.ShouldBe("Demo Org 10");
        }
    }
}
