#pragma checksum "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85605adca0ba78c34583d803df74e264fd2bb63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bike_Index), @"mvc.1.0.view", @"/Views/Bike/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bike/Index.cshtml", typeof(AspNetCore.Views_Bike_Index))]
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
#line 1 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\_ViewImports.cshtml"
using vroom;

#line default
#line hidden
#line 2 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\_ViewImports.cshtml"
using vroom.Models;

#line default
#line hidden
#line 2 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
using vroom.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85605adca0ba78c34583d803df74e264fd2bb63", @"/Views/Bike/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0faa884fe1d91f565496ae205baee14bc83884", @"/Views/_ViewImports.cshtml")]
    public class Views_Bike_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<Bike>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("The 1st Message."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bike3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 83vw ;height: 100vh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("The 2nd Message."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bike2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartials", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Controller"] = "Bike";
    ViewData["Action"] = "Index";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(241, 16, true);
            WriteLiteral("\r\n<br /><br />\r\n");
            EndContext();
            BeginContext(257, 3027, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85605adca0ba78c34583d803df74e264fd2bb637904", async() => {
                BeginContext(295, 490, true);
                WriteLiteral(@"
 

    

    <div class=""container"">        
        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""2000"" data-pause=""hover"">
         
            <!-- Wrapper for slides -->
            <div class=""carousel-inner"" role=""listbox"">
                <div class=""item active"">
                    <div class=""carousel-content"">
                        <div style=""margin: 0 auto"">
                            <p>
                                ");
                EndContext();
                BeginContext(785, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d85605adca0ba78c34583d803df74e264fd2bb638797", async() => {
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
                EndContext();
                BeginContext(913, 327, true);
                WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""carousel-content"">
                        <div style=""margin: 0 auto"">
                            <p>
                                ");
                EndContext();
                BeginContext(1240, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d85605adca0ba78c34583d803df74e264fd2bb6310545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1368, 1715, true);
                WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only""> Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"" />
    <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></scr");
                WriteLiteral(@"ipt>
    <script type=""text/javascript"" src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
    <style type=""text/css"">
        .carousel-inner {
            width: 83vw;
            height: 100vh;
            max-height: 100vh !important;
        }

        .carousel-content {
            color: black;
            display: flex;
            text-align: center;
        }
    </style>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('.carousel').carousel();
        });
    </script>

    <br />
    <br />
    <div>
        <p>
            Find Make: <input type=""text"" name=""searchString""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3083, "\"", 3113, 1);
#line 80 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
WriteAttributeValue("", 3091, ViewBag.CurrentFilter, 3091, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3114, 92, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-info\" /> |\r\n            ");
                EndContext();
                BeginContext(3206, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85605adca0ba78c34583d803df74e264fd2bb6314285", async() => {
                    BeginContext(3228, 13, true);
                    WriteLiteral("Remove Filter");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3245, 32, true);
                WriteLiteral("\r\n\r\n        </p>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3284, 100, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Bikes</h2>\r\n    </div>\r\n");
            EndContext();
#line 92 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
    if(User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Executive))
    { 

#line default
#line hidden
            BeginContext(3462, 52, true);
            WriteLiteral("        <div class=\"col-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(3514, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85605adca0ba78c34583d803df74e264fd2bb6317722", async() => {
                BeginContext(3558, 53, true);
                WriteLiteral("<i class=\"fas fa-motorcycle\"></i> &nbsp; Add New Bike");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3615, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 97 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3640, 244, true);
            WriteLiteral("    <br />\r\n    <div class=\"col-12\">\r\n        <table class=\"table table-striped border\">\r\n            <tr class=\"table-info\">\r\n                <th>Bike Photo</th>\r\n                <th>Bike Detail</th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3884, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d85605adca0ba78c34583d803df74e264fd2bb6319735", async() => {
                BeginContext(4113, 53, true);
                WriteLiteral("\r\n                        Price\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchString", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                                   WriteLiteral(ViewBag.CurrentFilter);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                                WriteLiteral(ViewBag.PriceSortParam);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                                 WriteLiteral(Model.PageNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4170, 70, true);
            WriteLiteral("\r\n                </th>\r\n                <th>Seller Information</th>\r\n");
            EndContext();
#line 113 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                 if (User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Executive))
                {

#line default
#line hidden
            BeginContext(4343, 31, true);
            WriteLiteral("                    <th></th>\r\n");
            EndContext();
#line 116 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4434, 62, true);
            WriteLiteral("                    <th class=\"text-right\">View Details</th>\r\n");
            EndContext();
#line 120 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4515, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 122 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
             foreach (var item in Model.Data)
            {

#line default
#line hidden
            BeginContext(4596, 42, true);
            WriteLiteral("            <tr>\r\n                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4638, "\"", 4681, 1);
#line 125 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
WriteAttributeValue("", 4644, Html.DisplayFor(m => item.ImagePath), 4644, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4682, 80, true);
            WriteLiteral(" width=\"150\" height=\"100\" /></td>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(4763, 36, false);
#line 127 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                  Write(Html.DisplayFor(m => item.Make.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4799, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(4802, 31, false);
#line 127 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                                                         Write(Html.DisplayFor(m => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(4833, 48, true);
            WriteLiteral(")</b> <br />\r\n                    <b>Model: </b>");
            EndContext();
            BeginContext(4882, 37, false);
#line 128 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4919, 44, true);
            WriteLiteral("<br />\r\n                    <b>Mileage: </b>");
            EndContext();
            BeginContext(4964, 34, false);
#line 129 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                               Write(Html.DisplayFor(m => item.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(4998, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(5044, 32, false);
#line 131 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
               Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(5076, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5078, 35, false);
#line 131 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                                                 Write(Html.DisplayFor(m => item.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(5113, 63, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>Name: </b> ");
            EndContext();
            BeginContext(5177, 37, false);
#line 133 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerName));

#line default
#line hidden
            EndContext();
            BeginContext(5214, 42, true);
            WriteLiteral("<br />\r\n                    <b>Email: </b>");
            EndContext();
            BeginContext(5257, 38, false);
#line 134 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(5295, 42, true);
            WriteLiteral("<br />\r\n                    <b>Phone: </b>");
            EndContext();
            BeginContext(5338, 38, false);
#line 135 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(5376, 27, true);
            WriteLiteral("\r\n                </td>\r\n\r\n");
            EndContext();
#line 138 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                 if (User.IsInRole(Roles.Admin) || User.IsInRole(Roles.Executive))
                {

#line default
#line hidden
            BeginContext(5506, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(5526, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d85605adca0ba78c34583d803df74e264fd2bb6329309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 140 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5581, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 141 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5643, 175, true);
            WriteLiteral("                    <td class=\"text-right\">\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5818, "\"", 5853, 1);
#line 146 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
WriteAttributeValue("", 5825, Url.Action("View/"+item.Id), 5825, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5854, 100, true);
            WriteLiteral("><i class=\"fas fa-search-plus\"></i></a>\r\n                        </div>\r\n                    </td>\r\n");
            EndContext();
#line 149 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5973, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 151 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6007, 27, true);
            WriteLiteral("        </table> \r\n        ");
            EndContext();
            BeginContext(6034, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d85605adca0ba78c34583d803df74e264fd2bb6332467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 153 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 153 "C:\Users\tahir\source\repos\vroom-master\vroom\Views\Bike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6106, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<Bike>> Html { get; private set; }
    }
}
#pragma warning restore 1591
