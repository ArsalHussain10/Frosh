#pragma checksum "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CardsPV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0283fcfaad5adc342301a4636af5eade071fb156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CardsPV), @"mvc.1.0.view", @"/Views/Shared/_CardsPV.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CardsPV.cshtml", typeof(AspNetCore.Views_Shared__CardsPV))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0283fcfaad5adc342301a4636af5eade071fb156", @"/Views/Shared/_CardsPV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66900e4754f4e6f1488a9cb7765ce258fdb04408", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CardsPV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 26, true);
            WriteLiteral("\r\n\r\n    <div class=\"card \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 150, "\"", 193, 3);
            WriteAttributeValue("", 160, "sendClassName(`", 160, 15, true);
#line 7 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CardsPV.cshtml"
WriteAttributeValue("", 175, ViewData["cId"], 175, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 191, "`)", 191, 2, true);
            EndWriteAttribute();
            BeginContext(194, 102, true);
            WriteLiteral(">\r\n        <div class=\"card-content\">\r\n            <h2 class=\"card-title\" style=\"text-align: center;\">");
            EndContext();
            BeginContext(297, 17, false);
#line 9 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CardsPV.cshtml"
                                                          Write(ViewData["cName"]);

#line default
#line hidden
            EndContext();
            BeginContext(314, 66, true);
            WriteLiteral("</h2>\r\n            <h3 class=\"card-subtitle\" style=\"float: left;\">");
            EndContext();
            BeginContext(381, 24, false);
#line 10 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\_CardsPV.cshtml"
                                                      Write(ViewData["cDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(405, 161, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"card-image\" style=\"background-image: url(\'https://gstatic.com/classroom/themes/img_read.jpg\');\"></div>\r\n    </div>\r\n\r\n");
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
