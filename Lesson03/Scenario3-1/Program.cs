using System;

namespace Scenario3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4, 5 }, { 3, 4, 5, 6, 7 }, { 5, 6, 7, 8, 9 }, { 6, 7, 8, 9, 10 } };
            int maxNum = 0;
            for(int i = 0; i < 4; i++){
                for (int j = 0; j < 5; j++){
                    if(arr[i,j] > maxNum){
                        maxNum = arr[i,j];
                    }
                }
                Console.WriteLine(maxNum);
            }
        }
    }
}
