#pragma checksum "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324d84f2fe8c60d324301600c1b309e6ab1c8a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\_ViewImports.cshtml"
using MLDShopping_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\_ViewImports.cshtml"
using MLDShopping_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"324d84f2fe8c60d324301600c1b309e6ab1c8a0b", @"/Areas/Admin/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e003c84cb468250d08076c5ee79fe52094a0abf4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MLDShopping_Admin.Models.AccountVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\Account\Index.cshtml"
    ViewData["Title"] = "Accounts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"content container-fluid\">\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-12\">\r\n            <div class=\"card w-100\">\r\n                <div class=\"card-body p-4\">\r\n                    <button class=\"btn btn-primary btn-sm mb-3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 353, "\"", 444, 5);
            WriteAttributeValue("", 363, "window.location.href", 363, 20, true);
            WriteAttributeValue(" ", 383, "=", 384, 2, true);
            WriteAttributeValue(" ", 385, "\'", 386, 2, true);
#nullable restore
#line 14 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\Account\Index.cshtml"
WriteAttributeValue("", 387, Url.Action("Edit", "Account", new { Areas = "Admin" }), 387, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 442, "\';", 442, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Add New Account</button>

                    <table class=""table table-bordered table-hover dataTable dtr-inline mt-3"" id=""tblAccounts"" width=""100%"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>Account Id</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Permissions</th>
                                <th>Created At</th>
                                <th>Deleted</th>
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
            var table = $(""#tblAccounts"").DataTable({
                paging: true,
                responsive: true,
                serverSide: true,
                autoWidth: true,
                ajax: {
                    url: """);
#nullable restore
#line 52 "C:\Users\mplad\source\repos\MLDShopping-Admin\MLDShopping-Admin\Areas\Admin\Views\Account\Index.cshtml"
                     Write(Url.Action("Read", "Account", new { area = "Admin"}));

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
                    { data: ""AccountId""},
                    { data: ""FirstName"" },
                    { data: ""LastName"" },
                    {
                        data: ""PermissionsString"",
                        orderable: false
                    },
                    {
                        data: ""CreatedAt"",
                        orderable: false
                    },
                    {
                        data: ""Deleted"",
                        o");
                WriteLiteral(@"rderable: false
                    },
                    {
                        data: ""AccountId"",
                        orderable: false,
                        render: function (data, type, account) {
                            return '<a href=""/admin/account/edit/' + data + '"">Edit</a>';
                        },
                        ""autoWidth"": true
                    }

                ],
                ""language"": {
                    ""search"": """",
                    ""searchPlaceholder"": ""Search...""
                },
            });
            //$('#tblAccounts tfoot th').each(function (i) {
            //    var title = $('#tblAccounts thead th').eq($(this).index()).text();
            //    $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" data-index=""' + i + '"" />');
            //});

            //$('#tblAccounts thead tr').clone(true).appendTo('#tblAccounts thead');

            //$('#tblAccounts thead tr:eq(1) th').each(function (i) {");
                WriteLiteral(@"
            //    var title = $(this).text();
            //    $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');

            //    $('input', this).on('keyup change', function () {
            //        if (table.column(i).search() !== this.value) {
            //            table
            //                .column(i)
            //                .search(this.value)
            //                .draw();
            //        }
            //    });
            //});

        })
    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MLDShopping_Admin.Models.AccountVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
