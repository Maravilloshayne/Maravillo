#pragma checksum "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9f74581b32a37384259d1bb877e3e86eaa0af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\_ViewImports.cshtml"
using Shane.Maravillo.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\_ViewImports.cshtml"
using Shane.Maravillo.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
using Shane.Maravillo.Web.Infrastructure.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9f74581b32a37384259d1bb877e3e86eaa0af8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b92b7906b07bae0b820e41c52eb53092759ec41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shane.Maravillo.Web.ViewModels.Users.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to Maravillo";

#line default
#line hidden
            BeginContext(175, 101, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Users</h2>\r\n    <p>Here is a paged list of all the users</p>\r\n    ");
            EndContext();
            BeginContext(276, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7832cc3d7b34684b55a9b081f66eb9c", async() => {
                BeginContext(320, 85, true);
                WriteLiteral("<button type=\"button\" class=\"btn\">Create User    <i class=\"fas fa-plus\"></i></button>");
                EndContext();
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
            EndContext();
            BeginContext(409, 249, true);
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Email Address</th>\r\n                <th>Gender</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
              
                foreach (User user in Model.Users.Items)
                {

#line default
#line hidden
            BeginContext(751, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(806, 13, false);
#line 26 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                       Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(819, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(855, 17, false);
#line 27 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                       Write(user.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(872, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(908, 11, false);
#line 28 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                       Write(user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(919, 76, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 995, "\"", 1055, 6);
            WriteAttributeValue("", 1005, "confirmResetPassword(\'", 1005, 22, true);
#line 30 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1027, user.Id, 1027, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1035, "\',", 1035, 2, true);
            WriteAttributeValue(" ", 1037, "\'", 1038, 2, true);
#line 30 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1039, user.FullName, 1039, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1053, "\')", 1053, 2, true);
            EndWriteAttribute();
            BeginContext(1056, 127, true);
            WriteLiteral(" title=\"Reset Password\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-key\"></i></button></a>\r\n                            ");
            EndContext();
            BeginContext(1183, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "689804c4b6f94513a8b78e88359d732c", async() => {
                BeginContext(1247, 76, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-pen-square\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1192, "~/home/update-profile/", 1192, 22, true);
#line 31 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1214, user.Id, 1214, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1327, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                              
                                if (user.LoginStatus == Shane.Maravillo.Web.Infrastructure.Data.Enums.LoginStatus.Active)
                                {

#line default
#line hidden
            BeginContext(1519, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1566, "\"", 1630, 6);
            WriteAttributeValue("", 1576, "confirmDeactivateAccount(\'", 1576, 26, true);
#line 35 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1602, user.Id, 1602, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1610, "\',", 1610, 2, true);
            WriteAttributeValue(" ", 1612, "\'", 1613, 2, true);
#line 35 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1614, user.FullName, 1614, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1628, "\')", 1628, 2, true);
            EndWriteAttribute();
            BeginContext(1631, 104, true);
            WriteLiteral(" title=\"Deactivate Account\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-lock\"></i></button></a>\r\n");
            EndContext();
#line 36 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1843, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1890, "\"", 1952, 6);
            WriteAttributeValue("", 1900, "confirmActivateAccount(\'", 1900, 24, true);
#line 39 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1924, user.Id, 1924, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1932, "\',", 1932, 2, true);
            WriteAttributeValue(" ", 1934, "\'", 1935, 2, true);
#line 39 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1936, user.FullName, 1936, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1950, "\')", 1950, 2, true);
            EndWriteAttribute();
            BeginContext(1953, 107, true);
            WriteLiteral(" title=\"Activate Account\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-lock-open\"></i></button></a>\r\n");
            EndContext();
#line 40 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2126, 39, true);
            WriteLiteral("                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2165, "\"", 2222, 6);
            WriteAttributeValue("", 2175, "confirmDeleteUser(\'", 2175, 19, true);
#line 42 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2194, user.Id, 2194, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2202, "\',", 2202, 2, true);
            WriteAttributeValue(" ", 2204, "\'", 2205, 2, true);
#line 42 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2206, user.FullName, 2206, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2220, "\')", 2220, 2, true);
            EndWriteAttribute();
            BeginContext(2223, 186, true);
            WriteLiteral(" title=\"Delete User\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n                            \r\n                    </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2443, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2836, "\"", 2868, 1);
#line 55 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2844, Model.Users.CurrentPage, 2844, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2869, 354, true);
            WriteLiteral(@" class=""form-control"" style=""width:50px;"" onKeydown=""javascript: if(event.keyCode = 13 && isNaN(parseInt($(this).val())==false)) window.location='/home/index?pageIndex=' + (isNaN(parseInt($(this).val())) ? 1 : parseInt($(this).val()));"" /></li>
                            <li class=""page-item""><span class=""form-control-plaintext"">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(3224, 21, false);
#line 56 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravilloSeed\Shayne.Maravillo\Shane.Maravillo.Web\Views\Home\Index.cshtml"
                                                                                                       Write(Model.Users.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3245, 3741, true);
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><span aria-hidden=""true"">&laquo;</span></a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><span aria-hidden=""true"">&raquo;</span></a></li>
                        </ul>
                    </nav>
                </td>
            </tr>
        </tfoot>

    </table>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-reset-password"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Reset Password</h5>
                <button type=""button"" class=""close");
            WriteLiteral(@""" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to reset the password of <span id=""modal-reset-password-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-reset-password-confirm""><button type=""button"" class=""btn btn-primary"">Reset Password</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-account-status"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><span class=""modal-account-status-label""></span> Account</h5>
                <button type=""button"" class=""close"" da");
            WriteLiteral(@"ta-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to <span class=""modal-account-status-label""></span> the account of <span id=""modal-account-status-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-account-status-confirm""><button type=""button"" class=""btn btn-primary""><span class=""modal-account-status-label""></span> Account</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-user"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete User</h5>
                <button ");
            WriteLiteral(@"type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-user-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-user-confirm""><button type=""button"" class=""btn btn-primary"">Delete User</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7007, 1338, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function confirmResetPassword(userId, userName) {
            $(""#modal-reset-password-username"").html(userName);
            $(""#modal-reset-password-confirm"").attr(""href"", ""/home/reset-password/"" + userId);
            $(""#modal-reset-password"").modal(""show"");
        }

        function confirmActivateAccount(userId, userName) {
            $(""#modal-account-status-username"").html(userName);
            $("".modal-account-status-label"").html(""Activate"");
            $(""#modal-account-status-confirm"").attr(""href"", ""/home/change-status/Active/"" + userId);
            $(""#modal-account-status"").modal(""show"");
        }
        function confirmDeactivateAccount(userId, userName) {
            $(""#modal-account-status-username"").html(userName);
            $("".modal-account-status-label"").html(""Deactivate"");
            $(""#modal-account-status-confirm"").attr(""href"", ""/home/change-status/Locked/"" + userId);
            $(""#modal-account-status"").moda");
                WriteLiteral(@"l(""show"");
        }
        function confirmDeleteUser(userId, userName) {
            $(""#modal-delete-user-username"").html(userName);
            $(""#modal-delete-user-confirm"").attr(""href"", ""/home/delete/"" + userId);
            $(""#modal-delete-user"").modal(""show"");
        }

        
    </script>");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shane.Maravillo.Web.ViewModels.Users.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
