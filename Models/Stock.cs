using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace GroupRazorPagesVideoGame.Models
{
	public class Stock
	{
		public int ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
	}
}
