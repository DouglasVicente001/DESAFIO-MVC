#pragma checksum "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224913c8c6cf15dde5bea5744f96e3120c8e63a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Igredientes), @"mvc.1.0.view", @"/Views/Gestao/Igredientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224913c8c6cf15dde5bea5744f96e3120c8e63a6", @"/Views/Gestao/Igredientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded81f4952854610371abb32b1eca0f900103e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Igredientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VirtualMagazine.Models.Igrediente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoIgrediente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Igredientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
  
    Layout="_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Igredientes</h2>\r\n<hr/>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224913c8c6cf15dde5bea5744f96e3120c8e63a66109", async() => {
                WriteLiteral("Criar novo igrediente");
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
<hr/>  
<script>
    $(document).ready( function () {
    $('#igredientes').DataTable({
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

<table id=""igredientes""class=""table table-striped table-bordered""> 
    <thead>
    <tr>
        <th>Id</th>
        <th>Receita</th>
        <th>Igredientes</th>
        <th>UnidadeDeMedida</th>
");
            WriteLiteral("        <th>Ações</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
         foreach(var igrediente in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
               Write(igrediente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
               Write(igrediente.Receita.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
               Write(igrediente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
               Write(igrediente.UnidadeDeMedida.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                \r\n");
            WriteLiteral("                <td>\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1868, "\"", 1914, 2);
            WriteAttributeValue("", 1875, "/Gestao/EditarIgrediente/", 1875, 25, true);
#nullable restore
#line 61 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
WriteAttributeValue("", 1900, igrediente.Id, 1900, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224913c8c6cf15dde5bea5744f96e3120c8e63a610924", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\" id=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2087, "\"", 2109, 1);
#nullable restore
#line 64 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
WriteAttributeValue("", 2095, igrediente.Id, 2095, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button class=\"btn btn-danger\" >Deletar</button> \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\DSVE\OneDrive - GFT Technologies SE\Desktop\Treino\MVC CURSO TREINO\TreinoMvc\VirtualMagazine\VirtualMagazine\Views\Gestao\Igredientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VirtualMagazine.Models.Igrediente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
