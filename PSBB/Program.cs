using System;

public class Program
{
    public string minimunBus(int firstInput, string secondInput)
    {
        string result = "";
        int containerResult = 0;
        string[] members = secondInput.Split(' ');
        
        if (members.Length != firstInput)
        {
            return "Input must be equal with count of family";
        }

        int[] familySizes = Array.ConvertAll(members, int.Parse);
        Array.Sort(familySizes);
        Array.Reverse(familySizes);
        
        bool[] used = new bool[firstInput];
        
        for (int i = 0; i < firstInput; i++)
        {
            if (used[i]) continue;
            int currentBusCapacity = familySizes[i];
            used[i] = true;
            
            for (int j = i + 1; j < firstInput; j++)
            {
                if (!used[j] && currentBusCapacity + familySizes[j] <= 4)
                {
                    currentBusCapacity += familySizes[j];
                    used[j] = true;
                    if (currentBusCapacity == 4) break;
                }
            }
            
            containerResult++;
        }

        result = containerResult.ToString();
        return result;
    }

    public static void Main()
    {
        Console.Write("Input the number of families : ");
        string input = Console.ReadLine();
        int firstInput = int.Parse(input);

        Console.Write("Input the number of members in the family (separated by a space) : ");
        string secondInput = Console.ReadLine();

        string result = new Program().minimunBus(firstInput, secondInput);

        Console.WriteLine(result);
    }
}
