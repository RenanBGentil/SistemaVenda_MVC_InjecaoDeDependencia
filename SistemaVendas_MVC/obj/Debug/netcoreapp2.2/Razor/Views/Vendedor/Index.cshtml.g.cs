#pragma checksum "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033a64154658f0080f5361c084d0ce1b403ca76b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedor_Index), @"mvc.1.0.view", @"/Views/Vendedor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendedor/Index.cshtml", typeof(AspNetCore.Views_Vendedor_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033a64154658f0080f5361c084d0ce1b403ca76b", @"/Views/Vendedor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc79c35a76e6dcb5e26c1b26b3a82190e8d45c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendedor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVendas_MVC.Models.VendedorModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 294, true);
            WriteLiteral(@"<h2>Vendedor</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:gray"">
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 16 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(397, 69, true);
            WriteLiteral("            <tr>\r\n                <td><button class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 466, "\"", 492, 3);
            WriteAttributeValue("", 476, "Editar(", 476, 7, true);
#line 19 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 483, item.Id, 483, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 491, ")", 491, 1, true);
            EndWriteAttribute();
            BeginContext(493, 73, true);
            WriteLiteral(">Editar</button></td>\r\n                <td><button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 566, "\"", 593, 3);
            WriteAttributeValue("", 576, "Excluir(", 576, 8, true);
#line 20 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 584, item.Id, 584, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 592, ")", 592, 1, true);
            EndWriteAttribute();
            BeginContext(594, 44, true);
            WriteLiteral(">Excluir</button></td>\r\n                <td>");
            EndContext();
            BeginContext(639, 7, false);
#line 21 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(646, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(674, 9, false);
#line 22 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(683, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(711, 10, false);
#line 23 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(721, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\renan\Desktop\ASP.NETCoreWebAPIv2\SistemaVendas_InjeçãoDeDependencia\SistemaVendas_MVC\Views\Vendedor\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(758, 441, true);
            WriteLiteral(@"    </tbody>
</table>
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Cadastrar Vendedor</button>
<script>

    function Editar(Id) {
        window.location.href = ""../Vendedor/Cadastro/"" + Id;
    }

    function Excluir(Id) {
        window.location.href = ""../Vendedor/Excluir/"" + Id;
    }

    function Cadastrar() {
        window.location.href = ""../Vendedor/Cadastro"";
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVendas_MVC.Models.VendedorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591