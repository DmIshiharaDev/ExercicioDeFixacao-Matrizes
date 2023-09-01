internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---- Construindo Matrizes ----");
        Console.WriteLine("------------------------------");

        Console.WriteLine();
        Console.Write("Quantas linhas e colunas você quer criar na matriz? ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Digite três valores inteiros dando um espaço entre eles:");
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }
    }
}