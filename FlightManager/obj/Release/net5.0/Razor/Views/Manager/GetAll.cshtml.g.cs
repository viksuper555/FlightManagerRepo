#pragma checksum "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead5376423047e3138e2628d58f45d1eef24efeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_GetAll), @"mvc.1.0.view", @"/Views/Manager/GetAll.cshtml")]
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
#line 1 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\_ViewImports.cshtml"
using FlightManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\_ViewImports.cshtml"
using FlightManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead5376423047e3138e2628d58f45d1eef24efeb", @"/Views/Manager/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f786fd48d4832d47c30e803e7f87b4fe4964de31", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightManager.ViewModels.Manager.IndexManagersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Manager/GetAll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<section class=""py-5 col-md-12"">
    <div class=""container col-md-12"">
        <h1 style=""margin: 2%; text-align: center;"">All Users</h1>
        <div style=""padding: 5%;"">
            <div>
                <h2>Show By: </h2>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mx-2""");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 543, 2);
            WriteAttributeValue("", 481, "/Manager/GetAll?page=1&showPerPage=10&filterBy=", 481, 47, true);
#nullable restore
#line 14 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 528, Model.FilterBy, 528, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">10</a>\r\n                    <a class=\"btn btn-primary mx-2\"");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 673, 2);
            WriteAttributeValue("", 611, "/Manager/GetAll?page=1&showPerPage=25&filterBy=", 611, 47, true);
#nullable restore
#line 15 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 658, Model.FilterBy, 658, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">25</a>\r\n                    <a class=\"btn btn-primary mx-2\"");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 803, 2);
            WriteAttributeValue("", 741, "/Manager/GetAll?page=1&showPerPage=50&filterBy=", 741, 47, true);
#nullable restore
#line 16 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 788, Model.FilterBy, 788, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">50</a>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <h2>Filter By: </h2>\r\n                <div class=\"mb-4\">\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1121, 4);
            WriteAttributeValue("", 1013, "/Manager/GetAll?page=1&showPerPage=", 1013, 35, true);
#nullable restore
#line 22 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1048, Model.ManagersPerPage, 1048, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1070, "&filterBy=Username&searchString=", 1070, 32, true);
#nullable restore
#line 22 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1102, Model.SearchString, 1102, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Username</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1193, "\"", 1305, 4);
            WriteAttributeValue("", 1200, "/Manager/GetAll?page=1&showPerPage=", 1200, 35, true);
#nullable restore
#line 23 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1235, Model.ManagersPerPage, 1235, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1257, "&filterBy=Email&searchString=", 1257, 29, true);
#nullable restore
#line 23 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1286, Model.SearchString, 1286, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Email</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1374, "\"", 1490, 4);
            WriteAttributeValue("", 1381, "/Manager/GetAll?page=1&showPerPage=", 1381, 35, true);
#nullable restore
#line 24 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1416, Model.ManagersPerPage, 1416, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1438, "&filterBy=FirstName&searchString=", 1438, 33, true);
#nullable restore
#line 24 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1471, Model.SearchString, 1471, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">FirstName</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1563, "\"", 1678, 4);
            WriteAttributeValue("", 1570, "/Manager/GetAll?page=1&showPerPage=", 1570, 35, true);
#nullable restore
#line 25 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1605, Model.ManagersPerPage, 1605, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1627, "&filterBy=LastName&searchString=", 1627, 32, true);
#nullable restore
#line 25 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 1659, Model.SearchString, 1659, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">LastName</a>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ead5376423047e3138e2628d58f45d1eef24efeb10051", async() => {
                WriteLiteral(@"
                        <div class=""form-group"" style=""display: none"">
                            <input type=""text"" class=""form-control"" id=""page"" name=""page"" value=""1"">
                        </div>
                        <div class=""form-group"" style=""display: none"">
                            <input type=""text"" class=""form-control"" id=""showPerPage"" name=""showPerPage""");
                BeginWriteAttribute("value", " value=\"", 2143, "\"", 2173, 1);
#nullable restore
#line 32 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 2151, Model.ManagersPerPage, 2151, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\" style=\"display: none\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"filterBy\" name=\"filterBy\"");
                BeginWriteAttribute("value", " value=\"", 2378, "\"", 2401, 1);
