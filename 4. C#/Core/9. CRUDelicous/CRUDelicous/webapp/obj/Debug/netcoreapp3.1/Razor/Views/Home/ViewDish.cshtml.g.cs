#pragma checksum "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530d236dcbb96b37f7210ce02a570433076ec1b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_ViewDish), @"mvc.1.0.view", @"/Views/Home/ViewDish.cshtml")]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530d236dcbb96b37f7210ce02a570433076ec1b1", @"/Views/Home/ViewDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buttons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530d236dcbb96b37f7210ce02a570433076ec1b13550", async() => {
                WriteLiteral("\r\n    <title>Dish View</title>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/ViewDish.css\"/>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/bootstrap.min.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530d236dcbb96b37f7210ce02a570433076ec1b14710", async() => {
                WriteLiteral("\r\n<div>\r\n    <div class=\"index\">\r\n\r\n");
                WriteLiteral("            <a href=\"/\">Home</a>\r\n");
#nullable restore
#line 14 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
            foreach (var VARIABLE in ViewBag.Dish) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"header-box\">\r\n                    <h1 class=\"header-text-lone\">");
#nullable restore
#line 16 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                                            Write(VARIABLE.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <h6 class=\"header-text-ltwo\">");
#nullable restore
#line 17 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                                            Write(VARIABLE.Chef);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"footer-box\">\r\n                    <div class=\"description\">\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                      Write(VARIABLE.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                    <a>\r\n                        <b class=\"padds\">Calories: </b>\r\n                    </a> ");
#nullable restore
#line 26 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                    Write(VARIABLE.Calories);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div></div>\r\n                    <a>\r\n                        <b class=\"padds\">Tastiness:</b>\r\n                    </a> ");
#nullable restore
#line 30 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                    Write(VARIABLE.Tastiness);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530d236dcbb96b37f7210ce02a570433076ec1b17445", async() => {
                    WriteLiteral("\r\n                        <button class=\"btn btn-danger\"");
                    BeginWriteAttribute("formaction", " formaction=\"", 1171, "\"", 1208, 2);
                    WriteAttributeValue("", 1184, "/delete/", 1184, 8, true);
#nullable restore
#line 36 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
WriteAttributeValue("", 1192, VARIABLE.DishId, 1192, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">Delete</button>\r\n                        <button class=\"btn btn-secondary\"");
                    BeginWriteAttribute("formaction", " formaction=\"", 1284, "\"", 1319, 2);
                    WriteAttributeValue("", 1297, "/edit/", 1297, 6, true);
#nullable restore
#line 37 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
WriteAttributeValue("", 1303, VARIABLE.DishId, 1303, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">Edit</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\aklus\CDProjects\4. C#\Core\9. CRUDelicous\CRUDelicous\webapp\Views\Home\ViewDish.cshtml"
                
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
