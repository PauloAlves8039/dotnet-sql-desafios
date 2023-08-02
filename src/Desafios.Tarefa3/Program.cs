internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int targetSum = int.Parse(Console.ReadLine());

        int[] inputArray = { 2, 7, 11, 15 };
       
        int[] result = FindIndexesToSum(inputArray, targetSum);

        if (result.Length == 2)
        {
            var i = result[0];
            var j = result[1];

            Console.Write("\nSoma da entrada: " + targetSum);
            Console.Write("\n" + targetSum + " é a soma de " + inputArray[i] + " + " + inputArray[j]);
            Console.Write("\n" + inputArray[i] + " + " + inputArray[j] + " são os números encontrados no array de entrada!");
        }
        else
        {
            Console.WriteLine("Nenhuma solução encontrada!");
        }

        Console.ReadLine();
    }

    private static int[] FindIndexesToSum(int[] array, int targetSum)
    {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            var complement = targetSum - array[i];

            if (indexMap.ContainsKey(complement) && indexMap[complement] != i)
            {
                return new int[] { indexMap[complement], i };
            }

            indexMap[array[i]] = i;
        }

        return new int[0];
    }
}