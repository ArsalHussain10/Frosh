#pragma checksum "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\MyLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aaa00f3a3b2a98aa36428d3a5d9effc64fa557c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MyLayout), @"mvc.1.0.view", @"/Views/Shared/MyLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MyLayout.cshtml", typeof(AspNetCore.Views_Shared_MyLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aaa00f3a3b2a98aa36428d3a5d9effc64fa557c", @"/Views/Shared/MyLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66900e4754f4e6f1488a9cb7765ce258fdb04408", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MyLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\MyLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 1362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f23db01717f0437b9fdff76c3e44aa98", async() => {
                BeginContext(64, 1140, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>MyLayout</title>
    <style>
        * {
            margin: 0;
        }

        nav {
            background: linear-gradient(to right, #9BCD9B, #C1FFC1);
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 10px;
        }
        .left-text {
            font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
            font-style: oblique;
            font-size: 39px;
            color: white;
        }
        .footer {
            background:  linear-gradient(to right, #9BCD9B, #C1FFC1);
            height: 50px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 0 20px;
            color: white;
            font-size: 20px;
        }
        .left-side {
            display: flex;
        }

        .side-panel {
            widt");
                WriteLiteral("h: 200px;\r\n        }\r\n\r\n        .animated-text {\r\n            animation: slide-in 1s ease-in;\r\n        }\r\n\r\n        ");
                EndContext();
                BeginContext(1205, 208, true);
                WriteLiteral("@keyframes slide-in {\r\n            from {\r\n                transform: translateX(-100%);\r\n            }\r\n\r\n            to {\r\n                transform: translateX(0);\r\n            }\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1420, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1422, 796, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f52d59eb9543c8bb48d29117a23a58", async() => {
                BeginContext(1428, 315, true);
                WriteLiteral(@"
    <nav>
        <div class=""left-side"">
            <div class=""side-panel"">
                <!-- side panel content goes here -->
            </div>
            <div class=""left-text animated-text"">
                Frosh
            </div>
        </div>
        <div class=""right-text"">
            ");
                EndContext();
                BeginContext(1744, 16, false);
#line 74 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\MyLayout.cshtml"
       Write(TempData["name"]);

#line default
#line hidden
                EndContext();
                BeginContext(1760, 143, true);
                WriteLiteral("\r\n            <div style=\"display: flex;\">\r\n                <button onclick=\"displayModal()\" class=\"plus-button\">+</button>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1903, "\"", 1939, 1);
#line 77 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\MyLayout.cshtml"
WriteAttributeValue("", 1910, Url.Action("Logout", "User"), 1910, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1940, 139, true);
                WriteLiteral(" class=\"logout-button\" style=\"color: white; text-decoration: underline;\">Logout</a>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n    ");
                EndContext();
                BeginContext(2080, 12, false);
#line 82 "D:\MyWork\semester7\EAD\codes\Frosh\Frosh\Views\Shared\MyLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2092, 119, true);
                WriteLiteral("\r\n\r\n    <div class=\"footer\">\r\n        <div>Arsal</div>\r\n        <div>Frosh</div>\r\n        <div>Asim</div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2218, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
