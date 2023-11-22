using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Libriary.Utils;
public class JsonService
{
	private class Json
	{
		public string DBConnect { get; set; }
	}

	public static string GetConnectionString()
	{
		string connection = string.Empty;
		using(StreamReader stream = new StreamReader(Environment.CurrentDirectory + @"\Utils\Config.json"))
		{
			var json = stream.ReadToEnd();
			var file = JsonConvert.DeserializeObject<Json>(json);
			connection = file.DBConnect;
		}

		return connection;
	}
}
