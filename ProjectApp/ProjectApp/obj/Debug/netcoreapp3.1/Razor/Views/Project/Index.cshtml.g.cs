#pragma checksum "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b4e4e6e42f73737e45a0fccd2b738545eeb6f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\_ViewImports.cshtml"
using ProjectApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\_ViewImports.cshtml"
using ProjectApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b4e4e6e42f73737e45a0fccd2b738545eeb6f5", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559333341d93fc68409c60ca32b6d868f1035843", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
 if (signInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92b4e4e6e42f73737e45a0fccd2b738545eeb6f54521", async() => {
                WriteLiteral("Add new project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
  
    if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <strong>There are currently no projects listed.</strong>\r\n");
#nullable restore
#line 18 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <thead>
                <tr>
                    <th>
                        Project
                    </th>
                    <th>
                        Status
                    </th>
                    <th>
                        Completion Date
                    </th>
                    <th>
                        Tags
                    </th>
");
#nullable restore
#line 36 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                     if (signInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th> Options </th>\r\n");
#nullable restore
#line 39 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                 foreach (ProjectListViewModel project in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
            WriteLiteral("                        <td class=\"info\">                           \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92b4e4e6e42f73737e45a0fccd2b738545eeb6f58142", async() => {
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                                                                                                  Write(project.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                                                                              WriteLiteral(project.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                       Write(project.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                       Write(project.CompletionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"info\">\r\n");
#nullable restore
#line 60 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                              
                                if (project.Tags.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>No tags</p>\r\n");
#nullable restore
#line 64 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                                }
                                else
                                {
                                    foreach (string tag in project.Tags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>");
#nullable restore
#line 69 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                                      Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 70 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
#nullable restore
#line 74 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                         if (signInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"feature\">\r\n");
            WriteLiteral("                    </td>\r\n");
#nullable restore
#line 80 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 86 "C:\Users\Jolien\source\repos\ProjectApp\ProjectApp\ProjectApp\Views\Project\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    table, td {\r\n        border-bottom: 1px solid black;\r\n    }\r\n\r\n    .info {\r\n        width: 20vw;\r\n    }\r\n\r\n    img {\r\n        width: 100px;\r\n    }\r\n</style>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ProjectApp.Domain.ProjectUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
