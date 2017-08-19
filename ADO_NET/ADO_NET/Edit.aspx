<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADO_NET.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        ul li {
            list-style-type: none;
            padding: 10px;
            border: 1px solid #ddd;
            margin-bottom: 5px;
            width: 450px;
        }

            ul li > a {
                float: right;
                margin-right: 10px;
            }
            ul li > span{
                margin-left:10px;
            }
    </style>
</head>
<body>
        <form id="form1" runat="server">
        <h1>Get list data from table : Category</h1>
        <div class="form-add">
            <label>Name</label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <br />
            <label>Status</label>
           <asp:RadioButtonList runat="server" ID="rdlStatus">
               <asp:ListItem Value="1" Selected="True">True</asp:ListItem>
                <asp:ListItem Value="0">Flase</asp:ListItem>
           </asp:RadioButtonList>

           <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" Text="Update this record" />
        </div>
        <ul>
            <asp:Repeater runat="server" ID="_rptListData">
                <ItemTemplate>
                    <li>
                        <span><%# Eval("ID") %></span>  
                        <span><%# Eval("Name") %></span>
                        <span><%# Eval("Status") %> </span>
                        <a href="/Edit.aspx?id=<%# Eval("ID") %>">Edit</a>
                        <a href="/Delete.aspx?id=<%# Eval("ID") %>">Delete</a>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>

    </form>
</body>
</html>
