using System;
using System.Collections.Generic;

class GFG
{

	static int N = 9;

	static bool isinRange(int[,] board)
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < N; j++)
			{

				if (board[i, j] <= 0 ||
					board[i, j] > 9)
				{
					return false;
				}
			}
		}
		return true;
	}

	static bool isValidSudoku(int[,] board)
	{

		if (isinRange(board) == false)
		{
			return false;
		}

		bool[] unique = new bool[N + 1];

		for (int i = 0; i < N; i++)
		{
			Array.Fill(unique, false);

			for (int j = 0; j < N; j++)
			{

				int Z = board[i, j];

				if (unique[Z])
				{
					return false;
				}
				unique[Z] = true;
			}
		}

		for (int i = 0; i < N; i++)
		{

			Array.Fill(unique, false);

			for (int j = 0; j < N; j++)
			{
				int Z = board[j, i];

				if (unique[Z])
				{
					return false;
				}
				unique[Z] = true;
			}
		}

		for (int i = 0; i < N - 2; i += 3)
		{

			for (int j = 0; j < N - 2; j += 3)
			{

				Array.Fill(unique, false);

				for (int k = 0; k < 3; k++)
				{
					for (int l = 0; l < 3; l++)
					{

						int X = i + k;

						int Y = j + l;

						int Z = board[X, Y];

						if (unique[Z])
						{
							return false;
						}
						unique[Z] = true;
					}
				}
			}
		}

		return true;
	}

	public static void Main()
	{
		int[,] board = { { 7, 8, 4,    1, 5, 9,    3, 2, 6 },
					     { 5, 3, 9,    6, 7, 2,    8, 4, 1 },
					     { 6, 1, 2,    4, 3, 8,    7, 5, 9 },

					     { 9, 2, 8,    7, 1, 5,    4, 6, 3 },
					     { 3, 5, 7,    8, 4, 6,    1, 9, 2 },
					     { 4, 6, 1,    9, 2, 3,    5, 8, 7 },

					     { 8, 7, 6,    3, 9, 4,    2, 1, 5 },
					     { 2, 4, 3,    5, 6, 1,    9, 7, 8 },
					     { 1, 9, 5,    2, 8, 7,    6, 3, 4 } };

		if (isValidSudoku(board))
		{
			Console.WriteLine("Valid");
		}
		else
		{
			Console.WriteLine("Not Valid");
		}

       
	}
}