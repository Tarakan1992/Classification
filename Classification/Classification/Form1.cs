﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Classification
{
	public partial class Form1 : Form
	{
	    private Bitmap originalImage;
	    private NeuralNetwork neuralNetwork;
		public Form1()
		{
			InitializeComponent();
		    originalImage = null;
            neuralNetwork = new NeuralNetwork();
            
		    var images = new List<Bitmap>();
		    var letters = new string[] {"K", "L", "M", "N"};
		    foreach (var item in letters)
		    {
                images.Add(new Bitmap(@"..\..\Content\" + item + ".png"));
		    }

            neuralNetwork.TeachingNeuralNetwork(images.ToArray());
		}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGenerateNoise_Click(object sender, EventArgs e)
        {
            int percentOfNoise;
            int.TryParse(comboBoxPercentOfNoise.SelectedItem.ToString(), out percentOfNoise);
            pictureBoxOriginal.Image = NoiseGenerator.MakeNoisy(originalImage, percentOfNoise);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentImageName = "";
            switch (comboBoxLetter.SelectedItem.ToString())
            {
                case "К":
                    currentImageName = "K";
                    break;
                case "Л":
                    currentImageName = "L";
                    break;
                case "М":
                    currentImageName = "M";
                    break;
                case "Н":
                    currentImageName = "N";
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Directory.GetCurrentDirectory();
            originalImage = new Bitmap(@"..\..\Content\" + currentImageName + ".png");
            pictureBoxOriginal.Image = originalImage;
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLetter.SelectedIndex != 0 && comboBoxPercentOfNoise.SelectedIndex != 0)
            {
                buttonGenerateNoise.Enabled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           
        }
	}
}
