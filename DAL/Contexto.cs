using SegundoParcialO2A2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SegundoParcialO2A2.DAL
{
	public class Contexto : DbContext
	{
		public DbSet<Pago> Pagos { get; set; }
		public Contexto() : base("ConStr")
		{

		}
	}
}