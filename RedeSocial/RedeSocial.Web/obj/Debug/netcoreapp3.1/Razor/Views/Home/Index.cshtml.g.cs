#pragma checksum "C:\Users\leona\Documents\GitHub\desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc33537ca24816cd4e9310747f40ce80d0a7a3c"
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
#line 1 "C:\Users\leona\Documents\GitHub\desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Documents\GitHub\desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc33537ca24816cd4e9310747f40ce80d0a7a3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4685160350bae5d28ed725c58660c277aacd98", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\leona\Documents\GitHub\desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("PreFooter", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Home Page</h1>\r\n    </div>\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\leona\Documents\GitHub\desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\Home\Index.cshtml"
Write(Html.Partial("_HelloUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
