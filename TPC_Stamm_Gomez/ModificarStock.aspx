<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarStock.aspx.cs" Inherits="TPC_Stamm_Gomez.ModificarStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> MODIFICAR STOCKS</h1>
    
    <div class="container">
        <div class="row py-3">
            <div class="col" id="main">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">IDSTOCK</th>
                            <th scope="col">DESCRIPCION</th>
                            <th scope="col">FECHA INGRESO</th>
                            <th scope="col">CANTIDAD INGRESADA</th>
                            <th scope="col">STOCK</th>
                            <th scope="col">ESTADO</th>

                        </tr>
                    </thead>
                    <tbody>

                    </tbody>
                </table>
                    <asp:TextBox runat="server" ID="text_idstock" TextMode="Number"/>
                    <asp:TextBox runat="server" ID="text_descripcion" />
                    <asp:TextBox runat="server" ID="text_fechaingreso" TextMode="DateTime" />
                    <asp:TextBox runat="server" ID="text_cantidad" TextMode="Number" />
                    <asp:TextBox runat="server" ID="text_stock" TextMode="Number" />
                    <asp:TextBox runat="server" ID="text_estadostock" />

                <br />
                <asp:Button Text="btn_modificar" ID="btn_Modificar" runat="server" onclick="btn_Modificar_Click"/>
            </div>
        </div>
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



</asp:Content>
