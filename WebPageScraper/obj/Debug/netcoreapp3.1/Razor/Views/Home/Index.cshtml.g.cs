#pragma checksum "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb5573e74a302f28157a2d630097a3a26edaf19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb5573e74a302f28157a2d630097a3a26edaf19", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9701c841e9a51f451ac7a6efacb7a0bb06c14fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\WebScraper\WebScraper\WebPageScraper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Web Scraper";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center section-padding"">
    <h1 class=""display-4"">Please enter a valid URL and click GO</h1>
    <div>
        <input type=""text"" placeholder=""Enter URL"" id=""url"" />&nbsp;&nbsp;<button>GO</button>
    </div>
    <div id=""error"" style=""color: red; visibility: hidden"">Invalid URL, please enter a new URL and try again!</div>
</div>
<div id=""images"" class=""section-padding"">
    <ul id=""lightSlider"">

    </ul>
</div>
<div id=""words"" class=""section-padding"">
    <table id=""word-table"" class=""tablesaw"" data-tablesaw-mode=""stack"">
               <thead><th></th><th></th></thead>
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
