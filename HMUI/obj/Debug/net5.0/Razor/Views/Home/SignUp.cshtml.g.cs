#pragma checksum "D:\Develop\CodeGit\HM2#2\HM2\HMUI\Views\Home\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaccb79b45125704c9b8f83ba6d7e54fe9bd06e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SignUp), @"mvc.1.0.view", @"/Views/Home/SignUp.cshtml")]
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
#line 1 "D:\Develop\CodeGit\HM2#2\HM2\HMUI\Views\_ViewImports.cshtml"
using HMUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Develop\CodeGit\HM2#2\HM2\HMUI\Views\_ViewImports.cshtml"
using HMUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaccb79b45125704c9b8f83ba6d7e54fe9bd06e2", @"/Views/Home/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"782917fb9a9bdd930860a9d71ad88dc68fba04c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Develop\CodeGit\HM2#2\HM2\HMUI\Views\Home\SignUp.cshtml"
Write(Html.Partial("_MenuBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""Line-Lable"">
    <div class=""line-1"">


    </div>
    <div class=""lable-set"">
        <h2 style=""margin:0px 0px 0px 0px"">สมัครสมาชิก</h2>
    </div>
    <div class=""line-2"">


    </div>

</div>

<!-- Modal -->
<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header""><button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button></div>

            <div id=""modalbody"" class=""modal-body"">




            </div>
            <!-- Modal footer -->
            <div class=""modal-footer"">
                <button id=""btnSaveConfig"" type=""button"" class=""btn btn-primary"" data-dismiss=""modal"" onclick=""SaveData('menu')""><i class=""fa fa-save""></i> บันทึก</button>
                <button type=""button""");
            BeginWriteAttribute("onchange", " onchange=\"", 1027, "\"", 1038, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" data-dismiss=\"modal\"><i class=\"fa fa-remove\"></i> ยกเลิก</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
