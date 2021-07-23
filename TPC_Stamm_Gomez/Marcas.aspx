<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marcas.aspx.cs" Inherits="TPC_Stamm_Gomez.Marcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    

    <h1>Listado de Marcas</h1>
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
                            <th scope="col">ID</th>
                            <th scope="col">Nombre</th>
                            <th scope="col">Acciones</th>
                              
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="repetidor">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("idMarcas") %></td>
                                    <td><%# Eval("nombreMarcas") %></td>
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarMarca.aspx?idM=<%#Eval("idMarcas") %>'><i title="Eliminar" class="fas fa-trash-alt"></i></a>
                                        <a class="btn btn-sm btn-outline-secondary" href=#><i title="Modificar datos" class="far fa-edit"></i></a>
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
