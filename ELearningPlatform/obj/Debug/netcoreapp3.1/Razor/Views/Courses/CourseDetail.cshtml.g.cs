#pragma checksum "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f882bc7311789b10129b1985f7311801c6b5f635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_CourseDetail), @"mvc.1.0.view", @"/Views/Courses/CourseDetail.cshtml")]
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
#line 1 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\_ViewImports.cshtml"
using ELearningPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\_ViewImports.cshtml"
using ELearningPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
using static ELearningPlatform.Data.TempDataHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f882bc7311789b10129b1985f7311801c6b5f635", @"/Views/Courses/CourseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61e4660f27ef6e4d4afdfcd7161c09242d38a53", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CourseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningPlatform.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
  
    ViewData["Title"] = "CourseDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";
    Course course = new Course();
    List<int> completedModule = new List<int>();
    IDictionary<int, string> InstructorName = new Dictionary<int, string>();
    if (TempData[TempdataKeyCourse] != null)
    {
        course = (Course)TempData[TempdataKeyCourse];
        TempData[TempdataKeyCourse] = null;
    }
    if(TempData[TempdataKeyCompletedModule] != null)
    {
        completedModule = (List<int>)TempData[TempdataKeyCompletedModule];
    }
    if(TempData[TempdataKeyModulesInstructor] != null)
    {
        InstructorName = (Dictionary<int, string>)TempData[TempdataKeyModulesInstructor];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-2"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">
            <a class=""black-text"" href=""#"">Courses</a>
            <i class=""fa fa-angle-right mx-2"" aria-hidden=""true""></i>
        </li>
        <li class=""breadcrumb-item active"">Angular 5</li>
    </ol>
    <hr />
</div>
<div class=""container mt-5"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h4 class=""mb-3"">");
#nullable restore
#line 37 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                        Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <img class=\"img-fluid mb-3\"");
            BeginWriteAttribute("src", " src=\"", 1403, "\"", 1420, 1);
#nullable restore
#line 42 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
WriteAttributeValue("", 1409, course.Ico, 1409, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <p>");
#nullable restore
#line 43 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
          Write(course.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
             if ((bool)TempData[TempdataKeyIsEnrolled])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button disabled type=\"button\" class=\"btn btn-default btn-sm mb-3\">Enroll</button>\r\n                <p class=\"text-muted text-sm\">You are currently enrolled in this course.</p>\r\n");
#nullable restore
#line 48 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1810, "\"", 1837, 2);
            WriteAttributeValue("", 1817, "Enroll?id=", 1817, 10, true);
#nullable restore
#line 51 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
WriteAttributeValue("", 1827, course.Id, 1827, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-default btn-sm mb-3\">Enroll</button></a>\r\n");
#nullable restore
#line 52 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <h6 class=\"mb-4\">Course Modules</h6>\r\n            <table class=\"table table-hover table-responsive-md\">\r\n                <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                     foreach (Module module in (List<Module>)TempData[TempdataKeyModules])
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 62 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                                 if (completedModule.Exists(e => e == module.Id))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 65 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2573, "\"", 2607, 2);
            WriteAttributeValue("", 2580, "ModuleDetails?id=", 2580, 17, true);
#nullable restore
#line 66 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
WriteAttributeValue("", 2597, module.Id, 2597, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                                                                 Write(module.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </td>\r\n                            <td class=\"text-right\">");
#nullable restore
#line 68 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                                              Write(InstructorName[module.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-right\">");
#nullable restore
#line 69 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                                              Write(module.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\lburnand\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Courses\CourseDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningPlatform.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591