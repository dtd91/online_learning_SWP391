#pragma checksum "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74b12b78e02c23472695403810ce18b46ced610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseRegister), @"mvc.1.0.view", @"/Views/Course/CourseRegister.cshtml")]
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
#line 1 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74b12b78e02c23472695403810ce18b46ced610", @"/Views/Course/CourseRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SWP391_OnlineLearning_Platform.Models.Price_Package>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseRegister.cshtml"
  
    ViewData["Title"] = "CourseRegister";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n\r\n    <div class=\"page-heading text-center\">\r\n        <div class=\"container\">\r\n            <h2>PRICING PLANS</h2>\r\n        </div>\r\n    </div>\r\n    <div class=\"container pricings\">\r\n        <div class=\"row text-center\">\r\n");
#nullable restore
#line 16 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseRegister.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-3 col-sm-6"">
                    <div class=""plan"">
                        <p class=""ribbon"">MOST POPULAR</p>
                        <p class=""price"">p.List_price</p>
                        <p class=""crew"">p.Name</p>
                        <div class=""plan-details"">
                            <p>Unlimited Courses</p>
                            <p>Online pass purchases</p>
                            <p>Online class reservations</p>
                            <p>Full Library Entry</p>
                            <p>Promo Code feature</p>
                        </div>
                        <a href=""#""><i class=""zmdi zmdi-arrow-right""></i>FREE TRIAL</a>
                        <a href=""#""><i class=""zmdi zmdi-arrow-right""></i>ORDER NOW</a>
                    </div>
                </div>
");
#nullable restore
#line 34 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseRegister.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SWP391_OnlineLearning_Platform.Models.Price_Package>> Html { get; private set; }
    }
}
#pragma warning restore 1591
