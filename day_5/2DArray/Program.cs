using System;
public class TwoDArray{
    // 2D array declaration
    public int[,] data = {
        {10, 11, 12, 13, 14},
        {5, 6, 7, 8, 9},
        {0, 1, 2, 3, 4,},
        {15, 16, 17, 18, 19}
        };
}

class Program{
    static void Main(string[] args){
        TwoDArray twoDArray = new TwoDArray();
        Console.WriteLine("the two dimensional array is : ");
        int NumOfRows = twoDArray.data.GetLength(0);
        int NumOfCols = twoDArray.data.GetLength(1);
        Console.WriteLine($"the array is : {NumOfRows} rows and {NumOfCols} columns");
        //joining all the rows to a single row
        for (int i = 0; i < twoDArray.data.GetLength(0); i++){
            for (int j = 0; j < twoDArray.data.GetLength(1); j++){
                Console.Write(twoDArray.data[i,j] + "\t");
            }
            Console.WriteLine();
        }

        //checking the length of the newly created array
        Console.WriteLine("the length of the two dimensional array is: " + twoDArray.data.Length);
        int[] oneDArray = new int[twoDArray.data.Length];
        int index = 0;
        for(int i = 0; i < twoDArray.data.GetLength(0); i++){
            for (int j = 0; j < twoDArray.data.GetLength(1); j++){
                oneDArray[index++] = twoDArray.data[i,j];
            }

        }
        Console.WriteLine("after sorting");
        // sorting the one dimensional array
        Array.Sort(oneDArray);
        // displaying the one dimensional array after sorting
        for(int i = 0; i < oneDArray.Length; i++){
            Console.Write(oneDArray[i]+ "  ");
        }
        Console.WriteLine();
        // reversing back to the 2d array
        index=0;
        for(int i = 0; i < twoDArray.data.GetLength(0); i++){
            for (int j = 0; j < twoDArray.data.GetLength(1); j++){
               twoDArray.data[i,j]  = oneDArray[index++];
            }
        }
        Console.WriteLine("after reversing back to 2d array");
        // displaying the 2d array after reversing
        for(int i = 0; i < twoDArray.data.GetLength(0); i++){
            for (int j = 0; j < twoDArray.data.GetLength(1); j++){
                Console.Write(twoDArray.data[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }

}
