#pragma checksum "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df5c03288305c6db8f59ff692ad65cd3761a8ae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
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
#line 1 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5c03288305c6db8f59ff692ad65cd3761a8ae5", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("timer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
  
    Layout = "~/Views/Shared/QuizComponent/_QuizLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .btn {\r\n        display: inline-block;\r\n    }\r\n</style>\r\n<div class=\"page-heading text-center\">\r\n    <div class=\"container\">\r\n        <h2>Type of quiz: As or prac</h2>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-xs-10\" style=\"margin-bottom:0px\">\r\n");
            WriteLiteral(@"        <div class=""lmao"" style=""margin-top:20px"">
            <div class=""col-xs-6"">
                <div class=""col-sm-6"">
                    <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#startModal"">Start</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#resetModal"">Reset</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#submitModal"">Submit</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
                            Instruction
                        </button>
                        <div>");
#nullable restore
#line 39 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
                        Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 43 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalSubmit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalStart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalReset"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalInstruction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>

            </div>

        </div>
    </div>
</div>
<hr />
<div class=""row"">
    <div class=""col-xs-8"">
        <div id=""div1"" class=""infoDiv"" style=""display:none;"">
            <div class=""company-story-content"">
                <h1 class=""story-title"">
                    Store <span class=""color-text"">Username</span>
                </h1>
            </div>
            <p>Store username is unique and it will be used to find your store.</p>
            <p>For example www.flashcart.com/<span class=""color-text"">abc</span> to find store that has <span class=""color-text"">abc</span> username.</p>
            <p>Please keep in mind before choosing username.</p>
            <ul>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;Username can contain <span class=""color-text"">Alphabets</span>
                <li>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;Username can contain <span class=""color-text"">Numbers</span>.</li>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;Username c");
            WriteLiteral(@"an contain <span class=""color-text"">Underscores</span>.</li>
            </ul>
        </div>

        <div id=""div2"" class=""infoDiv"" style=""display:none;"">
            <div class=""company-story-content"">
                <h1 class=""story-title"">Some other<span class=""color-text"">Username</span> </h1>
            </div>
            <p>Div</p>
        </div>
    </div>
    <div class=""col-xs-4"">
        <div class=""col-xs-6"">
            <h4>Navigation</h4>
            <div class=""btn-toolbar mb-3"" role=""toolbar"" aria-label=""Toolbar with button groups"">
                <div class=""btn-group mr-2"" role=""group"" aria-label=""First group"">
                    <button type=""button"" class=""btn btn-secondary info"" id=""1"">1</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""2"">2</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""3"">3</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""4"">4</button>");
            WriteLiteral(@"
                </div>

                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"" id=""btnGroupAddon""></div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df5c03288305c6db8f59ff692ad65cd3761a8ae59969", async() => {
                WriteLiteral("\r\n<p>\r\n    <input type=\"number\" name=\"display\" size=\"\r\n    20\" value=\"30\" />\r\n</p>\r\n\r\n<!-- changed the interval from 100ms to 1000ms -->\r\n<p>\r\n    <input type=\"button\" value=\"Start\"\r\n           onclick=\"Id=setInterval(\'startTimer()\', 1000)\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <script>\r\n        function startTimer() {\r\n            var obj = ");
#nullable restore
#line 125 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
                 Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

            /* make sure to tell javascript that 'seconds' is  Number that
                comes from the input box */
            var seconds;


            seconds = Number(obj);

            /*  Don't need this *AND* seconds-- */
                   seconds = seconds - 1;

            if (seconds <= 0) {
                clearInterval(Id);
                seconds = 0;
            }
            else {
                seconds--;
            }

            obj.display.value = seconds;
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
