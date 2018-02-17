using System;

namespace MovieTheatre
{
    class Tickets
    {
        public void Seating()
        {
            int[][] row = new int[5][];

            row[0] = new int[8] { 1, 0, 0, 1, 0, 1, 1, 1 };
            row[1] = new int[7] { 1, 1, 0, 1, 1, 1, 0 };
            row[2] = new int[6] { 1, 0, 0, 1, 0, 0 };
            row[3] = new int[5] { 1, 0, 1, 1, 1 };
            row[4] = new int[4] { 1, 0, 1, 0 };

            //row[5] = new int[5] { 1, 0, 1, 1, 0 };
            //row[6] = new int[5] { 1, 0, 0, 1, 0 };
            //row[7] = new int[5] { 1, 1, 0, 1, 1 };
            //row[8] = new int[5] { 1, 0, 0, 1, 0 };
            //row[9] = new int[5] { 1, 1, 1, 1, 1 };

            int[] count = new int[5];
            Console.WriteLine(count.Rank);
            Console.WriteLine(count.GetLowerBound(0));
            Console.WriteLine( count.GetUpperBound(0));

            for (int i = 0; i < row.Length; i++)
            {
                Console.Write("row({0}): ", i + 1);
                for (int j = 0; j < row[i].Length; j++)
                {
                    Console.Write("{0} ", row[i][j]);
                }
                Console.WriteLine();
            }

            //int n=0;
            //Console.WriteLine(count.GetUpperBound(n));

            int SeatsFilled = 0,totalSeats = 0;
            for (int i = 0; i < row.Length; i++)
            {
                for (int j = 0; j < row[i].Length; j++)
                {
                    if (row[i][j] == 1)
                    {
                        count[i]++;   
                    }           
                }
                totalSeats = totalSeats + row[i].Length;
                SeatsFilled = SeatsFilled + count[i];
                Console.WriteLine("\nseats filled in row {0} : {1}", i + 1, count[i]);
            }         
            Console.WriteLine("\nTotal number of seats filled in theatre are:{0}", SeatsFilled);
            Console.WriteLine("\nTotal number of empty seats are: {0}",totalSeats-SeatsFilled);
            Console.ReadLine();
        }
    }
}
