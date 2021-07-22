<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HistorialStock.aspx.cs" Inherits="TPC_Stamm_Gomez.HistorialStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Historial Stock </h1>
    <div class="container">
        <div class="row py-3">
            <div class="col-3 order-2" id="sticky-sidebar">
                <div class="sticky-top">
                    <div class="nav flex-column">
                        <div class='col-xs-3'>
                            <a href="CargarStock.aspx" class="btn btn-primary btn-block">Cargar Stock</a>
                            <a href="default.aspx" class="btn btn-primary btn-block">Total de Stock</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">Marca</th>
                            <th scope="col">Descripcion</th>
                            <th scope="col">Fecha Ingreso</th>
                            <th scope="col">Cantidad Ingresada</th>
                            <th scope="col">Acciones</th>

                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="repetidor">
                            <ItemTemplate> 
                                <tr>
                                    <td><%#Eval("idStock") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"marcas.nombreMarcas")%> </td>
                                    <td><%#Eval("descripcion") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem,"fecha_Ingreso") %></td>
                                    <td><%#Eval("cantidadIngresada") %> </td>
                                    <td>
                                        <a class="btn btn-sm btn-outline-info" href='EliminarProductos.aspx?idP=<%#Eval("idStock") %>'><i title="Eliminar" class="fas fa-trash-alt"></i></a>
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
