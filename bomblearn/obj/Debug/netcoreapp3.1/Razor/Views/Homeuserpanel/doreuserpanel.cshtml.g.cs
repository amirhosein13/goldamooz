#pragma checksum "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75077ce8801a6d86fb0753abdc1b17fdaba526d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homeuserpanel_doreuserpanel), @"mvc.1.0.view", @"/Views/Homeuserpanel/doreuserpanel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75077ce8801a6d86fb0753abdc1b17fdaba526d", @"/Views/Homeuserpanel/doreuserpanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d567f1434effcaf55c52eea1dbff70305f7299e", @"/Views/_ViewImports.cshtml")]
    public class Views_Homeuserpanel_doreuserpanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<dore>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/data/css/cssuserpanela.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
  
    ViewData["Title"] = "پنل کاربری";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f75077ce8801a6d86fb0753abdc1b17fdaba526d4566", async() => {
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
            WriteLiteral("\r\n<section class=\"ui container sec2userpanel\">\r\n    <div class=\"ui grid\">\r\n        <div class=\"col3\">\r\n            <div class=\"kenariconcol9 floatleft\">\r\n                <h2 class=\"txtright marginnone\">");
#nullable restore
#line 14 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                           Write(ViewBag.dorecount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                <h4 class=""txtright marginnone"">دوره های من</h4>
            </div>
            <div class=""iconlol3 float_right"">
                <i class=""huge graduation cap icon card cardicon""></i>
            </div>
        </div>
        <div class=""col3"">
            <div class=""kenariconcol9 floatleft"">
                <h2 class=""txtright marginnone"">0</h2>
                <h4 class=""txtright marginnone"">کیف پول من</h4>
            </div>
            <div class=""iconlol3 float_right"">
                <i class=""huge credit card icon cardicon""></i>
            </div>
        </div>
        <div class=""col3"">
            <div class=""kenariconcol9 floatleft"">
                <h2 class=""txtright marginnone"">");
#nullable restore
#line 32 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 33 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                 if (ViewBag.isteacher)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"txtright marginnone\">استاد</h4>\r\n");
#nullable restore
#line 36 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"txtright marginnone\">دانشجو</h4>\r\n");
#nullable restore
#line 40 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""iconlol3 float_right"">
                <i class=""huge user icon card cardicon""></i>
            </div>
        </div>
        <div class=""col42 right"">
            <div class=""ui vertical fluid right menu"">
                <a class=""item txtright active activemenukenar"">
                    دوره های من
                </a>
                <a class=""item txtright"">
                    فاکتور ها
                </a>
                <a class=""item txtright"">
                    سوالات من
                </a>
                <a class=""item txtright"">
                    پاسخ های من
                </a>
                <a class=""item txtright"">
                    تیکت های من
                </a>
");
#nullable restore
#line 63 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                 if (ViewBag.isteacher)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2256, "\"", 2294, 2);
            WriteAttributeValue("", 2263, "doreadmin/", 2263, 10, true);
#nullable restore
#line 65 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 2273, User.Identity.Name, 2273, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item txtright\">\r\n                        پنل دوره های من\r\n                    </a>\r\n");
#nullable restore
#line 68 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"item txtright\">\r\n                    خروج از حساب کاربری\r\n                </a>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col12 stretched column\">\r\n            <div class=\"ui grid\">\r\n");
#nullable restore
#line 77 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col_bala"">
                        <div class=""ui link cards tooltip"">
                            <div class=""tooltiptext"">
                                <div class=""containerkhodam"">
                                    <h3 class=""txtright"">");
#nullable restore
#line 83 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                    Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                                    <p class=\"txtright\">آخرین بروزرسانی :");
#nullable restore
#line 84 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                                    Write(item.doreakharinberoozresany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"txtright fontsize_14\">تعداد جلسات تدریس:");
#nullable restore
#line 85 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                                                 Write(item.doretedadgalase);

#line default
#line hidden
#nullable disable
            WriteLiteral(" جلسه</p>\r\n                                    <p class=\"txtright fontsize_14\">سطح دوره : ");
