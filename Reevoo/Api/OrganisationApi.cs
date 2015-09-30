using Reevoo.Message;
using System;
using System.Net;

namespace Reevoo.Api
{
    public class OrganisationApi : ApiBase
    {
        internal OrganisationApi(string key, string secret, Uri baseUri) : base(key, secret, baseUri) { }

        public OrganisationListResponse List()
        {
            var apiPath = $"v4/organisations/";

            var response = GetResponseOfType<OrganisationListResponse>(apiPath);

            return response;
        }

        public OrganisationDetailResponse Detail(string trkref)
        {
            var safeTrkref = WebUtility.UrlEncode(trkref);
            var apiPath = $"v4/organisations/{safeTrkref}";

            var response = GetResponseOfType<OrganisationDetailResponse>(apiPath);

            return response;
        }

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
