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
}

