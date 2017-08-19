<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookStore.AdminCP.Auth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="Ứng dụng demo bookstore được xây dựng bằng nền tảng ASP.NET Webform" />
    <meta name="author" content="TuanBuiDev" />

    <title>Đăng nhập hệ thống quản trị website BookStore</title>

    <!-- Bootstrap Core CSS -->
    <link href="../../assets/admin/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />

    <!-- MetisMenu CSS -->
    <link href="../../assets/admin/bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="../../assets/admin/dist/css/sb-admin-2.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="../../assets/admin/bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form id="frm_login" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Đăng nhập quản trị website BookStore</h3>
                        </div>
                        <div class="panel-body">
                            <fieldset>
                                <div class="form-group">
                                    <asp:Label CssClass="text-danger" runat="server" ID="m_server"></asp:Label>
                                </div>
                                <div class="form-group">
                                    <label class="text-danger hide" id="m_email"></label>
                                    <asp:TextBox runat="server" required autofocus TextMode="Email" ID="txtEmail" CssClass="form-control" placeholder="E-mail" />
                                </div>
                                <div class="form-group">
                                    <label class="text-danger hide" id="m_password"></label>
                                    <asp:TextBox runat="server" required TextMode="Password" ID="txtPassword" CssClass="form-control" placeholder="Password" />
                                </div>
                                <asp:Button runat="server" ID="btn_Login" OnClick="btn_Login_Click" CssClass="btn btn-lg btn-success btn-block" Text="Đăng nhập" />
                            </fieldset>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

     <!-- jQuery -->
    <script src="../../assets/admin/bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../../assets/admin/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="../../assets/admin/bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="../../assets/admin/dist/js/sb-admin-2.js"></script>

<%--    <script>
        $(function () {
            $('#btn_Login').off('click').on('click', function (e) {
                e.preventDefault();
                // Bắt lỗi phía client sử dụng JQuery
                var m_email = $('#m_email');
                var m_password = $('#m_password');
                var email = $('#txtEmail').val();
                var password = $('#txtPassword').val();

                if (email == "") {
                    m_email.removeClass("hide");
                    m_email.text("Nhập địa chỉ email"); m_email.focus(); return false;
                } else if (password == "") {
                    m_password.removeClass("hide");
                    m_password.text("Nhập mật khẩu"); return false;
                } else if (password.length < 6 || password.length > 32) {
                    m_password.removeClass("hide");
                    m_password.text("Mật khẩu phải từ 6 đến 32 ký tự"); return false;
                }
                return true;
            });
        });
    </script>--%>
</body>
</html>
