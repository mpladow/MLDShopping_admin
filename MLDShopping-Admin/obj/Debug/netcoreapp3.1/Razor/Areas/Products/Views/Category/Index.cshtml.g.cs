#pragma checksum "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302e57622efc4fe69f17b0f873cbe37e86efed30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Products_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Products/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\_ViewImports.cshtml"
using MLDShopping_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\_ViewImports.cshtml"
using MLDShopping_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302e57622efc4fe69f17b0f873cbe37e86efed30", @"/Areas/Products/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e003c84cb468250d08076c5ee79fe52094a0abf4", @"/Areas/Products/Views/_ViewImports.cshtml")]
    public class Areas_Products_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MLDShopping_Admin.Models.CategoryVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\Category\Index.cshtml"
    ViewData["Title"] = "Category";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section class=""content container-fluid"">
        <div class=""row mt-3"">
            <div class=""col-12"">
                <div class=""card w-100"">
                    <div class=""card-body p-4"">
                        <button class=""btn btn-primary btn-sm mb-3""");
            BeginWriteAttribute("onclick", " onclick=\"", 374, "\"", 469, 5);
            WriteAttributeValue("", 384, "window.location.href", 384, 20, true);
            WriteAttributeValue(" ", 404, "=", 405, 2, true);
            WriteAttributeValue(" ", 406, "\'", 407, 2, true);
#nullable restore
#line 12 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\Category\Index.cshtml"
WriteAttributeValue("", 408, Url.Action("Edit", "Category", new { Areas = "Products" }), 408, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 467, "\';", 467, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Add New Category</button>

                        <table class=""table table-bordered table-hover dataTable dtr-inline mt-3"" id=""tblCategories"" width=""100%"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>Category Id</th>
                                    <th>Name</th>
                                    <th>Description</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>

                    </div>
                </div>

            </div>
        </div>

    </section>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <!-- DataTables -->
    <script type=""text/javascript"" charset=""utf8"" src=""//cdn.datatables.net/1.10.5/js/jquery.dataTables.js""></script>

    <script language=""javascript"">
        $(document).ready(function () {
            var table = $(""#tblCategories"").DataTable({
                paging: true,
                responsive: true,
                serverSide: true,
                autoWidth: true,
                ajax: {
                    url: """);
#nullable restore
#line 47 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Products\Views\Category\Index.cshtml"
                     Write(Url.Action("Read", "Category", new { area = "Products"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    type: ""POST"",
                    contentType: ""application/json"",
                    data: function (d) {
                        return JSON.stringify(d);
                    },
                    dataSrc: function (json) {
                        console.log(json);
                        if (json.data)
                            return json.data;
                        else
                            return [];
                    }
                },
                columns: [
                    { data: ""CategoryId"", ""autoWidth"": true },
                    { data: ""Name"", ""autoWidth"": true },
                    { data: ""Description"", ""autoWidth"": true },
                    {
                        data: ""CategoryId"",
                        render: function (data, type, account) {
                            return '<a href=""/products/category/edit/' + data + '"">Edit</a>';
                        },
                        ""autoWidth"": true
       ");
                WriteLiteral("             }\r\n\r\n                ],\r\n                \"language\": {\r\n                    \"search\": \"\",\r\n                    \"searchPlaceholder\": \"Search...\"\r\n                },\r\n            });\r\n        })\r\n    </script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MLDShopping_Admin.Models.CategoryVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
