<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarSite.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title></title>

</head>
<body>
    <style>
        body {
            background-color: #5286F3;
            font-size: 14px;
            color: #fff;
        }
            
        .simple-login-container {
            width: 300px;
            max-width: 100%;
            margin: 50px auto;
        }

            .simple-login-container h2 {
                text-align: center;
                font-size: 20px;
            }

            .simple-login-container .btn-login {
                background-color: #FF5964;
                color: #fff;
            }

        a {
            color: #fff;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <div class="simple-login-container">
                <h2>Giriş Formu</h2>
                <div class="row">
                    <div class="col-md-12 form-group">
                        <asp:TextBox ID="Kad_Text" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 form-group">
                        <asp:TextBox ID="Pass_Text" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>

                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 form-group d-flex justify-content-center">
                        <asp:Button ID="Btn_Login" runat="server" Text="Giriş Yap" CssClass="btn btn-danger text-white w-100" OnClick="Btn_Login_Click" />
                    </div>
                    <div class="col-md-12 form-group d-flex justify-content-center">
                        <asp:LinkButton ID="LinkButton1" PostBackUrl="/KayıtOl/KayıtOl.aspx" runat="server"  CssClass="btn btn-outline-info text-white w-100" >KAYIT OL</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
