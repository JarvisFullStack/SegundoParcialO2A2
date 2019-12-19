using SegundoParcialO2A2.BLL;
using SegundoParcialO2A2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialO2A2.UI.Consultas
{
	public partial class cPagos : System.Web.UI.Page
	{
		public static List<Pago> listaPagos { get; set; }
		RepositorioBase<Pago> repositorio = new RepositorioBase<Pago>();
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{

			}
		}

		protected void checkboxFecha_CheckedChanged(object sender, EventArgs e)
		{			
			if(checkboxFecha.Checked)
			{
				this.textboxDesde.Enabled = true;
				this.textboxHasta.Enabled = true;
			} else
			{
				this.textboxDesde.Enabled = false;
				this.textboxHasta.Enabled = false;
			}
		}

		protected void buttonReporte_Click(object sender, EventArgs e)
		{
			Utilidades.ShowToastr(this, "Mostrando Modal", "Reporte");
			//Utilidades.ShowModal(this, "popupModal", "Payouts Report");
			//this.ReportePagos.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
			//this.ReportePagos.Reset();
			//this.ReportePagos.LocalReport.DataSources.Clear();
			//this.ReportePagos.LocalReport.ReportPath = Server.MapPath(@"~\UI\Reportes\ReportePagos.rdlc");
			//List<Pago> lista = Consultar();
			//this.ReportePagos.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("Pagos", lista));
			//this.ReportePagos.LocalReport.Refresh();
			List<Pago> lista = new RepositorioBase<Pago>().GetList(x => true);
			this.ReportePagos.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
			this.ReportePagos.Reset();
			this.ReportePagos.LocalReport.DataSources.Clear();
			this.ReportePagos.LocalReport.ReportPath = Server.MapPath(@"~\UI\Reportes\ReportePagos.rdlc");
			this.ReportePagos.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("Pagos", lista));
			this.ReportePagos.LocalReport.Refresh();
			
		}

		protected void buttonBuscar_Click(object sender, EventArgs e)
		{			
			listaPagos = Consultar(); 
			ActualizarGrid();
		}

		private List<Pago> Consultar()
		{
			Expression<Func<Pago, bool>> expression = x => true;
			bool porfecha = checkboxFecha.Checked;
			DateTime fechaDesde = textboxDesde.Text.ToDatetime();
			DateTime fechaHasta = textboxHasta.Text.ToDatetime();
			string criterio = textboxCriterio.Text;
			switch (dropdownFiltro.SelectedIndex)
			{
				case 0:
					if (porfecha)
					{
						expression = x => x.Fecha >= fechaDesde && x.Fecha <= fechaHasta;
					}
					else
					{
						expression = x => true;
					}
					break;
				case 1:
					if (porfecha)
					{
						int id = criterio.ToInt();
						expression = x => x.Pago_Id == id && (x.Fecha >= fechaDesde && x.Fecha <= fechaHasta);
					}
					else
					{
						int id = criterio.ToInt();
						expression = x => x.Pago_Id == id;
					}
					break;
				case 2:
					if (porfecha)
					{
						decimal descuento = criterio.ToDecimal();
						expression = x => x.Descuento == descuento && (x.Fecha >= fechaDesde && x.Fecha <= fechaHasta);
					}
					else
					{
						decimal descuento = criterio.ToDecimal();
						expression = x => x.Descuento == descuento;
					}
					break;
				case 3:
					if (porfecha)
					{
						expression = x => x.Monto == criterio.ToDecimal() && (x.Fecha >= fechaDesde && x.Fecha <= fechaHasta);
					}
					else
					{
						expression = x => x.Monto == criterio.ToDecimal();
					}
					break;
			}
			return repositorio.GetList(expression);
		}

		private void ActualizarGrid()
		{
			this.gridviewPagos.DataSource = null;			
			this.gridviewPagos.DataSource = listaPagos;
			this.gridviewPagos.DataBind();
		}
	}
}