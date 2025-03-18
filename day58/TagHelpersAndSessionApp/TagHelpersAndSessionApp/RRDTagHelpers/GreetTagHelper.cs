using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersAndSessionApp.RRDTagHelpers
{
    public class GreetTagHelper : TagHelper
    {
        public string DevName { get; set; } = "Devname"; // dev-name
        public string DevLocation { get; set; } = "DevLoaction";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";
            output.Content.SetHtmlContent($"Hello Developer {DevName}, how is you work @ {DevLocation},welcome to Taghelpers");
        }


    }
}
