<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarSite.Index.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <div style="position: absolute; top: 30px; left: 700px;">
            <ul>
                <li class="nav-item form-inline my-2 my-lg-0 d-flex justify-content-end" style="margin-left: 200px;">
                    <asp:TextBox ID="Text_Aratilan" runat="server" CssClass="form-control mr-sm-2" Placeholder="Ara" Width="500px"></asp:TextBox>

                    <asp:Button ID="Tikla" runat="server" CssClass="btn btn-success my-2 my-sm-0" Text="Ara" OnClick="Tikla_Click" />
                </li>
            </ul>
        </div>

        <table style="position: absolute; left: 490px; width: auto; margin: auto;" class="table table-hover">
            <tr>
                <td>
                    <asp:Image runat="server" ID="Img_Reklam" Height="500px" Width="1100px" ImageUrl="https://www.dogusoto.com.tr/Dosyalar/Kampanya/vw-ticari-ssh-kazandiran-servis1440x1080.jpg" />
                </td>
            </tr>
        </table>




        <table class="table table-hover w-25" style="background-color: #7bcb49">
            <tr>
                <td colspan="3">
                    <h5 style="text-align: center;">ÇABUK ULAŞ</h5>

                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:DropDownList ID="Drop_Marka" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="Drop_Marka_SelectedIndexChanged"></asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="Drop_Model" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
                </td>

            </tr>

            <tr>
                <td colspan="3" style="text-align: center;">
                    <h6>Fiyat Aralığı</h6>

                </td>
            </tr>
            <tr>

                <td colspan="1">

                    <asp:TextBox runat="server" ID="OneEpsiode" CssClass="form-control" Placeholder="En Küçük" Width="150px"></asp:TextBox>

                </td>
                <td>

                    <asp:TextBox runat="server" ID="TwoEpsiode" CssClass="form-control" Placeholder="En Büyük" Width="150px"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style1" style="text-align: center;">
                    <%--<asp:HyperLink ID="HyperLink1" NavigateUrl="~/Piyasa/Piyasa.aspx?MARKA="+ runat="server" CssClass="form-control btn btn-info w-100 text-white">Hemen Bul</asp:HyperLink>--%>
                    <asp:Button ID="Deneme" runat="server" Text="Hemen Bul" CssClass="form-control btn btn-info w-100 text-white" OnClick="Deneme_Click" />
                </td>
            </tr>
        </table>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="w-100" style="background-color: silver; text-align: center;">
            <h1>HAKKIMIZDA</h1>
            <asp:Label runat="server" Text="Hakkımızda sayfasının gücü aslında öylesine büyüktür ki sitenize gelen ziyaretçilerin markanıza karşı güven duymasına ve markayı içselleştirmesine yardımcı olur. Nihayetinde ise dönüşüm hedeflerinize ulaşmanızı sağlayan yolda ziyaretçinin adım adım ilerlemesine yol açar. Bu sayede hakkımızda sayfanızdan dahi dönüşüm oranınızı arttırmanız oldukça mümkün hale gelir. Peki hakkımızda sayfasına gelen ziyaretçinin dönüşüm yolculuğunda attığı adımlar neler olabilir dersiniz?"></asp:Label>

        </div>
    </form>
   
</asp:Content>
