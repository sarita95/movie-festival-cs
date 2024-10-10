namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
		Console.WriteLine("Enter Festival name:");
		var festival = new Festival(Console.ReadLine());

		Console.WriteLine("Enter Number of movies:");
		int num = Convert.ToInt32(Console.ReadLine());

		List<Movie> movies = new List<Movie>();
		for(int i = 0; i < num; i++)
		{
			movies.Add(CreateMovie());
		}

		var program = CreateProgram();
		program.Movies = movies;

		festival.AddProgram(program);

		Console.WriteLine(festival.GetData());
    }


    public static Movie CreateMovie()
    {
        Console.WriteLine("Enter Movie data:");
        Console.WriteLine("Enter genre:");

		string genre = Console.ReadLine();

		Console.WriteLine("Enter title:");

		string title = Console.ReadLine();

		Console.WriteLine("Enter duration:");
		int length = Convert.ToInt32(Console.ReadLine());

        return new Movie(length, new Genre(genre), title);
	}

	public static Program CreateProgram()
	{
		Console.WriteLine("Enter Program date:");

		DateTime date = Convert.ToDateTime(Console.ReadLine());

		return new Program(date);
	}
}

