#pragma checksum "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a61250c1cf91b245d19422d4c6aa053e710536c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseDetail), @"mvc.1.0.view", @"/Views/Course/CourseDetail.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a61250c1cf91b245d19422d4c6aa053e710536c", @"/Views/Course/CourseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28373cf24ff85914d872a3f8f52a8e9604e8c163", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CourseList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
  
    ViewData["Title"] = "CourseDetail";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
  
    var course = Model.course;
    var cate = ViewBag.Category;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-content bg-white"">
    <!-- inner page banner -->
    <div class=""page-banner ovbl-dark"" style=""background-image:url(assets/images/banner/banner2.jpg);"">
        <div class=""container"">
            <div class=""page-banner-entry"">
                <h1 class=""text-white"">Courses Details</h1>
            </div>
        </div>
    </div>
    <!-- Breadcrumb row -->
    <div class=""breadcrumb-row"">
        <div class=""container"">
            <ul class=""list-inline"">
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a61250c1cf91b245d19422d4c6aa053e710536c5861", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a61250c1cf91b245d19422d4c6aa053e710536c7245", async() => {
#nullable restore
#line 24 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
                                                                                                    Write(cate.Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
                                                                           WriteLiteral(cate.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
    <!-- Breadcrumb row END -->
    <!-- inner page banner END -->
    <div class=""content-block"">
        <!-- About Us -->
        <div class=""section-area section-sp1"">
            <div class=""container"">
                <div class=""row d-flex flex-row-reverse"">
                    <div class=""col-lg-3 col-md-4 col-sm-12 m-b30"">
                        <div class=""course-detail-bx"">
                            <div class=""course-price"">
                                <del>$190</del>
                                <h4 class=""price"">$120</h4>
                            </div>
                            <div class=""course-buy-now text-center"">
                                <a href=""#"" class=""btn radius-xl text-uppercase"">Buy Now This Courses</a>
                            </div>
                            <div class=""teacher-bx"">
                                <div class=""teacher-info"">
                                    <div cl");
            WriteLiteral("ass=\"teacher-thumb\">\r\n                                        <img src=\"assets/images/testimonials/pic1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1965, "\"", 1971, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    </div>
                                    <div class=""teacher-name"">
                                        <h5>Hinata Hyuga</h5>
                                        <span>Science Teacher</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""cours-more-info"">
                                <div class=""review"">
                                    <span>3 Review</span>
                                    <ul class=""cours-star"">
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></");
            WriteLiteral(@"li>
                                    </ul>
                                </div>
                                <div class=""price categories"">
                                    <span>Categories</span>
                                    <h5 class=""text-primary"">");
#nullable restore
#line 68 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
                                                        Write(cate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""course-info-list scroll-page"">
                                <ul class=""navbar"">
                                    <li><a class=""nav-link"" href=""#overview""><i class=""ti-zip""></i>Overview</a></li>
                                    <li><a class=""nav-link"" href=""#curriculum""><i class=""ti-bookmark-alt""></i>Curriculum</a></li>
                                    <li><a class=""nav-link"" href=""#instructor""><i class=""ti-user""></i>Instructor</a></li>
                                    <li><a class=""nav-link"" href=""#reviews""><i class=""ti-comments""></i>Reviews</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-9 col-md-8 col-sm-12"">
                        <div class=""courses-post"">
                            <div class=""ttr-post-media media-effect"">
");
            WriteLiteral("                                <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7a61250c1cf91b245d19422d4c6aa053e710536c14030", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4359, "~/img/", 4359, 6, true);
#nullable restore
#line 85 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
AddHtmlAttributeValue("", 4365, course.ThumbnailURL, 4365, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"ttr-post-info\">\r\n                                <div class=\"ttr-post-title \">\r\n                                    <h2 class=\"post-title\">");
#nullable restore
#line 89 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
                                                      Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                </div>\r\n                                <div class=\"ttr-post-text\">\r\n                                    <p>");
#nullable restore
#line 92 "C:\Users\Admin\Documents\GitHub\online_learning_SWP391\SWP391\Views\Course\CourseDetail.cshtml"
                                  Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <div class=""courese-overview"" id=""overview"">
                            <h4>Overview</h4>
                            <div class=""row"">
                                <div class=""col-md-12 col-lg-4"">
                                    <ul class=""course-features"">
                                        <li><i class=""ti-book""></i> <span class=""label"">Lectures</span> <span class=""value"">8</span></li>
                                        <li><i class=""ti-help-alt""></i> <span class=""label"">Quizzes</span> <span class=""value"">1</span></li>
                                        <li><i class=""ti-time""></i> <span class=""label"">Duration</span> <span class=""value"">60 hours</span></li>
                                        <li><i class=""ti-stats-up""></i> <span class=""label"">Skill level</span> <span class=""value"">Beginner</span></li>
                                  ");
            WriteLiteral(@"      <li><i class=""ti-smallcap""></i> <span class=""label"">Language</span> <span class=""value"">English</span></li>
                                        <li><i class=""ti-user""></i> <span class=""label"">Students</span> <span class=""value"">32</span></li>
                                        <li><i class=""ti-check-box""></i> <span class=""label"">Assessments</span> <span class=""value"">Yes</span></li>
                                    </ul>
                                </div>
                                <div class=""col-md-12 col-lg-8"">
                                    <h5 class=""m-b5"">Course Description</h5>
                                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentiall");
            WriteLiteral(@"y unchanged.</p>
                                    <h5 class=""m-b5"">Certification</h5>
                                    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry’s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
                                    <h5 class=""m-b5"">Learning Outcomes</h5>
                                    <ul class=""list-checked primary"">
                                        <li>Over 37 lectures and 55.5 hours of content!</li>
                                        <li>LIVE PROJECT End to End Software Testing Training Included.</li>
                                        <li>Learn Software Testing and Automation basics from a professional trainer from your own desk.</li>
                           ");
            WriteLiteral(@"             <li>Information packed practical training starting from basics to advanced testing techniques.</li>
                                        <li>Best suitable for beginners to advanced level users and who learn faster when demonstrated.</li>
                                        <li>Course content designed by considering current software testing technology and the job market.</li>
                                        <li>Practical assignments at the end of every session.</li>
                                        <li>Practical learning experience with live project work and examples.cv</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""m-b30"" id=""curriculum"">
                            <h4>Curriculum</h4>
                            <ul class=""curriculum-list"">
                                <li>
                                    <h5>First ");
            WriteLiteral(@"Level</h5>
                                    <ul>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 1.</span> Introduction to UI Design
                                            </div>
                                            <span>120 minutes</span>
                                        </li>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 2.</span> User Research and Design
                                            </div>
                                            <span>60 minutes</span>
                                        </li>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 3.");
            WriteLiteral(@"</span> Evaluating User Interfaces Part 1
                                            </div>
                                            <span>85 minutes</span>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <h5>Second Level</h5>
                                    <ul>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 1.</span> Prototyping and Design
                                            </div>
                                            <span>110 minutes</span>
                                        </li>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 2.</span> UI Desi");
            WriteLiteral(@"gn Capstone
                                            </div>
                                            <span>120 minutes</span>
                                        </li>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Lesson 3.</span> Evaluating User Interfaces Part 2
                                            </div>
                                            <span>120 minutes</span>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <h5>Final</h5>
                                    <ul>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Part 1.</span> Final Test
                      ");
            WriteLiteral(@"                      </div>
                                            <span>120 minutes</span>
                                        </li>
                                        <li>
                                            <div class=""curriculum-list-box"">
                                                <span>Part 2.</span> Online Test
                                            </div>
                                            <span>120 minutes</span>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                        <div");
            BeginWriteAttribute("class", " class=\"", 12662, "\"", 12670, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""instructor"">
                            <h4>Instructor</h4>
                            <div class=""instructor-bx"">
                                <div class=""instructor-author"">
                                    <img src=""assets/images/testimonials/pic1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12943, "\"", 12949, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""instructor-info"">
                                    <h6>Keny White </h6>
                                    <span>Professor</span>
                                    <ul class=""list-inline m-tb10"">
                                        <li><a href=""#"" class=""btn sharp-sm facebook""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm twitter""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm linkedin""><i class=""fa fa-linkedin""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm google-plus""><i class=""fa fa-google-plus""></i></a></li>
                                    </ul>
                                    <p class=""m-b0"">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dumm");
            WriteLiteral(@"y text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries</p>
                                </div>
                            </div>
                            <div class=""instructor-bx"">
                                <div class=""instructor-author"">
                                    <img src=""assets/images/testimonials/pic2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14421, "\"", 14427, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""instructor-info"">
                                    <h6>Keny White </h6>
                                    <span>Professor</span>
                                    <ul class=""list-inline m-tb10"">
                                        <li><a href=""#"" class=""btn sharp-sm facebook""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm twitter""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm linkedin""><i class=""fa fa-linkedin""></i></a></li>
                                        <li><a href=""#"" class=""btn sharp-sm google-plus""><i class=""fa fa-google-plus""></i></a></li>
                                    </ul>
                                    <p class=""m-b0"">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dumm");
            WriteLiteral(@"y text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries</p>
                                </div>
                            </div>
                        </div>
                        <div");
            BeginWriteAttribute("class", " class=\"", 15755, "\"", 15763, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""reviews"">
                            <h4>Reviews</h4>

                            <div class=""review-bx"">
                                <div class=""all-review"">
                                    <h2 class=""rating-type"">3</h2>
                                    <ul class=""cours-star"">
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li class=""active""><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                        <li><i class=""fa fa-star""></i></li>
                                    </ul>
                                    <span>3 Rating</span>
                                </div>
                                <div class=""review-bar"">
                                    <div class=""bar-bx"">
                                ");
            WriteLiteral(@"        <div class=""side"">
                                            <div>5 star</div>
                                        </div>
                                        <div class=""middle"">
                                            <div class=""bar-container"">
                                                <div class=""bar-5"" style=""width:90%;""></div>
                                            </div>
                                        </div>
                                        <div class=""side right"">
                                            <div>150</div>
                                        </div>
                                    </div>
                                    <div class=""bar-bx"">
                                        <div class=""side"">
                                            <div>4 star</div>
                                        </div>
                                        <div class=""middle"">
                                            <di");
            WriteLiteral(@"v class=""bar-container"">
                                                <div class=""bar-5"" style=""width:70%;""></div>
                                            </div>
                                        </div>
                                        <div class=""side right"">
                                            <div>140</div>
                                        </div>
                                    </div>
                                    <div class=""bar-bx"">
                                        <div class=""side"">
                                            <div>3 star</div>
                                        </div>
                                        <div class=""middle"">
                                            <div class=""bar-container"">
                                                <div class=""bar-5"" style=""width:50%;""></div>
                                            </div>
                                        </div>
                            ");
            WriteLiteral(@"            <div class=""side right"">
                                            <div>120</div>
                                        </div>
                                    </div>
                                    <div class=""bar-bx"">
                                        <div class=""side"">
                                            <div>2 star</div>
                                        </div>
                                        <div class=""middle"">
                                            <div class=""bar-container"">
                                                <div class=""bar-5"" style=""width:40%;""></div>
                                            </div>
                                        </div>
                                        <div class=""side right"">
                                            <div>110</div>
                                        </div>
                                    </div>
                                    <div class=""bar-bx"">
");
            WriteLiteral(@"                                        <div class=""side"">
                                            <div>1 star</div>
                                        </div>
                                        <div class=""middle"">
                                            <div class=""bar-container"">
                                                <div class=""bar-5"" style=""width:20%;""></div>
                                            </div>
                                        </div>
                                        <div class=""side right"">
                                            <div>80</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- contact area END -->

</div>");
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
