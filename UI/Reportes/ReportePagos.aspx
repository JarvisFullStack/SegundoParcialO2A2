﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportePagos.aspx.cs" Inherits="SegundoParcialO2A2.UI.Reportes.ReportePagos" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
		<asp:ScriptManager runat="server"></asp:ScriptManager>
        <div class="row">		
			<hr />
			<rsweb:ReportViewer  ID="ReportViewer1" runat="server"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
