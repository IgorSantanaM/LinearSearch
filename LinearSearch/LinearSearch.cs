using System;

public class LinearArray
{
    private int[] data; 
    private static Random generator = new Random();

    public LinearArray(int size)
    {
        data = new int[size]; // create space for array

        for (int i = 0; i < size; ++i)
        {
            data[i] = generator.Next(10, 100);
        }
    } // end LinearArray constructor
    public int LinearSearch(int searchKey)
    {
        // Loop through array sequentially
        for (int index = 0; index < data.Length; ++index)
        {
            if (data[index] == searchKey)
            {
                return index; // return index of integer if found
            }
        }
        return -1; // integer was not found
    } // end method LinearSearch
    public override string ToString()
    {
        string temporary = string.Empty;

        // Iterate through array
        foreach (int element in data)
        {
            temporary += element + " ";
        }

        temporary += "\n"; // add newline character
        return temporary;
    } // end method ToString
} // end class LinearArray
