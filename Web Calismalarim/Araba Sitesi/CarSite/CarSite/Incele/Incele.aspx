<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="Incele.aspx.cs" Inherits="CarSite.Incele.Incele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div style="margin-left: 90px; margin-top: 70px;">
            <div>
                <asp:Image ID="Resimciii" runat="server" Height="500" Width="800" />

            </div>
        </div>
        <table style="position: absolute; left: 60%; top: 20%; width: 600px;" class="table table-bordered">
            <tbody class="table table-dark" style="color: black;">
                <tr>
                    <td>SATAN KULLANICI :
                        <asp:Label ID="Satan_Kullanici" runat="server"></asp:Label><asp:Label ID="KAD" Visible="false" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>İLAN TARİHİ :
                        <asp:Label ID="ilan_tarihi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>MARKA :
                        <asp:Label ID="Marka_text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>MODEL :
                        <asp:Label ID="Model_text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>ARAÇ YILI :
                        <asp:Label ID="Arac_yili_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>KM :
                        <asp:Label ID="km_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>YAKIT TÜRÜ :
                        <asp:Label ID="Yakit_Turu_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>VİTES TİPİ :
                        <asp:Label ID="vites_tipi_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>MOTOR HACMİ :
                        <asp:Label ID="Motor_hacmi_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>MOTOR GÜCÜ :
                        <asp:Label ID="Motor_gucu_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>KİMDEN :
                        <asp:Label ID="Kimden_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>FİYAT :
                        <asp:Label ID="Fiyat_Text" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>AÇIKLAMA :
                        <asp:Label ID="Aciklama_Text" runat="server"></asp:Label>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <div style="margin-left: 140px;">
            <div>
                <asp:Button ID="Btn_Src" CssClass="btn btn-warning text-white w-50" runat="server" Text="İletişime Geçin" OnClick="Btn_Src_Click" />
            </div>
        </div>


    </form>
</asp:Content>
