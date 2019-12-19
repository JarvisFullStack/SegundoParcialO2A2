<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="rPagos.aspx.cs" Inherits="SegundoParcialO2A2.UI.Registros.rPagos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="card p-5">
		<div class="card-header">
			<h5 class="card-title text-center">Registro de Pagos</h5>
			<asp:Label runat="server" ID="labelFecha" CssClass="float-right"></asp:Label>
		</div>
		<div class="card-body">
			<div class="form-group">
				<asp:Label runat="server" Text="ID"></asp:Label>
				<asp:TextBox runat="server" CssClass="form-control col-6" ID="textboxId"></asp:TextBox>
				<asp:Button runat="server" ID="buttonBuscar" OnClick="buttonBuscar_Click" Text="Buscar" CssClass="btn btn-primary"/>
			</div>
			<div class="form-group">
				<asp:Label runat="server" Text="FacturaID"></asp:Label>
				<asp:TextBox runat="server" id="textboxFacturaId" CssClass="form-control col-5" TextMode="Number"></asp:TextBox>
			</div>

			<div class="form-group">
				<asp:Label runat="server" Text="Descuento"></asp:Label>
				<asp:TextBox runat="server" id="textboxDescuento" CssClass="form-control col-5" TextMode="Number"></asp:TextBox>
			</div>
			<div class="form-group">
				<asp:Label runat="server" Text="Monto"></asp:Label>
				<asp:TextBox runat="server" id="textboxMonto" CssClass="form-control col-5" TextMode="Number"></asp:TextBox>
			</div>


		</div>

		<div class="card-footer">			
			<asp:Button id="ButtonNuevo" class="btn btn-default" OnClick="ButtonNuevo_Click" Text="Nuevo" runat="server"/>
			<asp:Button id="ButtonGuardar" class="btn btn-success" OnClick="ButtonGuardar_Click" Text="Guardar" runat="server"/>
			<asp:Button id="ButtonEliminar" class="btn btn-danger" OnClick="ButtonEliminar_Click" Text="Eliminar" runat="server"/>
			<hr />
			<br />
			<a href="../Consultas/cPagos.aspx">Ver Listado</a>
		</div>

	</div>
</asp:Content>
