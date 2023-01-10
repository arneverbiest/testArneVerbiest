using System;
using System.Diagnostics.CodeAnalysis;


/*
 * 
 */
public class Solution
{
    public static char lostCharNW(string stringSent, string stringRec)
    {
        char answer = '*';
        char[] array1 = new char[stringSent.Length];
        char[] array2 = new char[stringRec.Length];



        for (int i = 0; i < stringSent.Length; i++)
        {
            array1[i] = stringSent[i];
        }
        for (int i = 0; i < stringRec.Length; i++)
        {
            array2[i] = stringRec[i];
        }

        Console.WriteLine("array1");
        foreach (var c in array1)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("array2");
        foreach (var d in array2)
        {
            Console.WriteLine(d);
        }
        



        return answer;
        
    }

    public static void Main(string[] args)
    {
        string[] input;
        //input for stringSent
        string stringSent = (Console.ReadLine());

        //input for stringRec
        string stringRec = (Console.ReadLine());


        char result = lostCharNW(stringSent, stringRec);
        Console.Write(result);

    }
}
