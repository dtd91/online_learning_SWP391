#pragma checksum "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b639b3684991e21adf8b09e45c54c918b69ddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessagePage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessagePage/Default.cshtml")]
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
#line 1 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b639b3684991e21adf8b09e45c54c918b69ddc", @"/Views/Shared/Components/MessagePage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28373cf24ff85914d872a3f8f52a8e9604e8c163", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MessagePage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<XTLASPNET.MessagePage.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = @Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-4\">\r\n    <div class=\"card-header bg-danger text-light\">\r\n        <h4>");
#nullable restore
#line 8 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 11 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
   Write(Html.Raw(Model.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        Chuyển đến - <a");
            BeginWriteAttribute("href", " href=\"", 361, "\"", 386, 1);
#nullable restore
#line 14 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
WriteAttributeValue("", 368, Model.UrlRedirect, 368, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\Components\MessagePage\Default.cshtml"
                                             Write(Model.UrlRedirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<XTLASPNET.MessagePage.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591