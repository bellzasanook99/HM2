#pragma checksum "C:\Users\s5801073810058\source\repos\HMCore\HMUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d479df417e7ef9704d4b283fe49ac913d70f57a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\s5801073810058\source\repos\HMCore\HMUI\Views\_ViewImports.cshtml"
using HMUI;

#line default
#line hidden
#line 2 "C:\Users\s5801073810058\source\repos\HMCore\HMUI\Views\_ViewImports.cshtml"
using HMUI.Models;

#line default
#line hidden
#line 5 "C:\Users\s5801073810058\source\repos\HMCore\HMUI\Views\Home\Index.cshtml"
using Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d479df417e7ef9704d4b283fe49ac913d70f57a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"782917fb9a9bdd930860a9d71ad88dc68fba04c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Core.Models.MdlRegisters>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\s5801073810058\source\repos\HMCore\HMUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 604, true);
            WriteLiteral(@"
<div class=""header-Barand"">
    <div class=""flx-brand"">
        <div class=""Barand"" data-flickity='{ ""fade"": true, ""imagesLoaded"": true,""pageDots"": false,""autoPlay"":5000}'>


            <div class=""carousel-cell"">


                <img class=""carousel-cell-image"" src=""https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg"" />
            </div>
            <div class=""carousel-cell"">


                <img class=""carousel-cell-image"" src=""https://www.industrialempathy.com/img/remote/ZiClJf-1920w.jpg"" />
            </div>
        </div>


    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core.Models.MdlRegisters> Html { get; private set; }
    }
}
#pragma warning restore 1591