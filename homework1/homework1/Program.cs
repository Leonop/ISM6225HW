using System;
using System.Collections.Generic;
using System.Linq;

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
                   /* foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }*/
                }
                Console.WriteLine(count);
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
                Console.WriteLine("Question 5: ");
                int Len = Math.Min(a.Length, b.Length);
                int[] window_len = new int[Len];
                for (int i= Len; i>=1; i--)
                {
                    

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }
/*
        public static int find(int[] a, int[] b)
        {
            int [,] array2D = new int[a.Length, b.Length];
            IList<int> result_list = new List<int>();
            int max_len = 0;
            for (int i = 1; i <= a.Length; i++)
            {
                for(int j=1; j<=b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        array2D[i, j] = 1;

                    }
                    else
                    {
                        array2D[i, j] = 0;
                    }
                }
            }
            
            for (int i = 1; i<=a.Length; i++)
            {
                for (int j =1; j<=b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        for(int k=1; k <= a.Length - i; k++)
                        {
                            if (a[i + k] == b[j + k])
                            {
                                count++;
                                max_len = count;
                                result_list.Add(a[i]);
                            }
                        } 
                        
                        
                    }
                    else
                    {

                    }
                }
            }
        }*/


        public static void solvePuzzle()
        {
            try
            {
                Console.WriteLine("Question6:");
                int U=1, C, L, N;
                int[] carry = new int[4];
                int[] num = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] num_fix = new int[8]; //Create a list to store the determined variable, because each of them are not equal.
 
                foreach(int E in num)
                {
                    num_fix[0]=U; // follow the pattern of UBERCOLN
                    num_fix[2]=E;
                    foreach(int R in num.Except(num_fix))
                    {
                        num_fix[3]=R;
                        if (E>R) // if E>R means R+L<9, so L=E-R
                        {
                            carry[0] = 0;
                            L = E - R;
                            int O = L - E; // carry is 0, so L == O+E
                            if ((!num_fix.Contains(L))&&(!num_fix.Contains(O))) // Add L and O to the list to make sure there are not duplicated numbers
                            {
                                num_fix[6]=L; 
                                num_fix[5]=O;
                            }
                            
                            foreach(int B in num.Except(num_fix)) // In the for loop of B from 1 to 9 but not same as the fixed number in num_fix
                            {
                                num_fix[1] = B;
                                if ((B + O >= 10)&&num.Contains(O)) // B+O is above 10 and O in (0,9)
                                {
                                    C = B + O - 10;
                                    if (num.Contains(C)&&!num_fix.Contains(C)) //C is not duplicated with the other numbers and it is in the range of (0,9)
                                    {
                                        num_fix[4]=C;
                                        N = U + C + 1;
                                        if (num.Contains(N) && !num_fix.Contains(N))
                                        {
                                            num_fix[7]=N;
                                            Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                            Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                            Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                        }
                                    }
                                }
                                else
                                {
                                    C = B + O;
                                    N = U + C-10; //U+C must be above 10. So the U has to be 1 and N equals to U+C-10
                                    if(num.Contains(C) && (!num_fix.Contains(C))&& num.Contains(N) && !num_fix.Contains(N))
                                    {
                                        num_fix[4]=C;
                                        num_fix[7]=N;
                                        Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                        Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                        Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                    }
                                    
                                }
                                
                            }
                        }
                        else
                        {
                            int O; // E<R
                            L = 10 + E - R; // L+R>10 then carry[0]=1
                            carry[0] = 1;
                            if (E < L)
                            {
                                O = L - carry[0] - E; // E+O+1=L carry[1]==0
                                if (num.Contains(L) && !num_fix.Contains(L) && num.Contains(O) && !num_fix.Contains(L))
                                {
                                    num_fix[6]=L;
                                    num_fix[5]=O;
                                }
                                foreach(int B in num.Except(num_fix))
                                {
                                    num_fix[1]=B;
                                    if ((B + O > 10)&& num.Contains(O))
                                    {
                                        C = B + O - 10;
                                        carry[2] = 1;
                                        if (num.Contains(C) && !num_fix.Contains(C)) //C is not duplicated with the other numbers and it is in the range of (0,9)
                                        {
                                            num_fix[4]=C;
                                            N = U + C + carry[2]-10;
                                            if (num.Contains(N) && !num_fix.Contains(N))
                                            {
                                                num_fix[7]=N;
                                                Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                                Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                                Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        C = B + O;
                                        N = U + C - 10; //U+C must be above 10. So the U has to be 1 and N equals to U+C-10
                                        if (num.Contains(C) && (!num_fix.Contains(C)) && num.Contains(N) && !num_fix.Contains(N))
                                        {
                                            num_fix[4] = C;
                                            num_fix[7] = N;
                                            Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                            Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                            Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                        }
                                    }
                                }
                            }
                            else
                            {   //E>L
                                L=E-R;
                                if (num.Contains(L) && !num_fix.Contains(L))
                                {
                                    num_fix[6] = L;
                                }
                                carry[0] = 0;
                                O = 10 + L - carry[0] - E; // L+R<10 but E+O>=10
                                if (num.Contains(O) && !num_fix.Contains(O))
                                {
                                    num_fix[5] = L;
                                }
                                carry[1] = 1;
                                foreach(int B in num.Except(num_fix))
                                {
                                    num_fix[1] = B;
                                    if ((B + O > 10) && num.Contains(O))
                                    {
                                        C = B + O - 10;
                                        carry[2] = 1;
                                        if (num.Contains(C) && !num_fix.Contains(C)) //C is not duplicated with the other numbers and it is in the range of (0,9)
                                        {
                                            num_fix[4] = C;
                                            N = U + C + carry[2]-10;
                                            if (num.Contains(N) && !num_fix.Contains(N))
                                            {
                                                num_fix[7] = N;
                                                Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                                Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                                Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        C = B + O;
                                        N = U + C - 10; //U+C must be above 10. So the U has to be 1 and N equals to U+C-10
                                        if (num.Contains(C) && (!num_fix.Contains(C)) && num.Contains(N) && !num_fix.Contains(N))
                                        {
                                            num_fix[4] = C;
                                            num_fix[7] = N;
                                            Console.WriteLine(U + " " + B + " " + E + " " + " " + R);
                                            Console.WriteLine(C + " " + O + " " + " " + O + " " + L);
                                            Console.WriteLine(U + " " + N + " " + C + " " + L + " " + E);
                                        }

                                    }

                                }

                            }
                        }
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
