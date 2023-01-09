using System;


/*
 * 
 */
public class Solution
{
    public static int busRemaining(int[,] busStation)
    {
        int answer = 0;
        // Write your code here


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
        Console.Write(result);

    }
}
