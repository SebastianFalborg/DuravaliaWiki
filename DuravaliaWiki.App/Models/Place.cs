using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuravaliaWiki.App.Models
{
    public class Place
    {
		public string Name { get; set; }

		public string Description { get; set; }

		public int XStartCoordinate { get; set; }

		public int YStartCoordinate { get; set; }

		public int XEndCoordinate { get; set; }

		public int YEndCoordinate { get; set; }

	}
}
