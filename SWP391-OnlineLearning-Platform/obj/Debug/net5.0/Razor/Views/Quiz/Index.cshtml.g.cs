#pragma checksum "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b2556510cf083525a92bc93153707f75d6f034"
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
#line 1 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b2556510cf083525a92bc93153707f75d6f034", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/trung.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/timer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
  
    Layout = "~/Views/Shared/QuizComponent/_QuizLayout.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page-heading text-center\">\r\n    <div class=\"container\">\r\n        <h2>Type of quiz: As or prac</h2>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-xs-10\" style=\"margin-bottom:0px\">\r\n");
            WriteLiteral(@"        <div class=""lmao"" style=""margin-top:20px"">
            <div class=""col-xs-6"">

                <div class=""col-sm-6"">
                    <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                        <button type=""button"" id=""formSave"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#startModal"">Start</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#resetModal"">Reset</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#submitModal"">Submit</button>
                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalLong"">
                            Instruction
                        </button>

                    </div>

                </div>

                <div class=""col-sm-6"">

                    ");
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalSubmit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalStart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 49 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
               Write(await Html.PartialAsync("QuizComponent/_ModalReset"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Quiz\Index.cshtml"
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
        <div class=""col-xs-6"">
            <h1>lamo</h1>
        </div>
        <div class=""col-xs-4"" style=""float:right; text-align:right"">
            <div class=""btn-group"" style=""float:right"">
                <button class=""btn btn-secondary"" style=""pointer-events:none"">
                    Point: null / null
                </button>
                <button class=""btn btn-danger"">Report question</button>
            </div>
            
            
        </div>
    </div>
</div>
<div class=""row"">

    <div class=""col-xs-8"">
        <div class=""col-xs-10"">
            <div id=""div1"" class=""infoDiv"" name=""div1"" style=""display:none;"">
                <h1>MCQ quiz</h1>
                <div class=""form-check"">
                    <input type=""radio"" class=""form-check-input"" name=""q"" id=""option1"">
                    <label class=""form-c");
            WriteLiteral(@"heck-label"" for=""option1"">Option 1</label>
                </div>
                <div class=""form-check"">
                    <input type=""radio"" class=""form-check-input"" name=""q"" id=""option2"">
                    <label class=""form-check-label"" for=""option2"">Option 2</label>
                </div>
                <div class=""form-check"">
                    <input type=""radio"" name=""q"" id=""option3"" class=""form-check-input"">
                    <label class=""form-check-label"" for=""option3"">Option 3</label>
                </div>
                <div class=""form-check"">
                    <input type=""radio"" name=""q"" id=""option4"" class=""form-check-input"">
                    <label class=""form-check-label"" for=""option4"">Option 4</label>
                </div>
            </div>
            <div id=""div2"" class=""infoDiv"" style=""display:none;"">
                <h1>constructed-response</h1>
                <input type=""text"" name=""div2"" />
            </div>
            <div id=""div3"" class=""");
            WriteLiteral(@"infoDiv"" style=""display:none;"">
                <div class=""form-group"">
                    <label for=""exampleFormControlTextarea1"">Example textarea</label>
                    <textarea class=""form-control"" id=""div2"" rows=""3"" name=""div2""></textarea>
                </div>
            </div>
        </div>
        <div class=""col-xs-2"">
            <span class=""vertical-line""></span>
        </div>
    </div>

    <div class=""col-xs-4"" style=""padding-left:5px"">
        <div class=""col-xs-6 form-group"" style=""padding-left:5px"">
            <div>
                <label  style=""font-size:20px"">Timer</label>
                <div id=""timer""></div>
            </div>
            <div hidden>
                <button id=""start-button"">Start</button>
                <button id=""stop-button"">Stop</button>
                <button id=""reset-button"">Reset</button>
            </div>
            <div class=""form-group btn-group"" role=""group"">
                <div style=""font-size:20px"">
         ");
            WriteLiteral(@"           <label>Navigation</label>
                </div>
                
                    <button type=""button"" class=""btn btn-secondary info"" id=""1"">1</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""2"">2</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""3"">3</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""4"">4</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""1"">1</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""2"">2</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""3"">3</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""4"">4</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""1"">1</button>
                    <button type=""button"" class=""btn btn-secondary info"" id=""2"">2</button>
                    <but");
            WriteLiteral("ton type=\"button\" class=\"btn btn-secondary info\" id=\"3\">3</button>\r\n                    <button type=\"button\" class=\"btn btn-secondary info\" id=\"4\">4</button>\r\n                </div>\r\n\r\n");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <div>
                    <label style=""font-size:20px"">Question size</label>
                </div>
                    <input type=""number"" class=""custom-select my-1 mr-sm-2"" min=""1.2"" max=""2.6"" step="".2"" id=""slider"" value=""1.2"" />
                
            </div>

        </div>
    </div>

");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b2556510cf083525a92bc93153707f75d6f03411970", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b2556510cf083525a92bc93153707f75d6f03413010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var test = true;

    function otherTest() {
        return true;
    }

    addEventListener('beforeunload', function (event) {
        if (!test || !otherTest()) {
            event.returnValue = 'You have unsaved changes.';
        }

    });

    document.getElementById('theButton').addEventListener('click', function (event) {
        test = !test;
        this.innerHTML = test.toString();
    });

</script>
<script>
    var question_constructed = [""div1"", ""div2"", ""div3"", ""q4""]

    $.each(question_constructed, function (index, value) {
        //$('textarea#message').val()
        //$('textarea[name=""product_question""]', this).val()
        $('textarea[name=' + value + ']').keyup(function () {
            if ($(this).val().length)
                //$('#yeah').show();
                $(""#"" + (index + 1)).attr('class', 'btn btn-primary info');
            //else
            //    $(""#"" + (index + 1)).attr('class', 'btn btn-secondary info');
        });
    })");
            WriteLiteral(@";

    var question_mcq = [""q"", ""q2"", ""q3"", ""q4""]
    $.each(question_mcq, function (index, value) {
        $(""input[name="" + value + ""]"").on('change', function () {
            if ($(this).attr('checked')) {
                $(""#"" + (index + 1)).attr('class', 'btn btn-primary info');
            }
            else {
                $(""#"" + (index + 1)).attr('class', 'btn btn-secondary info');
            }
        });
    });


    $.each(['div', 'p'], function (index, value) {

        $('input').on('input', function () {
            var v = $(this).val();
            $(""#"" + value + 1).css('font-size', v + 'em');
        });
        //$('p').css('font-size', v + 'em')
    });

    //$('input[name=amount]').keyup(function () {
    //    if ($(this).val().length)
    //        //$('#yeah').show();
    //        $(""#2"").attr('class', 'btn btn-primary info');
    //    else
    //        $(""#2"").attr('class', 'btn btn-secondary info');
    //});



</script>
<script src=""http");
            WriteLiteral(@"s://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>

<style>
    .vertical-line {
        display: inline-block;
        border-left: 1px solid #ccc;
        height: 125px;
    }

    .col-xs-2 {
        width: 0px;
        padding: 0px;
        margin: 0px;
        float: right;
    }
</style>

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
