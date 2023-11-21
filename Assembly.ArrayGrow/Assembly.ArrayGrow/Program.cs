using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static string[] Arr = new string[3];
    public static int current = 0;

    public static void GrowArr()
    {
        int arraysize = Arr.Length * 2;
        int loopcounter = Arr.Length;

        string[] Arr2 = new string[arraysize];

        for (int i = 0; i < loopcounter; i++)
        {
            Arr2[i] = Arr[i];
        }
        Arr = Arr2;
    }
    public static void Main()
    {
        do
        {
            Console.WriteLine("Enter the value:");
            
            string value = Console.ReadLine();

            if (current > Arr.Length - 1)
            {
                GrowArr();
            }
            Arr[current] = value;
            current++;

        } while (true);
    }
}