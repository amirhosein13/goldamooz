#pragma checksum "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f422b5b48480f35f173c3a50a40c407edab85e3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homedore_getdoreby), @"mvc.1.0.view", @"/Views/Homedore/getdoreby.cshtml")]
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
#line 1 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using bomblearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using layedata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\_ViewImports.cshtml"
using datacore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f422b5b48480f35f173c3a50a40c407edab85e3f", @"/Views/Homedore/getdoreby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d567f1434effcaf55c52eea1dbff70305f7299e", @"/Views/_ViewImports.cshtml")]
    public class Views_Homedore_getdoreby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<layedata.dore>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/data/css/cssdore.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/getdoreby"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f422b5b48480f35f173c3a50a40c407edab85e3f5177", async() => {
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
            WriteLiteral("<section class=\"margindoreha\">\r\n    <div class=\"ui container\">\r\n        <div class=\"divsoal\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f422b5b48480f35f173c3a50a40c407edab85e3f6528", async() => {
                WriteLiteral(@"
                <div class=""container "">
                    <div class=""ui w_100 icon input"">
                        <input style=""padding-right: 40px !important;"" class=""paddingh3dore prompt txtright inputsoalsearch inputindexsearchbala"" id=""searchsoal"" name=""searchinput"" type=""text"" placeholder=""چی میخوای یاد بگیری ؟"">
                        <button class=""btnsearchinputbalaindex""> <i class=""search icon""></i></button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div class=\"w_100 textcenter\">\r\n                <p>تعداد دوره های یافت شده با کلمه شما :");
#nullable restore
#line 19 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                   Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"textcenter margindoreha\">موردی یافت نشد</p>\r\n");
#nullable restore
#line 24 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gridkhodam margindoreha\">\r\n");
#nullable restore
#line 26 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                  int a = 0;
                    foreach (var item in Model)
                    {
                        if (a % 4 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col_bala"">
                                <div class=""ui link cards tooltip"">
                                    <div class=""tooltiptext navlayoutbala"">
                                        <div class=""containerkhodam"">
                                            <h3 class=""txtright"">");
#nullable restore
#line 35 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                            Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <p class=\"txtright\">آخرین بروزرسانی :");
#nullable restore
#line 36 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                            Write(item.doreakharinberoozresany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p class=\"txtright fontsize_14\">تعداد جلسات تدریس:");
#nullable restore
#line 37 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                         Write(item.doretedadgalase);

#line default
#line hidden
#nullable disable
            WriteLiteral(" جلسه</p>\r\n                                            <p class=\"txtright fontsize_14\">سطح دوره : ");
#nullable restore
#line 38 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                  Write(item.doresath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h3 class=\"txtright\">\r\n                                                ");
#nullable restore
#line 40 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                           Write(item.shortmatn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </h3>\r\n                                            <a");
            BeginWriteAttribute("title", " title=\"", 2324, "\"", 2346, 1);
#nullable restore
#line 42 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2332, item.dorename, 2332, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2347, "\"", 2374, 2);
            WriteAttributeValue("", 2354, "/dore/", 2354, 6, true);
#nullable restore
#line 42 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2360, item.doreid, 2360, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"positive ui button\">ادامه مطلب</button></a>\r\n                                        </div>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("title", " title=\"", 2566, "\"", 2588, 1);
#nullable restore
#line 45 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2574, item.dorename, 2574, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2589, "\"", 2616, 2);
            WriteAttributeValue("", 2596, "/dore/", 2596, 6, true);
#nullable restore
#line 45 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2602, item.doreid, 2602, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card w_100\">\r\n                                            <div class=\"image\">\r\n                                                <img class=\"w_100 h_100\"");
            BeginWriteAttribute("alt", " alt=\"", 2823, "\"", 2843, 1);
#nullable restore
#line 48 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2829, item.dorename, 2829, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2844, "\"", 2866, 1);
#nullable restore
#line 48 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2852, item.dorename, 2852, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2867, "\"", 2891, 1);
#nullable restore
#line 48 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 2873, item.doreimageurl, 2873, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""content balapost"">
                                                <div class=""header txtright font_14"">
                                                    <h2 class=""txtright coloblack font_14 h2post"">");
#nullable restore
#line 52 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                             Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                                </div>\r\n                                                <div class=\"description txtright\">\r\n                                                    <a");
            BeginWriteAttribute("title", " title=\"", 3423, "\"", 3445, 1);
#nullable restore
#line 55 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 3431, item.dorename, 3431, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"textblack\">");
#nullable restore
#line 55 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                           Write(item.doremodars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"extra content\">\r\n");
#nullable restore
#line 59 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                 if (item.dorebargozary == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"right floated span1post\">به اتمام رسیده</span>\r\n");
#nullable restore
#line 62 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"right floated span1post\">درحال برگزاری</span>\r\n");
#nullable restore
#line 66 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                 if (item.dorehgaymat == 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"span2post\">\r\n                                                        رایگان\r\n                                                    </span>\r\n");
#nullable restore
#line 72 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"span2post\">\r\n                                                        ");
#nullable restore
#line 76 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                   Write(item.dorehgaymat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                                    </span>\r\n");
#nullable restore
#line 78 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 86 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                            a++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col_bala"">
                                <div class=""ui link cards tooltip2"">
                                    <div class=""tooltiptext2"">
                                        <div class=""containerkhodam"">
                                            <h3 class=""txtright"">");
#nullable restore
#line 94 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                            Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <p class=\"txtright\">آخرین بروزرسانی :");
#nullable restore
#line 95 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                            Write(item.doreakharinberoozresany);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p class=\"txtright fontsize_14\">تعداد جلسات تدریس:");
#nullable restore
#line 96 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                         Write(item.doretedadgalase);

#line default
#line hidden
#nullable disable
            WriteLiteral(" جلسه</p>\r\n                                            <p class=\"txtright fontsize_14\">سطح دوره : ");
#nullable restore
#line 97 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                  Write(item.doresath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <h3 class=\"txtright\">\r\n                                                ");
#nullable restore
#line 99 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                           Write(item.shortmatn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </h3>\r\n                                            <a");
            BeginWriteAttribute("title", " title=\"", 6252, "\"", 6274, 1);
#nullable restore
#line 101 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6260, item.dorename, 6260, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 6275, "\"", 6302, 2);
            WriteAttributeValue("", 6282, "/dore/", 6282, 6, true);
#nullable restore
#line 101 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6288, item.doreid, 6288, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a> <button class=\"positive ui button\">ادامه مطلب</button>\r\n                                        </div>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("title", " title=\"", 6495, "\"", 6517, 1);
#nullable restore
#line 104 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6503, item.dorename, 6503, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 6518, "\"", 6545, 2);
            WriteAttributeValue("", 6525, "/dore/", 6525, 6, true);
#nullable restore
#line 104 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6531, item.doreid, 6531, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"card w_100\">\r\n                                            <div class=\"image\">\r\n                                                <img class=\"w_100 h_100\"");
            BeginWriteAttribute("alt", " alt=\"", 6752, "\"", 6772, 1);
#nullable restore
#line 107 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6758, item.dorename, 6758, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6773, "\"", 6795, 1);
#nullable restore
#line 107 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6781, item.dorename, 6781, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 6796, "\"", 6820, 1);
#nullable restore
#line 107 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 6802, item.doreimageurl, 6802, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""content balapost"">
                                                <div class=""header txtright font_14"">
                                                    <h2 class=""txtright coloblack font_14 h2post"">");
#nullable restore
#line 111 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                             Write(item.dorename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                                </div>\r\n                                                <div class=\"description txtright\">\r\n                                                    <a");
            BeginWriteAttribute("title", " title=\"", 7352, "\"", 7374, 1);
#nullable restore
#line 114 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
WriteAttributeValue("", 7360, item.dorename, 7360, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"textblack\">");
#nullable restore
#line 114 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                                                           Write(item.doremodars);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"extra content\">\r\n");
#nullable restore
#line 118 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                 if (item.dorebargozary == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"right floated span1post\">به اتمام رسیده</span>\r\n");
#nullable restore
#line 121 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"right floated span1post\">درحال برگزاری</span>\r\n");
#nullable restore
#line 125 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                 if (item.dorehgaymat == 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"span2post\">\r\n                                                        رایگان\r\n                                                    </span>\r\n");
#nullable restore
#line 131 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"span2post\">\r\n                                                        ");
#nullable restore
#line 135 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                   Write(item.dorehgaymat);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                                    </span>\r\n");
#nullable restore
#line 137 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 143 "C:\Users\amirh\OneDrive\Desktop\bomblearn\bomblearn\Views\Homedore\getdoreby.cshtml"
                            a++;
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#searchsoal"").autocomplete({
                source: '/api/soalapisearch/Searchindex'
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<layedata.dore>> Html { get; private set; }
    }
}
#pragma warning restore 1591
