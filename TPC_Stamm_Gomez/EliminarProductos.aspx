<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProductos.aspx.cs" Inherits="TPC_Stamm_Gomez.EliminarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="form-group">
        <asp:Label Text="Marca" runat="server" />
        <asp:TextBox runat="server" ID="txtMarca" Enabled="false" />  

    </div>
     <div class="form-group">
        <asp:Label Text="Descripcion" runat="server" />
         <asp:TextBox runat="server"  ID="txtDescripcion" Enabled="false"/> 
    </div>
     <div class="form-group">
        <asp:Label Text="Presentacion" runat="server" />
         <asp:TextBox runat="server" ID="txtPresentacion" Enabled="false"/> 
    </div>
    <div class="form-group">
        <asp:Label Text="Categoria" runat="server" />
        <asp:TextBox runat="server" ID="txtCategoria" Enabled="false"/>  
    </div>
    <div class="form-group">

    </div>



</asp:Content>
