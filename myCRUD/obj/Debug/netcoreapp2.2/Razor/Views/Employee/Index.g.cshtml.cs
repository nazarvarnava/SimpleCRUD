#pragma checksum "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac9c38fd34976058e5ca81ebed8a9c2645935df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\_ViewImports.cshtml"
using MyCRUD;

#line default
#line hidden
#line 2 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\_ViewImports.cshtml"
using MyCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac9c38fd34976058e5ca81ebed8a9c2645935df", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc55f8680b54db6c4e22b0651587fc1d77f67b27", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 866, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac9c38fd34976058e5ca81ebed8a9c2645935df5982", async() => {
                BeginContext(41, 600, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>MyCRUD</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    ");
                EndContext();
                BeginContext(641, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ac9c38fd34976058e5ca81ebed8a9c2645935df6987", async() => {
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
                BeginContext(688, 206, true);
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js\"></script>\r\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>\r\n    \r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(901, 131, true);
            WriteLiteral("\r\n<style>\r\n    header{\r\n        display: none!important;\r\n    }\r\n    footer a{\r\n        display: none!important;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(1032, 7545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac9c38fd34976058e5ca81ebed8a9c2645935df9482", async() => {
                BeginContext(1038, 1416, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""table-wrapper"">
            <div class=""table-title"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h2>Manage <b>Employees</b></h2>
                    </div>
                    <div class=""col-sm-6"">
                        <a href=""#addEmployeeModal"" class=""btn btn-success"" data-toggle=""modal""><i class=""material-icons"">&#xE147;</i> <span>Add New Employee</span></a>
                        <!-- <a href=""#deleteEmployeeModal"" class=""btn btn-danger"" data-toggle=""modal""><i class=""material-icons"">&#xE15C;</i> <span>Delete</span></a>-->
                    </div>
                </div>
            </div>
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr>
                        <th>
                            <span class=""custom-checkbox"">
                                <input type=""checkbox"" id=""selectAll"">
                      ");
                WriteLiteral(@"          <label for=""selectAll""></label>
                            </span>
                        </th>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Phone</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 57 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                       var i = 1;

#line default
#line hidden
                BeginContext(2490, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 58 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                     foreach (var employee in ViewBag.employees)
                    {

#line default
#line hidden
                BeginContext(2579, 96, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(2676, 1, false);
#line 62 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(2677, 69, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>");
                EndContext();
                BeginContext(2747, 13, false);
#line 64 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                           Write(employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2760, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2800, 14, false);
#line 65 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                           Write(employee.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2814, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2854, 15, false);
#line 66 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                           Write(employee.Adress);

#line default
#line hidden
                EndContext();
                BeginContext(2869, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2909, 14, false);
#line 67 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                           Write(employee.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(2923, 456, true);
                WriteLiteral(@"</td>
                            <td>
                                <a href=""#editEmployeeModal"" class=""edit"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Edit"">&#xE254;</i></a>
                                <a href=""#deleteEmployeeModal"" class=""delete"" data-toggle=""modal""><i class=""material-icons"" data-toggle=""tooltip"" title=""Delete"">&#xE872;</i></a>
                                <input type=""hidden"" class=""id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3379, "\"", 3399, 1);
#line 71 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
WriteAttributeValue("", 3387, employee.Id, 3387, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3400, 71, true);
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 74 "C:\Users\Назар\source\repos\MyCRUD\MyCRUD\Views\Employee\Index.cshtml"
                        i++;
                    }

#line default
#line hidden
                BeginContext(3524, 260, true);
                WriteLiteral(@"                </tbody>
            </table>
        
        </div>
    </div>
    <!-- Add Modal HTML -->
    <div id=""addEmployeeModal"" class=""modal fade"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                ");
                EndContext();
                BeginContext(3784, 1615, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac9c38fd34976058e5ca81ebed8a9c2645935df15534", async() => {
                    BeginContext(3851, 1541, true);
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Add Employee</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Name</label>
                            <input type=""text"" class=""form-control"" required=""required"" name=""name"">
                        </div>
                        <div class=""form-group"">
                            <label>Email</label>
                            <input type=""email"" class=""form-control"" required=""required"" name=""email"">
                        </div>
                        <div class=""form-group"">
                            <label>Address</label>
                            <textarea class=""form-control"" required name=""adress""></textarea>
                        </div>
                 ");
                    WriteLiteral(@"       <div class=""form-group"">
                            <label>Phone</label>
                            <input type=""text"" class=""form-control"" required name=""phone"">
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-success"" value=""Add"">
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5399, 226, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Edit Modal HTML -->\r\n    <div id=\"editEmployeeModal\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                ");
                EndContext();
                BeginContext(5625, 1724, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac9c38fd34976058e5ca81ebed8a9c2645935df19594", async() => {
                    BeginContext(5691, 1651, true);
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Edit Employee</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Name</label>
                            <input type=""text"" class=""form-control"" required=""required"" name=""name"" id=""name"">
                        </div>
                        <div class=""form-group"">
                            <label>Email</label>
                            <input type=""email"" class=""form-control"" required=""required"" name=""email"" id=""email"">
                        </div>
                        <div class=""form-group"">
                            <label>Address</label>
                            <textarea class=""form-control"" required name=""adress"" id=""adress""></textarea>
               ");
                    WriteLiteral(@"         </div>
                        <div class=""form-group"">
                            <label>Phone</label>
                            <input type=""text"" class=""form-control"" required name=""phone"" id=""phone"">
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-info"" value=""Save"">
                        <input type=""hidden"" name=""id"" id=""id"" />
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7349, 230, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Delete Modal HTML -->\r\n    <div id=\"deleteEmployeeModal\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                ");
                EndContext();
                BeginContext(7579, 941, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac9c38fd34976058e5ca81ebed8a9c2645935df23781", async() => {
                    BeginContext(7645, 868, true);
                    WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Delete Employee</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <p>Are you sure you want to delete these Records?</p>
                        <p class=""text-warning""><small>This action cannot be undone.</small></p>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"">
                        <input type=""submit"" class=""btn btn-danger"" value=""Delete"">
                        <input type=""hidden"" id=""id"" name=""id"" />
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8520, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(8577, 1587, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        
        $('[data-toggle=""tooltip""]').tooltip();
        $('table .delete').on('click', function () {
            var id = $(this).parent().find('.id').val();
            $('#deleteEmployeeModal #id').val(id);
        });
        $('table .edit').on('click', function () {
            var id = $(this).parent().find('.id').val();
            $.ajax({
                type: 'GET',
                url: 'employee/find/' + id,
                success: function (employee) {
                    $('#editEmployeeModal #id').val(employee.id);
                    $('#editEmployeeModal #name').val(employee.name);
                    $('#editEmployeeModal #email').val(employee.email);
                    $('#editEmployeeModal #adress').val(employee.adress);
                    $('#editEmployeeModal #phone').val(employee.phone);
                }
            })
        });

        
        var checkbox = $('table tbody inpu");
            WriteLiteral(@"t[type=""checkbox""]');
        $(""#selectAll"").click(function () {
            if (this.checked) {
                checkbox.each(function () {
                    this.checked = true;
                });
            } else {
                checkbox.each(function () {
                    this.checked = false;
                });
            }
        });
        checkbox.click(function () {
            if (!this.checked) {
                $(""#selectAll"").prop(""checked"", false);
            }
        });
    });
</script>
</html>           ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
