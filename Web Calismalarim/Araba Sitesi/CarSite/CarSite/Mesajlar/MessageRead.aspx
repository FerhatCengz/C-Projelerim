<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="MessageRead.aspx.cs" Inherits="CarSite.Mesajlar.MessageRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="Form1" runat="server">
        <div>
            <div class="d-flex justify-content-around align-content-center">
                <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Mesajlar/GidenKutusu.aspx" runat="server" CssClass="btn btn-warning text-white">Giden Mesajlar (<asp:Label ID="Total_Set_Message" runat="server" Text="0"></asp:Label>)</asp:HyperLink>
                <asp:HyperLink ID="HyperLink4" NavigateUrl="~/Mesajlar/MessageRead.aspx" CssClass="btn btn-danger text-white" runat="server">Okunan Mesajlar (<asp:Label ID="lbl_Okunan" runat="server" Text="0"></asp:Label>)</asp:HyperLink>
            </div>
            <br />

        </div>
        <table class="table table-bordered">
            <tbody class="table-dark">
                <tr>
                    <td>MESAJID</td>
                    <td>TARİH</td>
                    <td>GÖNDEREN</td>
                    <td>BAŞLIK</td>
                    <td>İÇERİK</td>
                    <td>İŞLEMLER</td>
                </tr>
            </tbody>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">

                    <ItemTemplate>

                        <tr>
                            <td><%# Eval("MESAJID") %></td>
                            <td><%# Eval("TARIH") %></td>
                            <td><%# Eval("GONDEREN_KULLANICI") %></td>
                            <td><%# Eval("BASLIK") %></td>
                            <td><%# Eval("ICERIK") %></td>
                            <td>
                                <div class="d-flex justify-content-around">
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/Mesajlar/Yanitla.aspx?MESAJID="+Eval("MESAJID") %>' runat="server" CssClass="btn btn-info text-white">Yanıtla</asp:HyperLink>
                                    <asp:LinkButton ID="DeleteMessage" runat="server" CssClass="btn btn-danger text-white" CommandName="DeleteBtn" CommandArgument='<%# Eval("MESAJID") %>'>Sil</asp:LinkButton>

                                </div>

                            </td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </table>

    </form>
</asp:Content>
