#pragma checksum "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cefed155508ae305744af262bf2ec74c311d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ModificarContactoView), @"mvc.1.0.view", @"/Views/Usuario/ModificarContactoView.cshtml")]
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
#line 1 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cefed155508ae305744af262bf2ec74c311d47", @"/Views/Usuario/ModificarContactoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99e93f27658e4dea006173d63d024f2283a419b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ModificarContactoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VistaModificarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
  
    ViewData["Title"] = "ModificarContacto";

    if (ViewBag.PermisoUsuario == "1")
    {
        Layout = "_Layout";
    }
    else if (ViewBag.PermisoUsuario == "2")
    {
        Layout = "LayoutUsuarioEstandar";
    }
    else if (ViewBag.PermisoUsuario == "3")
    {
        Layout = "LayoutUsuarioCatalogos";
    }

    if (ViewBag.PermisoUsuario == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            redireccion(\'/Usuario/MuestraLoginUsuario\');\r\n        </script>\r\n");
#nullable restore
#line 22 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""contenidoC"" style=""margin-top:80px"">
    <section id=""principalC"">
        <CENTER>
            <div content=""width=device-widt"" class=""row"">
                <div class=""col-sm-2""></div>
                <div class=""col-sm-8"">
                    <h1>Modificar Contacto</h1>

                    <table id=""consultaC"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>Nombre </th>
                                <th>Apellidos </th>
                                <th>Puesto </th>
                                <th>Oficina </th>
                                <th>Modificar</th>
                                <th>Eliminar</th>

                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 49 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                             foreach (UsuarioModel temp in ViewBag.ListaUsuarios)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 52 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                                   Write(temp.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                                   Write(temp.PrimerApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                                                        Write(temp.SegundoApellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 54 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                                   Write(temp.Puesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 55 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                                   Write(temp.Oficina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cefed155508ae305744af262bf2ec74c311d478823", async() => {
                WriteLiteral("\r\n\r\n                                        <td>\r\n                                            <input id=\"idUsuario\" name=\"idUsuario\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2113, "\"", 2136, 1);
#nullable restore
#line 60 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
WriteAttributeValue("", 2121, temp.IdUsuario, 2121, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                            <button type=\"submit\" class=\"btn btn-secondary\">Modificar</button>\r\n                                        </td>\r\n\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cefed155508ae305744af262bf2ec74c311d4711526", async() => {
                WriteLiteral("\r\n                                        <td>\r\n                                            <input id=\"idUsuario\" name=\"idUsuario\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2622, "\"", 2645, 1);
#nullable restore
#line 70 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
WriteAttributeValue("", 2630, temp.IdUsuario, 2630, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                                            <button type=\"submit\" class=\"btn btn-danger\">Eliminar</button>\r\n                                        </td>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 83 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                     if (ViewBag.ERROR != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\" id=\"al1\" role=\"alert\" style=\"display: block; text-align:center\">\r\n                            <h6> ");
#nullable restore
#line 86 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"
                            Write(ViewBag.ERROR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <br>\r\n");
#nullable restore
#line 89 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Usuario\ModificarContactoView.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <div class=\"col-sm-2\"></div>\r\n            </div>\r\n\r\n        </CENTER>\r\n    </section>\r\n</section>\r\n");
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