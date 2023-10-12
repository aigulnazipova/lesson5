using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Matrix
    {
        public int[,] A;
        public int[,] B;
    }
    
        Matrix matrix(int[,] a, int[,] b)
        {
            A = a;
            B = b;
        }

        public void PrintMatrix()
        {
            Console.WriteLine("Матрица А:");
            for (int i = 0; i < A.GetLength(0), i++)
            {
                for (int j = 0; j < A.GetLength(1), j++)
                {
                    Console.Write(A[i, j] + "t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица B:");
            for (int i = 0; i < B.GetLength(0);  i++)
            {
                for (int j = 0; j < B.GetLengt(1);  j++)
                {
                    Console.Write(B[i, j] + "t");
                }
                Console.WriteLine();
            }
        }
    
        public bool CheckMatrix()
        {
            if (A.GetLength(1) != B.GetLength(0))
            {
                Console.WriteLine("Матрицы невозможно перемножить");
                return false;
            }
            else
            {
                return true;
            }
        }

        public interface[,] Multiply()
        {
            int[,] result = int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0), i++)
            {
                for (int j = 0; j < B.GetLengt(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < A.GetLength(1);  k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    result[i, j] = sum;
                }

            }

        return result;
        }
    
        internal class Program
        {
            static void Main(string[] args)
            {

           
            
            }
        }
}
