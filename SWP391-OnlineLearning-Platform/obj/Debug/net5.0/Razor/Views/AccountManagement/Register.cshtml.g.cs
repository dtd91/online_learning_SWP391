#pragma checksum "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f1f03c36e0a73191fce71a9a9d5cb398d5a2b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManagement_Register), @"mvc.1.0.view", @"/Views/AccountManagement/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f1f03c36e0a73191fce71a9a9d5cb398d5a2b6", @"/Views/AccountManagement/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManagement_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391_OnlineLearning_Platform.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
   ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""container"">
    <div class=""row profile"">

        <div class=""col-md-9"">
            <div class=""profile-content"">
                <div class=""text-center"">
                    <h3 style=""margin-top:20px"">Login</h3>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 17 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                     using (Html.BeginForm("Register", "AccountManagement", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 22 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 23 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Full_Name, "", new { @class = "form-control", @placeholder = "Full Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Full_Name, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 27 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control", @placeholder = "User Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Username, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 33 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                             if (ViewBag.error != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">");
#nullable restore
#line 38 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                                                Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 38 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 41 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Dob, new { @class = "form-control", @placeholder = "Date of birth" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Dob, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 46 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 48 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 51 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 52 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control", @placeholder = "Confim Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 53 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 56 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Auth_Provider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Auth_Provider, "", new { @class = "form-control", @placeholder = "Auth Provider" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 58 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Auth_Provider, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 61 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Avatar_Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 62 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Avatar_Url, "", new { @class = "form-control", @placeholder = "Avatar" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 63 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Avatar_Url, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 66 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 67 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, "", new { @class = "form-control", @placeholder = "Phone Number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 68 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 71 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Reset_password_token));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 72 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Reset_password_token, "", new { @class = "form-control", @placeholder = "Reset password token" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 73 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Reset_password_token, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 76 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Verification_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 77 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Verification_code, "", new { @class = "form-control", @placeholder = "Verification Code" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 78 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Verification_code, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 81 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.LabelFor(m => m.Status_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 82 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.TextBoxFor(m => m.Status_Id, "", new { @class = "form-control", @placeholder = "Status" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 83 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status_Id, "", new { @class = "badge badge-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" name=\"submit\" class=\"btn btn-danger\" value=\"Register\" />\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "D:\FPTU-Learning\Spring2022\SWP391\Week5\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\AccountManagement\Register.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
