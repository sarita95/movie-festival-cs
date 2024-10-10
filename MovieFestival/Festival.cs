using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFestival
{
	internal class Festival
	{
		public string Name { get; set; }
		public List<Program> Programs { get; set; }

		public Festival(string name) 
		{
			Name = name;
			Programs = new List<Program>();
		}

		public void AddProgram(Program program)
		{
			Programs.Add(program);
		}

		public string GetData()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(Name.ToString());

			int numOfMovies = 0;
			foreach (Program program in Programs)
			{
				numOfMovies += program.Movies.Count;
				sb.AppendLine(program.GetData());
			}

			sb.AppendLine("Num of movies: " + numOfMovies.ToString());

			return sb.ToString();
		}
	}
}
