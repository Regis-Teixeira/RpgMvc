#pragma checksum "D:\Régis\RpgMvc\Views\Personagens\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e95b712142eee43438e79ee9bc4c10f63a384c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_index), @"mvc.1.0.view", @"/Views/Personagens/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e95b712142eee43438e79ee9bc4c10f63a384c0", @"/Views/Personagens/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Namespace da classe de Modelo para esta view-->\r\n");
            WriteLiteral("<!--Inclua os TempData para Sucesso e Erro aqui, conforme exemplo na view de Autenticação-->\r\n");
#nullable restore
#line 4 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
  ViewBag.Title = "Personagens"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Título da página para o navegador-->\r\n<h2>Relação de Personagens</h2><!--Título da página-->\r\n<p>\r\n <!--Links apontando para views na mesma pasta-->\r\n    ");
#nullable restore
#line 8 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
Write(Html.ActionLink("Criar Novo Personagem", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr><!--Títulos das colunas da tabela-->\r\n        <th>");
#nullable restore
#line 12 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 15 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 16 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 17 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
       Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n<!--Looping para escrever os dados na tabela-->\r\n");
#nullable restore
#line 21 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disputas ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><!--Coluna para Links/botões-->\r\n                ");
#nullable restore
#line 31 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |  \r\n                ");
#nullable restore
#line 32 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \r\n                ");
#nullable restore
#line 33 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
                    , new { onclick = "return confirm('Deseja realmente deletar este personagem?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
#nullable restore
#line 40 "D:\Régis\RpgMvc\Views\Personagens\index.cshtml"
Write(Html.ActionLink("Embate com armas!!!", "Index", "Disputas", null, new { @class = "btn btn-warning"}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
