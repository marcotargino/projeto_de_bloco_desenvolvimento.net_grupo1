#pragma checksum "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd47b03788a40c2c6c31c2a6225d9aab377a253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PostagemApi_Delete), @"mvc.1.0.view", @"/Views/PostagemApi/Delete.cshtml")]
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
#line 1 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\_ViewImports.cshtml"
using RedeSocial.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd47b03788a40c2c6c31c2a6225d9aab377a253", @"/Views/PostagemApi/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4685160350bae5d28ed725c58660c277aacd98", @"/Views/_ViewImports.cshtml")]
    public class Views_PostagemApi_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedeSocial.Domain.Account.Postagem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n\r\n    <h1>Deletar este post?</h1>\r\n    <article class=\"card\">\r\n        <div class=\"card__wrapper\">\r\n\r\n            <figure class=\"card__feature\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 329, "\"", 379, 1);
#nullable restore
#line 17 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml"
WriteAttributeValue("", 335, Html.DisplayFor(model => model.urlFotoPost), 335, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card__img\" alt=\"Bridge\" width=\"275\" height=\"240\">\r\n            </figure>\r\n\r\n            <div class=\"card__box\">\r\n\r\n                <header class=\"card__item card__header\">\r\n                    <h2 class=\"card__item card__item--small card__title\">");
#nullable restore
#line 23 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml"
                                                                    Write(Html.DisplayFor(model => model.titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </header>\r\n\r\n                <hr class=\"card__item card__divider\">\r\n\r\n                <section class=\"card__item card__body\">\r\n                    <p>");
#nullable restore
#line 29 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml"
                  Write(Html.DisplayFor(model => model.legenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </section>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </article>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd47b03788a40c2c6c31c2a6225d9aab377a2536904", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7dd47b03788a40c2c6c31c2a6225d9aab377a2537170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "C:\Users\natan\source\repos\RedeSocialPB\projeto_de_bloco_desenvolvimento.net_grupo1\RedeSocial\RedeSocial.Web\Views\PostagemApi\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.postagemId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd47b03788a40c2c6c31c2a6225d9aab377a2539027", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<style>
    /* Block */
    .card {
        width: 300px;
        font-family: 'Playfair Display', serif;
        text-align: center;
        transition: all .125s;
        transform: scale(1) translateY(0px);
    }

    /* Elements */
    .card__wrapper {
        padding-top: .1px;
        padding-bottom: .1px;
        position: relative;
        background-color: #ffffff;
        color: #999999;
        box-shadow: 0 0 5px 0 rgba(0,0,0,.05);
    }

        .card__wrapper:after {
            content: '';
            position: absolute;
            z-index: -1;
            top: 15px;
            right: 15px;
            bottom: 0;
            left: 15px;
            box-shadow: 0 5px 15px 0 rgba(0,0,0,.2);
            transition: all .125s;
            transform: scale(1) translateY(0px);
        }

    .card__box {
        padding-right: 35px;
        padding-left: 35px;
        margin-top: 25px;
        margin-bottom: 25px;
    }

    .card__item {
        ");
            WriteLiteral(@"margin-top: 20px;
        margin-bottom: 20px;
    }

    .card__item--small {
        margin-top: 10px;
        margin-bottom: 10px;
    }

    .card__feature {
        margin-top: 0;
        margin-right: 0;
        margin-bottom: 0;
        margin-left: 0;
    }

    .card__img {
        display: block;
        max-width: 100%;
        height: 280px;
        width: 300px;
    }

    .card__header {
        position: relative;
        z-index: 1;
    }

    .card__title {
        color: #222222;
        font-size: 30px;
        font-weight: 400;
        line-height: 1.25;
    }

    .card__label {
        color: #cccccc;
        font-family: 'Montserrat', sans-serif;
        font-size: 8px;
        text-transform: uppercase;
        letter-spacing: .2em;
    }

    .card__divider {
        display: block;
        width: 100%;
        height: 15px;
        border: none;
        background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGlu");
            WriteLiteral(@"Zz0idXRmLTgiPz48IURPQ1RZUEUgc3ZnIFBVQkxJQyAiLS8vVzNDLy9EVEQgU1ZHIDEuMS8vRU4iICJodHRwOi8vd3d3LnczLm9yZy9HcmFwaGljcy9TVkcvMS4xL0RURC9zdmcxMS5kdGQiPjxzdmcgdmVyc2lvbj0iMS4xIiBpZD0iTGF5ZXJfMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB4bWxuczp4bGluaz0iaHR0cDovL3d3dy53My5vcmcvMTk5OS94bGluayIgeD0iMHB4IiB5PSIwcHgiIHdpZHRoPSIyOHB4IiBoZWlnaHQ9IjE1cHgiIHZpZXdCb3g9IjAgMCAyOCAxNSIgZW5hYmxlLWJhY2tncm91bmQ9Im5ldyAwIDAgMjggMTUiIHhtbDpzcGFjZT0icHJlc2VydmUiPjxwYXRoIGZpbGw9IiNERURFREUiIGQ9Ik0yNy41LDdoLTZDMjEuMiwzLjEsMTgsMCwxNCwwUzYuOCwzLjEsNi41LDdoLTZDMC4yLDcsMCw3LjIsMCw3LjVTMC4yLDgsMC41LDhoNmMwLjMsMy45LDMuNSw3LDcuNSw3czcuMi0zLjEsNy41LTdoNkMyNy44LDgsMjgsNy44LDI4LDcuNVMyNy44LDcsMjcuNSw3eiBNMTQsMWMzLjQsMCw2LjIsMi42LDYuNSw2SDcuNUM3LjgsMy42LDEwLjYsMSwxNCwxeiBNMTQsMTRjLTMuNCwwLTYuMi0yLjYtNi41LTZoMTIuOUMyMC4yLDExLjQsMTcuNCwxNCwxNCwxNHoiLz48L3N2Zz4=);
        background-repeat: no-repeat;
        background-position: center center;
    }

    .card__body {
        font-size: 16px;
        line-height: 1.75;
    }

    /");
            WriteLiteral(@"* Modifiers */
    .card:hover {
        cursor: pointer;
        transform: scale(1.05);
    }

        .card:hover .card__wrapper {
            box-shadow: 0 0 10px 0 rgba(0,0,0,.05);
        }

            .card:hover .card__wrapper:after {
                transform: scale(0.95) translateY(10px);
            }

    /* Demo */
    body {
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        background-color: #e9ebea;
        text-align: center;
    }

    .card {
        display: inline-block;
        margin-top: calc( ( 100vh - 506px ) / 2 );
        margin-right: 15px;
        margin-left: 15px;
        top: 50%;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedeSocial.Domain.Account.Postagem> Html { get; private set; }
    }
}
#pragma warning restore 1591
