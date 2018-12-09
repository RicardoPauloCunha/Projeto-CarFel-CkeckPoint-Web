#pragma checksum "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4814322859f522345e11bf5c1ed1afc3a77c136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depoimento_Listar), @"mvc.1.0.view", @"/Views/Depoimento/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depoimento/Listar.cshtml", typeof(AspNetCore.Views_Depoimento_Listar))]
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
#line 1 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
using Projeto_CarFel_CkeckPoint_Web.Models;

#line default
#line hidden
#line 2 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
using Projeto_CarFel_CheckPoint_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4814322859f522345e11bf5c1ed1afc3a77c136", @"/Views/Depoimento/Listar.cshtml")]
    public class Views_Depoimento_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     if (ViewBag.UserLog == 1)
    {
        ViewBag.Title = "Central de Depoimentos";
    }
    else
    {
        ViewBag.Title = "Depoimentos";
    }

#line default
#line hidden
#line 11 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(294, 70, true);
            WriteLiteral("\r\n<div class=\"titulo flex-container\">\r\n    <div class=\"titulo-item\">\r\n");
            EndContext();
#line 17 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
         if (ViewBag.UserLog == 1)
        {

#line default
#line hidden
            BeginContext(411, 45, true);
            WriteLiteral("            <h2>Central de Depoimentos</h2>\r\n");
            EndContext();
#line 20 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(492, 34, true);
            WriteLiteral("            <h2>Depoimentos</h2>\r\n");
            EndContext();
#line 24 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(537, 40, true);
            WriteLiteral("        \r\n    </div>\r\n</div>\r\n\r\n<main>\r\n");
            EndContext();
#line 30 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
     if (ViewBag.UserLog == 1)
    { 

#line default
#line hidden
            BeginContext(617, 125, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag espacamento\">\r\n            <h2>Avaliar Depoimentos</h2>\r\n                ");
            EndContext();
            BeginContext(743, 28, false);
#line 34 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
           Write(TempData["AvaliacaoSucesso"]);

#line default
#line hidden
            EndContext();
            BeginContext(771, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 36 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                  
                    List<DepoimentoModel> lista = ViewData["Depoimentos"] as List<DepoimentoModel>;
                

#line default
#line hidden
            BeginContext(953, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 39 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Pendente")
                    {

#line default
#line hidden
            BeginContext(1113, 553, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b>");
            EndContext();
            BeginContext(1667, 21, false);
#line 51 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                             Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 57, true);
            WriteLiteral("</b></p>\r\n                                            <p>");
            EndContext();
            BeginContext(1746, 20, false);
#line 52 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(1968, 14, false);
#line 56 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1982, 276, true);
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""dep-footer flex-container"">
                                        <div class=""df-aprovado"">
                                            <button style=""margin-right: 0.5em""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2258, "\"", 2300, 2);
            WriteAttributeValue("", 2265, "/Depoimento/Aprovar?id=", 2265, 23, true);
#line 60 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 2288, lista[i].Id, 2288, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2301, 194, true);
            WriteLiteral(">Aprovado</a></button>\r\n                                        </div>\r\n                                        <div class=\"df-reprovado\">\r\n                                            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2538, 2);
            WriteAttributeValue("", 2502, "/Depoimento/Reprovar?id=", 2502, 24, true);
#line 63 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 2526, lista[i].Id, 2526, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2539, 284, true);
            WriteLiteral(@">Reprovado</a></button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 70 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2865, 40, true);
            WriteLiteral("            </div>\r\n        </section>\r\n");
            EndContext();
            BeginContext(2907, 127, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag espacamento\">\r\n            <h2>Depoimentos Aprovados</h2>\r\n                ");
            EndContext();
            BeginContext(3035, 28, false);
#line 77 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
           Write(TempData["AvaliacaoSucesso"]);

#line default
#line hidden
            EndContext();
            BeginContext(3063, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 79 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Aprovado")
                    {

#line default
#line hidden
            BeginContext(3265, 553, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b>");
            EndContext();
            BeginContext(3819, 21, false);
#line 91 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                             Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3840, 57, true);
            WriteLiteral("</b></p>\r\n                                            <p>");
            EndContext();
            BeginContext(3898, 20, false);
#line 92 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(3918, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(4120, 14, false);
#line 96 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(4134, 249, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"dep-footer flex-container\">\r\n                                        <div class=\"df-reprovado\">\r\n                                            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4383, "\"", 4426, 2);
            WriteAttributeValue("", 4390, "/Depoimento/Reprovar?id=", 4390, 24, true);
#line 100 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
WriteAttributeValue("", 4414, lista[i].Id, 4414, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4427, 282, true);
            WriteLiteral(@">Excluir</a></button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 107 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }  

#line default
#line hidden
            BeginContext(4753, 190, true);
            WriteLiteral("            </div>\r\n            <div class=\"dep-buttons flex-container\">\r\n                    <button><a href=\"/Pagina/Home\">Voltar</a></button>\r\n                </div>\r\n        </section>\r\n");
            EndContext();
#line 114 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"

    }

    else
    {

#line default
#line hidden
            BeginContext(4971, 91, true);
            WriteLiteral("        <section class=\"depoimentos depoimentos-pag\">\r\n            <h2>Depoimentos</h2>\r\n\r\n");
            EndContext();
#line 122 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
             if (ViewBag.UserLog > 0)
            {

#line default
#line hidden
            BeginContext(5116, 69, true);
            WriteLiteral("                <div class=\"user-dep-escrever\">\r\n                    ");
            EndContext();
            BeginContext(5186, 27, false);
#line 125 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
               Write(TempData["valDepCadastrar"]);

#line default
#line hidden
            EndContext();
            BeginContext(5213, 76, true);
            WriteLiteral("\r\n                    <div class=\"mensegeInvalid\">\r\n                        ");
            EndContext();
            BeginContext(5290, 24, false);
#line 127 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                   Write(TempData["MensengeValT"]);

#line default
#line hidden
            EndContext();
            BeginContext(5314, 542, true);
            WriteLiteral(@"
                    </div> 
                    <div class=""flex-container"">
                        <div class=""dep-img flex-container"" style=""justify-content: flex-end;"">
                            <img src=""/imagem/user.png"" alt=""icone de usuario"" style=""height: 3em;"">		
                        </div>
                        <div class=""dep-container-escrever"">
                            <div class=""dep-header flex-container"">
                                <div class=""dh-text"">
                                    <p><b>");
            EndContext();
            BeginContext(5857, 19, false);
#line 136 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                     Write(ViewBag.UsuarioLogN);

#line default
#line hidden
            EndContext();
            BeginContext(5876, 527, true);
            WriteLiteral(@"</b></p>
                                </div>
                            </div>
                            <form method=""post"" action=""/Depoimento/Cadastrar"">
                                <textarea name=""texto"" placeholder=""Deixe seu depoimento:"" class=""contato-item-form-input dep-textarea""></textarea>
                                <input type=""submit"" value=""Enviar"" class=""button-sub"">
                            </form>
                        </div>
                    </div>	
                </div>
");
            EndContext();
#line 146 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
            }

#line default
#line hidden
            BeginContext(6418, 42, true);
            WriteLiteral("\r\n            <div class=\"Usuarios-dep\">\r\n");
            EndContext();
#line 149 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                  
                    List<DepoimentoModel> lista = ViewData["Depoimentos"] as List<DepoimentoModel>;
                

#line default
#line hidden
            BeginContext(6600, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 152 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                 for (int i =  lista.Count-1 ; i > 0; i--)
                {
                    if (lista[i].Situacao == "Aprovado")
                    {

#line default
#line hidden
            BeginContext(6760, 554, true);
            WriteLiteral(@"                        <div class=""user-dep"">
                            <div class=""flex-container"">
                                <div class=""dep-img"">
                                    <img src=""/imagem/user.png"" alt=""icone de usuario"">		
                                </div>
                                <div class=""dep-container"">          
                                    <div class=""dep-header flex-container"">
                                        <div class=""dh-text"">
                                            <p><b> ");
            EndContext();
            BeginContext(7315, 21, false);
#line 164 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                              Write(lista[i].Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(7336, 57, true);
            WriteLiteral("</b></p>\r\n                                            <p>");
            EndContext();
            BeginContext(7394, 20, false);
#line 165 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                          Write(lista[i].DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(7414, 201, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"dep-main\">\r\n                                        <p>");
            EndContext();
            BeginContext(7616, 14, false);
#line 169 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                                      Write(lista[i].Texto);

#line default
#line hidden
            EndContext();
            BeginContext(7630, 338, true);
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""dep-footer flex-container"">
                                    </div>
                                </div>
                            </div>
                            <div class=""dep-barra""></div>
                        </div>
");
            EndContext();
#line 177 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
                    }
                }  

#line default
#line hidden
            BeginContext(8012, 183, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"dep-buttons flex-container\">\r\n              <button><a href=\"/Pagina/Home\">Voltar</a></button>\r\n            </div>\t\r\n        </section>\r\n");
            EndContext();
#line 185 "C:\Users\7\Desktop\Senai\Projeto-CarFel-CkeckPoint-Web\Views\Depoimento\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(8202, 9, true);
            WriteLiteral("</main>\r\n");
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
