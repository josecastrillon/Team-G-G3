#pragma checksum "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2180f15bd247c455be62b0fbe78471944cf217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Frontend.Pages.Propietarios.Pages_Propietarios_DetailPropietarios), @"mvc.1.0.razor-page", @"/Pages/Propietarios/DetailPropietarios.cshtml")]
namespace Veterinaria.App.Frontend.Pages.Propietarios
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
#line 1 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\_ViewImports.cshtml"
using Veterinaria.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2180f15bd247c455be62b0fbe78471944cf217", @"/Pages/Propietarios/DetailPropietarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7999b6faf884d70e4c43d0dc9bc8fca65ad920a5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Propietarios_DetailPropietarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Detalle Propietario</h1>\r\n\r\n<ul >\r\n  <li class=\"list-group-item\">Documento: ");
#nullable restore
#line 9 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                    Write(Model.propietario.documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Nombre: ");
#nullable restore
#line 10 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                 Write(Model.propietario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Apellido: ");
#nullable restore
#line 11 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                   Write(Model.propietario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Dirección: ");
#nullable restore
#line 12 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                    Write(Model.propietario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Teléfono: ");
#nullable restore
#line 13 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                   Write(Model.propietario.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Correo Electrónico: ");
#nullable restore
#line 14 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                             Write(Model.propietario.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Password: ");
#nullable restore
#line 15 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                   Write(Model.propietario.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\">Género: ");
#nullable restore
#line 16 "C:\Users\David Prieto\Documents\GitHub\Team-G-G3\Veterinaria.App\Veterinaria.App.Frontend\Pages\Propietarios\DetailPropietarios.cshtml"
                                 Write(Model.propietario.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Frontend.Pages.DetailPropietariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Frontend.Pages.DetailPropietariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Frontend.Pages.DetailPropietariosModel>)PageContext?.ViewData;
        public Veterinaria.App.Frontend.Pages.DetailPropietariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
