using System;
using System.Collections.Generic;
using System.Linq;

namespace homework1
{
    class Program
    {
        /*private static object r5;
        private static object result_array;*/

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
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 8, 9 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            displayArray(r5);

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

                for (int i = x; i <= y; i++)
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
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        result_list.Add(i);
                    }
                }
                // Print the first 5 digits from the list
                for (int k = 0; k < n; k++)
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
                for (i = 1; i <= n; i++)
                {
                    // Print space
                    for (j = n; j > n + 1 - i; j--)
                    {
                        Console.Write(" ");
                    };
                    // Print *
                    for (k = 1; k <= 2 * (n - i) + 1; k++)
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
                int LenOFList = S.Length;
                int count = 0;
                // Write your code here\
                bool[] arr = new bool[LenOFList];
                for (int i = 0; i < LenOFList; i++)
                {
                    for (int j = 0; j < J.Length; j++)
                    {
                        if (J[j] == S[i])
                        {
                            count = count + 1;
                        }
                        else
                        {
                            arr[i] = false;
                        }
                    }
                }

                return count;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }


        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            // Define a result array
            int[] result_array = new int[a.Length];
            try
            {
                Console.WriteLine();
                Console.WriteLine("Question 5: ");
                int len = Math.Max(a.Length, b.Length);
                //Declare the Jagged Array of four elements
                int[][] intArray = new int[a.Length][];
                /*List<List<int>> mylist = new List<List<int>>();*/
                int[] array_nums = new int[a.Length];
                List<int[]> arraylist = new List<int[]>();
                //Create a dictionary to store the arrays and length of arrays
                Dictionary<int, int[]> dict_array = new Dictionary<int, int[]>();
                //Define a list to store the variables of num
                List<int> mylist = new List<int>();
                // Define a maxlist to compare with my list
                List<int> maxlist = new List<int>();


                //Initialize the elements
                int j = 0;
                for (int i = 0; i <= Math.Min(a.Length, b.Length); i++)
                {
                    if (a[i] == b[j])
                    {
                        mylist.Add(a[i]);
                        j++;
                        /* Console.WriteLine(maxlist.Count+" test!!!");*/
                        if (mylist.Count >= maxlist.Count)
                        {
                            maxlist = mylist;
                        }
                        if ((j >= b.Length) || (i >= a.Length))
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (a[i] > b[j])
                        {
                            i--;
                            j++;
                            /*maxlist = mylist;*/
                            mylist = new List<int>();
                            /*Console.WriteLine("Test3");*/
                        }
                        else
                        {
                            /*maxlist = mylist;*/
                            mylist = new List<int>();
                            /*Console.WriteLine("Test3");*/

                        }

                    }
                }
                result_array = maxlist.ToArray();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return result_array;// return the actual array
        }

        public static void displayArray(int[] a)
        {
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
        }

/*        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }*/


        public static void solvePuzzle()
        {
            // Convert integer to string
            /*string uber_string = uber.ToString();*/
            /*Console.WriteLine(uber_string);*/
            int[] uber_array = new int[4];
            int[] cool_array = new int[4];
            int[] uncle_array = new int[5];
            int[] letters_array = new int[8];
     

            //Define a list to store uber and cool
            IList<int> uber_list = new List<int>();
            IList<int> cool_list = new List<int>();
            IList<int> uncle_list = new List<int>();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Question6:");
                /*U, O, C, L, N;*/
                /*                int[] carry = new int[4];
                                string[] letters = new string[8] { "U", "B", "E", "R", "C", "O", "N", "L" };
                                int[] num = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                                int[] num_fix = new int[8]; //Create a list to store the determined variable, because each of them are not equal.*/
                Dictionary<String, int> result = new Dictionary<String, int>();

                int count = 0;
                for (int ubercoln = 1234567; ubercoln <= 98765432; ubercoln++)
                {
                    letters_array = ubercoln.ToString("00000000").Select(c => c - 48).ToArray();
                    bool isUnique = letters_array.Distinct().Count() == letters_array.Count();
/*                    Console.WriteLine(ubercoln+"     "+letters_array[0]+ letters_array[1]+ letters_array[2] + letters_array[3] + letters_array[4] + letters_array[5] + letters_array[6] + letters_array[7]);
*/                    if (isUnique == false)
                    {
                        continue;
                    }
                    uber_list.Add(letters_array[0]);
                    uber_list.Add(letters_array[1]);
                    uber_list.Add(letters_array[2]);
                    uber_list.Add(letters_array[3]);

  
                    cool_list.Add(letters_array[4]);
                    cool_list.Add(letters_array[5]);
                    cool_list.Add(letters_array[5]);
                    cool_list.Add(letters_array[6]);

                    int uber = int.Parse(string.Join(",", uber_list).Replace(",", ""));
/*                    Console.WriteLine(uber+"uber");
*/                    // Convert an array to a list
                    /*cool_list = col_array.ToList();
                    cool_list = cool_list.Insert(1, cool_list[1]);*/
                    int cool = int.Parse(string.Join(",", cool_list).Replace(",", ""));
/*                    Console.WriteLine(cool+"cool");
*/                    // The value based on the iterator
                    uncle_list.Add(letters_array[0]);
                    uncle_list.Add(letters_array[7]);
                    uncle_list.Add(letters_array[4]);
                    uncle_list.Add(letters_array[6]);
                    uncle_list.Add(letters_array[2]);
                    // convert unclelist to integer
                    int uncle = int.Parse(string.Join(",", uncle_list).Replace(",", ""));
/*                    Console.WriteLine(uncle+"uncle");
*/                    int uncle_i = cool + uber;
                    if (uncle_i == uncle)
                    {
                        Console.WriteLine("UBER " + uber +"+" +" COOL " + cool + " =" + " UNCLE " + uncle);
                    }
                    uber_list = new List<int>();
                    cool_list = new List<int>();
                    uncle_list = new List<int>();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }

    }
}