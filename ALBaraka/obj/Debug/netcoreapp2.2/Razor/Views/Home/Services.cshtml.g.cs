#pragma checksum "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cbda7c20d61ae5d6b0f44a828735fa3e1d0406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Services), @"mvc.1.0.view", @"/Views/Home/Services.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Services.cshtml", typeof(AspNetCore.Views_Home_Services))]
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
#line 1 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using ALBaraka.Models;

#line default
#line hidden
#line 2 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using ALBaraka.Models.ViewModels;

#line default
#line hidden
#line 3 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 5 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 6 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 7 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\_ViewImports.cshtml"
using ALBaraka.Repositories.UnitOfWork;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cbda7c20d61ae5d6b0f44a828735fa3e1d0406", @"/Views/Home/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c42a8dd2e9db33f5a2d5ccbfa0ab15eb819fdb6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hvr-rectangle-in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Medicinal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
  
    ViewData["Title"] = "Services";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
        var currentCulture = ViewContext.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture;

#line default
#line hidden
            DefineSection("Banner", async() => {
                BeginContext(331, 57, true);
                WriteLiteral("\r\n    <!-- banner1 -->\r\n    <div class=\"banner1 jarallax\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 388, "\"", 497, 7);
                WriteAttributeValue("", 396, "background:", 396, 11, true);
                WriteAttributeValue(" ", 407, "url(/Uploads/StaticImages/", 408, 27, true);
#line 11 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
WriteAttributeValue("", 434, staticData.GetValue("About_Banner",null), 434, 41, false);

#line default
#line hidden
                WriteAttributeValue("", 475, ")", 475, 1, true);
                WriteAttributeValue(" ", 476, "no-repeat", 477, 10, true);
                WriteAttributeValue(" ", 486, "0px", 487, 4, true);
                WriteAttributeValue(" ", 490, "-99px;", 491, 7, true);
                EndWriteAttribute();
                BeginContext(498, 176, true);
                WriteLiteral(">\r\n        <div class=\"container\">\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"services-breadcrumb\">\r\n        <div class=\"container\">\r\n            <ul>\r\n                <li>");
                EndContext();
                BeginContext(674, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d04067146", async() => {
                    BeginContext(719, 17, false);
#line 19 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                           Write(Localizer["Home"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(740, 35, true);
                WriteLiteral("<i>|</i></li>\r\n                <li>");
                EndContext();
                BeginContext(776, 21, false);
#line 20 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
               Write(Localizer["Programs"]);

#line default
#line hidden
                EndContext();
                BeginContext(797, 103, true);
                WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <!-- //banner1 -->\r\n    <!-- //banner -->\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(903, 109, true);
            WriteLiteral("\r\n<div class=\"agile_menu\" id=\"menu\">\r\n    <div class=\"container\">\r\n        <h3 class=\"w3_heade_tittle_agile\">");
            EndContext();
            BeginContext(1013, 21, false);
#line 31 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                     Write(Localizer["Programs"]);

#line default
#line hidden
            EndContext();
            BeginContext(1034, 126, true);
            WriteLiteral("</h3>\r\n        <p class=\"sub_t_agileits\"></p>\r\n        <div class=\"menu_w3ls_agile_top_section\">\r\n            <div class=\"\">\r\n");
            EndContext();
#line 35 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                 if (currentCulture.Name == "ar")
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1302, 231, true);
            WriteLiteral("                        <div style=\"display:block\">\r\n                            <div class=\"w3_agile_recipe-grid\">\r\n\r\n\r\n                                <div class=\"col-md-6 col-sm-6 tab-info\">\r\n                                    ");
            EndContext();
            BeginContext(1533, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040610784", async() => {
                BeginContext(1581, 5, true);
                WriteLiteral(" <h4>");
                EndContext();
                BeginContext(1587, 9, false);
#line 44 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1596, 5, true);
                WriteLiteral("</h4>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1605, 41, true);
            WriteLiteral("\r\n                                    <p>");
            EndContext();
            BeginContext(1647, 64, false);
#line 45 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                  Write(string.Join(' ', item.Description.Split(" ").Take(50).ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 60, true);
            WriteLiteral("</p>\r\n                                    <div class=\"read\">");
            EndContext();
            BeginContext(1771, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040614007", async() => {
                BeginContext(1867, 22, false);
#line 46 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                                                                                Write(Localizer["Read More"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                                      WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1893, 159, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"col-md-6 col-sm-6 tab-image\">\r\n                                    ");
            EndContext();
            BeginContext(2052, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040617076", async() => {
                BeginContext(2100, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2101, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040617454", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2111, "~/Uploads/Services/", 2111, 19, true);
#line 49 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
AddHtmlAttributeValue("", 2130, item.ID, 2130, 10, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 2140, ".jpg", 2140, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2166, 205, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"clearfix\"></div>\r\n                            </div>\r\n\r\n                        </div>\r\n                        <br/>\r\n");
            EndContext();
#line 56 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                    }
                }
                else
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2526, 230, true);
            WriteLiteral("                        <div style=\"display:block\">\r\n                            <div class=\"w3_agile_recipe-grid\">\r\n\r\n                                <div class=\"col-md-6 col-sm-6 tab-image\">\r\n                                    ");
            EndContext();
            BeginContext(2756, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040621925", async() => {
                BeginContext(2804, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2805, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040622303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2815, "~/Uploads/Services/", 2815, 19, true);
#line 66 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
AddHtmlAttributeValue("", 2834, item.ID, 2834, 10, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 2844, ".jpg", 2844, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2870, 152, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 col-sm-6 tab-info\">\r\n                                    ");
            EndContext();
            BeginContext(3022, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040626107", async() => {
                BeginContext(3070, 5, true);
                WriteLiteral(" <h4>");
                EndContext();
                BeginContext(3076, 12, false);
#line 69 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                    Write(item.Name_EN);

#line default
#line hidden
                EndContext();
                BeginContext(3088, 5, true);
                WriteLiteral("</h4>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3097, 41, true);
            WriteLiteral("\r\n                                    <p>");
            EndContext();
            BeginContext(3139, 67, false);
#line 70 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                  Write(string.Join(' ', item.Description_EN.Split(" ").Take(50).ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(3206, 60, true);
            WriteLiteral("</p>\r\n                                    <div class=\"read\">");
            EndContext();
            BeginContext(3266, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73cbda7c20d61ae5d6b0f44a828735fa3e1d040629337", async() => {
                BeginContext(3362, 22, false);
#line 71 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                                                                                Write(Localizer["Read More"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                                                                                                      WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3388, 211, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"clearfix\"></div>\r\n                            </div>\r\n\r\n                        </div>\r\n                        <br/>\r\n");
            EndContext();
#line 78 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Home\Services.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3641, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStaticDataValues staticData { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
