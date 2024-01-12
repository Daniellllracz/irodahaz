using System.Text;

namespace irodahaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StreamReader> irodaHaz = new();
            using StreamReader sr = new(@"..\..\..\src\irodahaz.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) irodaHaz.Add(new(sr.ReadLine()));
            sr.Close();

            irodaHaz.ForEach(i => Console.WriteLine(i) );


        }
    }
}
