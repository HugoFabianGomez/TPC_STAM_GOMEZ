<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.EliminarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
    <br />
    <br />
        <asp:Label Text="IdStock" runat="server" />
        <asp:TextBox runat="server" ID="text_idStock" Enabled="false"/>

    </div>    
    <div class="form-group">
        <asp:Label Text="descripcion" runat="server" />
        <asp:TextBox runat="server" ID="txt_descripcion" Enabled="false"/>

    </div>
    <div class="form-group">
        <asp:Label Text="Fecha Ingreso" runat="server" />
        <asp:TextBox runat="server" ID="text_fechaIngreso" Enabled="false"/>

    </div>
    <div class="form-group">
        <asp:Label Text="Cantidad Ingresada" runat="server"/>
        <asp:TextBox runat="server" ID="text_cantidadingresada" Enabled="false" />

    </div>
    <div class="form-group">
        <asp:Label Text="Estado" runat="server"/>
        <asp:TextBox runat="server" ID="text_estadostock" Enabled="false" />

    </div>


    <br />
     <div class="form-group">

        <asp:Button Text="EliminarStock" OnClick="EliminarStock_Click" runat="server" />

    </div>

</asp:Content>
