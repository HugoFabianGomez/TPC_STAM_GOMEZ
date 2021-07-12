<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.CargarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> CARGAR STOCK   </h1>
    <br />
    <br />

    <h1> CARGAR STOCK</h1>

    <br />
    <br />
   <%-- <div>   
        <asp:Label Text="IDSTOCK" runat="server" Width="150px" />
        <asp:TextBox ID="text_idstock" TextMode="Number" runat ="server" />
    </div>
    <br />--%>
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


<!--    <a ID="btn_Agregar" class="btn btn-primary btn-block" onclick="btn_Agregar_Click">Cargar Stock</a> -->
    <asp:Button Text="AGREGAR" ID="btn_Agregar"  runat="server"  OnClick="btn_Agregar_Click"/>


<%--    <asp:Button ID="btn_Agregar" Text="AGREGAR" OnClick="btn_Agregar_Click" runat="server"/>--%>





</asp:Content>
