#pragma checksum "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "062a36a6bad1e2e31786d8587b3842540af5a801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Component_Comments), @"mvc.1.0.view", @"/Views/Component/Comments.cshtml")]
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
#line 1 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062a36a6bad1e2e31786d8587b3842540af5a801", @"/Views/Component/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d6898af3ee645766c02769f00bd7edd74cd52", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Component_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml"
  
    ViewData["Title"] = "Comments";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    Total Comments: ");
#nullable restore
#line 6 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml"
               Write(ViewData["CommentCount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<ul>     \r\n");
#nullable restore
#line 10 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml"
   foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <li>");
#nullable restore
#line 12 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml"
        Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\Dell\Documents\project_practice\Lab1\Lab2\Views\Component\Comments.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n   ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
