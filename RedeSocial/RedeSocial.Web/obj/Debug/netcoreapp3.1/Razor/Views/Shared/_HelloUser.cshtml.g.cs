#pragma checksum "C:\Users\natan\source\repos\RedeSocial-Infnet-master\RedeSocial.Web\Views\Shared\_HelloUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a292a64f857210d569af383a44127cffb79f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HelloUser), @"mvc.1.0.view", @"/Views/Shared/_HelloUser.cshtml")]
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
#line 1 "C:\Users\natan\source\repos\RedeSocial-Infnet-master\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natan\source\repos\RedeSocial-Infnet-master\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a292a64f857210d569af383a44127cffb79f92", @"/Views/Shared/_HelloUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6467a2e62e89bb94bebf43733461e301fb307d69", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HelloUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div class=\"text-center\">\n        <h1 class=\"display-4\">Olá, ");
#nullable restore
#line 8 "C:\Users\natan\source\repos\RedeSocial-Infnet-master\RedeSocial.Web\Views\Shared\_HelloUser.cshtml"
                              Write(this.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <h2>Hoje é ");
#nullable restore
#line 9 "C:\Users\natan\source\repos\RedeSocial-Infnet-master\RedeSocial.Web\Views\Shared\_HelloUser.cshtml"
              Write(DateTime.Now.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n        <a href=\"#\">CLIQUE AQUI E VEJA AS NOVIDADES</a>\n    </div>\n\n");
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
