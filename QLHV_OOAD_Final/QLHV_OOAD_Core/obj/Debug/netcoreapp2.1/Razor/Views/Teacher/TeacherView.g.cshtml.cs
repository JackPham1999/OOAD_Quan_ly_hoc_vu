#pragma checksum "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5ca484a703a52e78580a47a8fce53ac94413d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherView), @"mvc.1.0.view", @"/Views/Teacher/TeacherView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/TeacherView.cshtml", typeof(AspNetCore.Views_Teacher_TeacherView))]
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
#line 1 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\_ViewImports.cshtml"
using QLHV_OOAD_Core;

#line default
#line hidden
#line 2 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\_ViewImports.cshtml"
using QLHV_OOAD_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba5ca484a703a52e78580a47a8fce53ac94413d0", @"/Views/Teacher/TeacherView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f81ecf2cedf760d88ee00c64d573a491e38b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeacherView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-bar-item w3-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ScoreAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ScoreEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml"
  
    ViewData["Title"] = "TeacherView";
    Layout = "~/Views/_GeneralLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml"
  
    var data = (GiaoVien)ViewData["Teacher"];
    var mon = (MonHoc)ViewData["Mon"];

#line default
#line hidden
            BeginContext(192, 56, true);
            WriteLiteral("\r\n\r\n<div class=\"sidenav\" style=\"padding-top:60px\">\r\n    ");
            EndContext();
            BeginContext(248, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86d3eb51541347af9928bdf72e62089d", async() => {
                BeginContext(306, 9, true);
                WriteLiteral("Thông tin");
                EndContext();
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
            EndContext();
            BeginContext(319, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(325, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b933ca50f05f495b8a8bb7e59cd8defe", async() => {
                BeginContext(380, 9, true);
                WriteLiteral("Thêm điểm");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(399, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ad8c8542e2a4a42bbbbf6366487a3a0", async() => {
                BeginContext(455, 8, true);
                WriteLiteral("Sửa điểm");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 349, true);
            WriteLiteral(@"
</div>

<div style="" margin-left:15%; padding-top:60px"">
    <div style=""background-color:white; padding:20px;"">
        <p style=""line-height: 1.8"" />
        <h2 style=""text-align:center"">Thông tin giáo viên</h2>
        <br />
        <div class=""row"">
            <div class=""col-md-2"">Họ tên:</div>
            <div class=""col-md-2"">");
            EndContext();
            BeginContext(817, 10, false);
#line 26 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml"
                             Write(data.Hoten);

#line default
#line hidden
            EndContext();
            BeginContext(827, 98, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Môn giảng dạy:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(926, 13, false);
#line 28 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml"
                             Write(mon.TenMonHoc);

#line default
#line hidden
            EndContext();
            BeginContext(939, 97, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Số điện thoại</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(1037, 8, false);
#line 30 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Teacher\TeacherView.cshtml"
                             Write(data.SDT);

#line default
#line hidden
            EndContext();
            BeginContext(1045, 58, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
