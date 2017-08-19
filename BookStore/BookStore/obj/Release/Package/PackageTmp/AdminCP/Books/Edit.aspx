<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCP/Admin.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="BookStore.AdminCP.Books.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentAdmin" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Category
                            <small>Edit</small>
            </h1>
        </div>
        <!-- /.col-lg-12 -->
        <div class="col-lg-7" style="padding-bottom: 120px">
            <div class="form-group">
                <label>Danh mục sách</label>
                <asp:DropDownList runat="server" ID="ddlCate" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="form-group">
                <label>Tên sách</label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <label>Mô tả</label>
                <asp:TextBox TextMode="MultiLine" runat="server" ID="txtDesc" CssClass="form-control ckeditor"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <label>Nội dung</label>
                <asp:TextBox TextMode="MultiLine" runat="server" ID="txtDetail" CssClass="form-control ckeditor"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <img width="170" height="150" runat="server" id="img_preview" src="../../assets/upload/images/category/none.png" /><hr />
                <asp:FileUpload runat="server" ID="img_upload" />
            </div>
            <div class="form-group">
                <hr />
                <label>Giá</label>
                <asp:TextBox runat="server" TextMode="Number" ID="numPrice" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <label>Từ khóa</label>
                <asp:TextBox runat="server" ID="txtKeyword" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <label>Meta Description</label>
                <asp:TextBox runat="server" ID="txtMetaDesc" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <hr />
                <label>Trạng thái</label>
                <asp:RadioButtonList runat="server" ID="rblStatus">
                    <asp:ListItem Value="1">Actived</asp:ListItem>
                    <asp:ListItem Value="0">Blocked</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <asp:Button runat="server" ID="btnUpdateBook" OnClick="btnUpdateBook_Click" Text="Cập nhật" CssClass="btn btn-primary" />
        </div>
        <!-- /.row -->
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
