<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarProducto.aspx.cs" Inherits="TPC_Stamm_Gomez.ModificarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>


                <div class="col">
                    <div class="form-group">
                        <asp:Label Text="Marca" runat="server" />
                        <asp:TextBox runat="server" ID="txtMarca" Enabled="false" />

                    </div>
                    <div class="form-group">
                        <asp:Label Text="Descripcion" runat="server" />
                        <asp:TextBox runat="server" ID="txtDescripcion" Enabled="false" />
                    </div>
                    <div class="form-group">
                        <asp:Label Text="Presentacion" runat="server" />
                        <asp:TextBox runat="server" ID="txtPresentacion" Enabled="false" />
                    </div>


                    <div class="form-group">
                        <asp:Label Text="Categoria" runat="server" />
                        <asp:TextBox runat="server" ID="txtCategoria" Enabled="false" />
                    </div>

                    <div class="form-group">
                        <asp:Label Text="Precio" runat="server" />
                        <asp:TextBox runat="server" ID="txtPrecio" Enabled="false" />
                    </div>
                </div>
            </td>
            <td>


                <div class="col">
                    <div class="form-group">
                        <label for="formGroupExampleInput">Marca</label>
                        <asp:DropDownList runat="server" ID="ddlMarcas" OnSelectedIndexChanged="ddlMarcas_SelectedIndexChanged"></asp:DropDownList>


                    </div>
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Descripcion</label>
                        <asp:TextBox runat="server" ID="txtDescripcion1" />
                    </div>
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Presentacion</label>
                        <asp:DropDownList runat="server" ID="ddlPresentacion" AutoPostBack="true" OnSelectedIndexChanged="ddlPresentacion_SelectedIndexChanged" ></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Categoria</label>
                        <asp:DropDownList runat="server" ID="ddlCategoria" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="formGroupExampleInput2">Precio Unitario</label>
                        <asp:TextBox runat="server" ID="txtPrecio1" />
                    </div>
                </div>

            </td>
    </table>

    <asp:Button Text="Modificar" OnClick="Modificar_Click" runat="server" />
</asp:Content>
