using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Classification
{
    public class NeuralNetwork
    {
        private int[,] neuralNetwork;

        public void TeachingNeuralNetwork(Bitmap[] images)
        {
            var matrixsList = new List<int[,]>();
            foreach (var image in images)
            {
                var vector = new int[image.Width*image.Height];

                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        vector[j + (i*image.Height)] = ActivationFunction(image.GetPixel(i, j));
                    }
                }
                matrixsList.Add(TransponentF(vector));
            }

            neuralNetwork = SumOfMatrixs(matrixsList);
        }

        private int[,] SumOfMatrixs(List<int[,]> list)
        {
            var resultMatrix = new int[list[0].GetLength(0), list[0].GetLength(1)];
            foreach (var matrix in list)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        resultMatrix[i,j] += matrix[i,j];
                    }
                }
            }

            return resultMatrix;
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
                    resultMatrix[j, i] = vector[j] * vector[i];
                }
            }
            return resultMatrix;
        }
    }
}
