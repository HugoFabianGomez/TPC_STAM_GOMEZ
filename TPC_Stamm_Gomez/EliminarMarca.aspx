<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarMarca.aspx.cs" Inherits="TPC_Stamm_Gomez.EliminarMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="form-group">
        <asp:Label Text="ID" runat="server" />
        <asp:TextBox runat="server" ID="txtID" Enabled="false" />  

    </div>
     <div class="form-group">
        <asp:Label Text="Marca" runat="server" />
         <asp:TextBox runat="server"  ID="txtMarca" Enabled="false"/> 
    </div>

    <asp:Button Text="Eliminar" OnClick="Eliminar_Click" runat="server" />
</asp:Content>
