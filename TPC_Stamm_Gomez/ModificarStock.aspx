<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.ModificarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Update panel</h3>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label Text="ID REGISTRO DEL STOCK" runat="server" />
            <asp:TextBox AutoPostBack="true" runat="server" ID="txtidstock" OnTextChanged="txtidstock_TextChanged" CssClass="form-control" />

            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">IDSTOCK</th>
                            <th scope="col">FECHA INGRESO</th>
                            <th scope="col">CANTIDAD INGRESADA</th>
                            <th scope="col">STOCK</th>
                            <th scope="col">ESTADO</th>

                        </tr>
                    </thead>
                    <tbody>  <%// traigo el registro ojo historia--%>
                        <%foreach (Dominio.Stock item2 in UnRegistro)
                            {%>
                        <tr>
                            <th scope="row"><% =item2.idStock %></th>
                            <td><% =item2.fecha_Ingreso.ToShortDateString() %> </td>
                            <td><% =item2.cantidadIngresada %></td>
                            <td><% =item2.stock %></td>
                            <td><% =item2.estadoStock %></td>
                            <%--<td><% =item.fecha_Ingreso.ToShortDateString() %></td>--%>
                        </tr>

                        <%} %>
                    </tbody>
                </table>
            </div>





















           <%-- <div class="form-group">
                <div class="row">
                    <div class="col">
                        <asp:Label Text="text" runat="server" ID="lblNombre" />
                    </div>
                    <div class="col">
                        <asp:TextBox AutoPostBack="true" runat="server" ID="txtNombre" OnTextChanged="txtNombre_TextChanged" CssClass="form-control" />
                    </div>
                    <div class="col">
                        <asp:Button Text="Aceptar" CssClass="form-control" runat="server" ID="btnAceptar" OnClick="btnAceptar_Click" />
                    </div>
                </div>
            </div>--%>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>