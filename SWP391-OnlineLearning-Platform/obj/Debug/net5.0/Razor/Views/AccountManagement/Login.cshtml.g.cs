#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b62a3fc4047d3c4d891c0b3b5668ce1086944d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_Login), @"mvc.1.0.view", @"/Views/AccountManagement/Login.cshtml")]
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
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b62a3fc4047d3c4d891c0b3b5668ce1086944d0", @"/Views/AccountManagement/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391_OnlineLearning_Platform.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!--div class=\"container\">\r\n   <div class=\"row profile\">-->\r\n");
            WriteLiteral(@"
<!--<div class=""col-md-9"">
            <div class=""profile-content"">
                <div class=""text-center"">
                    <h3 style=""margin-top:20px"">Login</h3>
                </div>
                <form method=""post"" asp-action=""Login"">
                    ");
#nullable restore
#line 19 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <div class=""form-group"">
                        <label asp-for=""Email"" class=""control-label"">Enter Your Email</label>
                        <input asp-for=""Email"" placeholder=""Enter Your Email"" class=""form-control"" />
                        <span asp-validation-for=""Email"" class=""text-danger"">");
#nullable restore
#line 24 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                                                                        Write(ViewBag.ErrorMess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>

                    <div class=""form-group"">
                        <label asp-for=""Password"" class=""control-label"">Enter Your Password</label>
                        <input asp-for=""Password"" placeholder=""Enter Your Password"" class=""form-control"" />
                        <span asp-validation-for=""Password"" class=""text-danger""></span>
                    </div>



                    <div class=""form-group"">
                        <input type=""submit"" value=""Login"" class=""btn btn-success"" style=""margin-left:35%; padding:5px 20px"" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>-->
<div class=""container"">
    <div class=""row profile"">

        <div class=""col-md-9"">
            <div class=""profile-content"">
                <div class=""text-center"">
                    <h3 style=""margin-top:20px"">Login</h3>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 52 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                     using (Html.BeginForm("Login", "AccountManagement", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 56 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 61 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 62 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" value=\"Login\" />\r\n                        </div>\r\n");
#nullable restore
#line 67 "D:\FPTLearning\Spring2022\SWP391\Week 4\Source Code\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391_OnlineLearning_Platform.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
