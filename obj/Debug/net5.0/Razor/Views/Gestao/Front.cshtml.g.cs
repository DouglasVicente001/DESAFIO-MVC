#pragma checksum "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d978c9374098dce8ed3829d0dbbae53b843cf39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Front), @"mvc.1.0.view", @"/Views/Gestao/Front.cshtml")]
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
#line 1 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\_ViewImports.cshtml"
using VirtualMagazine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\_ViewImports.cshtml"
using VirtualMagazine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\_ViewImports.cshtml"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d978c9374098dce8ed3829d0dbbae53b843cf39", @"/Views/Gestao/Front.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded81f4952854610371abb32b1eca0f900103e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Front : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VirtualMagazine.Models.Receita>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaReceita", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/BatataRecheada.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Receitas</h2>\n<hr />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d978c9374098dce8ed3829d0dbbae53b843cf395070", async() => {
                WriteLiteral("Ver igredientes das receitas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<hr />
<script>
    $(document).ready(function () {
        $('#receita').DataTable({
            ""info"": false,
            ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_registros por p??gina"",
                ""zeroRecords"": ""Desculpa, nada encontrado"",
                ""info"": ""Mostrando p??gina _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro dispon??vel"",
                ""search"": ""Buscar:"",
                ""paginate"": {
                    ""first"": ""Primeiro"",
                    ""last"": ""??ltimo"",
                    ""next"": ""Pr??ximo"",
                    ""previous"": ""Anterior""
                }
            }
        });
    });
</script>

<table id=""receita"" class=""table table-striped table-bordered"">
    <thead>
        <tr>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml"
         foreach (var receita in Model)
        {
           
   
            


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\n                    <div class=\"card mb-4 shadow-sm\">\n                        <h3><p>");
#nullable restore
#line 42 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml"
                          Write(receita.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h3> \n                        \n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d978c9374098dce8ed3829d0dbbae53b843cf398224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""btn-group"">

                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                        </div>
                        <div class=""card-body"">
                            <td>
                            </td>
                            <p class=""card-text"">MODO DE PREPARO: <br>");
#nullable restore
#line 52 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml"
                                                                 Write(receita.ModoPreparo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                            <div class=\"d-flex justify-content-between align-items-center\">\n\n                                <small class=\"text-muted\">Tempo estimado: ");
#nullable restore
#line 56 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml"
                                                                     Write(receita.TempoPreparo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n                <br>\n");
#nullable restore
#line 62 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Front.cshtml"


           

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VirtualMagazine.Models.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
