#pragma checksum "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CommentsBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44d27e593baa391255537333430f5f712183d81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentsBox), @"mvc.1.0.view", @"/Views/Shared/_CommentsBox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CommentsBox.cshtml", typeof(AspNetCore.Views_Shared__CommentsBox))]
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
#line 1 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\_ViewImports.cshtml"
using Frosh;

#line default
#line hidden
#line 2 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\_ViewImports.cshtml"
using Frosh.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d27e593baa391255537333430f5f712183d81c", @"/Views/Shared/_CommentsBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66900e4754f4e6f1488a9cb7765ce258fdb04408", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentsBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 76, true);
            WriteLiteral("    <div class=\"comment-box\" onclick=\"\">\r\n        <p> Comment By:  <i> <b>  ");
            EndContext();
            BeginContext(201, 17, false);
#line 6 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CommentsBox.cshtml"
                             Write(ViewData["item2"]);

#line default
#line hidden
            EndContext();
            BeginContext(218, 45, true);
            WriteLiteral(" </b> </i>  </p>\r\n        <p> Description:   ");
            EndContext();
            BeginContext(264, 28, false);
#line 7 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CommentsBox.cshtml"
                      Write(ViewData["item1CommentText"]);

#line default
#line hidden
            EndContext();
            BeginContext(292, 19, true);
            WriteLiteral(" </p>\r\n        <p> ");
            EndContext();
            BeginContext(312, 28, false);
#line 8 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CommentsBox.cshtml"
       Write(ViewData["item1CommentDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(340, 17, true);
            WriteLiteral(" </p>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
