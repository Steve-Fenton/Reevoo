using System.Text;

namespace Reevoo.UI
{
    public class Retailer
    {
        public static string Badge()
        {
            var badgeName = "ford-cx-17042014-header";
            var badgeClass = "reevoomark_badge_ford-cx-17042014-header";
            var badgeUrl = "http://cdn-badges.reevoo.com/reevoomark/badges/en-GB/ford-cx-17042014-header/overall/100.png?t=1397736790";
            var score = "100";

            var reviewLink = "http://mark.reevoo.com/reevoomark/en-GB/retailer_reviews/GMXZ-FOC-N";
            var reevooAction = "reviews";

            var sb = new StringBuilder();

            sb.AppendLine("<div class=\"box reevooMark\">");
            sb.AppendLine("    <div id=\"reevoomark_retailer_badge_0\">");
            sb.AppendLine($"        <div style=\"position: relative; overflow: hidden; width: 202px; height: 53px; padding: 0px; background - image: url(&quot;{badgeUrl}&quot;); background-position: 0px 0px;\" data-score=\"{score}\" data-sku=\"undefined\" data-badge-name=\"{badgeName}\" data-badge-type=\"retailer_reviews\" data-badge-variant=\"undefined\" class=\"reevoomark_badge {badgeClass}\">");
            sb.AppendLine($"            <a href=\"{reviewLink}\" data-reevoo-action=\"{reevooAction}\" style=\"position: absolute; left: 0px; top: 0px; width: 202px; height: 53px; overflow: hidden; text-indent: -999em;\" class=\"reviews\"><span style=\"top: 40px; left: 75px; font-size: 12px; line-height: 10px; font-family: &quot;Arial&quot;,sans-serif; position: absolute; text-indent: 0px;\">Read customer reviews</span></a>");
            sb.AppendLine("            <div style=\"top: 3px; left: 76px; width: 139px; font - size: 12px; text - align: left; text - decoration: none; font - weight: normal; line - height: 12px; color: rgb(0, 0, 0); position: absolute; text - indent: 0px;\">of customers would buy again from TrustFordOnline.</div>");
            sb.AppendLine("        </div>");
            sb.AppendLine("    </div>");
            sb.AppendLine("</div>");

            return sb.ToString();
        }
    }
}
