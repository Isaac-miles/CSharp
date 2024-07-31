using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp01
{
     class Arrays
    {
        public static void Run()
        {
            var num = new[] { 3, 7, 9, 2, 14, 6 };
            //Console.WriteLine(num.Length);


            var numList = new List<int>() {2,4,6,8};

            int[,] arr =  { { 1, 2 }, { 3, 4, }, { 5, 6 } };

            //Console.WriteLine(arr[2,1]);

            String[,,] simple3DArrays = new String[2,3,2]
            
            {
                { {"001","002" }, {"003","004" }, { "005","006" } }, 
                { {"007","008"}, { "009", "010" }, { "011","012"} } 
            };
            //Console.WriteLine(simple3DArrays[1,1,1]);

            int[,] arr3D = new int[,]
                {
                    {1,2,3},
                    {4,5,6}, 
                    {8,9,10}
                };

            for(int i = 0; i < arr3D.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr3D.GetLength(1); j++)
                {
                    sum += arr3D[i, j];
                }
                Console.WriteLine(sum); //print the sum of the current row
            }
        }
    }
}
