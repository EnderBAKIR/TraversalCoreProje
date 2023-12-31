#pragma checksum "C:\Users\Ender\OneDrive\Masaüstü\Masaüstü\TraversalProject-master\TraversalProject\Views\Admin\PartialSidebar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70ba3075d943b9f84dec806195b686d79bab790b5a7d6087828e666a4f9d7567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialSidebar), @"mvc.1.0.view", @"/Views/Admin/PartialSidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70ba3075d943b9f84dec806195b686d79bab790b5a7d6087828e666a4f9d7567", @"/Views/Admin/PartialSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b5668328aef60d664de0b95ac105868715041d617560202702853ad53b0f74f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PartialSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""menu-inner py-1"">
    <!-- Dashboard -->
    <li class=""menu-item"">
        <a href=""/admin/dashboard/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-home-circle""></i>
            <div data-i18n=""Analytics"">İstatistikler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/profile/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-edit""></i>
            <div data-i18n=""Analytics"">Profil Ayarları</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/comment/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment""></i>
            <div data-i18n=""Analytics"">Misafir Yorumları</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/destination/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-car""></i>
            <div data-i18n=""Analytics"">Tur Rotaları</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/");
            WriteLiteral(@"user/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-user""></i>
            <div data-i18n=""Analytics"">Misafirler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/contactUs/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-message-alt""></i>
            <div data-i18n=""Analytics"">Gelen Mesajlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/reservation/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-restaurant""></i>
            <div data-i18n=""Analytics"">Rezervasyonlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/guide/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-help-circle""></i>
            <div data-i18n=""Analytics"">Rehberlerimiz</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/role/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-key""></i>
            <");
            WriteLiteral(@"div data-i18n=""Analytics"">Rol Menüsü</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/announcement/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-notification""></i>
            <div data-i18n=""Analytics"">Duyurular</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/about/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-album""></i>
            <div data-i18n=""Analytics"">Hakkımızda</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/newsletter/index"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-envelope""></i>
            <div data-i18n=""Analytics"">Abone Misafirler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/mail/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-mail-send""></i>
            <div data-i18n=""Analytics"">Mail Gönder</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href");
            WriteLiteral(@"=""/pdfreport/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-file-pdf""></i>
            <div data-i18n=""Analytics"">Pdf Raporları</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/excel/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-report""></i>
            <div data-i18n=""Analytics"">Excel Raporları</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/admin/city/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-star""></i>
            <div data-i18n=""Analytics"">AJAX işlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/admin/apiexchange/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-money""></i>
            <div data-i18n=""Analytics"">API Exchange</div>
        </a>
    </li>
    
    <li class=""menu-item"">
        <a href=""/member/dashboard/memberdashboard"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-ghost""></i");
            WriteLiteral(@">
            <div data-i18n=""Analytics"">Üye Paneli</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/default/index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-exit""></i>
            <div data-i18n=""Analytics"">Siteye git</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/login/logout/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-exit""></i>
            <div data-i18n=""Analytics"">Çıkış yap</div>
        </a>
    </li>
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
