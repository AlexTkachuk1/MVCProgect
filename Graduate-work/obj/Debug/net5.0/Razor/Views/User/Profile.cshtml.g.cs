#pragma checksum "C:\Users\Кирито\source\repos\Graduate-work\Graduate-work\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a914ca18840cf4828f4001a3291595b892ab50c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a914ca18840cf4828f4001a3291595b892ab50c2", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83505a1ae71caef0bb2bd89da8c4609c657fb63", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html");
            BeginWriteAttribute("lang", " lang=\"", 30, "\"", 37, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a914ca18840cf4828f4001a3291595b892ab50c24645", async() => {
                WriteLiteral(@"
    <title>My project | Pages | Profile</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"">
    <link href=""/css/_Layout.css"" rel=""stylesheet"" type=""text/css"" media=""all"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a914ca18840cf4828f4001a3291595b892ab50c25895", async() => {
                WriteLiteral(@"

    <div class=""bgded"" style=""background-image:url(/wwwroot/images/demo/backgrounds/01.png);"">

        <div id=""breadcrumb"" class=""hoc clear"">

            <ul>
                <li><a href=""#"">Profile</a></li>
                <li><a href=""#"">Gallery</a></li>
                <li><a href=""#"">The essence of the site</a></li>
            </ul>

        </div>

    </div>

    <div class=""wrapper row3"">
        <main class=""hoc container clear"">

            <div class=""sidebar one_quarter first"">

                <h6>Заголовок слева со ссылками на инструменты для работы с профилем</h6>
                <nav class=""sdb_holder"">
                    <ul>
                        <li><a href=""#"">Установить авотар</a></li>
                        <li><a href=""#"">Моя галерея</a></li>
                        <li><a href=""#"">Привязать почту к учетной записи</a></li>
                        <li><a href=""#"">Добавить событие</a></li>
                    </ul>
                </nav>
           ");
                WriteLiteral(@"     <div class=""sdb_holder"">
                    <h6>Общая информация</h6>
                    <address>
                        Полное имя<br>
                        Страна где проживает<br>
                        Город где проживает<br>
                        <br>
                        Tel: xxxx xxxx xxxxxx<br>
                        Email: <a href=""#"">contact@domain.com</a>
                    </address>
                </div>

            </div>

            <div class=""content three_quarter"">

                <h1>Ник пользователя</h1>
                <img class=""imgl borderedbox inspace-5"" src=""Путь к станартной аватарке если пользователь не установил другую""");
                BeginWriteAttribute("alt", " alt=\"", 2064, "\"", 2070, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <p>Текстовое сообщение пользователя для посетителей страницы</p>
                <h1>Table(s)</h1>
                <div class=""scrollable"">
                    <table>
                        <thead>
                            <tr>
                                <th>Header 1</th>
                                <th>Header 2</th>
                                <th>Header 3</th>
                                <th>Header 4</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><a href=""#"">Value 1</a></td>
                                <td>Value 2</td>
                                <td>Value 3</td>
                                <td>Value 4</td>
                            </tr>
                            <tr>
                                <td>Value 5</td>
                                <td>Value 6</td>
                                <td>Value");
                WriteLiteral(@" 7</td>
                                <td><a href=""#"">Value 8</a></td>
                            </tr>
                            <tr>
                                <td>Value 9</td>
                                <td>Value 10</td>
                                <td>Value 11</td>
                                <td>Value 12</td>
                            </tr>
                            <tr>
                                <td>Value 13</td>
                                <td><a href=""#"">Value 14</a></td>
                                <td>Value 15</td>
                                <td>Value 16</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div id=""comments"">
                    <h2>Comments</h2>
                    <ul>
                        <li>
                            <article>
                                <header>
                                    <figure class=""a");
                WriteLiteral("vatar\"><img src=\"/images/demo/avatar.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4160, "\"", 4166, 0);
                EndWriteAttribute();
                WriteLiteral(@"></figure>
                                    <address>
                                        By <a href=""#"">A Name</a>
                                    </address>
                                    <time datetime=""2045-04-06T08:15+00:00"">Friday, 6<sup>th</sup> April 2045 </time>
                                </header>
                                <div class=""comcont"">
                                    <p>Комментарий</p>
                                </div>
                            </article>
                        </li>
                        <li>
                            <article>
                                <header>
                                    <figure class=""avatar""><img src=""/images/demo/avatar.png""");
                BeginWriteAttribute("alt", " alt=\"", 4929, "\"", 4935, 0);
                EndWriteAttribute();
                WriteLiteral(@"></figure>
                                    <address>
                                        By <a href=""#"">A Name</a>
                                    </address>
                                    <time datetime=""2045-04-06T08:15+00:00"">Friday, 6<sup>th</sup> April 2045 </time>
                                </header>
                                <div class=""comcont"">
                                    <p>Комментарий</p>
                                </div>
                            </article>
                        </li>
                        <li>
                            <article>
                                <header>
                                    <figure class=""avatar""><img src=""/images/demo/avatar.png""");
                BeginWriteAttribute("alt", " alt=\"", 5698, "\"", 5704, 0);
                EndWriteAttribute();
                WriteLiteral(@"></figure>
                                    <address>
                                        By <a href=""#"">A Name</a>
                                    </address>
                                    <time datetime=""2045-04-06T08:15+00:00"">Friday, 6<sup>th</sup> April 2045 </time>
                                </header>
                                <div class=""comcont"">
                                    <p>Комментарий</p>
                                </div>
                            </article>
                        </li>
                    </ul>
                    <h2>Write A Comment</h2>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a914ca18840cf4828f4001a3291595b892ab50c212925", async() => {
                    WriteLiteral("\r\n                        <div class=\"one_third first\">\r\n                            <label for=\"name\">Name <span>*</span></label>\r\n                            <input type=\"text\" name=\"name\" id=\"name\"");
                    BeginWriteAttribute("value", " value=\"", 6587, "\"", 6595, 0);
                    EndWriteAttribute();
                    WriteLiteral(" size=\"22\" required>\r\n                        </div>\r\n                        <div class=\"one_third\">\r\n                            <label for=\"email\">Mail <span>*</span></label>\r\n                            <input type=\"email\" name=\"email\" id=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 6846, "\"", 6854, 0);
                    EndWriteAttribute();
                    WriteLiteral(" size=\"22\" required>\r\n                        </div>\r\n                        <div class=\"one_third\">\r\n                            <label for=\"url\">Website</label>\r\n                            <input type=\"url\" name=\"url\" id=\"url\"");
                    BeginWriteAttribute("value", " value=\"", 7085, "\"", 7093, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" size=""22"">
                        </div>
                        <div class=""block clear"">
                            <label for=""comment"">Your Comment</label>
                            <textarea name=""comment"" id=""comment"" cols=""25"" rows=""10""></textarea>
                        </div>
                        <div>
                            <input type=""submit"" name=""submit"" value=""Submit Form"">
                            &nbsp;
                            <input type=""reset"" name=""reset"" value=""Reset Form"">
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"clear\"></div>\r\n        </main>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
