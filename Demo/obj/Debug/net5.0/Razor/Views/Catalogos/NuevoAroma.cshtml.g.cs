#pragma checksum "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e682bfca214e91b9245772b2fc4a078ce51ee5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogos_NuevoAroma), @"mvc.1.0.view", @"/Views/Catalogos/NuevoAroma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e682bfca214e91b9245772b2fc4a078ce51ee5a", @"/Views/Catalogos/NuevoAroma.cshtml")]
    public class Views_Catalogos_NuevoAroma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Models.AromasModelView>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e682bfca214e91b9245772b2fc4a078ce51ee5a2809", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Nuevo Aroma</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e682bfca214e91b9245772b2fc4a078ce51ee5a3874", async() => {
                WriteLiteral("\r\n\r\n<h4>Aromas</h4>\r\n<hr />\r\n<div class=\"container-fluid\">\r\n    <div>\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 289, "\"", 329, 1);
#nullable restore
#line 20 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
WriteAttributeValue("", 296, Url.Action("Aromas","Catalogos"), 296, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Regresar</a>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 24 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
             using (Html.BeginForm("NuevoAroma","Catalogos",FormMethod.Post)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.Label("nombre","Nombre",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.TextBoxFor(model=> model.nombre,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 32 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.Label("abreviatura","Abrev",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.TextBoxFor(model=> model.abreviatura,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n");
                WriteLiteral("                ");
#nullable restore
#line 37 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.Label("status","Status",new {@class="control-label"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
           Write(Html.DropDownList("status",Model.StatusList,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"text-danger\">\r\n");
#nullable restore
#line 46 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
             if(ViewBag.Errores != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
                   Write(ViewBag.Errores);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\PROGRAMACION\source\repos\Demo\Demo\Views\Catalogos\NuevoAroma.cshtml"
                                        
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Models.AromasModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
