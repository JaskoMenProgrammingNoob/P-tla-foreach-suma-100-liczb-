using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        
        int n = 101;
        int suma = 0;
        int[] dane = new int[n];
        for ( int i = 0; i < n; i++)
        {
            dane[i] = i;

        }
        for ( int i = 0; i < n; i++)
        {
            Console.Write($"{dane[i]}");
            Console.WriteLine();
        }
        

        foreach(int i in dane)
        {
           /* dane[i] += n; */
            suma += dane[i];
        }

        Console.WriteLine($"Suma: {suma}");



    }






}