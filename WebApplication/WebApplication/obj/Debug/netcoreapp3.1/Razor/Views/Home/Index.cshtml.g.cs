#pragma checksum "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff7024f65bbb141381bf84a97f494d5eab9ea24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff7024f65bbb141381bf84a97f494d5eab9ea24", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.Driver>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-bordered-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>150</h3>

                    <p>Active Drivers</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-bag""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>

        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>53<sup style=""font-size: 20px"">%</sup></h3>

                    <p>Driver Ratings</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-stats-bars""></i>
                </div>
                <a href=""#"" class=""small-");
            WriteLiteral(@"box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>

        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>44</h3>

                    <p>Passenger Registrations</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person-add""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>

        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>65</h3>

                    <p>Passenger Stats</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""#"" class=""small-box-");
            WriteLiteral(@"footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
    </div>
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">

                    <!-- Profile Image -->
                    <div class=""card card-success card-outline"">
                        <div class=""card-body box-profile"">
                            <div class=""text-center"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ff7024f65bbb141381bf84a97f494d5eab9ea249442", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <h3 class=\"profile-username text-center\"> ");
#nullable restore
#line 78 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 78 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p class=\"text-muted text-center\">Passenger ");
#nullable restore
#line 79 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                   Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            <ul class=""list-group list-group-unbordered mb-3"">
                                <li class=""list-group-item"">
                                    <b>Trips Completed</b> <a class=""float-right"">204</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Amount Due</b> <a class=""float-right"">R543.00</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Ratings</b> <a class=""float-right"">3/10 Stars</a>
                                </li>
                            </ul>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff7024f65bbb141381bf84a97f494d5eab9ea2412507", async() => {
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ff7024f65bbb141381bf84a97f494d5eab9ea2412796", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 92 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <input type=\"submit\" style=\"width:180px\" value=\"UPDATE\" class=\"btn btn-success\" />\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                    <!-- About Me Box -->
                    <div class=""card card-success"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">PASSENGER</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <strong><i class=""fas fa-book mr-1""></i> detail submitted</strong>

                            <p class=""text-muted"">
                                Documents recieved
                            </p>
                            <hr>
                            <strong><i class=""fas fa-map-marker-alt mr-1""></i> Location</strong>
                            <p class=""text-muted"">Johanesburg</p>
                            <hr>
                        </div>
                        <!-- /.card-body -->
            ");
            WriteLiteral(@"        </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills"">
                                <li class=""nav-item""><a class=""btn btn-success"" href=""#update"" data-toggle=""tab"">Activity</a></li>
                            </ul>
                        </div><!-- /.card-header -->
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane"" id=""update"">
                                    <!-- Post -->
                                    <div class=""card card-success"">
                                        <div class=""card-header"">
                                            <h3 class=""card-title"">DRIVER #");
#nullable restore
#line 134 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                      Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                        </div>
                                        <!-- /.card-header -->
                                        <div class=""card-body"" style=""background-color:white"">
                                            <div class=""row"">
                                                <div>
                                                    <div class=""row"">
                                                        <div class=""col-12 col-sm-4"">
                                                            <div class=""info-box bg-light"">
                                                                <div class=""info-box-content"">
                                                                    <span class=""info-box-text text-center text-muted"">Date Account </span>
                                                                    <span class=""info-box-number text-center text-muted mb-0"">05/02/2020</span>
                                                                </div>");
            WriteLiteral(@"
                                                            </div>
                                                        </div>
                                                        <div class=""col-12 col-sm-4"">
                                                            <div class=""info-box bg-light"">
                                                                <div class=""info-box-content"">
                                                                    <span class=""info-box-text text-center text-muted"">Added by</span>
                                                                    <span class=""info-box-number text-center text-muted mb-0"">Admin 1</span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class=""col-12 col-sm-4"">
                                                         ");
            WriteLiteral(@"   <div class=""info-box bg-light"">
                                                                <div class=""info-box-content"">
                                                                    <span class=""info-box-text text-center text-muted"">Last modified</span>
                                                                    <span class=""info-box-number text-center text-muted mb-0"">05/04/2020<span>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""row"">
                                                        <div class=""col-12"">
                                                            <div class=""post"">
                                                                <div class=""user-block"">
                                    ");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ff7024f65bbb141381bf84a97f494d5eab9ea2421406", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                                    <span class=\"username\">\n                                                                        <a href=\"#\">");
#nullable restore
#line 172 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 172 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                           Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                                                    </span>
                                                                    <span class=""description"">Worker Passenger</span>
                                                                </div>
                                                                <!-- /.user-block -->
                                                                <div class=""row"" style=""position:center"">
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Full Name</h5>
                                                                        <span class=""description"">");
#nullable restore
#line 180 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 180 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                                         Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                    </div>
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Gender</h5>
                                                                        <span class=""description"">");
#nullable restore
#line 184 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                             Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                    </div>
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Age</h5>
                                                                        <span class=""description"">34 years old</span>
                                                                    </div>
                                                                </div>
                                                                </br>
                                                                </br>
                                                                <div class=""row"">

                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Email</h5>
                                                                        ");
            WriteLiteral("<span class=\"description\">");
#nullable restore
#line 197 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                    </div>
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Cell</h5>
                                                                        <span class=""description"">");
#nullable restore
#line 201 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                             Write(Model.Cell);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                    </div>
                                                                </div>
                                                                </br>
                                                                </br>
                                                                <div class=""row"">
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Usertype</h5>
                                                                        <span class=""description"">Passeneger</span>
                                                                    </div>
                                                                    <div class=""col-4"">
                                                                        <h5 class=""headline"">Passenger type</h5>
                                                             ");
            WriteLiteral(@"           <span class=""description"">Worker</span>
                                                                    </div>

                                                                </div>
                                                                </br>
                                                                </br>
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff7024f65bbb141381bf84a97f494d5eab9ea2429093", async() => {
                WriteLiteral("\n                                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff7024f65bbb141381bf84a97f494d5eab9ea2429418", async() => {
                    WriteLiteral("\n                                                                        <i class=\"fas fa-user\"></i>Update\n                                                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 220 "C:\Users\user\team27\BetaPrototype\WebApplication\WebApplication\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
                                            </div>

                                        </div>
                                        <!-- /.card-body -->
                                    </div>
                                    <!-- Post -->
                                    <!-- /.post -->
                                </div>

                                <!-- /.tab-pane -->
                            </div>
                            <!-- /.tab-content -->
                        </div><!-- /.card-body -->
                    </div>
                    <!-- /.nav-tabs-custom -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.Driver> Html { get; private set; }
    }
}
#pragma warning restore 1591
