#pragma checksum "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086bb339cf34fea76c533e1e0000784cc19f7e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Edit), @"mvc.1.0.view", @"/Views/Manager/Edit.cshtml")]
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
#line 1 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\_ViewImports.cshtml"
using FlightManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\_ViewImports.cshtml"
using FlightManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086bb339cf34fea76c533e1e0000784cc19f7e0c", @"/Views/Manager/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a777bd6627f8c17f7378f5f166d04f04ecfbca", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightManager.ViewModels.Manager.EditManagerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Manager/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"py-5\">\n    <div class=\"container\">\n        <h1 style=\"margin: 2%; text-align: center;\">Edit User</h1>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086bb339cf34fea76c533e1e0000784cc19f7e0c4398", async() => {
                WriteLiteral("\n            <div>\n                <div class=\"form-group\">\n                    <label for=\"firstName\">First Name</label>\n                    <input type=\"text\" class=\"form-control\" id=\"firstName\" name=\"FirstName\"");
                BeginWriteAttribute("value", " value=\"", 526, "\"", 550, 1);
#nullable restore
#line 13 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
WriteAttributeValue("", 534, Model.FirstName, 534, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n\n                <div class=\"form-group\">\n                    <label for=\"lastName\">Last Name</label>\n                    <input type=\"text\" class=\"form-control\" id=\"lastName\" name=\"LastName\"");
                BeginWriteAttribute("value", " value=\"", 767, "\"", 790, 1);
#nullable restore
#line 18 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
WriteAttributeValue("", 775, Model.LastName, 775, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"egn\">EGN</label>\n                    <input type=\"text\" class=\"form-control\" id=\"egn\" name=\"EGN\"");
                BeginWriteAttribute("value", " value=\"", 985, "\"", 1003, 1);
#nullable restore
#line 22 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
WriteAttributeValue("", 993, Model.EGN, 993, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"departureTime\">Address</label>\n                    <input type=\"text\" class=\"form-control\" id=\"address\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 1220, "\"", 1242, 1);
#nullable restore
#line 26 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
WriteAttributeValue("", 1228, Model.Address, 1228, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <div class=\"form-group\" style=\"display: none\">\n                    <input type=\"text\" class=\"form-control\" id=\"id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1408, "\"", 1425, 1);
#nullable restore
#line 29 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
WriteAttributeValue("", 1416, Model.Id, 1416, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n                <div class=\"form-group text-center\">\n");
#nullable restore
#line 32 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Edit</button>\n");
#nullable restore
#line 35 "C:\Users\viksu\OneDrive\Documents\vik\FlightManager\FlightManager\FlightManager\Views\Manager\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n</section>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightManager.ViewModels.Manager.EditManagerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591