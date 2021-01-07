using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*
         *  Given an array of n distinct integers, and an integer threshold, t, how many (a,b,c) index triplets
         *exist that satisfy both of the  following condiitons?

         *d[a] < d[b] < d[c]
         *d[a] + d[b] + d[c] <= t

         *Example
         *d = [1, 2, 3, 4, 5]
         *t = 8

         *The following 4 triplets satisfy the constraints:
         *(1, 2, 3)-> 1 + 2 + 3 = 6 <= 8
         *(1, 2, 4)-> 1 + 2 + 4 = 7 <= 8
         *(1, 2, 5)-> 1 + 2 + 5 = 8 <= 8
         *(1, 3, 4)-> 1 + 3 + 4 = 8 <= 8

         *output: 4
        */
        List<int> d = new List<int>() { 1, 2, 3, 4, 5 };
        long t = 8;
        Console.Write("d = [");
        for (int i = 0; i < d.Count; i++)
        {
            Console.Write(d[i]);
            if (i!=d.Count-1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        Console.WriteLine("t = "+t);
        Console.WriteLine();
        Console.WriteLine("\nAnswer: " + triplets(t, d));
    }

    public static long triplets(long t, List<int> arr)
    {
        arr.Sort();
        long answer = 0;
        int n = arr.Count;
        bool reset = false;
        int a = 0, b = 1,c = 2;
        while (true)
        {
            
            if (arr[a] + arr[b] + arr[c] <= t)
            {
                Console.WriteLine($"({arr[a]},{arr[b]},{arr[c]}) -> {arr[a]} + {arr[b]} + {arr[c]} = {arr[a]+ arr[b]+ arr[c]} <= {t}");
                answer++;
                reset = false;
            }
            else if (!reset)
            {
                reset = true;
                c = n - 1;
            }
            else
                break;

            c++;            
            if (c == n)
            {
                b++;

                if (b == n - 1)
                {
                    a++;

                    if (a == n - 2)
                        break;

                    b = a + 1;
                    reset = true;
                }
                c = b + 1;
            }
        }
        return answer;
    }

}
    