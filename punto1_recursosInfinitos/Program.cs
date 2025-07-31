class Program
{
    static void Main()
    {
        int[] nums;
        int requiredSum;

        Console.WriteLine("Ingrese los números del arreglo separados por espacio:");
        nums = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Ingrese la suma requerida:");
        requiredSum = int.Parse(Console.ReadLine()!);

        int count = SearchCombination(nums, requiredSum);

        Console.WriteLine(count == 0
            ? "No se encontró ninguna combinación."
            : $"Se encontraron {count} combinación(es).");
    }

    static int SearchCombination(int[] nums, int requiredSum)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == requiredSum)
                {
                    Console.WriteLine($"{nums[i]} + {nums[j]} = {requiredSum}");
                    count++;
                }
            }
        }
        
        return count;
    }
}
