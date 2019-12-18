using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SegundoParcialO2A2.DAL
{
	public class Contexto : DbContext
	{
		public Contexto() : base("ConStr")
		{

		}
	}
}