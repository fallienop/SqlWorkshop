using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSqlWorkshopProject.Models
{
	internal class UserLogin
	{
		public string Uuid { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Salt { get; set; }
		public string Md5 { get; set; }
		public string Sha1 { get; set; }
		public string Sha256 { get; set; }
		//public string LoginEmail { get; set; }
		public DateTime Registerdate { get; set; }
		public int Registered_duration { get; set; }
	}
}
