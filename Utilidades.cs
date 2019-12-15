using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SegundoParcialO2A2
{
	public static class Utilidades
	{
		public static void ShowToastr(Page page, string message, string title, string type = "info")
		{
			page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message",
				  String.Format("toastr.{0}('{1}', '{2}');", type.ToLower(), message, title), addScriptTags: true);
		}
	}
}