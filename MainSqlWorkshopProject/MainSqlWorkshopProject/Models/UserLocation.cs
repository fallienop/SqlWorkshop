using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSqlWorkshopProject.Models
{
	internal class UserLocation
	{
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Postcode { get; set; }
		public string Coordinates { get; set; }
	//	public string Timezone { get; set; }
		public string Country { get; set; }
	}
}
