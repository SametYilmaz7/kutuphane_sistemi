#pragma checksum "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd863b7b9eccc958d85b612b1522704c48e0f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_KitapListele), @"mvc.1.0.view", @"/Views/Kitap/KitapListele.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\_ViewImports.cshtml"
using kutuphane_sistemi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\_ViewImports.cshtml"
using kutuphane_sistemi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd863b7b9eccc958d85b612b1522704c48e0f92", @"/Views/Kitap/KitapListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc1c8a7067ffd834cc0ea12c12a382b3093194ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitap_KitapListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kutuphane_sistemi.Models.Kitap>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KitapOlustur", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
  
    ViewData["Title"] = "KitapListele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kitap Listele</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd863b7b9eccc958d85b612b1522704c48e0f923832", async() => {
                WriteLiteral("Yeni Olu??tur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Kitap_adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Kitap_tur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Kitap_yazar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Uye_adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayNameFor(model => model.Uye_soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kitap_adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kitap_tur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kitap_yazar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uye_adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uye_soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.ActionLink("G??ncelle", "KitapGuncelle", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.ActionLink("Detay", "KitapDetay", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
           Write(Html.ActionLink("Sil", "KitapSil", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\samet\source\repos\kutuphane_sistemi\kutuphane_sistemi\Views\Kitap\KitapListele.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kutuphane_sistemi.Models.Kitap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
