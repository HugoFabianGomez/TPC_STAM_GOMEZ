<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="TPC_Stamm_Gomez.ListadoProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="table">
        <thead>
            <tr>
                <th scope="col">Codigo</th>
                <th scope="col">Producto</th>
                <th scope="col">Descripcion</th>
                <th scope="col">Precio</th>
                <th scope="col">Categoria</th>
            </tr>
        </thead>
        <tbody>

            <%foreach (Dominio.Producto item in listas)
                {%>
            <tr>
                <th scope="row"><% =item.id %></th>
                <td><% =item.marcas.nombreMarcas%>
                <td><%=item.descripcion %></td>
                <td><%=item.precioUnitario.ToString("0.00") %></td>
                <td><%=item.categorias.nombreCategoria %></td>
            </tr>

            <%} %>
        </tbody>
    </table>

    <a href="Default.aspx" class="btn btn-primary">Volver</a>

</asp:Content>
