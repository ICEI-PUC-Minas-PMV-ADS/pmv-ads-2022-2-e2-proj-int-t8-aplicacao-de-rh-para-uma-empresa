#pragma checksum "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69711a753d506d88955655cbb3d6b3ec9be12de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69711a753d506d88955655cbb3d6b3ec9be12de8", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarConfirmacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Listagem de Registros";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n\r\n   \r\n\r\n");
#nullable restore
#line 11 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
     if (TempData["MensagemSucesso"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" data-bs-dismiss=\"alert\" aria-label=\"Close\">X</button>\r\n            ");
#nullable restore
#line 15 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
       Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
     if (TempData["MensagemErro"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n            <button type=\"button\" class=\"btn btn-danger btn-sm close-alert\" data-bs-dismiss=\"alert\" aria-label=\"Close\">X</button>\r\n            ");
#nullable restore
#line 23 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
       Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />

    <h2 class=""display-4"">Registros de Entrada</h2>
    <div class=""d-grid gap-2 d-md-flex justify-content-md-end"">
        
    </div>

    <br />
    <table id=""table-contatos"" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Matrícula</th>
                <th scope=""col"">Entrada</th>
                <th scope=""col"">Saída</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
             if (Model != null && Model.Any())
            {
                foreach (var contato in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 52 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                                   Write(contato.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                       Write(contato.Matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class =\"horacor1\">");
#nullable restore
#line 55 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                                         Write(contato.Entrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"horacor1\">");
#nullable restore
#line 56 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                                        Write(contato.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                        <td>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69711a753d506d88955655cbb3d6b3ec9be12de810889", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                                                                                                WriteLiteral(contato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69711a753d506d88955655cbb3d6b3ec9be12de813570", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                                                                                                           WriteLiteral(contato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"odd\"><td valign=\"top\" colspan=\"5\">Nenhum registro encontrado</td></tr>\r\n");
#nullable restore
#line 70 "C:\Users\Luizão\Source\Repos\pmv-ads-2022-2-e2-proj-int-t8-aplicacao-de-rh-para-uma-empresa\src\BEMQ\ControleDeContatos\Views\Contato\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <style>\r\n       \r\n       \r\n\r\n        .horacor1 {\r\n            font-weight: 500;\r\n            \r\n        }\r\n    </style>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591