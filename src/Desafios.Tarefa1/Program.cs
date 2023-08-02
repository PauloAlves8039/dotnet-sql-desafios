internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayNumber = { 7, 5, 3, 9, 6, 4, 1 };

        Console.Write("\nLista original: ");
        PrintArrayConsole(arrayNumber);

        ChangeElement(arrayNumber);

        arrayNumber = RemoveElement(arrayNumber, 4);

        Console.Write("\nNova lista: ");
        PrintArrayConsole(arrayNumber);

        Console.Write("\nSoma dos valores da nova lista: " + SumAllElements(arrayNumber));

        Console.ReadLine();
    }

    private static int[] RemoveElement(int[] array, int valueToRemove)
    {
        var count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != valueToRemove)
            {
                array[count++] = array[i];
            }
        }

        Array.Resize(ref array, count);
        
        return array;
    }

    private static int[] ChangeElement(int[] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 9)
            {
                array[i] = 5;
            }
        }

        return array;
    }

    private static int SumAllElements(int[] array) 
    {
        var sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    private static void PrintArrayConsole(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}