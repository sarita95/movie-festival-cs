namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
        var program = new Program(DateTime.Now);

        program.AddMovie(new Movie(55, new Genre("Drama"), "Title 1"));
        program.AddMovie(new Movie(60, new Genre("Triler"), "Title 2"));
		Console.WriteLine(program.GetData());
    }


    public Movie CreateMovie()
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

	public Program CreateProgram()
	{
		Console.WriteLine("Enter Program date:");

		DateTime date = Convert.ToDateTime(Console.ReadLine());

		return new Program(date);
	}
}

