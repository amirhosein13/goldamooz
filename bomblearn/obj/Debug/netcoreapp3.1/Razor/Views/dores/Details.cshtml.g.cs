#pragma checksum "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f6be0b733e700a8d3f8dce46eace80d15fb482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dores_Details), @"mvc.1.0.view", @"/Views/dores/Details.cshtml")]
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
#line 1 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using layedata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using datacore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f6be0b733e700a8d3f8dce46eace80d15fb482", @"/Views/dores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d567f1434effcaf55c52eea1dbff70305f7299e", @"/Views/_ViewImports.cshtml")]
    public class Views_dores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<layedata.dore>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32f6be0b733e700a8d3f8dce46eace80d15fb4825605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"ui container txtright\">\r\n    <h2>??????????????</h2>\r\n\r\n    <div>\r\n        <h4>????????</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 17 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.dorename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 20 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.dorename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 23 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doremodars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 26 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doremodars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 29 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.dorehgaymat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 32 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.dorehgaymat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 35 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.dorebargozary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 38 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.dorebargozary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 41 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doretedadgalase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 44 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doretedadgalase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 47 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doretedaddaneshamooz));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 50 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doretedaddaneshamooz));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 53 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doretedadsaatbargozary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 56 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doretedadsaatbargozary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 59 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doresath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 62 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doresath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 65 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doreakharinberoozresany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 68 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doreakharinberoozresany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 71 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.doreimageurl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 74 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.doreimageurl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 77 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.dorematn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 80 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.dorematn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 83 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.shortmatn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 86 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
           Write(Html.DisplayFor(model => model.shortmatn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32f6be0b733e700a8d3f8dce46eace80d15fb48214836", async() => {
                WriteLiteral("??????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\dores\Details.cshtml"
                               WriteLiteral(Model.doreid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32f6be0b733e700a8d3f8dce46eace80d15fb48216995", async() => {
                WriteLiteral("???????????? ???? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32f6be0b733e700a8d3f8dce46eace80d15fb48218281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<layedata.dore> Html { get; private set; }
    }
}
#pragma warning restore 1591
