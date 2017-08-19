<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookStore.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-xs-12 col-sm-9">
        <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
        </p>
        <div class="row">
            <div class="row">
                <asp:Repeater runat="server" ID="_rptListBook">
                    <ItemTemplate>
                        <div class="col-sm-6 col-md-4">
                            <a title="<%# Eval("Name") %>" href="/chi-tiet-sach/<%# BLL.Tools.Tools.convertToUnSign(Eval("Name").ToString()) %>-<%# Eval("ID") %>">
                                <div class="thumbnail clearfix">
                                    <img src="<%# Eval("ImagePath") %>" alt="<%# Eval("Name") %>" /><hr />
                                    <div class="caption">
                                        <h4>
                                            <b><%# Eval("Name") %></b>
                                        </h4>
                                        <hr />
                                        <p><%# Eval("Description") %></p>
                                        <hr />
                                        <p class="pull-left price"><%# Eval("Price") %>$</p>
                                        <a title="<%# Eval("Name") %>" href="/chi-tiet-sach/<%# BLL.Tools.Tools.convertToUnSign(Eval("Name").ToString()) %>-<%# Eval("ID") %>" class="btn btn-primary pull-right" role="button">View</a>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!--/row-->
    </div>
    <!--/.col-xs-12.col-sm-9-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
