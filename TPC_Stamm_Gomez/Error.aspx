<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPC_Stamm_Gomez.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Ooop... Ha Ocurrido un Error....</h1>
    <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>

    <a href="Default.aspx" class="btn btn-primary">Volver</a>

</asp:Content>
