using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    namespace SingleDimensionalArrays
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] r = {1, 9, 5, 3, 2, 2, 1, 8, 1, 5, 2, 3};
                
                int[] u = {1, 9, 5, 3, 2, 8};
                
                EliminateDuplicates(r);
            }

            private static void  EliminateDuplicates(int[] list)
            {
                //copy elements to a string array
                string[] p = new string[list.Length];
                for (int i = 0; i < list.Length; i++)
                {
                    p[i] = list[i].ToString();
                }
                //check if the array has duplicates
                var elements = new StringBuilder();
                for (int i = 0; i < list.Length; i++)
                {
                    for (int j=i+1;j < list.Length;j++)
                    {
                        if (list[i] == list[j])
                        {
                            p[j] = string.Empty;
                        }
                    }
                }

                foreach (var i in p)
                {
                    if (i!=string.Empty)
                    {
                        Console.Write(i +"  ");
                    } 
                }
            }
        }
    }
}