#nullable restore
#line 86 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                                          Write(item.doresath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h3 class=\"txtright\">\r\n                                        ");
#nullable restore
#line 88 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                   Write(item.shortmatn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h3>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f75077ce8801a6d86fb0753abdc1b17fdaba526d12902", async() => {
                WriteLiteral("<button class=\"positive ui button\">ادامه مطلب</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 90 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
AddHtmlAttributeValue("", 3528, item.dorename, 3528, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3550, "~/dore/", 3550, 7, true);
#nullable restore
#line 90 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
AddHtmlAttributeValue("", 3557, item.doreid, 3557, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <a");
            BeginWriteAttribute("title", " title=\"", 3739, "\"", 3761, 1);
#nullable restore
#line 93 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 3747, item.dorename, 3747, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3762, "\"", 3789, 2);
            WriteAttributeValue("", 3769, "/dore/", 3769, 6, true);
#nullable restore
#line 93 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 3775, item.doreid, 3775, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"card w_100\">\r\n                                    <div class=\"image\">\r\n                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 3952, "\"", 3972, 1);
#nullable restore
#line 96 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 3958, item.dorename, 3958, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3973, "\"", 3995, 1);
#nullable restore
#line 96 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 3981, item.dorename, 3981, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 3996, "\"", 4020, 1);
#nullable restore
#line 96 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 4002, item.doreimageurl, 4002, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""content balapost"">
                                        <div class=""header txtright font_14"">
                                            <h2 class=""txtright font_14 h2post"">");
#nullable restore
#line 100 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                                           Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        </div>\r\n                                        <div class=\"description txtright\">\r\n                                            <a");
            BeginWriteAttribute("title", " title=\"", 4486, "\"", 4508, 1);
#nullable restore
#line 103 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 4494, item.dorename, 4494, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"textblack\">");
#nullable restore
#line 103 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                                                                   Write(item.doremodars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"extra content\">\r\n");
#nullable restore
#line 107 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                         if (item.dorebargozary == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"right floated span1post\">به اتمام رسیده</span>\r\n");
#nullable restore
#line 110 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"right floated span1post\">درحال برگزاری</span>\r\n");
#nullable restore
#line 114 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                         if (item.dorehgaymat == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"span2post\">\r\n                                                رایگان\r\n                                            </span>\r\n");
#nullable restore
#line 120 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"span2post\">\r\n                                                ");
#nullable restore
#line 124 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                           Write(item.dorehgaymat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                            </span>\r\n");
#nullable restore
#line 126 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 132 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""col4 right"">
            <div class=""ui vertical fluid right menu"">
                <a href=""/userpanel"" class=""item txtright active activemenukenar"">
                    دوره های من
                </a>
                <a href=""/factor"" class=""item txtright"">
                    فاکتور ها
                </a>
                <a href=""/soalhayeman"" class=""item txtright"">
                    سوالات من
                </a>
                <a href=""/pasokhhayeman"" class=""item txtright"">
                    پاسخ های من
                </a>
                <a href=""/"" class=""item txtright"">
                    تیکت های من
                </a>
");
#nullable restore
#line 152 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                 if (ViewBag.isteacher)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 6868, "\"", 6906, 2);
            WriteAttributeValue("", 6875, "doreadmin/", 6875, 10, true);
#nullable restore
#line 154 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
WriteAttributeValue("", 6885, User.Identity.Name, 6885, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"item txtright\">\r\n                        پنل دوره های من\r\n                    </a>\r\n                    <a href=\"/blogadmin\" class=\"item txtright\">\r\n                       مقالات\r\n                    </a>\r\n");
#nullable restore
#line 160 "C:\Users\amirh\OneDrive\Desktop\pro\bomblearn\bomblearn\Views\Homeuserpanel\doreuserpanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/Logout\" class=\"item txtright\">\r\n                    خروج از حساب کاربری\r\n                </a>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<dore>> Html { get; private set; }
    }
}
#pragma warning restore 1591
