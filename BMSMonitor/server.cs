using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace BMSMonitor
{
	class Server
	{
#if false
		public static string strSrvName;
		public static string strSrvID;
		public static string strSrvPass;
		public static string strconn;

		//string strconn = "Server=" + strSrvName + ";Database=bms_manufacturer;Uid=" + strSrvID + ";Pwd=" + strSrvPass + ";CharSet=utf8;";

		public static MySqlConnection con = null;
		public static MySqlCommand cmd = null;


		public void Init(string name, string id, string pass)
		{
			strconn = "Server=" + strSrvName + ";Database=bms_manufacturer;Uid=" + strSrvID + ";Pwd=" + strSrvPass + ";CharSet=utf8;";
		}
#endif
	}
}
