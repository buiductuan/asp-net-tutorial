<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCP/Admin.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Edit.aspx.cs" Inherits="BookStore.AdminCP.Categories.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentAdmin" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Category
                            <small>Update</small>
            </h1>
        </div>
        <!-- /.col-lg-12 -->
        <div class="col-lg-7" style="padding-bottom: 120px">
            <div class="form-group">
                <label>Tên danh mục</label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                <div class="form-group">
                    <hr />
                    <label>Mô tả danh mục</label>
                    <asp:TextBox TextMode="MultiLine" runat="server" ID="txtDesc" CssClass="form-control ckeditor"></asp:TextBox>
                </div>
                <div class="form-group">
                    <hr />
                    <img width="170" height="150" runat="server" id="img_preview" src="../../assets/upload/images/category/none.png" /><hr />
                    <asp:FileUpload runat="server" ID="img_upload" />
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
                <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" Text="Cập nhật" CssClass="btn btn-primary" />
            </div>
        </div>
        <!-- /.row -->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
