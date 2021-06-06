<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Yanitla.aspx.cs" Inherits="CarSite.Mesajlar.Yanitla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 999px;
            margin-right: 344px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="Form1" runat="server" class="auto-style1">
        <div class="table table-borderless" style="margin-left: 300px;">
            <div>
                <br />
                <asp:Label runat="server" for="Gonderen_Text" Text="Gönderen"></asp:Label>
                <asp:TextBox ID="Gonderen_Text" runat="server" CssClass="form-control" Placeholder="Gönderen"></asp:TextBox>
            </div>
            <div>
                <br />
                <asp:Label runat="server" for="BASLIK_Text" Text="BAŞLIK"></asp:Label>
                <asp:TextBox ID="BASLIK_Text" runat="server" CssClass="form-control" Placeholder="BAŞLIK"></asp:TextBox>
            </div>

            <div>
                <br />
                <asp:Label runat="server" for="Icerik_Text" Text="İçerik"></asp:Label>
                <textarea runat="server" id="Icerik_Text" cols="20" rows="12" class="form-control" placeholder="İçerik"></textarea>
            </div>
            <br />
            <br />

            <div class="d-flex justify-content-around">
                <asp:Button ID="Btn_Gonder" runat="server" Text="Gönder" CssClass="btn btn-outline-success w-75" OnClick="Btn_Gonder_Click" />

            </div>
        </div>




    </form>


</asp:Content>
