#pragma checksum "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b25234708f285641cd4ad7c2e1042adf855ae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentView), @"mvc.1.0.view", @"/Views/Student/StudentView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/StudentView.cshtml", typeof(AspNetCore.Views_Student_StudentView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b25234708f285641cd4ad7c2e1042adf855ae7", @"/Views/Student/StudentView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f81ecf2cedf760d88ee00c64d573a491e38b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostbackData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-bar-item w3-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Semester", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
  
    ViewData["Title"] = "StudentView";
    Layout = "~/Views/_GeneralLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
  
    var data = (HocSinh)ViewData["Student"];
    PhuHuynh[] ph = (PhuHuynh[])ViewData["Parent"];
    var lop = (string)ViewData["Class"];

#line default
#line hidden
            BeginContext(246, 56, true);
            WriteLiteral("\r\n\r\n<div class=\"sidenav\" style=\"padding-top:60px\">\r\n    ");
            EndContext();
            BeginContext(302, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bc4d2cc53d84a709f7f0092b9f0d202", async() => {
                BeginContext(386, 9, true);
                WriteLiteral("Thông tin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(405, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "721ff8c324bf4f838d524301e6695c39", async() => {
                BeginContext(485, 8, true);
                WriteLiteral("Xem điểm");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(497, 347, true);
            WriteLiteral(@"
</div>

<div style="" margin-left:15%; padding-top:60px"">
    <div style=""background-color:white; padding:20px;"">
        <p style=""line-height: 1.8""/>
        <h2 style=""text-align:center"">Thông tin học sinh</h2>
        <br />
        <div class=""row"">
            <div class=""col-md-2"">Họ tên:</div>
            <div class=""col-md-2"">");
            EndContext();
            BeginContext(845, 10, false);
#line 26 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(855, 88, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Lớp:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(944, 3, false);
#line 28 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(lop);

#line default
#line hidden
            EndContext();
            BeginContext(947, 94, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Giới tính:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(1042, 13, false);
#line 30 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.GioiTinh);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 137, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Ngày sinh:</div>\r\n            <div class=\"col-md-4\">");
            EndContext();
            BeginContext(1193, 41, false);
#line 34 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.NgaySinh.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 92, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Dân tộc:</div>\r\n            <div class=\"col-md-4\">");
            EndContext();
            BeginContext(1327, 11, false);
#line 36 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.DanToc);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 141, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Số điện thoại:</div>\r\n            <div class=\"col-md-4\">");
            EndContext();
            BeginContext(1480, 8, false);
#line 40 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.SDT);

#line default
#line hidden
            EndContext();
            BeginContext(1488, 91, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Chế độ:</div>\r\n            <div class=\"col-md-4\">");
            EndContext();
            BeginContext(1580, 10, false);
#line 42 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(data.CheDo);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 147, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Địa chỉ thường trú:</div>\r\n            <div class=\"col-md-10\">");
            EndContext();
            BeginContext(1738, 9, false);
#line 46 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                              Write(data.DCTT);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 145, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Địa chỉ hiện tại:</div>\r\n            <div class=\"col-md-10\">");
            EndContext();
            BeginContext(1893, 9, false);
#line 50 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                              Write(data.DCHT);

#line default
#line hidden
            EndContext();
            BeginContext(1902, 138, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Họ tên cha:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2041, 11, false);
#line 54 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[0].HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(2052, 88, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-1\">SĐT:</div>\r\n            <div class=\"col-md-3\">");
            EndContext();
            BeginContext(2141, 9, false);
#line 56 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[0].SDT);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 96, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Nghề nghiệp:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2247, 16, false);
#line 58 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[0].NgheNghiep);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 137, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Họ tên mẹ:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2401, 11, false);
#line 62 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[1].HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(2412, 88, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-1\">SĐT:</div>\r\n            <div class=\"col-md-3\">");
            EndContext();
            BeginContext(2501, 9, false);
#line 64 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[1].SDT);

#line default
#line hidden
            EndContext();
            BeginContext(2510, 96, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Nghề nghiệp:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2607, 16, false);
#line 66 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[1].NgheNghiep);

#line default
#line hidden
            EndContext();
            BeginContext(2623, 148, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">Họ tên người giám hộ:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2772, 11, false);
#line 70 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[2].HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(2783, 88, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-1\">SĐT:</div>\r\n            <div class=\"col-md-3\">");
            EndContext();
            BeginContext(2872, 9, false);
#line 72 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[2].SDT);

#line default
#line hidden
            EndContext();
            BeginContext(2881, 96, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-2\">Nghề nghiệp:</div>\r\n            <div class=\"col-md-2\">");
            EndContext();
            BeginContext(2978, 16, false);
#line 74 "E:\University\Subjects\OAD\OOAD_Quan_ly_hoc_vu\QLHV_OOAD_Final\QLHV_OOAD_Core\Views\Student\StudentView.cshtml"
                             Write(ph[2].NgheNghiep);

#line default
#line hidden
            EndContext();
            BeginContext(2994, 57, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    <hr/>\r\n</div>\r\n\r\n");
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
