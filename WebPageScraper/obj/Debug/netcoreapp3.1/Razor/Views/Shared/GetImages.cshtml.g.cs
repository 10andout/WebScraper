#pragma checksum "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9c6eb371c8f67b98b24c7e2c916bfafffb0053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GetImages), @"mvc.1.0.view", @"/Views/Shared/GetImages.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\_ViewImports.cshtml"
using WebPageScraper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\_ViewImports.cshtml"
using WebPageScraper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9c6eb371c8f67b98b24c7e2c916bfafffb0053", @"/Views/Shared/GetImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9701c841e9a51f451ac7a6efacb7a0bb06c14fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_GetImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml"
   if (Model.Any())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml"
         foreach (var img in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <p><img");
            BeginWriteAttribute("src", " src=\"", 141, "\"", 151, 1);
#nullable restore
#line 8 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml"
WriteAttributeValue("", 147, img, 147, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 200px; max-height: 200px; width: auto; height: auto;\" /></p>\r\n            </li>\r\n");
#nullable restore
#line 10 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Shared\GetImages.cshtml"
         
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
