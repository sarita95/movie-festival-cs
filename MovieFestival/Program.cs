using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	internal class Program
	{ 
		public DateTime Date { get; set; }
		public List<Movie> Movies { get; set; }

		public Program(DateTime date)
		{
			Date = date;
			Movies = new List<Movie>();
		}

		public void AddMovie(Movie movie)
		{		
			Movies.Add(movie); 
		}

		public string GetData()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Date.ToString());

			int length = 0;
			foreach (Movie movie in Movies)
			{
				length += movie.Length;
				sb.AppendLine(movie.GetData());
			}

			sb.AppendLine("Duration: " + length.ToString());

			return sb.ToString();
		}
	}
}
