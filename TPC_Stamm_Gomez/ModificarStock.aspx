<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.ModificarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> MODIFICAR STOCKS</h1>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label Text="ID REGISTRO DEL STOCK" runat="server" />
            <asp:TextBox AutoPostBack="true" runat="server" ID="txtidstock" OnTextChanged="txtidstock_TextChanged" CssClass="form-control"/>

            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">IDSTOCK</th>
                            <%--<th scope="col">DESCRIPCION</th>--%>
                            <th scope="col">FECHA INGRESO</th>
                            <th scope="col">CANTIDAD INGRESADA</th>
                            <th scope="col">STOCK</th>
                            <%--<th scope="col">ESTADO</th>--%>

                        </tr>
                    </thead>

                        <%foreach(Dominio.Stock item2 in UnRegistro)
                            {%>
                        <tr>
                            <th scope="row"><% =item2.idStock %></th>
                            <%--<td><% =item2.descripcion %> </td>--%>
                            <td><% =item2.fecha_Ingreso.ToShortDateString() %> </td>
                            <td><% =item2.cantidadIngresada %></td>
                            <td><% =item2.stock %></td>
                           <%-- <td><% =item2.estadoStock %></td>--%>
                        </tr>

                        <%} %>
                    
                    <br />
                </table>
                    <asp:TextBox runat="server" ID="text_idstock" TextMode="Number" />
                    <%--<asp:TextBox runat="server" ID="text_descripcion" TextMode=""/>--%>
                    <asp:TextBox runat="server" ID="text_fechaingreso" TextMode="Date"/>
                    <asp:TextBox runat="server" ID="text_cantidad" TextMode="Number"/>
                    <asp:TextBox runat="server" ID="text_stock" TextMode="Number"/>
                    <%--<asp:TextBox runat="server" ID="text_estadostock" TextMode="Number"/>--%>
                <br />
                <asp:Button Text="btn_modificar" ID="btn_Modificar" runat="server" onclick="btn_Modificar_Click"/>
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