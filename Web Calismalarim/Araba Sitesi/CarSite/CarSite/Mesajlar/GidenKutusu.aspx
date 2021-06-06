<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="GidenKutusu.aspx.cs" Inherits="CarSite.Mesajlar.GidenKutusu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server">
        <div>
            <div class="d-flex justify-content-around align-content-center">
                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Mesajlar/GidenKutusu.aspx" runat="server" CssClass="btn btn-warning text-white">Giden Mesajlar (<asp:Label ID="Total_Set_Message" runat="server" Text="0"></asp:Label>)</asp:HyperLink>
                <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Mesajlar/MessageRead.aspx" CssClass="btn btn-danger text-white" runat="server">Okunan Mesajlar (<asp:Label ID="lbl_Okunan" runat="server" Text="0"></asp:Label>)</asp:HyperLink>
            </div>
            <table class="table table-hover">
                <tbody class="table-dark">
                    <tr>
                        <td>MESAJID</td>
                        <td>TARİH</td>
                        <td>GÖNDERDİĞİM KİŞİ</td>
                        <td>BAŞLIK</td>
                        <td>İÇERİK</td>
                        <td style="text-align: center">İŞLEMLER</td>
                    </tr>
                </tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("MESAJID") %></td>
                            <td><%# Eval("TARIH") %></td>
                            <td><%# Eval("ALICI_KULLANICI") %></td>
                            <td><%# Eval("BASLIK") %></td>
                            <td><%# Eval("ICERIK") %></td>
                            <td>
                                <div class="d-flex justify-content-around">
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/Mesajlar/DelteGiden.aspx?MESAJID="+Eval("MESAJID") %>' CssClass="btn btn-danger text-white" runat="server">Sil</asp:HyperLink>

                                </div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
    </form>


</asp:Content>
