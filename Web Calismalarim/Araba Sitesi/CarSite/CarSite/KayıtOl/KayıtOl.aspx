<%@ Page Title="" Language="C#" MasterPageFile="~/KayıtOl/Site1.Master" AutoEventWireup="true" CodeBehind="KayıtOl.aspx.cs" Inherits="CarSite.KayıtOl.KayıtOl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!doctype html>
    <html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
        <meta name="generator" content="Hugo 0.83.1">
        <title>Checkout example · Bootstrap v5.0</title>

        <link rel="canonical" href="https://getbootstrap.com/docs/5.0/examples/checkout/">



        <!-- Bootstrap core CSS -->
        <link href="../assets/dist/css/bootstrap.min.css" rel="stylesheet">

        <style>
            .bd-placeholder-img {
                font-size: 1.125rem;
                text-anchor: middle;
                -webkit-user-select: none;
                -moz-user-select: none;
                user-select: none;
            }

            @media (min-width: 768px) {
                .bd-placeholder-img-lg {
                    font-size: 3.5rem;
                }
            }
        </style>


        <!-- Custom styles for this template -->
        <link href="form-validation.css" rel="stylesheet">
    </head>
    <body>

        <div class="container">
            <main>


                <div class="row g-5">
                    <div class="col-md-5 col-lg-4 order-md-last">
                    </div>
                    <div class="col-md-7 col-lg-8">
                        <h4 class="mb-3">Kayıt Formu</h4>
                        <form class="needs-validation" novalidate runat="server">
                            <div class="row g-3">
                                <div class="col-sm-6">
                                    <label for="Adınız_TEXT" class="form-label">Adınız</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="Adınız_TEXT" Placeholder="Adınız"></asp:TextBox>
                                    <div class="invalid-feedback">
                                        Boş Kalamaz
                                    </div>
                                </div>

                                <div class="col-sm-6">
                                    <label for="Soyadınız_Text" class="form-label">Soyadınız</label>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="Soyadınız_Text" Placeholder="Adınız"></asp:TextBox>
                                    <div class="invalid-feedback">
                                        Boş Kalamaz
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="Kad_Text" class="form-label">Kullanıcı Adınız</label>
                                    <div class="input-group has-validation">
                                        <span class="input-group-text">@</span>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="Kad_Text" Placeholder="Kullanıcı Adınız"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Boş Kalamaz
                                        </div>
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="email_Text" class="form-label">Email</label>
                                    <div class="input-group has-validation">
                                        <span class="input-group-text">@</span>
                                        <asp:TextBox runat="server" CssClass="form-control" ID="email_text" Placeholder="E-Mail"></asp:TextBox>

                                        <div class="invalid-feedback">
                                            Boş Kalamaz
                                        </div>
                                    </div>
                                </div>

                                <div class="col-12">
                                    <label for="Pass_Text" class="form-label">Parolanız</label>
                                    <div class="input-group has-validation">
                                        <asp:TextBox runat="server" CssClass="form-control" ID="Pass_Text" Placeholder="Parolanız" TextMode="Password"></asp:TextBox>
                                        <div class="invalid-feedback">
                                            Boş Kalamaz
                                        </div>
                                    </div>
                                    <br />
                                    <br />
                                </div>
                                <asp:Button runat="server" Text="Üye Ol" CssClass="w-100 btn btn-primary btn-lg" OnClick="Unnamed1_Click" />
                        </form>

                    </div>
                </div>
            </main>

            <footer class="my-5 pt-5 text-muted text-center text-small">
                <p class="mb-1">&copy; 2017–2021 Tüm Haklar Saklıdır</p>

            </footer>
        </div>


        <script src="../assets/dist/js/bootstrap.bundle.min.js"></script>

        <script src="form-validation.js"></script>
    </body>
    </html>

</asp:Content>





