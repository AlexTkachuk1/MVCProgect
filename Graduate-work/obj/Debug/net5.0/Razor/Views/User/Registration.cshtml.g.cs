#pragma checksum "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f099853e7ffcf0260d15d449ea65af6f681be7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Registration), @"mvc.1.0.view", @"/Views/User/Registration.cshtml")]
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
#line 1 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\_ViewImports.cshtml"
using Graduate_work;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\_ViewImports.cshtml"
using Graduate_work.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f099853e7ffcf0260d15d449ea65af6f681be7d", @"/Views/User/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83505a1ae71caef0bb2bd89da8c4609c657fb63", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistrationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/registration.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/Registration"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f099853e7ffcf0260d15d449ea65af6f681be7d4540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n ");
            }
            );
            WriteLiteral("\r\n<div class=\"title\">\r\n    Регистрация:\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f099853e7ffcf0260d15d449ea65af6f681be7d5753", async() => {
                WriteLiteral("\r\n    <div class=\"alert-info\">\r\n        Введите свой никнейм:\r\n    </div>\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 16 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
   Write(Html.TextBoxFor(x => x.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
   Write(Html.ValidationMessageFor(x => x.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"alert-info\">\r\n        Введите свой пароль:\r\n    </div>\r\n\r\n    <div class=\"password\">\r\n        <input type=\"password\" id=\"password-input\" placeholder=\"Введите пароль\"");
                BeginWriteAttribute("name", " name=\"", 573, "\"", 619, 1);
#nullable restore
#line 25 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
WriteAttributeValue("", 580, nameof(RegistrationViewModel.Password), 580, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"flex\">\r\n            <label><input type=\"checkbox\" class=\"password-checkbox\"></label>\r\n            <div>\r\n                Показать пароль\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 32 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
   Write(Html.ValidationMessageFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"alert-info\">\r\n        Введите свой пароль повторно:\r\n    </div>\r\n\r\n    <div class=\"password\">\r\n        <input type=\"password\" id=\"password-input2\" placeholder=\"Введите пароль\"");
                BeginWriteAttribute("name", " name=\"", 1075, "\"", 1125, 1);
#nullable restore
#line 40 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
WriteAttributeValue("", 1082, nameof(RegistrationViewModel.PasswordCopy), 1082, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"flex\">\r\n            <label><input type=\"checkbox\" class=\"password-checkbox\"></label>\r\n            <div>\r\n                Показать пароль\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 47 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
   Write(Html.ValidationMessageFor(x => x.PasswordCopy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"alert-info\">\r\n        Выберите дату своего рождения:\r\n    </div>\r\n    <div>\r\n        <input type=\"date\"");
                BeginWriteAttribute("name", " name=\"", 1513, "\"", 1562, 1);
#nullable restore
#line 54 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
WriteAttributeValue("", 1520, nameof(RegistrationViewModel.DateOfBirth), 1520, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1910-01-01\">\r\n        ");
#nullable restore
#line 55 "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Registration.cshtml"
   Write(Html.ValidationMessageFor(x => x.DateOfBirth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"submit\">\r\n        <input type=\"submit\" value=\"зарегистрироваться\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistrationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
