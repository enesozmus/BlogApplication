#pragma checksum "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2792a0fceff274f24f803078e631957fd15e2cc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\_ViewImports.cshtml"
using BlogApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\_ViewImports.cshtml"
using BlogApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2792a0fceff274f24f803078e631957fd15e2cc9", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc16d844003408fa6783bc55a96e3e396a7ff0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Author>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--/main--><!--/main--><!--/main--><!--/main--><!--/main-->
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Register Now</h3>
        <div class=""inner-sec"">
            <div class=""login p-5 bg-light mx-auto mw-100"">
");
#nullable restore
#line 13 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2792a0fceff274f24f803078e631957fd15e2cc95026", async() => {
                WriteLiteral("\r\n                        <div class=\"form-row\">\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label for=\"validationCustom01\">Name</label>\r\n                                ");
#nullable restore
#line 20 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.AuthorName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 21 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.ValidationMessageFor(x => x.AuthorName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("                            </div>\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                <label for=\"validationCustom02\">E-mail</label>\r\n                                ");
#nullable restore
#line 28 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.AuthorMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 29 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.ValidationMessageFor(x => x.AuthorMail, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label for=""exampleInputPassword1 mb-2"">Password</label>
                                ");
#nullable restore
#line 38 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.AuthorPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 39 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.ValidationMessageFor(x => x.AuthorPassword, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                <label for=\"exampleInputPassword2 mb-2\">Confirm Password/Image</label>\r\n                                ");
#nullable restore
#line 46 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.AuthorImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 47 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"
                           Write(Html.ValidationMessageFor(x => x.AuthorImage, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral(@"                            </div>

                        </div>
                        <button type=""submit"" class=""btn btn-primary submit mb-4"">Register</button>
                        <p>
                            <a href=""#"" id=""btn1"">By clicking Signup, I agree to your terms</a>
                        </p>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\ensoz\source\repos\BlogApplicationSln\BlogApplication\Views\Register\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <br />\r\n\r\n    <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2792a0fceff274f24f803078e631957fd15e2cc911071", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <script>\r\n        $(\'#btn1\').click(function () {\r\n            swal(\"Our Terms...\", \"terms terms terms terms terms terms terms terms terms terms terms terms terms terms terms terms terms terms\");\r\n        });\r\n    </script>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
