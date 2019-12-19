<%@ Page Title="" Language="C#" MasterPageFile="~/MainLayout.Master" AutoEventWireup="true" CodeBehind="cPagos.aspx.cs" Inherits="SegundoParcialO2A2.UI.Consultas.cPagos" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:ScriptManager runat="server"></asp:ScriptManager>
	<script>
		function popupModal() {
			$("modalReportePagos").modal("show");
		}
	</script>
	<div class="container">
		<div class="row">
			<div class="col-4">
				<asp:Label runat="server" Text="Filtro"></asp:Label>
				<asp:DropDownList id="dropdownFiltro" runat="server">
					<asp:ListItem Text="Todo"></asp:ListItem>
					<asp:ListItem Text="ID"></asp:ListItem>
					<asp:ListItem Text="Descuento"></asp:ListItem>
					<asp:ListItem Text="Monto"></asp:ListItem>
				</asp:DropDownList>				
			</div>
			<div class="col-4">
				<div class="form-group">
					<asp:Label runat="server" Text="Criterio"></asp:Label>
				<asp:TextBox runat="server" class="form-control" ID="textboxCriterio"></asp:TextBox>
				</div>
			</div>
			<div class="col-4">
				<asp:Button runat="server" Text="Buscar" id="buttonBuscar" OnClick="buttonBuscar_Click" CssClass="btn btn-primary"/>
			</div>
		</div>
		<div class="row">
			<div class="col-4">
				<asp:CheckBox runat="server" Text="Filtrar Fecha" ID="checkboxFecha" OnCheckedChanged="checkboxFecha_CheckedChanged"/>
			</div>
			<div class="col-4">
				<div class="form-group">
					<asp:Label runat="server" Text="Desde"></asp:Label>
				<asp:TextBox runat="server" CssClass="form-control" TextMode="Date" ID="textboxDesde"></asp:TextBox>
				</div>
			</div>
			<div class="col-4">
				<div class="form-group">
					<asp:Label runat="server" Text="Hasta"></asp:Label>
				<asp:TextBox runat="server" CssClass="form-control" TextMode="Date" ID="textboxHasta"></asp:TextBox>
				</div>
			</div>
			
		</div>
<div class="row">
		<rsweb:ReportViewer  runat="server" ProcessingMode="Remote" ID="ReportePagos" Height="100%" Width="100%">
        </rsweb:ReportViewer>
	</div>
		<hr />
		<br />
		<%--<asp:UpdatePanel runat="server">
			<ContentTemplate>--%>
				<asp:GridView runat="server" ID="gridviewPagos"></asp:GridView>
			<%--</ContentTemplate>
			<Triggers runat="server">
				<asp:AsyncPostBackTrigger ControlID="gridviewPagos"/>
			</Triggers>
		</asp:UpdatePanel>--%>

		<asp:Button OnClick="buttonReporte_Click" ID="buttonReporte" runat="server" CssClass="btn btn-primary" Text="Ver Reporte"/>
		<hr />
		<br />
		<a href="../Reportes/ReportePagos.aspx">Ver Pagina Separada</a>
		
	</div>
	<hr />
	<br />
	
	 

	
	 <!--
    <div class="modal" id="modalReportePagos" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog modal-lg" role="document">
            <div class="modal-content" style="width: 1000px;height:1000px;margin-right:100px;">
                <div class="modal-header">
                    <h3 class="modal-title" id="ModalLebel">
						Payouts Report
                    </h3>
                    <button data-dismiss="modal" aria-label="Close" type="button" class="close" ><span aria-hidden="true">&times;</span></button>
                </div>
                <div class="modal-body">
                    
                    <rsweb:ReportViewer runat="server" ProcessingMode="Remote" ID="ReportePagoss" Height="100%" Width="100%">
                    </rsweb:ReportViewer>
                </div>
            </div>
        </div>
    </div>
		 -->

	
</asp:Content>
