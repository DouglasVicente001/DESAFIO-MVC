#pragma checksum "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3443555d3bee15705895e2dfbe097b15bd66ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Index), @"mvc.1.0.view", @"/Views/Gestao/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3443555d3bee15705895e2dfbe097b15bd66ab", @"/Views/Gestao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded81f4952854610371abb32b1eca0f900103e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VirtualMagazine.Models.Receita>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-footer text-white clearfix small z-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Receitas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Igredientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnidadeDeMedidas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
  
    Layout="_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<! --Icons Cards-- >
<div class=""row"">
        <div class=""col-xl-3 col-sm-6 mb-3"">
          <div class=""card text-white bg-primary o-hidden h-100"">
            <div class=""card-body"">
              <div class=""card-body-icon"">
                <i class=""fa fa-fw fa-receipt""></i>
              </div>
              <div class=""mr-5"">Criar Receitas</div>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3443555d3bee15705895e2dfbe097b15bd66ab5833", async() => {
                WriteLiteral("\r\n              <span class=\"float-left\">Ver todas</span>\r\n              <span class=\"float-right\">\r\n                <i class=\"fa fa-angle-right\"></i>\r\n              </span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>
        </div>
        <div class=""col-xl-3 col-sm-6 mb-3"">
          <div class=""card text-white bg-success o-hidden h-100"">
            <div class=""card-body"">
              <div class=""card-body-icon"">
                <i class=""fa fa-fw fa-hotdog""></i>
              </div>
              <div class=""mr-5"">Igredientes</div>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3443555d3bee15705895e2dfbe097b15bd66ab7870", async() => {
                WriteLiteral("\r\n              <span class=\"float-left\">Ver todos</span> \r\n              <span class=\"float-right\">\r\n                <i class=\"fa fa-angle-right\"></i>\r\n              </span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>
        </div>
        <div class=""col-xl-3 col-sm-6 mb-3"">
          <div class=""card text-white bg-warning o-hidden h-100"">
            <div class=""card-body"">
              <div class=""card-body-icon"" >
                <i class=""fa fa-fw fa-blender""></i>
              </div>
              <div class=""mr-5"">Unidades de Medida</div>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de3443555d3bee15705895e2dfbe097b15bd66ab9917", async() => {
                WriteLiteral("\r\n              <span class=\"float-left\">Ver todos</span>\r\n              <span class=\"float-right\">\r\n                <i class=\"fa fa-angle-right\"></i>\r\n              </span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          </div>
        </div>
        


<script>
    $(document).ready( function () {
    $('#receita').DataTable({
        ""info"" : false,
        ""language"" : {
        ""lengthMenu"": ""Mostrando _MENU_registros por página"",
        ""zeroRecords"": ""Desculpa, nada encontrado"",
        ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
        ""infoEmpty"": ""Nenhum registro disponível"",
        ""search"": ""Buscar:"",
        ""paginate"": {
            ""first"":     ""Primeiro"",
            ""last"":     ""Último"",
            ""next"":     ""Próximo"",
            ""previous"":   ""Anterior""
            }
        }  
    });
} );
</script>

<table id=""receita""class=""table table-striped table-bordered""> 
    <thead>
    <tr>
        
        <th>Receitas</th>
        <th>Tempo</th>
        <th>Modo de preparo</th>
        
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 91 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
         foreach(var receita in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>");
#nullable restore
#line 94 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
               Write(receita.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
               Write(receita.TempoPreparo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
               Write(receita.ModoPreparo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            </tr>\r\n");
#nullable restore
#line 99 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n    \r\n        ");
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
