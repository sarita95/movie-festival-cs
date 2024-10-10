using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	internal class Genre
	{
		public string Name { get; set; }

		public Genre(string name) 
		{ 
			Name = name;
		}

		public string GetData() 
		{
			string genre = Name[0] + Name[Name.Length - 1].ToString().ToUpper();
			return genre;
		}
	}
}
