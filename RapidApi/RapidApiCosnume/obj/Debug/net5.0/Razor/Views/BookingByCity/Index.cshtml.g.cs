#pragma checksum "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7152f60946c606b617eda3b69ca3704dcc2023d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingByCity_Index), @"mvc.1.0.view", @"/Views/BookingByCity/Index.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\_ViewImports.cshtml"
using RapidApiCosnume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\_ViewImports.cshtml"
using RapidApiCosnume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7152f60946c606b617eda3b69ca3704dcc2023d0", @"/Views/BookingByCity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301d51a92af7bd65a1c6df076112b3727d1110d5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BookingByCity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookingApiViewModel.Result>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
  
    Layout = null;
    int count = 0;                            //değer tanımladık. sıfırdan başlıyor.

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <br /> <br />\r\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
 using (Html.BeginForm("Index", "BookingByCity", FormMethod.Post))

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Şehir ID Giriniz</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"cityID\" />\r\n    <br />\r\n    <button class=\"btn btn-primary\">Şehir için Otelleri Listele</button>\r\n");
#nullable restore
#line 15 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7152f60946c606b617eda3b69ca3704dcc2023d04998", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n    \r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Otel Adı</th>\r\n            <th>Otel Puanı</th>\r\n            <th>Detaylar</th>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
         foreach (var item in Model)
        {
            count++;                                       //Değer 1-1 artacak

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 31 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
               Write(item.reviewScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\" class=\"btn btn-primary\">Detaylar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\PC\Desktop\ApıProject\MyApiProject\RapidApi\RapidApiCosnume\Views\BookingByCity\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookingApiViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
