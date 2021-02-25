using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.cvičení
{
	public class Matrix
	{
		private double[,] MTX;

		//Matrix constructor
		public Matrix(double[,] MatrixA)
		{
			MTX = MatrixA;
		}

	/*	//Matrix checker
		public static void MatrixChecker(Matrix A, Matrix B)
		{
			int MArows = A.MTX.GetLength(0);
			int MBrows = B.MTX.GetLength(0);

			int MAcolumns = A.MTX.GetLength(1);
			int MBcolumns = B.MTX.GetLength(1);

			Exception ExceptionCheckMatch = new Exception();
			Exception ExceptionCheckSquare = new Exception("Matrix is not square!");
			if (MArows == MBrows || MAcolumns == MBcolumns || (MArows == MBcolumns && MBrows == MAcolumns))
			{
				throw ExceptionCheckMatch;
			}


		}*/
		//Operators

		//Addition

		public static Matrix operator +(Matrix A, Matrix B)
		{
			try
			{
				//Matrix.MatrixChecker(A, B);
				var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);
				for (int i = 0; i < A.MTX.GetLength(0); i++)
				{
					for (int j = 0; j < A.MTX.GetLength(1); j++)
					{

						MTX.MTX[i, j] = A.MTX[i, j] + B.MTX[i, j];

					}

				}
				return MTX;
			}
			catch
			{
				Console.WriteLine("Error 1.1");
			}
			return null;

		}

		//Difference
		public static Matrix operator -(Matrix A, Matrix B)
		{
			try
			{
				//Matrix.MatrixChecker(A, B);
				var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);

				for (int i = 0; i < A.MTX.GetLength(0); i++)
				{
					for (int j = 0; j < A.MTX.GetLength(1); j++)
					{

						MTX.MTX[i, j] = A.MTX[i, j] - B.MTX[i, j];

					}

				}
				return MTX;
			}
			catch
			{
				Console.WriteLine("Error 1.2");
			}
			return null;

		}


		//Positive Comparison
		public static bool operator ==(Matrix A, Matrix B)
		{
			var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);
			try
			{
				for (int i = 0; i < A.MTX.GetLength(0); i++)
				{
					for (int j = 0; j < A.MTX.GetLength(1); j++)
					{
						if (A.MTX[i, j] == B.MTX[i, j])
						{
							return true;
						}
						else { return false; }

					}

				}
				return true;
			}
			catch
			{

				return false;
			}

		}

		//Negative Comparison
		public static bool operator !=(Matrix A, Matrix B)
		{
			var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);

			try
			{
				for (int i = 0; i < A.MTX.GetLength(0); i++)
				{

					for (int j = 0; j < A.MTX.GetLength(1); j++)
					{
						if (A.MTX[i, j] != B.MTX[i, j])
						{
							return true;
						}
						else
						{ return false; }
					}

				}
				return true;
			}
			catch
			{

				return false;
			}

		}

		// Multiplication
		public static Matrix operator *(Matrix A, Matrix B)
		{

			try
			{
				//Matrix.MatrixChecker(A, B);
				var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);
				var X = MTX.MTX;

				for (int i = 0; i < X.GetLength(0); i++)
				{
					for (int j = 0; j < X.GetLength(1); j++)
					{
						X[i, j] = 0;

						for (int k = 0; k < A.MTX.GetLength(1); k++)
						{
							X[i, j] = X[i, j] + A.MTX[i, k] * B.MTX[k, j];

						}
					}

				}
				MTX.MTX = X;
				return MTX;
			}
			catch
			{
				Console.WriteLine("Error: Matrix size is incorrect");
				return null;
			}


		}

		//unary minus

		public static Matrix operator -(Matrix A)
		{
			try
			{
				var MTX = new Matrix(new double[A.MTX.GetLength(0), A.MTX.GetLength(1)]);

				for (int i = 0; i < A.MTX.GetLength(0); i++)
				{
					for (int j = 0; j < A.MTX.GetLength(1); j++)
					{
						MTX.MTX[i, j] = A.MTX[i, j] * (-1);

					}

				}
				return MTX;
			}
			catch
			{
				Console.WriteLine("Error: Matrix size is incorrect");
				return null;
			}

		}


		// Determinant 

		public double Determinant()
		{

			var Determinant = 0;
			if (MTX.GetLength(0) == MTX.GetLength(1) && MTX.GetLength(1) == 1)
			{
				Determinant = (int)MTX[0, 0];
				return Determinant;
			}
			else if (MTX.GetLength(0) == MTX.GetLength(1) && MTX.GetLength(1) == 2)
			{

				Determinant = (int)(MTX[0, 0] * MTX[1, 1] - MTX[1, 0] * MTX[0, 1]);
				return Determinant;

			}
			else if ((MTX.GetLength(0) == MTX.GetLength(1) && MTX.GetLength(1) == 3))
			{
				Determinant =
					(int)((int)((MTX[0, 0] * MTX[1, 1] * MTX[2, 2]) + (MTX[0, 1] * MTX[1, 2] * MTX[2, 0]) + (MTX[0, 2] * MTX[1, 0] * MTX[2, 1]))
					- (MTX[2, 0] * MTX[1, 1] * MTX[0, 2] + MTX[2, 1] * MTX[1, 2] * MTX[0, 0] + MTX[2, 2] * MTX[1, 0] * MTX[0, 1]));
				return Determinant;

			}
			Console.WriteLine("Error: Matrix size is incorrect");
			return Double.NaN;

		}


		public override string ToString()
		{
			StringBuilder output = new StringBuilder("");

			for (int i = 0; i < MTX.GetLength(0); i++)
			{
				output.Append("{ ");

				for (int j = 0; j < MTX.GetLength(1); j++)
				{
					output.Append($"{MTX[i, j]} ");
				}

				output.Append("}\n");
			}

			return output.ToString();
		}


	}
}

