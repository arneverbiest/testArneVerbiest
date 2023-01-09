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
        if (stringSent != stringRec)
        {
            for (int i = 0; i < stringSent.Length; i++)
            {
                if (stringSent.Length < stringRec.Length)
                {
                    Console.WriteLine(stringSent.LastIndexOf(stringSent));
                }

                /*
                                if (stringSent[i] != stringRec[i])
                                {
                                    Console.WriteLine(stringRec[i]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("the output is the same");
                        }
                 */


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
