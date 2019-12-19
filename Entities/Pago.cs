using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundoParcialO2A2.Entities
{
	[Serializable]
	public class Pago
	{
		[Key]
		public int Pago_Id { get; set; }
		public int Factura_Id { get; set; }
		public decimal Descuento { get; set; }
		public decimal Monto { get; set; }
		public DateTime Fecha { get; set; }

		public Pago()
		{

		}
	}
}