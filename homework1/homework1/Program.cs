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
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
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
                int len = Math.Max(a.Length,b.Length);
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
                for(int i=0; i <= Math.Min(a.Length, b.Length); i++)
                {
                    if (a[i]==b[j])
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
            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
        }
        



        public static void solvePuzzle()
        {
            // Convert integer to string
            /*string uber_string = uber.ToString();*/
            /*Console.WriteLine(uber_string);*/
            int[] uber_array = new int[4];
            int[] cool_array = new int[4];
            int[] uncle_array = new int[5];

            //Define a list to store uber and cool
            IList<int> uber_list = new List<int>();
            IList<int> cool_list = new List<int>();
            IList<int> uncle_list = new List<int>();

            
            try
            {
                Console.WriteLine();
                Console.WriteLine("Question6:");
                 /*U, O, C, L, N;*/
                int[] carry = new int[4];
                string[] letters = new string[8] { "U", "B", "E", "R", "C", "O", "N", "L" };
                int[] num = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] num_fix = new int[8]; //Create a list to store the determined variable, because each of them are not equal.
                Dictionary<String[], int[]> result = new Dictionary<String[], int[]>();

                int count = 0;
                for (int uber = 123; uber<=9876; uber++)
                {
                    uber_list = uber.ToString("0000").Select(c => c - 48).ToList();

                    // Convert list to array
                    uber_array = uber_list.ToArray();
                    // Create a character common list to remove 
                    IList<int> comm_list = new List<int>();
                    /*comm_list.Add(uber_array[0]);
                    comm_list.Add(uber_array[1]);
                    comm_list.Add(uber_array[2]);
                    comm_list.Add(uber_array[3]);*/
                    comm_list = uber_list;

                    //Check if the common list has duplicate number
                    bool isUnique = uber_list.Distinct().Count() == uber_list.Count();
                    if (isUnique == false||uber_list[0]>1)
                    {
                        continue;
                    }

                    for (int cool = 112; cool<=9887; cool++)
                    {
                        cool_list = cool.ToString("0000").Select(c => c - 48).ToList();
                        
                        if (cool_list[1] != cool_list[2])
                        {
                            continue;
                        }
                        /*bool flag = cool_list.Distinct().Count() == cool_list.Count() - 1;
                        if (flag == false)
                        {
                            continue;
                        }*/
                        /*Console.WriteLine("cool is "+cool+" , uber is " +uber+ "Count is" + count);*/


                        /*if((uber_list.Contains(cool_list[0]))|| (uber_list.Contains(cool_list[1]))|| (uber_list.Contains(cool_list[3])))
                        {
                            continue;
                        }*/

                        //Convert list to array
                        //Create a dictionary to store the arrays and length of arrays
                       /* var dict = new Dictionary<string, int>()
                        {
                            {"U", uber_list[0] },
                            {"B", uber_list[1] },
                            {"E", uber_list[2] },
                            {"R", uber_list[3] },
                            {"C", cool_list[0] },
                            {"O", cool_list[1] },
                            {"L", cool_list[3] }
                        };*/
                        comm_list.Add(cool_list[0]);
                        comm_list.Add(cool_list[1]);
                        comm_list.Add(cool_list[3]);

                        /*isUnique = comm_list.Distinct().Count() == comm_list.Count();
                        // if the common list is not unique, then break
                        if (isUnique == false)
                        {
                            continue;
                        }*/

                        int uncle = cool + uber;
                        /*                        Console.WriteLine("count is "+count+" "+uncle + " vs "+dict["U"]+"?"+dict["C"]+dict["L"]+dict["E"]);
                        */
                        uncle_list = uncle.ToString("00000").Select(c => c - 48).ToList();
                        // if there is any duplicate number is the comm_list, go to next loop
                        comm_list.Add(uncle_list[1]);

                        if (comm_list.Distinct().Count() != comm_list.Count())
                        {
                            continue; 
                        }
                        Console.WriteLine("U " + uncle_list[0] + ",N " + uncle_list[1] + ",C " + uncle_list[2] + ",L " + uncle_list[3] + ",E " + uncle_list[4]);
                        Console.WriteLine("U " + uber_list[0] + ", B " + uber_list[1] + ", E " + uber_list[2] + ", R " + uber_list[3] + ", C" + cool_list[0] + ", O" + cool_list[1] + ", L" + cool_list[3] + ", N" + uncle_list[1]);
                        Console.WriteLine(count);

                        /*uncle_array = uncle_list.ToArray();*/
                        // if N is duplicated with the other numbers, go to next loop
                        /*  if (comm_list.Contains(uncle_list[1]))
                          {
                              continue;
                          }*/

                        /*if ((uncle_array[0] == dict["U"]) && (uncle_array[2] == dict["C"]) && (uncle_array[3] == dict["L"]) && (uncle_array[4] == dict["E"]) && (isUnique == true))
                        {
                            Console.WriteLine("UBER: " + uber + ", COOL: " + cool + ", UNCLE: " + uncle);
                        }*/
                        /*                        Console.WriteLine("U " + uber_list[0] + ", B " + uber_list[1] + ", E " + uber_list[2] + ", R " + uber_list[3] + ", C" + cool_list[0] + ", O" + cool_list[0] + ", L" + cool_list[3]);
                        */
                        if ((uncle_array[0] == uber_list[0]) && (uncle_array[2] == cool_list[0]) && (uncle_array[3] == cool_list[3]) && (uncle_array[4] == uber_list[2]))
                        {
                            Console.WriteLine("UBER: " + uber + ", COOL: " + cool + ", UNCLE: " + uncle);
                        }
                        /*dict = new Dictionary<string, int>();*/
                        comm_list = new List<int>();
                        count++;

                    }

                }

               
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }

    }
}



