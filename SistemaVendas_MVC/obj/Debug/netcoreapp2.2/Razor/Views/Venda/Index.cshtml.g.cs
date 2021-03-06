#pragma checksum "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f9b2c24eeaf6696856a97804299ee921d86dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Index), @"mvc.1.0.view", @"/Views/Venda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Index.cshtml", typeof(AspNetCore.Views_Venda_Index))]
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
#line 1 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\_ViewImports.cshtml"
using SistemaVendas_MVC;

#line default
#line hidden
#line 2 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\_ViewImports.cshtml"
using SistemaVendas_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f9b2c24eeaf6696856a97804299ee921d86dfe", @"/Views/Venda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc79c35a76e6dcb5e26c1b26b3a82190e8d45c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVendas_MVC.Models.VendaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 311, true);
            WriteLiteral(@"
<h1>Listagem de Vendas</h1>

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:gray"">
            <th>Id</th>
            <th>Data</th>
            <th>Vendedor</th>
            <th>Cliente</th>
            <th>Total</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(411, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(450, 7, false);
#line 19 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(457, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(485, 32, false);
#line 20 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
               Write(item.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(517, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(545, 15, false);
#line 21 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
               Write(item.Cliente_Id);

#line default
#line hidden
            EndContext();
            BeginContext(560, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(588, 16, false);
#line 22 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
               Write(item.Vendedor_Id);

#line default
#line hidden
            EndContext();
            BeginContext(604, 30, true);
            WriteLiteral("</td>\r\n                <td>R$ ");
            EndContext();
            BeginContext(635, 15, false);
#line 23 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
                  Write(item.TotalVenda);

#line default
#line hidden
            EndContext();
            BeginContext(650, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Venda\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(687, 239, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"Cadastrar()\">Registrar Vendas</button>\r\n<script>\r\n    function Cadastrar() {\r\n        window.location.href = \"../Venda/Registrar\";\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVendas_MVC.Models.VendaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
