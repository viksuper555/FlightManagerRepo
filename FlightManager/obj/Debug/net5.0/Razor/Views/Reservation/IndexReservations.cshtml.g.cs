#pragma checksum "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed7bf62e78d3e2d22c1564ee17c283cd0aa1977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_IndexReservations), @"mvc.1.0.view", @"/Views/Reservation/IndexReservations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed7bf62e78d3e2d22c1564ee17c283cd0aa1977", @"/Views/Reservation/IndexReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f786fd48d4832d47c30e803e7f87b4fe4964de31", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_IndexReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightManager.ViewModels.Reservation.IndexReservationsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Reservation/IndexReservations"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
  
    ViewData["Title"] = "IndexReservations";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"py-5\">\r\n        <div class=\"container\">\r\n            <h1 style=\"margin: 2%; text-align: center;\">All Reservations</h1>\r\n            <div style=\"padding: 5%;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ed7bf62e78d3e2d22c1564ee17c283cd0aa19774622", async() => {
                WriteLiteral(@"
                    <div class=""form-group"" style=""display: none"">
                        <input type=""text"" class=""form-control"" id=""page"" name=""page"" value=""1"">
                    </div>
                    <div class=""form-group"">
                        <label for=""searchstring"">Search email:</label>
                        <input type=""text"" class=""form-control"" id=""searchstring"" name=""searchString""");
                BeginWriteAttribute("value", " value=\"", 845, "\"", 872, 1);
#nullable restore
#line 17 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 853, Model.SearchString, 853, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <button type=\"submit\" class=\"form-group btn btn-primary\">Search</button>\r\n                ");
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
            WriteLiteral(@"
                <table class=""table"">
                    <thead class=""table-theme"">
                        <tr>
                            <th scope=""col"">First Name</th>
                            <th scope=""col"">Second Name</th>
                            <th scope=""col"">Last Name</th>
                            <th scope=""col"">Email</th>
                            <th scope=""col"">EGN</th>
                            <th scope=""col"">Phone Number</th>
                            <th scope=""col"">Nationality</th>
                            <th scope=""col"">Ticket Type</th>
                            <th scope=""col"">Ticket Count</th>
                            <th scope=""col"">Is Confirmed</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 38 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                         for (var i = 0; i < Model.Reservations.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 41 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                                           Write(Model.Reservations[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].EGN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].TicketType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].TicketsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                               Write(Model.Reservations[i].IsConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                                 if (@Model.Reservations[i].IsConfirmed == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <div class=\"button-holder\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3063, "\"", 3118, 2);
            WriteAttributeValue("", 3070, "/Reservation/Delete?id=", 3070, 23, true);
#nullable restore
#line 55 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 3093, Model.Reservations[i].Id, 3093, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-uppercase\">Delete</a>\r\n                                        </div>\r\n                                    </td>\r\n");
#nullable restore
#line 58 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                <div class=\"d-flex flex-wrap align-items-center\">\r\n                    <div class=\"pagination mx-auto\">\r\n");
#nullable restore
#line 67 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                          
                            var prevPage = Model.CurrentPage - 1;
                            var nextPage = Model.CurrentPage + 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                         if (Model.CurrentPage != 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 3835, "\"", 3920, 4);
            WriteAttributeValue("", 3842, "/Reservation/IndexReservations?page=", 3842, 36, true);
#nullable restore
#line 73 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 3878, prevPage, 3878, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3887, "&searchString=", 3887, 14, true);
#nullable restore
#line 73 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 3901, Model.SearchString, 3901, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary prev-arrow mx-1\"><i class=\"material-icons\">keyboard_arrow_left</i></a>\r\n");
#nullable restore
#line 74 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                         for (var j = 1; j <= (Model.ReservationsCount / 8) + 1; j++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                             if (j == Model.CurrentPage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4307, "\"", 4385, 4);
            WriteAttributeValue("", 4314, "/Reservation/IndexReservations?page=", 4314, 36, true);
#nullable restore
#line 80 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4350, j, 4350, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4352, "&searchString=", 4352, 14, true);
#nullable restore
#line 80 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4366, Model.SearchString, 4366, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                                                                                                                                     Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 81 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                            }
                            else if (j >= Model.CurrentPage - 4 && (j <= Model.CurrentPage + 4 && j <= Model.EndPage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 4611, "\"", 4689, 4);
            WriteAttributeValue("", 4618, "/Reservation/IndexReservations?page=", 4618, 36, true);
#nullable restore
#line 84 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4654, j, 4654, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4656, "&searchString=", 4656, 14, true);
#nullable restore
#line 84 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4670, Model.SearchString, 4670, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mx-1\">");
#nullable restore
#line 84 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                                                                                                                              Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 85 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 88 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                         if (Model.CurrentPage != Model.EndPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 4899, "\"", 4984, 4);
            WriteAttributeValue("", 4906, "/Reservation/IndexReservations?page=", 4906, 36, true);
#nullable restore
#line 90 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4942, nextPage, 4942, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4951, "&searchString=", 4951, 14, true);
#nullable restore
#line 90 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
WriteAttributeValue("", 4965, Model.SearchString, 4965, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary next-arrow mx-1\"><i class=\"material-icons\">keyboard_arrow_right</i></a>\r\n");
#nullable restore
#line 91 "C:\Users\viksu\Source\Repos\viksuper555\FlightManagerRepo\FlightManager\Views\Reservation\IndexReservations.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\"\r\n          rel=\"stylesheet\">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightManager.ViewModels.Reservation.IndexReservationsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
