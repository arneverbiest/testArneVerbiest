using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;


/*
 * 
 */
public class Solution
{
    public static char lostCharNW(string stringSent, string stringRec)
    {
        char answer = '*';

        List<char> sentList = new List<char>();
        List<char> recList = new List<char>();

        if (stringSent.Length > stringRec.Length)
        {
            for (int i = 0; i < stringSent.Length; i++)
            {
                sentList.Add(stringSent[i]);
            }

            for (int i = 0; i < stringRec.Length; i++)
            {
                recList.Add(stringRec[i]);
            }
        }

        List<char> answerList = sentList.Except(recList).ToList();
        answer = answerList[0];

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