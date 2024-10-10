namespace MovieFestival;

class App
{
    static void Main(string[] args)
    {
        string genre = new Genre("Drama").GetData();
        Console.WriteLine(genre);
    }
}

