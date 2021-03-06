#pragma checksum "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41890047cacdf82bbb51ce3907cc01cb97f3c347"
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
#line 1 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\_ViewImports.cshtml"
using ELearningPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\_ViewImports.cshtml"
using ELearningPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
using static ELearningPlatform.Data.TempDataHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
using static ELearningPlatform.Data.CoursesData;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41890047cacdf82bbb51ce3907cc01cb97f3c347", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3081f39eae504873096168130ab2136a2bf59d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningPlatform.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Course> allCourses = new List<Course>();
    List<Subject> subjects = new List<Subject>();
    if (TempData[TempdataKeyAllCourses] == null)
        allCourses = new List<Course>();
    else
        allCourses = (List<Course>)TempData[TempdataKeyAllCourses];

    if (TempData[TempdataKeySubjects] != null)
        subjects = (List<Subject>)TempData[TempdataKeySubjects];

    if (TempData[TempdataKeyIsConnected] != null && (bool)TempData[TempdataKeyIsConnected] == true)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">

            <div class=""well"">
                <div class=""row"">
                    <div class=""col-md-12 mb-3"">
                        Resume your current lesson
                        <i class=""fa fa-angle-right"" aria-hidden=""true""></i>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-1"">
                        <img class=""img-fluid"" src=""https://mdbootstrap.com/img/Photos/Others/images/16.jpg"" alt=""Card image cap"">
                    </div>
                    <div class=""col-md-11 title-group"">
                        <span class=""title-primary"">Angular 5 Training</span>
                        <span class=""title-secondary"">
                            Changing Pages with Routing
                        </span>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 mb-2"">
                    ");
            WriteLiteral("<h4 class=\"title-sting\">Your Courses</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-deck\">\r\n");
#nullable restore
#line 46 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
                  
                    int b = 0;
                    List<Course> coursesInscripted = new List<Course>();
                    foreach (int idCourse in (List<int>)TempData[TempdataKeyInscriptionCourse])
                    {
                        var course = allCourses.Find(e => e.Id == idCourse);
                        ViewDataDictionary courseValue = new ViewDataDictionary(ViewData) { { ViewDataId, course.Id }, { ViewDataName, course.Name }, { ViewDataDesc, course.Desc }, { ViewDataIco, course.Ico } };
                        await Html.RenderPartialAsync("Course", courseValue);
                        if (b >= 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\r\n");
#nullable restore
#line 57 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
                            b = 0;
                        }
                        b++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 64 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr class=""my-5"">
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h4 class=""title-sting"">All Courses</h4>
        </div>
        <div class=""col-md-3"">
            <div class=""md-form"">
                <input type=""text"" id=""inputIconEx1"" class=""form-control"">
                <label for=""inputIconEx1"">Search</label>
            </div>
        </div>
        <div class=""col-md-3"">
");
#nullable restore
#line 79 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
              
                ViewDataDictionary subjectValue = new ViewDataDictionary(ViewData);
                foreach (Subject subject in subjects)
                {
                    subjectValue.Add(subject.Label, subject);
                }
                await Html.RenderPartialAsync("Filter", subjectValue);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"card-deck\">\r\n");
#nullable restore
#line 90 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
          
            int i = 0;
            foreach (Course course in allCourses)
            {
                ViewDataDictionary courseValue = new ViewDataDictionary(ViewData) { { ViewDataId, course.Id }, { ViewDataName, course.Name }, { ViewDataDesc, course.Desc }, { ViewDataIco, course.Ico }, { ViewDataIdSubject, course.IdSubject } };
                await Html.RenderPartialAsync("Course", courseValue);
                if (i >= 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 99 "C:\Users\Loic\Documents\GitHub\ELearningPlatform\ELearningPlatform\Views\Home\Index.cshtml"
                    i = 0;
                }
                i++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
