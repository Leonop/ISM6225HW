using System;
using System.Collections.Generic;
/*using System.Range;*/

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
                if (y < x)
                    Console.Write(result);

                for (int i = x; i<=y; i++)
                {
                    if (Program.isSelfDividingNumber(i))
                        result.Add(i);
                }
                Console.Write("Question1" + "\n");
                foreach (var item in result)
                {
                    Console.Write(item + ",");
                }
                Console.WriteLine("\n");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
        
        public static bool isSelfDividingNumber(int n)
        {
            bool flag = true;
            int original = n;
            int r = 0;
            while (n > 0)
            {
                r = n % 10;
                if (r != 0 && (original % r != 0))
                {
                    flag = false;
                    return flag;
                }
                else if (r == 0)
                    return false;
                n = n / 10;
            }
            return flag;
        }

        public static void printSeries(int n)
        {
            try
            {
                Console.Write("Question2 \n");
                int i, j = 0;
                // Write your code here
                // Use next for loop to generate the list of digits
                IList<int> result_list = new List<int>();
                for (i=1; i<=n; i++)
                {
                    for (j=1; j<=i; j++)
                    {
                        result_list.Add(i);
                    }
                }
                // Print the first 5 digits from the list
                for (int k = 0; k<n; k++)
                {
                    Console.WriteLine(result_list[k]);
                }
                Console.WriteLine(); // start from a new line for the question3
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
                Console.WriteLine("Question3");
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
                Console.WriteLine("Question4");
                // Get the length of list
                int LenOFList = Math.Max(J.Length, S.Length);
                int count = 0; 
                // Write your code here\
                bool[] arr = new bool[LenOFList];
                for (int i = 0; i < LenOFList; i++)
                {
                    foreach (var item in J)
                    {
                        if (item == S[i])
                        {
                            arr[i] = true;
                        }
                        else
                        {
                            arr[i] = false;
                        }
                    }
                    if (arr[i] == true)
                    {
                        count = count + 1;
                    }
                }
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n test"+S[0:5]);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }
  /*      public static int[] arraySlice(int[] arr, int a, int b)
        {
            for (int i=0; i<Math.Max(a,b); i++)
            {
                arr[i]
            }
        }*/



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
