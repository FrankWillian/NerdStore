#pragma checksum "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73395d3337bc6008b642b1628ecbdf8e25edffb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Index), @"mvc.1.0.view", @"/Views/Eventos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Index.cshtml", typeof(AspNetCore.Views_Eventos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73395d3337bc6008b642b1628ecbdf8e25edffb7", @"/Views/Eventos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdStore.Core.Data.EventSourcing.StoredEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(114, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
            BeginContext(151, 319, true);
            WriteLiteral(@"        <table class=""table table-sm table-bordered table-hover col-md-12"">
            <thead class=""table-dark"">
            <tr>
                <td>Id</td>
                <td>Nome</td>
                <td>Data</td>
                <td>JSON</td>
            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
             foreach (var evento in Model)
            {

#line default
#line hidden
            BeginContext(529, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(576, 9, false);
#line 22 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
                   Write(evento.Id);

#line default
#line hidden
            EndContext();
            BeginContext(585, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(617, 11, false);
#line 23 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
                   Write(evento.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(628, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(660, 21, false);
#line 24 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
                   Write(evento.DataOcorrencia);

#line default
#line hidden
            EndContext();
            BeginContext(681, 37, true);
            WriteLiteral("</td>\r\n                    <td><code>");
            EndContext();
            BeginContext(719, 12, false);
#line 25 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
                         Write(evento.Dados);

#line default
#line hidden
            EndContext();
            BeginContext(731, 37, true);
            WriteLiteral("</code></td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "C:\NerdStore\src\NerdStore.WebApp.MVC\Views\Eventos\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(783, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
            BeginContext(834, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdStore.Core.Data.EventSourcing.StoredEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
