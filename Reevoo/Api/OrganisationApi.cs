using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class OrganisationApi : ApiBase
    {
        internal OrganisationApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        /// <summary>
        /// Allow a user to retrieve information for all organisations associated with their API key.
        /// </summary>
        /// <returns></returns>
        public OrganisationListResponse List()
        {
            var apiPath = $"v4/organisations/";

            var response = GetResponseOfType<OrganisationListResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Allow a user to retrieve information for a specific organisation.
        /// Users are only allow to retrieve information for organisations that their API key is assigned to.
        /// http://reevoo.github.io/docs/reevooapi/organisation/organisation-list/
        /// </summary>
        /// <param name="trkref"></param>
        /// <returns></returns>
        public OrganisationDetailResponse Detail(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}";

            var response = GetResponseOfType<OrganisationDetailResponse>(apiPath);

            return response;
        }

        /// <summary>
        /// Allow a user to retrieve information for a specific organisation.
        /// Users are only allow to retrieve information for organisations that their API key is assigned to.
        /// http://reevoo.github.io/docs/reevooapi/organisation/organisation-detail/
        /// </summary>
        /// <param name="trkref"></param>
        /// <param name="branchCode"></param>
        /// <returns></returns>
        public OrganisationDetailResponse Detail(string trkref, string branchCode)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var safeBranchCode = WebUtility.UrlEncode(branchCode);
            var apiPath = $"v4/organisations/{safeTrkref}?branch_code={safeBranchCode}";

            var response = GetResponseOfType<OrganisationDetailResponse>(apiPath);

            return response;
        }
    }
}
