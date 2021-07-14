<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaNuevoProd.aspx.cs" Inherits="TPC_Stamm_Gomez.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        <div class="form-group">
            <label for="formGroupExampleInput">Marca</label>
            <asp:DropDownList runat="server" ID="ddlMarcas">
        
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="formGroupExampleInput2">Another label</label>
            <input type="text" class="form-control" id="formGroupExampleInput2" placeholder="Another input placeholder">
        </div>
    </div>
</asp:Content>
