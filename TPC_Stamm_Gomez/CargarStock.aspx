<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.CargarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> CARGAR NUEVO STOCK   </h1>
    
    <br />
    <br />
   
    <div>
        <asp:Label Text="IDPRODUCTO" runat="server" Width="150px" />
        <asp:TextBox ID="text_idproducto" TextMode="Number" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label Text="FECHA INGRESO" runat="server" Width="150px"/>
        <asp:TextBox ID="text_fechaingreso" TextMode="Date"  runat="server" />
    </div>
    <br />
    <div>
        <asp:Label Text="CANTIDAD" runat="server" Width="150px"/>
        <asp:TextBox ID="text_cantidad" TextMode="Number" runat="server" />
    </div>
    <br />
    <div>
        <asp:Label Text="STOCK" runat="server" Width="150px" />
        <asp:TextBox ID="text_stock" TextMode="Number" runat="server" />
    </div>
    <br />      
    <asp:Button Text="AGREGAR" ID="btn_Agregar" OnClick="btn_Agregar_Click" runat="server" />
    <br />
    <br />
    <br />  
    <br />
    <br />



</asp:Content>
