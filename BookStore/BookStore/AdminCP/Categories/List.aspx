<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCP/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="BookStore.AdminCP.Categories.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentAdmin" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Category
                            <small>List</small>
            </h1>
        </div>
        <!-- /.col-lg-12 -->
        <table class="table table-striped table-bordered table-hover" id="dataTables-example">
            <thead>
                <tr>
                    <th></th>
                    <th>Mã</th>
                    <th>Tên</th>
                    <th>Mô tả</th>
                    <th>Trạng thái</th>
                    <th>Xóa</th>
                    <th>Sửa</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="_rptListCategory">
                    <ItemTemplate>
                        <tr class="odd gradeX">
                            <td>
                                <img src="<%# Eval("ImagePath") %>" width="100" height="70" alt="" />
                            </td>
                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("Name") %></td>
                            <td><%# Eval("Description") %></td>
                            <td>
                                <a href="#" data-id="<%# Eval("ID") %>" class="isActive">
                                    <%# bool.Parse(Eval("Status").ToString()) == true ? "Hoạt động" : "Ẩn"  %>
                                </a>
                            </td>
                            <td class="center"><i class="fa fa-trash-o  fa-fw"></i><a href="/AdminCP/Categories/Delete.aspx?id=<%# Eval("ID") %>">Xóa</a></td>
                            <td class="center"><i class="fa fa-pencil fa-fw"></i><a href="/AdminCP/Categories/Edit.aspx?id=<%# Eval("ID") %>">Sửa</a></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </tbody>
        </table>
    </div>
    <!-- /.row -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
    <script>
        $(function () {
            $('.isActive').off('click').on('click', function (e) {
                e.preventDefault();
                var id = $(this).data('id');
                var btn = $(this);

                $.get('/AdminCP/Categories/ajax/ChangedStatus.aspx?id=' + id, function (data) {
                    if (data == "10") {
                        btn.html("Hoạt động");
                    } else { btn.html("Ẩn"); }
                });
            });
        });
    </script>
</asp:Content>
