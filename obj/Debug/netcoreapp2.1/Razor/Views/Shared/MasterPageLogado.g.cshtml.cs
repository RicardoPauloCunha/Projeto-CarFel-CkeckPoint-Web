#pragma checksum "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Shared\MasterPageLogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17f196bfde104ab0b6e81c26207ecda4a41d2201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageLogado), @"mvc.1.0.view", @"/Views/Shared/MasterPageLogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageLogado.cshtml", typeof(AspNetCore.Views_Shared_MasterPageLogado))]
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
#line 1 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Shared\MasterPageLogado.cshtml"
using Projeto_CarFel_CkeckPoint_Web.Models;

#line default
#line hidden
#line 2 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Shared\MasterPageLogado.cshtml"
using Projeto_CarFel_CheckPoint_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f196bfde104ab0b6e81c26207ecda4a41d2201", @"/Views/Shared/MasterPageLogado.cshtml")]
    public class Views_Shared_MasterPageLogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 40, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(132, 537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0793049d0af4aa5a7df8f4b097d0385", async() => {
                BeginContext(138, 499, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"">
	<link href=""http://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
    <link type=""text/css"" rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/css/materialize.min.css""/>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0""/>
	<link rel=""stylesheet"" type=""text/css"" href=""/css/estilo.css"">
	<title>CarFel - ");
                EndContext();
                BeginContext(638, 13, false);
#line 13 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Shared\MasterPageLogado.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(651, 11, true);
                WriteLiteral(" </title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(669, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(671, 2430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8504b80df8940adbcd1124cd7a8142a", async() => {
                BeginContext(677, 1365, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-2.1.1.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/0.98.0/js/materialize.min.js""></script>
    
	<header>
		<nav>
			<div class=""nav-wrapper"">
				<!-- <img class=""logo-img"" src=""imagem/logo.png"" alt=""Logo da empresa CarFel"">	 -->
				<a href=""#"" data-activates=""menu-mobile"" class=""button-collapse"">
					<i class=""material-icons"">menu</i>
				</a>
				<script>
				$(function(){
					$("".button-collapse"").sideNav();
				});
				</script>
				<ul class=""right hide-on-med-and-down"">
					<li><a href=""/Pagina/Home"">Home</a></li>
					<li><a href=""/Pagina/Empresa"">Sobre Nós</a></li>
					<li><a href=""/Pagina/Precos"">Preçõs</a></li>
					<li><a href=""/Pagina/Contato"">Contato</a></li>
                    <li><a href=""/Depoimento/Listar"">Depoimentos</a></li>
					<li><a href=""/Shared/Sair"">Sair</a></li>
				</ul>
				
				<ul class=""class side-nav"" id=""menu-mobile"">
					<li><a href=""/Pagina/Home"">Home<");
                WriteLiteral(@"/a></li>
					<li><a href=""/Pagina/Empresa"">Sobre Nós</a></li>
					<li><a href=""/Pagina/Precos"">Preçõs</a></li>
					<li><a href=""/Pagina/Contato"">Contato</a></li>
                    <li><a href=""/Depoimento/Listar"">Depoimentos</a></li>
					<li><a href=""/Shared/Sair"">Sair</a></li>
				</ul>
			</div>
		</nav>
	</header>

    ");
                EndContext();
                BeginContext(2043, 12, false);
#line 52 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Shared\MasterPageLogado.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2055, 1039, true);
                WriteLiteral(@"

	<section class=""chat flex-container"">
		<div class=""chat-header"">
			Envie-nos uma mensagem
		</div>
	</section>

    <footer class=""flex-container"">
    	<ul>
			<a href=""/Pagina/Home"">
				<li class=""footer-item"">Home</li>
				<li>CheckPoint</li>
				<li>Termos de uso</li>
				<li>Suporte</li>
				<li>Chat</li>
			</a>
        </ul>
        <ul>
			<a href=""/Pagina/Empresa"">
				<li class=""footer-item"">Institucional</li>
				<li>Sobre Nós</li>
				<li>História</li>
				<li>Outros produtos</li>
				<li>Colaboradores</li>
			</a>
        </ul>
        <ul>
			<a href=""/Pagina/Contato"">
				<li class=""footer-item""> Contato</li>
				<li>(XX) XXXXX-XXXX</li>
				<li>carfel.checkpoint@gmail.com</li>
				<li>Alameda Barão de Limeira, 539 </li>
				<li>Santa Cecilia</li>
			</a>
        </ul>
        <ul>
            <li class=""footer-item"">Siga-nós</li>
            <img src=""/imagem/redessociais.png"" alt=""Icones das redes sociais."" width=""170"" height=""170"">
        </ul>
");
                WriteLiteral("    </footer>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3101, 9, true);
            WriteLiteral("\r\n</html>");
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
