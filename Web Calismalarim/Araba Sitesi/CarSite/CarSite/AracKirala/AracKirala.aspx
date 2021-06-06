﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Panel.Master" AutoEventWireup="true" CodeBehind="AracKirala.aspx.cs" Inherits="CarSite.AracKirala.AracKirala" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .div {
            float: left;
            height: 200px;
            width: 303px;
            margin: 10px;
            color: black;
            margin: 90px;
            padding-top: 1em;
        }
    </style>


    <form runat="server" class="table table-primary">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <div class="div">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/Incele/Incele.aspx?KAD_ID="+Eval("KAD_ID") %>'> <asp:Image Height="300px" Width="430px" runat="server" ImageUrl='<%# Eval("RESIM") %>'></asp:Image></asp:HyperLink>
                        <asp:Label runat="server" Text='<%#  "MARKA : "+Eval("MARKA") %>'></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label runat="server" Text='<%#  "YIL : "+Eval("ARAC_YILI") %>'></asp:Label>

                        <br />
                        <asp:Label runat="server" Text='<%#  "FİYAT : "+Eval("FİYAT") %>'></asp:Label>
                        <br />

                        <asp:Label runat="server" Text='<%#  "MODEL : "+Eval("MODEL") %>'></asp:Label>

                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>




</asp:Content>