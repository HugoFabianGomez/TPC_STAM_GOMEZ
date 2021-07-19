<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="TPC_Stamm_Gomez.ListadoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Listado de Productos</h1>
    <div class="container">
        <div class="row py-3">
            <div class="col-3 order-2" id="sticky-sidebar">
                <div class="sticky-top">
                    <div class="nav flex-column">
                        <div class='col-xs-3'>
                            <a href="CargaNuevoProd.aspx" class="btn btn-primary btn-block">Cargar Nuevo Producto</a>
                            <a href="Default.aspx" class="btn btn-primary btn-block">Volver</a>
                        </div>
                    </div>
                </div>
            </div>


            <div class="col" id="main">
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
            </div>
        </div>
    </div>
</asp:Content>
