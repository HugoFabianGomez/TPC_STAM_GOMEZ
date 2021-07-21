<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HistorialStock.aspx.cs" Inherits="TPC_Stamm_Gomez.HistorialStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Historial Stock </h1>
    <div class="container">
        <div class="row py-3">
            <div class="col-3 order-2" id="sticky-sidebar">
                <div class="sticky-top">
                    <div class="nav flex-column">
                        <div class='col-xs-3'>
                            <a href="CargarStock.aspx" class="btn btn-primary btn-block">Cargar Eliminar y Modificar Stock</a>
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

                        </tr>
                    </thead>
                    <tbody>
                        <%foreach (Dominio.Stock item in historia)
                            {%>
                        <tr>
                            <th scope="row"><% =item.idStock %></th>
                            <td><% =item.marcas.nombreMarcas%> </td>
                            <td><% =item.descripcion %></td>
                            <td><% =item.fecha_Ingreso.ToShortDateString() %></td>
                            <td><% =item.cantidadIngresada %></td>
                        </tr>

                        <%} %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>


</asp:Content>
