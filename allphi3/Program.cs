using System;
using System.Diagnostics.Metrics;
using System.Xml;


public class Solution
{
    public static int busRemaining(int[,] busStation)
    {
        //declaratie
        int answer = 0;
        int counter = 1;

        //elke waarde tellen
        for (int i = 1; i < busStation.GetLength(0); i++)
        {

            //totaal aantal busroutes optellen
            counter++;
            //controleren of busroutes overlappen
            if ((busStation[i, 1] >= busStation[i - 1, 1]) && (busStation[i,0] <= busStation[i-1, 1]))
            {
                answer++;
            }
        }

        //totaal aantal busroutes aftrekken van de overlappende
        answer = counter - answer;

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
        Console.WriteLine($"the remaining routes are {result}");
        Console.Write(result);

    }
}
