#pragma checksum "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c355592307e1c1e7ad92dacb7e6b437dc450381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c355592307e1c1e7ad92dacb7e6b437dc450381", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199b4e53545c67bd84ad2eaa2357bc02933d8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c355592307e1c1e7ad92dacb7e6b437dc4503815201", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"css/site.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<header>\r\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow \">\r\n        <div class=\"container spacer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c355592307e1c1e7ad92dacb7e6b437dc4503816424", async() => {
                WriteLiteral("<h2>Dojo Activity Center</h2>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                <ul class=""navbar-nav flex-grow-1"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c355592307e1c1e7ad92dacb7e6b437dc4503818629", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"options\">\r\n                <h7 class=\"welcome-msg\">Welcome ");
#nullable restore
#line 22 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                                           Write(ViewBag.LoggedInUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h7>
                <a href=""/logout"" class=""btn btn-danger welcome-msg"">Log out</a>

            </div>
        </div>
    </nav>
</header>

<table class=""table table-dark"">
    <thead>
    <tr>
        <th>Activity</th>
        <th>Date and Time</th>
        <th>Duration</th>
        <th>Event Coordinator</th>
        <th>Participants</th>
        <th>Actions</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
      
        foreach (Activity VARIABLE in ViewBag.Activities) {
            if (VARIABLE.Date < DateTime.Now) {
                
            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                   Write(VARIABLE.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                   Write(VARIABLE.Date.ToString("MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 49 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                                                       Write(VARIABLE.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                   Write(VARIABLE.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                                      Write(VARIABLE.DurationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                   Write(VARIABLE.Poster.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                   Write(VARIABLE.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                      
                        if (ViewBag.LoggedInUser.UserId == VARIABLE.UserId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2296, "\"", 2331, 2);
            WriteAttributeValue("", 2303, "/delete/", 2303, 8, true);
#nullable restore
#line 56 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2311, VARIABLE.ActivityId, 2311, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2402, "\"", 2439, 2);
            WriteAttributeValue("", 2409, "/activity/", 2409, 10, true);
#nullable restore
#line 57 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2419, VARIABLE.ActivityId, 2419, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">View</a>\r\n\r\n                            </td>\r\n");
#nullable restore
#line 60 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                        }
                        else {
                            if (VARIABLE.Guests.Any(f => f.UserId == ViewBag.LoggedInUser.UserId)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2749, "\"", 2813, 4);
            WriteAttributeValue("", 2756, "/unrsvp/", 2756, 8, true);
#nullable restore
#line 64 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2764, VARIABLE.ActivityId, 2764, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2784, "/", 2784, 1, true);
#nullable restore
#line 64 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2785, ViewBag.LoggedInUser.UserId, 2785, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Un-RSVP</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2889, "\"", 2926, 2);
            WriteAttributeValue("", 2896, "/activity/", 2896, 10, true);
#nullable restore
#line 65 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2906, VARIABLE.ActivityId, 2906, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">View</a>\r\n                                </td>\r\n");
#nullable restore
#line 67 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                            }
                            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3144, "\"", 3206, 4);
            WriteAttributeValue("", 3151, "/rsvp/", 3151, 6, true);
#nullable restore
#line 70 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3157, VARIABLE.ActivityId, 3157, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3177, "/", 3177, 1, true);
#nullable restore
#line 70 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3178, ViewBag.LoggedInUser.UserId, 3178, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">RSVP</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3280, "\"", 3317, 2);
            WriteAttributeValue("", 3287, "/activity/", 3287, 10, true);
#nullable restore
#line 71 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3297, VARIABLE.ActivityId, 3297, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">View</a>\r\n\r\n                                </td>\r\n");
#nullable restore
#line 74 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>  \r\n");
#nullable restore
#line 78 "C:\Users\aklus\CDProjects\4. C#\Exam\Activity Planner\webapp\Views\Home\Dashboard.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n<a href=\"/newActivity\" class=\"btn btn-primary movement\">Add New Activity</a>");
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
