using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.cvičení
{
	public class Program
	{
		static void Main(string[] args)
		{
			double[,] MTXA = new double[,]
			{
				{1, -2, 3},
				{4, -5, 6},
				{7, -8, 9}


			};

			double[,] MTXB = new double[,]
			{
				{1, -2, 3},
				{4, -5, 6},
				{7, -8, 9}



			};


			Matrix MA = new Matrix(MTXA);
			Matrix MB = new Matrix(MTXB);

			Console.WriteLine("First Matrix\n");
			Console.WriteLine(MA.ToString());
			Console.WriteLine("\n");
			Console.WriteLine("Second Matrix\n");
			Console.WriteLine(MB.ToString());

			Console.WriteLine("---------------------------\n Positive Comparison \n");
			Console.WriteLine(MA == MB);
			Console.WriteLine("---------------------------\n Negative Comparison \n");
			Console.WriteLine(MA != MB);

			Console.WriteLine("---------------------------\n Addition \n");
			Console.WriteLine(MA + MB);
			Console.WriteLine("---------------------------\n Difference \n");
			Console.WriteLine(MA - MB);

			Console.WriteLine("---------------------------\n Multiplication \n");
			Console.WriteLine(MA * MB);

			Console.WriteLine("---------------------------\n Unary minus \n");
			Console.WriteLine("Matrix A: \n");
			Console.WriteLine((-MA));
			
			Console.WriteLine("Matrix B: \n");
			Console.WriteLine((-MB));

			Console.WriteLine("---------------------------\nDeterminant ");
			Console.WriteLine("\n Matrix A: ");
			Console.WriteLine(MA.Determinant());
			Console.WriteLine("\n Matrix B:");
			Console.WriteLine(MB.Determinant());

			Console.ReadLine();




		}

	}
}
