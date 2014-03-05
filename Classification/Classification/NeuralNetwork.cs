using System;
using System.Collections.Generic;
using System.Drawing;

namespace Classification
{
	using System.Linq;

	public class NeuralNetwork
	{
		private int[,] neuralNetwork;

		public void TeachingNeuralNetwork(Bitmap[] images)
		{
			var matrixsList = new List<int[,]>();
			foreach (var image in images)
			{
				matrixsList.Add(TransponentF(GetVectorFromImage(image)));
			}

			neuralNetwork = SumOfMatrixs(matrixsList);
		}

		private int[,] SumOfMatrixs(List<int[,]> list)
		{
			var width = list[0].GetLength(0);
			var height = list[0].GetLength(1);

			var resultMatrix = new int[width, height];

			foreach (var matrix in list)
			{
				for (int i = 0; i < width; i++)
				{
					for (int j = 0; j < height; j++)
					{
						if (i != j)
						{
							resultMatrix[i, j] += matrix[i, j];
						}
						else
						{
							resultMatrix[i, j] = 0;
						}
					}
				}
			}

			return resultMatrix;
		}

		private int[] GetVectorFromImage(Bitmap image)
		{
			var vector = new int[image.Width * image.Height];

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					vector[j + (i * image.Width)] = ActivationFunction(image.GetPixel(i, j));
				}
			}

			return vector;
		}

		private int ActivationFunction(Color color)
		{
			if (color.B > 127 && color.R > 127 && color.G > 127)
			{
				return 1;
			}

			return -1;
		}

		private int[,] TransponentF(int[] vector)
		{
			var length = vector.Length;
			var resultMatrix = new int[length, length];

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					resultMatrix[i, j] = vector[i] * vector[j];
				}
			}
			return resultMatrix;
		}

		public Bitmap RecognizeImage(Bitmap image)
		{
			var result = new int[image.Width * image.Height];
			var vector = GetVectorFromImage(image);

			for (int k = 0; k < 50; k++)
			{
				for (int i = 0; i < neuralNetwork.GetLength(0); i++)
				{
					for (int j = 0; j < neuralNetwork.GetLength(1); j++)
					{
						result[i] += neuralNetwork[i, j]*vector[j];
					}
				}
			}

			for (int i = 0; i < image.Width; i++)
			{
				result[i] = LimitFunction(result[i]);
			}

			return DecodeImage(result, image.Width, image.Height);
		}

		private int LimitFunction(int x)
		{
			return x >= 0 ? 1 : -1;
		}

		private Bitmap DecodeImage(int[] vector, int width, int height)
		{
			var image = new Bitmap(width, height);

			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					image.SetPixel(i, j, DeactivationFunction(vector[i * width + j]));
				}
			}

			return image;
		}

		private Color DeactivationFunction(int x)
		{
			return x > 0 ? Color.White : Color.Black;
		}
	}
}
