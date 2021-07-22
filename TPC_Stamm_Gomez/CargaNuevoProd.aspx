<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaNuevoProd.aspx.cs" Inherits="TPC_Stamm_Gomez.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        <div class="form-group">
            <label for="formGroupExampleInput">Marca</label>
            <asp:DropDownList runat="server" ID="ddlMarcas" OnSelectedIndexChanged="ddlMarcas_SelectedIndexChanged"></asp:DropDownList>


        </div>
        <div class="form-group">
            <label for="formGroupExampleInput2">Descripcion</label>
            <asp:TextBox runat="server" ID="txtDescripcion" />
        </div>
        <div class="form-group">
            <label for="formGroupExampleInput2">Categoria</label>
            <asp:DropDownList runat="server" ID="ddlCategoria"  OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="formGroupExampleInput2">Presentacion</label>
            <asp:DropDownList runat="server" ID="ddlPresentacion" OnSelectedIndexChanged="ddlPresentacion_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="formGroupExampleInput2">Precio Unitario</label>
            <asp:TextBox runat="server" ID="txtPrecio" />
        </div>


        <asp:Button Text="Confirmar" runat="server" ID="btnCargar" OnClick="btnCargar_Click" />

    </div>
</asp:Content>
