#pragma checksum "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2538f0d56889a83bf1b1f2b1904c791f1cae3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Summary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Summary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Summary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Summary_Default))]
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
#line 1 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2538f0d56889a83bf1b1f2b1904c791f1cae3b3", @"/Views/Shared/Components/Summary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Summary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (ViewData.ModelState.ErrorCount > 0)
{

#line default
#line hidden
            BeginContext(45, 179, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado:</h3>\r\n        ");
            EndContext();
            BeginContext(224, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2538f0d56889a83bf1b1f2b1904c791f1cae3b34114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 6 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 8 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(307, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Erro"] != null)
{

#line default
#line hidden
            BeginContext(344, 182, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado:</h3>\r\n        <p>");
            EndContext();
            BeginContext(527, 16, false);
#line 15 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
      Write(TempData["Erro"]);

#line default
#line hidden
            EndContext();
            BeginContext(543, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(564, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Erros"] != null)
{

#line default
#line hidden
            BeginContext(602, 171, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado:</h3>\r\n");
            EndContext();
#line 24 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
          
            var erros = TempData["Erros"] as string[];
            foreach (var erro in erros)
            {

#line default
#line hidden
            BeginContext(897, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(917, 4, false);
#line 28 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
              Write(erro);

#line default
#line hidden
            EndContext();
            BeginContext(921, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 29 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
            }
        

#line default
#line hidden
            BeginContext(953, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 33 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
            BeginContext(970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Sucesso))
{

#line default
#line hidden
            BeginContext(1021, 144, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">");
            EndContext();
            BeginContext(1166, 15, false);
#line 39 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
                       Write(ViewBag.Sucesso);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 19, true);
            WriteLiteral("</h3>\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
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
