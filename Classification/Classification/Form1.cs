using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Classification
{
	using System.Configuration;
	using System.Linq;

	public partial class Form1 : Form
	{
		private Bitmap originalImage;
		private Dictionary<string, Bitmap> _originalImages;
		private NeuralNetwork _neuralNetwork;

		public Form1()
		{
			InitializeComponent();
			originalImage = null;
			_originalImages = new Dictionary<string, Bitmap>();
			ImageInitialization();
			_neuralNetwork = new NeuralNetwork();
			_neuralNetwork.TeachingNeuralNetwork(_originalImages.Values.ToArray());
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonGenerateNoise_Click(object sender, EventArgs e)
		{
			var appSetting = ConfigurationManager.AppSettings;
			var key = appSetting[comboBoxLetter.SelectedItem.ToString()];
			int percentOfNoise;
			int.TryParse(comboBoxPercentOfNoise.SelectedItem.ToString(), out percentOfNoise);
			originalImage = new Bitmap(_originalImages[key]);

			pictureBoxOriginal.Image = NoiseGenerator.MakeNoisy(originalImage, percentOfNoise);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			originalImage = new Bitmap(_originalImages[ConfigurationManager.AppSettings[comboBoxLetter.SelectedItem.ToString()]]);
			pictureBoxOriginal.Image = originalImage;
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
			pictureBoxResult.Image = _neuralNetwork.RecognizeImage(originalImage);
		}

		private void ImageInitialization()
		{
			var appSettings = ConfigurationManager.AppSettings;
			foreach (var letter in comboBoxLetter.Items)
			{
				var key = appSettings[letter.ToString()];
				_originalImages[key] = new Bitmap("../../Content/" + key + ".png");
			}
		}
	}
}
