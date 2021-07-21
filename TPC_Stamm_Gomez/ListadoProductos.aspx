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
                            <th scope="col">Acciones</th>           
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="repetidor">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("id") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"marcas.nombreMarcas")%> </td>
                                    <td><%#Eval("descripcion") %></td>
                                    <td><%#Eval("precioUnitario") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"categorias.nombreCategoria")%> </td>
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarProductos.aspx?idP=<%#Eval("id") %>'><i title="Eliminar" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href="#"><i title="Modificar datos" class="far fa-edit"></i></a>
                                    </td>

                                </tr>

                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
