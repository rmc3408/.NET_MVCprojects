#pragma checksum "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f27d01fa2793e9b12b964a5cadbb60057fa3491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LStudents), @"mvc.1.0.view", @"/Views/Home/LStudents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LStudents.cshtml", typeof(AspNetCore.Views_Home_LStudents))]
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
#line 4 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\_ViewImports.cshtml"
using StudentSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f27d01fa2793e9b12b964a5cadbb60057fa3491", @"/Views/Home/LStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f888562078eaadf123ea9ca1b1d111ddc0f411e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
  
    
    ViewBag.Title = "List of Student";

#line default
#line hidden
            BeginContext(75, 304, true);
            WriteLiteral(@"
    <table class=""table table-primary"">
        
        <tr>
            <th> Firstname</th>
            <th> LastName</th>
            <th> Email</th>
            <th> Gpa</th>
            <th> FullTime</th>
            <th> CourseCode</th>
            <th> StudentID</th>
        </tr>

");
            EndContext();
#line 19 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        foreach (Student st in Model)
        {

#line default
#line hidden
            BeginContext(429, 23, true);
            WriteLiteral("    <tr>\r\n        <td> ");
            EndContext();
            BeginContext(453, 12, false);
#line 22 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(465, 20, true);
            WriteLiteral("</td>\r\n        <td> ");
            EndContext();
            BeginContext(486, 11, false);
#line 23 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(497, 20, true);
            WriteLiteral("</td>\r\n        <td> ");
            EndContext();
            BeginContext(518, 8, false);
#line 24 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.Email);

#line default
#line hidden
            EndContext();
            BeginContext(526, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(871, 30, true);
            WriteLiteral("\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(902, 6, false);
#line 45 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
       Write(st.Gpa);

#line default
#line hidden
            EndContext();
            BeginContext(908, 16, true);
            WriteLiteral("\r\n            \r\n");
            EndContext();
#line 47 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
             if (st.Gpa > 4)
            {

#line default
#line hidden
            BeginContext(969, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(987, 9, true);
            WriteLiteral(" - Good\r\n");
            EndContext();
#line 50 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
            }
            else if (st.Gpa < 2)
            {

#line default
#line hidden
            BeginContext(1060, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1078, 8, true);
            WriteLiteral(" - Bad\r\n");
            EndContext();
#line 54 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1134, 15, true);
            WriteLiteral("               ");
            EndContext();
            BeginContext(1151, 17, true);
            WriteLiteral(" = Keep working\r\n");
            EndContext();
#line 58 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
            }

#line default
#line hidden
            BeginContext(1183, 28, true);
            WriteLiteral("        </td>\r\n        <td> ");
            EndContext();
            BeginContext(1212, 11, false);
#line 60 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.FullTime);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 20, true);
            WriteLiteral("</td>\r\n        <td> ");
            EndContext();
            BeginContext(1244, 13, false);
#line 61 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 20, true);
            WriteLiteral("</td>\r\n        <td> ");
            EndContext();
            BeginContext(1278, 12, false);
#line 62 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        Write(st.StudentID);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 64 "C:\Users\molin\Documents\WebApplic\Projects\StudentSystem\StudentSystem\Views\Home\LStudents.cshtml"
        
        }

#line default
#line hidden
            BeginContext(1329, 30, true);
            WriteLiteral("        \r\n\r\n    </table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
