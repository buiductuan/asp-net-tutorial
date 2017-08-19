<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCP/Admin.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="BookStore.AdminCP.Books.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentAdmin" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Book
                            <small>List</small>
            </h1>
        </div>
        <!-- /.col-lg-12 -->
        <table class="table table-striped table-bordered table-hover" id="dataTables-example">
            <thead>
                <tr>
                    <th></th>
                    <th>Mã</th>
                    <th>Danh mục cha</th>
                    <th>Tên</th>
                    <th>Mô tả</th>
                    <th>Trạng thái</th>
                    <th>Xóa</th>
                    <th>Sửa</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="_rptListBook">
                    <ItemTemplate>
                        <tr class="odd gradeX">
                            <td>
                                <img src="<%# Eval("ImagePath") %>" width="100" height="70" alt="" />
                            </td>
                            <td><%# Eval("ID") %></td>
                            <td>
                                <%# Convert.ToInt32(Eval("CateID").ToString()) > 0 ? GetNameAParentBook(long.Parse(Eval("CateID").ToString())) : "Không có" %>
                            </td>
                            <td><%# Eval("Name") %></td>
                            <td><%# Eval("Description") %></td>
                            <td>
                                <a href="#" data-id="<%# Eval("ID") %>" class="isActive">
                                    <%# bool.Parse(Eval("Status").ToString()) == true ? "Hoạt động" : "Ẩn"  %>
                                </a>
                            </td>
                            <td class="center"><i class="fa fa-trash-o  fa-fw"></i><a href="/AdminCP/Books/Delete.aspx?id=<%# Eval("ID") %>">Xóa</a></td>
                            <td class="center"><i class="fa fa-pencil fa-fw"></i><a href="/AdminCP/Books/Edit.aspx?id=<%# Eval("ID") %>">Sửa</a></td>
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
        $('.isActive').off('click').on('click', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            var btn = $(this);

            $.get('/AdminCP/Books/ajax/ChangedStatus.aspx?id=' + id, function (data) {
                if (data == "10") {
                    btn.html("Hoạt động");
                } else { btn.html("Ẩn"); }
            });
        });
    </script>
</asp:Content>
