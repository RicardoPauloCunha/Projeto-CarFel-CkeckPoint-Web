#pragma checksum "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Pagina\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5af993708da1c9646616bb9d679e485b120b569b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_Contato), @"mvc.1.0.view", @"/Views/Pagina/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/Contato.cshtml", typeof(AspNetCore.Views_Pagina_Contato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af993708da1c9646616bb9d679e485b120b569b", @"/Views/Pagina/Contato.cshtml")]
    public class Views_Pagina_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Pagina\Contato.cshtml"
  
    ViewBag.Title = "Contato";
    if (this.ViewBag.UserLog == null)
    {
        Layout = "MasterPageDeslogado";
    }
    else
    {
        Layout = "MasterPageLogado";    
    }

#line default
#line hidden
            BeginContext(199, 2206, true);
            WriteLiteral(@"
<div class=""titulo flex-container"">
        <div class=""titulo-item"">
            <h2>Contato</h2>
        </div>
</div>

<main>

    <section class=""contato flex-container flex-container-colum espacamento"">
        <div class=""contato-item"">
            <h1>Entrar em contato</h1>
            <div>
            <form class=""contato-item-form"">
                <input type=""text"" name=""nome"" placeholder=""Nome:"" class=""contato-item-form-input"">
                <input type=""text"" name=""email"" placeholder=""E-mail:"" class=""contato-item-form-input"">
                <input type=""text"" name=""telefone"" placeholder=""Telefone/Whatsapp:"" class=""contato-item-form-input"">
                <input type=""text"" name=""assunto"" placeholder=""Assunto:"" class=""contato-item-form-input"">
                <textarea placeholder=""Mensagem:"" class=""contato-item-form-input contato-textarea""></textarea>
            </form>
            <div class=""botao-contato"">
                <button><a href=""#"">Enviar</a></button>
   ");
            WriteLiteral(@"         </div>
        </div>
        </div>
        <div class=""contato-item-dados"">
            <h2>CarFel</h2>
            <h3>Endereço:</h3>
            <p>Alameda Barão de Limeira, 539</p>
            <p>Santa Cecilia</p>
            <p>SAC XXXXXXXXX</p>
            <h3>Telefone:</h3>
            <p>(xx) XXXXX-XXXX</p>
            <h3>E-mail:</h3>
            <p>carfel.checkpoint@gmail.com</p>
            <h3>Redes Sociais</h3>
            <img src=""/imagem/redessociais.png"" alt=""Icones das redes sociais."" width=""170"" height=""170"">
        </div>
    </section>

    <section class=""mapa"">
        <div class=""mapa-img"">
            <h2>Como Chegar</h2>
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8871329131534!2d-46.64847708510331!3d-23.53656156656186!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1s");
            WriteLiteral("pt-BR!2sbr!4v1536842153722\" width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n        </div>\r\n    </section>\r\n    \r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
