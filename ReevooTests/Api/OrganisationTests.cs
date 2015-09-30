using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reevoo.Api;
using Shouldly;

namespace ReevooTests.Api
{
    [TestClass]
    public class OrganisationTests
    {
        [TestMethod]
        public void Organisation_List_ExpectResults()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Organisation.List();

            response.Organisations.Count.ShouldBeGreaterThan(0);
            response.Summary.Pagination.CurrentPage.ShouldBe(1);
        }

        [TestMethod]
        public void Organisation_Detail_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            var response = reevooApi.Organisation.Detail("D10");

            response.Name.ShouldBe("Demo Org 10");
        }

        [TestMethod]
        public void Organisation_Detail_WithBranchCode_ExpectResult()
        {
            var reevooApi = new ReevooApi();

            // TODO: find a valid branch code
            var response = reevooApi.Organisation.Detail("D10", "A");

            response.Name.ShouldBe("Demo Org 10");
        }
    }
}
