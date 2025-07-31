class Program
{
    static void Main()
    {
        int[] nums;

        Console.WriteLine("Ingrese los números del arreglo separados por espacio:");
        string? input = Console.ReadLine();

        try
        {
            nums = (input ?? throw new Exception()).Split(' ').Select(int.Parse).ToArray();
        }
        catch
        {
            Console.WriteLine("Error: Entrada inválida. Ingrese números enteros separados por espacio.");
            return;
        }

        Console.WriteLine("Ingrese la suma requerida:");
        if (!int.TryParse(Console.ReadLine(), out int requiredSum))
        {
            Console.WriteLine("Error: suma requerida inválida.");
            return;
        }

        if (!SearchCombination(nums, requiredSum))
            Console.WriteLine("No se encontró ninguna combinación.");
    }

    static bool SearchCombination(int[] nums, int requiredSum)
    {
        var seen = new HashSet<int>();

        foreach (int num in nums)
        {
            int complement = requiredSum - num;
            if (seen.Contains(complement))
            {
                Console.WriteLine($"{complement} + {num} = {requiredSum}");
                return true; // Finaliza en la primera combinación que encuentra
            }
            seen.Add(num);
        }

        return false;
    }
}
