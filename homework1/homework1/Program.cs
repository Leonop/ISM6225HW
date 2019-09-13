using System;
using System.Collections.Generic;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            selfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        public static void selfDividingNumbers(int x, int y)
        {
            try
            {
                // Write your code here
                IList<int> result = new List<int>();
                for(int i = x; i<= y; i++)
                {
                    //less than 10
                    if(Math.Abs(i)<10)
                    {
                        result.Add(i);
                    }
                    else if(i % 10==0) // last digit equals 0
                    {
                    continue;
                    }
                    else
                    {
                        int value = i;
                        while(value>0)
                        {
                            if(value %10 ==0)
                            {
                                break;
                            }
                            else if(i%(value%10)!=0)
                            {
                                break;
                            }
                            value = value / 10;
                        }
                        if(value ==0)
                        {
                            result.Add(i);
                        }
                    }
                }
                result.foreach (Console.WriteLine) ;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                int i, j = 0;
                // Write your code here
                for (i=1; i<=n; i++)
                {
                    string num = i.ToString();
                    if (j <= n)
                        Console.WriteLine(num);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                int i, j, k = 0;
                // Write your code here
                for ( i=1; i<=n; i++)
                {
                    // Print space
                    for (j = n; j>n+1-i; j--)
                    {
                        Console.Write(" ");
                    };
                    // Print *
                    for(k = 1; k<=2*(n-i)+1; k++)
                    {
                        Console.Write("*");
                    };
                    k = 0;
                    //Print next row
                    Console.WriteLine();
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}
