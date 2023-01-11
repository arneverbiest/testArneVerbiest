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
        //declaratie van lijsten.
        char answer = '*';
        List<char> sentList = new List<char>();
        List<char> recList = new List<char>();


        //checken of input hetzelfde is.
        if (stringSent != stringRec)
        {
            //stringSent in lijst zetten
            for (int i = 0; i < stringSent.Length; i++)
            {
                sentList.Add(stringSent[i]);
            }


            //stringRec in lijst zetten.
            for (int i = 0; i < stringRec.Length; i++)
            {
                recList.Add(stringRec[i]);
            }


            //controle of recList of SentList het grootste is.
            if (recList.Count < sentList.Count)
            {

                //kleinste lijst aftrekken van de grotere lijst. waardoor we de uitkomst bekomen.
                List<char> answerList = sentList.Except(recList).ToList();
                answer = answerList[0];
            }


            //controle of recList of SentList het grootste is.
            else if (recList.Count > sentList.Count)
            {

                //kleinste lijst aftrekken van de grotere lijst. waardoor we de uitkomst bekomen.
                List<char> answerList = recList.Except(sentList).ToList();
                answer = answerList[0];
            }


            //antwoord als de input hetzelfde is.
            else
            {
                Console.WriteLine("NA"); 
            }


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