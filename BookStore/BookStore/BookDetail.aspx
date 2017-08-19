<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BookDetail.aspx.cs" Inherits="BookStore.BookDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-xs-12 col-sm-9">
        <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
        </p>
        <div class="row">
            <div class="row">
                <a href="/">Trang chủ</a> / 
                <a runat="server" id="name_cate_book"></a>/ 
                <a runat="server" id="this_book"></a>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-4 item-photo">
                    <img runat="server" class="img img-responsive img-thumbnail" id="img_book" />
                </div>
                <div class="col-xs-8" style="border: 0px solid gray">
                    <!-- Datos del vendedor y titulo del producto -->
                    <h3><%= ThisBook().Name %></h3>
                    <h5><%= ThisBook().Description %></h5>

                    <!-- Precios -->
                    <h6 class="title-price"><small>Giá</small></h6>
                    <h3 class="price" style="margin-top: 0px;"><%= ThisBook().Price %> $</h3>
                </div>
                <div class="col-xs-9">
                    <br />
                    <div style="width: 100%; border-top: 1px solid silver">
                        <%= ThisBook().Detail %>
                    </div>
                </div>
            </div>
        </div>
        <!--/row-->
    </div>
    <!--/.col-xs-12.col-sm-9-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
