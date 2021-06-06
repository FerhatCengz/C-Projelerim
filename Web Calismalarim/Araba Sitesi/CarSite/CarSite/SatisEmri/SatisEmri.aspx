<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="SatisEmri.aspx.cs" Inherits="CarSite.SatisEmri.SatisEmri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 425px;
        }

        .auto-style2 {
            display: block;
            width: 100%;
            height: calc(2.25rem + 2px);
            font-size: 1rem;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: 0.25rem;
            transition: none;
            border: 1px solid #ced4da;
            margin-top: 0;
            background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="Form1" runat="server" class="auto-style1">
        <table class="table table-hover">
            <tr>
                <td>
                    <asp:TextBox ID="Satan_Text" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Resim" runat="server">Resim</asp:Label>
                    <asp:TextBox ID="Resim" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Marka" runat="server">Marka</asp:Label>
                    <asp:DropDownList ID="Marka_Drop" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="Marka_Drop_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Model" runat="server">Model</asp:Label>
                    <asp:DropDownList ID="Model_Drop" runat="server" CssClass="auto-style2"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Yil_TEXT" runat="server">Araç Yılı</asp:Label>
                    <asp:TextBox ID="Yil_TEXT" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="KM_TEXT" runat="server">KM</asp:Label>
                    <asp:TextBox ID="KM_TEXT" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Yakit_Drop" runat="server">Yakıt Türü</asp:Label>
                    <asp:DropDownList ID="Yakit_Drop" runat="server" CssClass="form-control"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Vites_Drop" runat="server">Vites Türü</asp:Label>
                    <asp:DropDownList ID="Vites_Drop" runat="server" CssClass="form-control"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="MotorHacmi_Text" runat="server">Motor Hacmi</asp:Label>
                    <asp:TextBox ID="MotorHacmi_Text" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="MotorGucu_Text" runat="server">Motor Gücü</asp:Label>
                    <asp:TextBox ID="MotorGucu_Text" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Kimden_Drop" runat="server">Kimden</asp:Label>
                    <asp:DropDownList ID="Kimden_Drop" runat="server" CssClass="form-control"></asp:DropDownList>
                </td>
            </tr>

      
            <tr>
                <td>
                    <asp:Label for="Aciklama_Text" runat="server">Açıklama</asp:Label>
                    <textarea id="Aciklama_Text" cols="20" rows="2" runat="server"></textarea>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="KİRALIK" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" />

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label for="Fiyat_Text" runat="server">Fiyat</asp:Label>
                    <asp:TextBox ID="Fiyat_Text" runat="server" CssClass="form-control"></asp:TextBox>

                </td>
            </tr>
        </table>
        <div class="d-flex justify-content-center">
            <asp:Button ID="Btn_Ekle" runat="server" Text="İlanı Ver" CssClass="btn btn-warning w-100 text-white" OnClick="Btn_Ekle_Click"/>
        </div>







    </form>






</asp:Content>
