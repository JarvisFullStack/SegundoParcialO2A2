using SegundoParcialO2A2.BLL;
using SegundoParcialO2A2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialO2A2.UI.Reportes
{
	public partial class ReportePagos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				List<Pago> lista = new RepositorioBase<Pago>().GetList(x => true);
				this.ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
				this.ReportViewer1.Reset();
				this.ReportViewer1.LocalReport.DataSources.Clear();
				this.ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\UI\Reportes\ReportePagos.rdlc");
				this.ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("Pagos", lista));
				this.ReportViewer1.LocalReport.Refresh();

			}
		}
	}
}