#nullable restore
#line 35 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 2386, Model.FilterBy, 2386, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <label for=""searchstring"">Search:</label>
                            <input type=""text"" class=""form-control"" id=""searchstring"" name=""searchString""");
                BeginWriteAttribute("value", " value=\"", 2663, "\"", 2690, 1);
#nullable restore
#line 39 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 2671, Model.SearchString, 2671, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <button type=\"submit\" class=\"form-group btn btn-primary\">Search</button>\r\n                    ");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n");
#nullable restore
#line 47 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
             if (Model.Managers.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table"">

                    <thead class=""table-theme"">
                        <tr>
                            <th scope=""col"">Username</th>
                            <th scope=""col"">First Name</th>
                            <th scope=""col"">Last Name</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">EGN</th>
                            <th scope=""col"">Address</th>
                            <th scope=""col"">Phone Number</th>
                            <th scope=""col"">Edit</th>
                            <th scope=""col"">Delete</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 65 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                         for (var i = 0; i < Model.Managers.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 68 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                                           Write(Model.Managers[i].Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].EGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 74 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                               Write(Model.Managers[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"button-holder\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4469, "\"", 4514, 2);
            WriteAttributeValue("", 4476, "/Manager/Edit?id=", 4476, 17, true);
#nullable restore
#line 77 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 4493, Model.Managers[i].Id, 4493, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Edit</a>
                                    </div>
                                </td>
                                <td>
                                    <div class=""button-holder"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 4778, "\"", 4825, 2);
            WriteAttributeValue("", 4785, "/Manager/Delete?id=", 4785, 19, true);
#nullable restore
#line 82 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 4804, Model.Managers[i].Id, 4804, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 89 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
            }
            else
            {
                if (Model.ManagersCount == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-center mb-4\">No managers yet.</p>\r\n");
#nullable restore
#line 95 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-wrap align-items-center\">\r\n                <div class=\"pagination mx-auto\">\r\n");
#nullable restore
#line 99 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                      
                        var prevPage = Model.CurrentPage - 1;
                        var nextPage = Model.CurrentPage + 1;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                     if (Model.CurrentPage != 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 5666, "\"", 5774, 8);
            WriteAttributeValue("", 5673, "/Manager/GetAll?page=", 5673, 21, true);
#nullable restore
#line 105 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 5694, prevPage, 5694, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5703, "&showPerPage=", 5703, 13, true);
#nullable restore
#line 105 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 5716, Model.ManagersPerPage, 5716, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5738, "&", 5738, 1, true);
#nullable restore
#line 105 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 5739, Model.FilterBy, 5739, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5754, "&", 5754, 1, true);
#nullable restore
#line 105 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 5755, Model.SearchString, 5755, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary prev-arrow mx-1\"><i class=\"material-icons\">keyboard_arrow_left</i></a>\r\n");
#nullable restore
#line 106 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                     for (var j = 1; j <= (Model.ManagersCount / Model.ManagersPerPage) + 1; j++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                         if (j == Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 6153, "\"", 6254, 8);
            WriteAttributeValue("", 6160, "/Manager/GetAll?page=", 6160, 21, true);
#nullable restore
#line 112 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6181, j, 6181, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6183, "&showPerPage=", 6183, 13, true);
#nullable restore
#line 112 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6196, Model.ManagersPerPage, 6196, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6218, "&", 6218, 1, true);
#nullable restore
#line 112 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6219, Model.FilterBy, 6219, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6234, "&", 6234, 1, true);
#nullable restore
#line 112 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6235, Model.SearchString, 6235, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                                                                                                                                                        Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 113 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                        }
                        else if (j >= Model.CurrentPage - 4 && (j <= Model.CurrentPage + 4 && j <= Model.EndPage))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 6464, "\"", 6565, 8);
            WriteAttributeValue("", 6471, "/Manager/GetAll?page=", 6471, 21, true);
#nullable restore
#line 116 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6492, j, 6492, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6494, "&showPerPage=", 6494, 13, true);
#nullable restore
#line 116 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6507, Model.ManagersPerPage, 6507, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6529, "&", 6529, 1, true);
#nullable restore
#line 116 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6530, Model.FilterBy, 6530, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6545, "&", 6545, 1, true);
#nullable restore
#line 116 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6546, Model.SearchString, 6546, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mx-1\">");
#nullable restore
#line 116 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                                                                                                                                                 Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 117 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                     if (Model.CurrentPage != Model.EndPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 6755, "\"", 6863, 8);
            WriteAttributeValue("", 6762, "/Manager/GetAll?page=", 6762, 21, true);
#nullable restore
#line 122 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6783, nextPage, 6783, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6792, "&showPerPage=", 6792, 13, true);
#nullable restore
#line 122 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6805, Model.ManagersPerPage, 6805, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6827, "&", 6827, 1, true);
#nullable restore
#line 122 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6828, Model.FilterBy, 6828, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6843, "&", 6843, 1, true);
#nullable restore
#line 122 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
WriteAttributeValue("", 6844, Model.SearchString, 6844, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary next-arrow mx-1\"><i class=\"material-icons\">keyboard_arrow_right</i></a>\r\n");
#nullable restore
#line 123 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Manager\GetAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightManager.ViewModels.Manager.IndexManagersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
