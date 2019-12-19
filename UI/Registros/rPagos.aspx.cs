using SegundoParcialO2A2.BLL;
using SegundoParcialO2A2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialO2A2.UI.Registros
{
	public partial class rPagos : System.Web.UI.Page
	{
		RepositorioBase<Pago> repositorio = new RepositorioBase<Pago>();
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{

				this.labelFecha.Text = DateTime.Now.ToFormatDate();
			}
		}

		protected void ButtonNuevo_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		protected void ButtonGuardar_Click(object sender, EventArgs e)
		{
			bool paso = false;
			if(Validar())
			{
				Pago pago = LlenaClase();
				if(pago.Pago_Id > 0)
				{
					paso = repositorio.Modificar(pago);
				} else
				{
					paso = repositorio.Guardar(pago);
				}
				
			} else
			if(paso)
			{
				Utilidades.ShowToastr(this, "Correcto", "Correcto", "success");
				LimpiarCampos();
				return;
			} else
			{
				Utilidades.ShowToastr(this, "Error", "Error", "error");
			}
		}

		private Pago LlenaClase()
		{
			return new Pago() { Pago_Id = textboxId.Text.ToInt(),
			Factura_Id = textboxFacturaId.Text.ToInt(),
			Fecha = labelFecha.Text.ToDatetime(),
			Descuento = textboxDescuento.Text.ToDecimal(),
			Monto = textboxMonto.Text.ToDecimal()};
		}

		private bool Validar()
		{
			if(textboxFacturaId.ToInt() > 0 || !string.IsNullOrEmpty(textboxDescuento.Text) || !string.IsNullOrEmpty(textboxMonto.Text))
			{
				return true;
			}
			return false;
		}

		protected void ButtonEliminar_Click(object sender, EventArgs e)
		{
			if(repositorio.Eliminar(textboxId.Text.ToInt()))
			{
				Utilidades.ShowToastr(this, "Correcto", "Correcto", "success");
				LimpiarCampos();
			} else
			{
				Utilidades.ShowToastr(this, "Error", "Error", "error");
			}
		}

		private void LimpiarCampos()
		{
			this.textboxId.Text = string.Empty;
			labelFecha.Text = DateTime.Now.ToFormatDate();
			textboxFacturaId.Text = "0";
			textboxDescuento.Text = "0";
			textboxMonto.Text = "0";
		}

		protected void buttonBuscar_Click(object sender, EventArgs e)
		{
			int id = textboxId.Text.ToInt();
			if(id > 0)
			{
				Pago pago = this.repositorio.Buscar(id);
				if(pago != null)
				{
					Utilidades.ShowToastr(this, "Encontrado", "Encontrado", "success");
					LlenaCampos(pago);
				} else
				{
					Utilidades.ShowToastr(this, "No Encontrado", "No Encontrado", "info");
				}
				
			} else
			{
				Utilidades.ShowToastr(this, "Error", "Error", "error");
			}
		}

		private void LlenaCampos(Pago pago)
		{
			this.textboxId.Text = pago.Pago_Id.ToString();
			labelFecha.Text = pago.Fecha.ToFormatDate();
			textboxFacturaId.Text = pago.Factura_Id.ToString();
			textboxDescuento.Text = pago.Descuento.ToString();
			textboxMonto.Text = pago.Monto.ToString();
			
		}
	}
}