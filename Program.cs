using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, SCITT World! These are some of my favorite things:");
        List<string> favoriteThings = new List<string>
        {
            "Pizza",
            "Beer",
            "Baseball"
        };
      
      string json = JsonConvert.SerializeObject(favoriteThings);
      Console.WriteLine(json);
    }
}