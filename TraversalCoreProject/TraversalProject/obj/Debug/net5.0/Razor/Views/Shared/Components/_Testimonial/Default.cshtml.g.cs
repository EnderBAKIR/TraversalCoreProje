#pragma checksum "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50723406db6421465962921b6e827502ba1194238e0932f2b597ec026322d589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.ContactDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"50723406db6421465962921b6e827502ba1194238e0932f2b597ec026322d589", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5668328aef60d664de0b95ac105868715041d617560202702853ad53b0f74f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Misafirlerimiz bizim için ne dediler?</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">Düşünceleriniz bizim için çok kıymetli.</h3>
            </div>
            <!-- /grids -->
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 14 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimonial-content"">
                                <div class=""testimonial"">
                                    <blockquote>
                                        <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                        ");
#nullable restore
#line 21 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                                   Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </blockquote>\n                                    <div class=\"testi-des\">\n                                        <div class=\"test-img\">\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1251, "\"", 1274, 1);
#nullable restore
#line 25 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 1257, item.ClientImage, 1257, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\n                                        </div>\n                                        <div class=\"peopl align-self\">\n                                            <h3>");
#nullable restore
#line 28 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                                           Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                            <p class=""indentity"">Example City</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 35 "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <!-- /grids -->\n    </div>\n    <!-- //grids -->\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
