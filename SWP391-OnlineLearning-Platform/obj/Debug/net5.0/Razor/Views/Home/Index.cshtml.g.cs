#pragma checksum "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39943ca71feb0da555a09c1d8a1a11b7e7a4dcba"
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
#line 1 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39943ca71feb0da555a09c1d8a1a11b7e7a4dcba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cc414232cb72a548af1b9bdfef0c3bcad4d1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SWP391_OnlineLearning_Platform.Controllers.ExampleController.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    //var students = ViewBag.students as List<SWP391_OnlineLearning_Platform.Controllers.ExampleController.Student>;
    var students = ViewData["students"] as List<SWP391_OnlineLearning_Platform.Controllers.ExampleController.Student>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>


<div>
    <table class=""table"">
        <tr>
            <td>id</td>
            <td>Fname</td>
            <td>Lname</td>
        </tr>
");
#nullable restore
#line 21 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
               Write(item.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
               Write(item.Lname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "E:\Project\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SWP391_OnlineLearning_Platform.Controllers.ExampleController.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
