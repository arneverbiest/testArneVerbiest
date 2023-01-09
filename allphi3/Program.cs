using System;
using System.Xml;


/*
 * 
 */
public class Solution
{
    public static int busRemaining(int[,] busStation)
    {

        int answer = 0;






        for (int i = 1; i < busStation.GetLength(0); i++)
        {
            if (busStation[i, 1] >= busStation[i - 1, 1])
            {
                Console.WriteLine($"{busStation[i, 1]} >= {busStation[i - 1, 1]}");
                if (busStation[i, 0] <= busStation[i - 1, 1])
                {
                    Console.WriteLine($"{busStation[i, 0]} <= {busStation[i - 1, 1]}");
                    answer++;

                }
            }
        }
        return answer;
    }

    public static void Main(string[] args)
    {
        string[] input;
        //input for busStation
        input = Console.ReadLine().Split(' ');
        int busStation_row = int.Parse(input[0]);
        int busStation_col = int.Parse(input[1]);
        int[,] busStation = new int[busStation_row, busStation_col];
        for (int idx = 0; idx < busStation_row; idx++)
        {
            input = Console.ReadLine().Split(' ');
            for (int jdx = 0; jdx < busStation_col; jdx++)
            {
                busStation[idx, jdx] = int.Parse(input[jdx]);
            }
        }




        int result = busRemaining(busStation);
        Console.WriteLine($"there will be {result} bus routes less");
        Console.Write(result);

    }
}
