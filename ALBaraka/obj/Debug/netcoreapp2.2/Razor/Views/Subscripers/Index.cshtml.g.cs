#pragma checksum "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf41cc3bff60dcee0d3f4a8db893246dcac2e177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscripers_Index), @"mvc.1.0.view", @"/Views/Subscripers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subscripers/Index.cshtml", typeof(AspNetCore.Views_Subscripers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf41cc3bff60dcee0d3f4a8db893246dcac2e177", @"/Views/Subscripers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c42a8dd2e9db33f5a2d5ccbfa0ab15eb819fdb6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscripers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subscriber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
  
    ViewData["Title"] = "Subscribers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 32, true);
            WriteLiteral("\r\n    <h2>Subscribers</h2>\r\n\r\n\r\n");
            EndContext();
            BeginContext(160, 1111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf41cc3bff60dcee0d3f4a8db893246dcac2e1775341", async() => {
                BeginContext(232, 212, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <input id=\"checkall\" type=\"checkbox\" />\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(445, 41, false);
#line 19 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(486, 79, true);
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 24 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(622, 108, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"Emails\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 730, "\"", 749, 1);
#line 28 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
WriteAttributeValue("", 738, item.Email, 738, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(750, 82, true);
                WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(833, 40, false);
#line 31 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(873, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 34 "D:\Asp.net Core\ALBaraka\ALBaraka\Views\Subscripers\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(940, 324, true);
                WriteLiteral(@"        </tbody>
    </table>
    <h3>The Mail Subject  : </h3> <input type=""text"" name=""Subject"" class=""form-control"" /><br />
    <h3>The Mail Html File  : </h3> <input type=""file"" name=""File"" required /><br />
    <br />
    <input type=""submit"" value=""Send Mail To Selected Subscribers"" class=""btn btn-primary"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1271, 590, true);
            WriteLiteral(@"

<script>
        var checkall = document.getElementById(""checkall"");
        var myform = document.getElementsByName(""Emails"");
        checkall.onclick = function () {
            if (checkall.checked == true) {
                for (var i = 0; i < document.getElementsByName(""Emails"").length; i++) {
                    myform[i].checked = true;
                }
            } else {
                for (var i = 0; i < document.getElementsByName(""Emails"").length; i++) {
                    myform[i].checked = false;
                }
            }
        }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subscriber>> Html { get; private set; }
    }
}
#pragma warning restore 1591