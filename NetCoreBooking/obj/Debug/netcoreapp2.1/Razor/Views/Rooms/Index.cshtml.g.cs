#pragma checksum "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f35f868c7bd1ac79c6fdeaf2655c8bad79981a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Index), @"mvc.1.0.view", @"/Views/Rooms/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Index.cshtml", typeof(AspNetCore.Views_Rooms_Index))]
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
#line 1 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\_ViewImports.cshtml"
using NetCoreBooking;

#line default
#line hidden
#line 2 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\_ViewImports.cshtml"
using NetCoreBooking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f35f868c7bd1ac79c6fdeaf2655c8bad79981a", @"/Views/Rooms/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45ae8a7a0a46d607c9a387c8bd5d110c9c62728", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking_Room.Models.Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 68, true);
            WriteLiteral("<br />\r\n<br />\r\n<button type=\"button\" class=\"btn btn-success\">\r\n    ");
            EndContext();
            BeginContext(204, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac47b3147fe44f8a3aaeb67b8bceb67", async() => {
                BeginContext(227, 59, true);
                WriteLiteral("<span style=\"font-size:1vw; color:white;\">Create New</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 29, true);
            WriteLiteral("\r\n</button>\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(319, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a3d42f6da64e5b95c61273028f8041", async() => {
                BeginContext(380, 125, true);
                WriteLiteral("\r\n    <p>\r\n        Title: <input type=\"text\" name=\"seacrhString\">\r\n        <input type=\"submit\" value=\"Filter\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(512, 183, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-striped table-bordered display\" style=\"width:100%\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(696, 45, false);
#line 27 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.room_name));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(797, 44, false);
#line 30 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.capacity));

#line default
#line hidden
            EndContext();
            BeginContext(841, 76, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n        <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(974, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1047, 44, false);
#line 39 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.room_name));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1171, 43, false);
#line 42 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 170, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <ul class=\"list-inline m-0\">\r\n                            <li class=\"list-inline-item\">\r\n");
            EndContext();
            BeginContext(1547, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1579, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ef9e8527244466b2be038594713703", async() => {
                BeginContext(1629, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                                                       WriteLiteral(item.room_id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1637, 95, true);
            WriteLiteral("|\r\n                            </li>\r\n                            <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1732, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30a8bd53538944c89c3a8b9f06363ec2", async() => {
                BeginContext(1784, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
#line 51 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                                                                                  WriteLiteral(item.room_id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1794, 118, true);
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1927, 79, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n</div>\r\n<br />\r\n<div class=\"card-footer\">\r\n");
            EndContext();
            BeginContext(2058, 33, true);
            WriteLiteral("        <ul class=\"pagination\">\r\n");
            EndContext();
#line 66 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
              
                int position;
                int pageCurrent = ViewBag.pageCurrent;
                string seacrhString = ViewBag.seacrhString;
                float numSize = ViewBag.numSize;
                if (pageCurrent > 1)
                {

#line default
#line hidden
            BeginContext(2362, 88, true);
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2450, "\"", 2575, 1);
#line 74 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 2457, Url.Action("Index", "Rooms", new { seacrhString = (seacrhString != "" ? seacrhString : null), page = pageCurrent-1 }), 2457, 118, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2576, 56, true);
            WriteLiteral(" tabindex=\"-1\">Previous</a>\r\n                    </li>\r\n");
            EndContext();
#line 76 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                }

                for (position = 1; position <= numSize; position++)
                {

                    if (position == pageCurrent)
                    {

#line default
#line hidden
            BeginContext(2816, 73, true);
            WriteLiteral("                        <li class=\"page-item active\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2889, "\"", 3009, 1);
#line 83 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 2896, Url.Action("Index", "Rooms", new { seacrhString = (seacrhString != "" ? seacrhString : null), page = position }), 2896, 113, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3010, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3012, 8, false);
#line 83 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                                                                                                                                                                                              Write(position);

#line default
#line hidden
            EndContext();
            BeginContext(3020, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 84 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                    }

                    else
                    {

#line default
#line hidden
            BeginContext(3105, 66, true);
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3171, "\"", 3291, 1);
#line 88 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 3178, Url.Action("Index", "Rooms", new { seacrhString = (seacrhString != "" ? seacrhString : null), page = position }), 3178, 113, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3292, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3294, 8, false);
#line 88 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                                                                                                                                                                                       Write(position);

#line default
#line hidden
            EndContext();
            BeginContext(3302, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 89 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                    }

                }
                if (pageCurrent > 0 && pageCurrent < numSize)
                {

#line default
#line hidden
            BeginContext(3439, 88, true);
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3527, "\"", 3652, 1);
#line 95 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 3534, Url.Action("Index", "Rooms", new { seacrhString = (seacrhString != "" ? seacrhString : null), page = pageCurrent+1 }), 3534, 118, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3653, 52, true);
            WriteLiteral(" tabindex=\"-1\">Next</a>\r\n                    </li>\r\n");
            EndContext();
#line 97 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Rooms\Index.cshtml"
                }

            

#line default
#line hidden
            BeginContext(3741, 17, true);
            WriteLiteral("\r\n        </ul>\r\n");
            EndContext();
            BeginContext(3774, 20, true);
            WriteLiteral("</div>\r\n<br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking_Room.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
