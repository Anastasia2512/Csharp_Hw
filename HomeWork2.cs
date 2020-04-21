using System;

namespace homeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1
               int numOfRow;
                do
                {
                    Console.WriteLine("Enter a number between 3 -9 :");
                    numOfRow = Convert.ToInt32(Console.ReadLine());
                } while (numOfRow < 3 || numOfRow > 9);

                int[][] matrix = new int[numOfRow][];
                int x = 1;
                  for (int row = 0; row < matrix.Length; row++, x++)
                   {
                       matrix[row] = new int[row + 1];
                       for (int col = 0; col < matrix[row].Length; col++)
                       {
                           matrix[row][col] = x;
                       }
                   }
                  foreach (int[] row in matrix)
                   {
                    foreach (int col in row)
                    {

                        Console.Write(col + " ");
                    }

                    Console.WriteLine();
                }

                //q2
                string[] arr = new string[] { "Anastasia", "Rahel", "David" };
                for(int i=0; i<arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                foreach (string col in arr)
                {
                        Console.Write($"{col}"+ " ");

                }


                //q3
                int[][] Matrix = new int[4][];

                    Matrix[0] = new int[] { 1, 2, 3 };
                    Matrix[1] = new int[] { 4, 5, 6 };
                    Matrix[2] = new int[] { 7, 8, 9 };
                    Matrix[3] = new int[] {10,11,12 };

                for (int row=0; row < Matrix.Length; row++)
                {
                    for (int col = 0; col < Matrix[row].Length; col++)
                    {
                        Console.Write($"[ {Matrix[row][col]}]");
                    }
                    Console.WriteLine();
                }

                foreach(int[] row in Matrix)
                {
                    foreach(int col in row)
                    {
                        Console.Write($"[{col}]");
                    }
                    Console.WriteLine();
                }

                //q4
                int age;
                do
                {
                    Console.WriteLine("Please enter your age:");
                    age = Convert.ToInt32(Console.ReadLine());
                } while (age < 0 || age > 120);

                //q5
                int numOfRow;
                do
                {
                    Console.WriteLine("choose a number between 2-5 :");
                    numOfRow = Convert.ToInt32(Console.ReadLine());
                } while (numOfRow < 2 || numOfRow > 5);

                bool[][] matrix = new bool[numOfRow][];
                bool x = true;
                bool y = false;
                  for (int row = 0; row < matrix.Length; row++ )
                   {
                       matrix[row] = new bool[row + 1] ;
                       for (int col = 0; col < matrix[row].Length; col++)
                       {
                        if (row % 2 == 0)
                        {
                            matrix[row][col] = x;
                        }
                        else
                            matrix[row][col] = y;

                        }
                   }

                foreach (bool[] row in matrix)
                   {
                    foreach (bool col in row)
                    {

                        Console.Write(col + " ");
                    }

                    Console.WriteLine();
                }

            //q Matrix
            string[][] str = new string[3][]{ new string[] { "", "", "" }, new string[] { "", "", "" }, new string[] { "", "", "" } };
            for (int row = 0; row < str.Length; row++)
            {
                   for (int col = 0; col < str[row].Length; col++)
                   {
                       if (row==col)
                       {
                        str[row][col] = "main";
                       }
                       else if(row+col == str.Length -1)
                       {
                        str[row][col] = "sub";
                       }
                       else if(row + col == str.Length-1  && row == col)
                       {
                        str[row][col] = "center";
                       }
                       else if(row < col)
                       {
                        str[row][col] = "up";
                       }
                       else 
                       {
                        str[row][col] = "down";

                       }
                   }
                }
                foreach (string[] row in str)
               {
                foreach (string col in row)
                {
                    Console.Write($"[{col}]");
                }
                Console.WriteLine();
                }



        }
    }
}
