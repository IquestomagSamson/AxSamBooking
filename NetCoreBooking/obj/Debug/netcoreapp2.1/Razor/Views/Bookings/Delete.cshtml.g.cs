#pragma checksum "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e9466416ed7b67efceeebc88858b5829ee4f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Delete), @"mvc.1.0.view", @"/Views/Bookings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bookings/Delete.cshtml", typeof(AspNetCore.Views_Bookings_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e9466416ed7b67efceeebc88858b5829ee4f54", @"/Views/Bookings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45ae8a7a0a46d607c9a387c8bd5d110c9c62728", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking_Room.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:1vw; color:dodgerblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 201, true);
            WriteLiteral("\r\n\r\n\r\n<h4 style=\"color:coral\">Bạn có thực sự muốn xóa lịch booking cuộc họp này không?</h4>\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(329, 49, false);
#line 16 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.booking_title));

#line default
#line hidden
            EndContext();
            BeginContext(378, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(451, 45, false);
#line 19 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.booking_title));

#line default
#line hidden
            EndContext();
            BeginContext(496, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(569, 46, false);
#line 22 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.start_time));

#line default
#line hidden
            EndContext();
            BeginContext(615, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(688, 42, false);
#line 25 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.start_time));

#line default
#line hidden
            EndContext();
            BeginContext(730, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(803, 44, false);
#line 28 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.end_time));

#line default
#line hidden
            EndContext();
            BeginContext(847, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(920, 40, false);
#line 31 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.end_time));

#line default
#line hidden
            EndContext();
            BeginContext(960, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1033, 48, false);
#line 34 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.participants));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1154, 44, false);
#line 37 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.participants));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1271, 40, false);
#line 40 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1384, 36, false);
#line 43 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.note));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1493, 44, false);
#line 46 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.users_id));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1610, 40, false);
#line 49 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.users_id));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1723, 40, false);
#line 52 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 72, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd style=\"color:cornflowerblue\">\r\n            ");
            EndContext();
            BeginContext(1836, 39, false);
#line 55 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.room_id));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1909, 353, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8daa36e6b3845038d8e4516491a9a1e", async() => {
                BeginContext(1935, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1945, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5dfe846dad3b404ba1b15a2c27aae8d3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\Huy\Desktop\Ky_9\TTCN\NetCoreBooking\NetCoreBooking\Views\Bookings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.booking_id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1989, 137, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" style=\"font-size:1vw; color:white\" />\r\n        <br /><br />\r\n\r\n        ");
                EndContext();
                BeginContext(2126, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed406d212294d189030b38b863ca12a", async() => {
                    BeginContext(2223, 22, true);
                    WriteLiteral("Trở về trang danh sách");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2249, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2262, 16, true);
            WriteLiteral("\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking_Room.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
