#pragma checksum "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passengers_UnassignedList), @"mvc.1.0.view", @"/Views/Passengers/UnassignedList.cshtml")]
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
#line 1 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe", @"/Views/Passengers/UnassignedList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Passengers_UnassignedList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.Passenger>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profille", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
  
    ViewData["Title"] = "Assigned Passengers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n        <div class=\"col-1\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe6447", async() => {
                WriteLiteral("Add New Passenger");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"col-1\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe7802", async() => {
                WriteLiteral("Deactivated list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"col-1\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe9156", async() => {
                WriteLiteral("Deactivated list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <table class=\"table table-striped table-bordered\">\r\n");
#nullable restore
#line 29 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
         for (int i = 0; i < 2; i++)
        {
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-8\">\r\n                    <div class=\"card bg-light\">\r\n                        <div class=\"card-header text-muted border-bottom-0\">\r\n                            Passenger #");
#nullable restore
#line 38 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                  Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body pt-0\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-7\">\r\n                                    <h2 class=\"lead\"><b>");
#nullable restore
#line 43 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                                    <p class=\"text-muted text-sm\"><b>Account:</b> ");
#nullable restore
#line 44 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                                             Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / Age:24 / Worker </p>\r\n                                    <ul class=\"ml-4 mb-0 fa-ul text-muted\">\r\n                                        <li class=\"small\"><span class=\"fa-li\"><i class=\"fas fa-lg fa-building\"></i></span> Address: ");
#nullable restore
#line 46 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                                                                                               Write(item.HomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"small\"><span class=\"fa-li\"><i class=\"fas fa-lg fa-phone\"></i></span> Email:  ");
#nullable restore
#line 47 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                                                                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li class=\"small\"><span class=\"fa-li\"><i class=\"fas fa-lg fa-phone\"></i></span> Phone #: +");
#nullable restore
#line 48 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                                                                                             Write(item.Cell);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                                <div class=\"col-5 text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe14634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <div class=""text-right"">
                                <a href=""#"" class=""btn btn-sm bg-teal"">
                                    <i class=""fas fa-comments""></i>
                                </a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70e2e51506f3f8e7a3765e1ebbcfae5aae0ed9fe16182", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-user\"></i>Profile\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                           WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-muted border-bottom-0"">

                        </div>
                        <div class=""card-body pt-0"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <h2 class=""lead"">Trips #");
#nullable restore
#line 78 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                       Write(item.TripID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <h3 class=\"lead\"><b>From:");
#nullable restore
#line 79 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                        Write(item.ArrivalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> To: ");
#nullable restore
#line 79 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                                                                     Write(item.DepartureTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n                                </div>\r\n");
#nullable restore
#line 81 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
                                 if (item.TripID == 49)
                                {
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <div class=""card-footer"">
                            <div class=""text-right"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 93 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Passengers\UnassignedList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.Passenger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
