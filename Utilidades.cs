using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SegundoParcialO2A2
{
	public static class Utilidades
	{
		public static void ShowToastr(Page page, string message, string title, string type = "info")
		{
			page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
				  String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
		}

		public static DateTime ToDatetime(this object obj)
		{
			DateTime.TryParse(obj.ToString(), out DateTime value);
			return value;
		}
		static readonly string FECHA_FORMAT = "yyyy-MM-dd";
		public static string ToFormatDate(this DateTime dateTime)
		{
			return dateTime.ToString(FECHA_FORMAT);
		}

		public static int ToInt(this object obj)
		{
			if (obj == null)
				return 0;
			int.TryParse(obj.ToString(), out int value);
			return value;
		}
		public static Decimal ToDecimal(this object obj)
		{
			Decimal.TryParse(obj.ToString(), out Decimal value);
			return value;
		}
		public static void ShowModal(System.Web.UI.Page page, string NombreModal, string Titulo)
		{
			ScriptManager.RegisterStartupScript(page, page.GetType(), "Popup", $"{NombreModal}('{ Titulo }');", true);
		}

	}
}