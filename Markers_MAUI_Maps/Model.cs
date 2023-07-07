using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markers_MAUI_Maps
{
	public class Model
	{
		public string Country { get; set; }
		public double Population { get; set; }
		public Model(string country, double population)
		{
			Country = country;
			Population = population;
		}
	}
}
