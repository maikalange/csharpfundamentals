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
                
                string[] u1 = {"1", "9", "5", "3", "2", "8"};
                string[] u2 = { "1", "9", "3", "3", "2", "8" };

                EliminateDuplicates(r);
                StrictlyIdenticalArrays(u1, u2);
            }

            private static bool StrictlyIdenticalArrays(string[] list1,string[] list2)
            {
                bool areIdentical = true;
                for (int i = 0,j=0; i < list1.Length; i++,j++)
                {
                        if (list1[i]!=list2[j])
                        {
                            areIdentical = false;
                            break;
                        }
                }
                return areIdentical;
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