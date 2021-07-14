<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Marcas.aspx.cs" Inherits="TPC_Stamm_Gomez.Marcas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> MARCAS</h1>

    <div class="container">
        <div class="row py-3">
            <div class="col-3 order-2" id="sticky-sidebar">
                <div class="sticky-top">
                    <div class="nav flex-column">
                        <div class='col-xs-3'> 
                             <a href="CargarStock.aspx" class="btn btn-primary btn-block">Cargar Marcas</a>
                             


                        </div>
                    </div>
                </div>
            </div>
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th scope="col">NOMBRE</th>
                        </tr>
                    </thead>
                    <tbody>
                       <%-- <%foreach (Dominio.Marcas item in marcas)
                            {%>
                        <tr>
                            <th scope="row"><% =item.idMarcas %></th>
                            <td><% =item.nombreMarcas%>
                        </tr>

                        <%} %>--%>
                    </tbody>
                </table>
            </div>
        </div>
    </div>


</asp:Content>
