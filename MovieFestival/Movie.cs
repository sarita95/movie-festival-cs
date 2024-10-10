using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	internal class Movie
	{
		public int Length { get; set; }
		public Genre Genre { get; set; }
		public string Title { get; set; }

		public Movie(int length, Genre genre, string title)
		{
			Length = length;
			Genre = genre;
			Title = title;
		}

		public string GetData()
		{
			string movie = Title + Length.ToString() + Genre.GetData();
			return movie;
		}
	}
}
