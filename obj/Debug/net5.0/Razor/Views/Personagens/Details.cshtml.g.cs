#pragma checksum "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9a97fc9bd9f7056c604d7ef4822d8e6ecb0984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Details), @"mvc.1.0.view", @"/Views/Personagens/Details.cshtml")]
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
#line 1 "D:\Régis\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Régis\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a9a97fc9bd9f7056c604d7ef4822d8e6ecb0984", @"/Views/Personagens/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
  
    ViewBag.Title = "Detalhes do Personagem";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Detalhes do Personagem</h2>\r\n<div>\r\n    <hr/>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>");
#nullable restore
#line 10 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 11 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 13 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 14 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 16 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 17 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 19 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 20 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 22 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 23 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>");
#nullable restore
#line 25 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 26 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
       Write(Html.DisplayFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 30 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 31 "D:\Régis\RpgMvc\Views\Personagens\Details.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
