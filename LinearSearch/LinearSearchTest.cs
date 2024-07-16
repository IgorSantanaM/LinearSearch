using System;

public class LinearSearchTest
{
    public static void Main(string[] args)
    {
        int searchInt; // search key
        int position; // location of search key in array

        // Create array and output it
        LinearArray searchArray = new LinearArray(10);
        Console.WriteLine(searchArray); // display array

        // Input first int from user
        Console.Write("Please enter an integer value (-1 to quit): ");
        searchInt = Convert.ToInt32(Console.ReadLine());

        // Repeatedly input an integer; -1 terminates the app
        while (searchInt != -1)
        {
            // Perform linear search
            position = searchArray.LinearSearch(searchInt);

            if (position != -1) // Integer was found
            {
                Console.WriteLine(
                    "The integer {0} was found in position {1}.\n",
                    searchInt, position);
            }
            else // Integer was not found
            {
                Console.WriteLine(
                    "The integer {0} was not found.\n",
                    searchInt);
            }

            // Input next int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
        } // end while
    } // end Main
} // end class LinearSearchTest
