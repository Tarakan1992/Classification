using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classification
{
	using System.Configuration;

	public partial class Form1 : Form
	{
		private Bitmap originalImage;
		private Dictionary<string, Bitmap> _originalImages;

		public Form1()
		{
			InitializeComponent();
			originalImage = null;
			_originalImages = new Dictionary<string, Bitmap>();
			ImageInitialization();

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
			originalImage = new Bitmap(_originalImages[ConfigurationManager.AppSettings[comboBoxLetter.SelectedItem.ToString()]]);
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

		private void ImageInitialization()
		{
			var appSettings = ConfigurationManager.AppSettings;
			foreach (var letter in comboBoxLetter.Items)
			{
				var key = appSettings[letter.ToString()];
				_originalImages[key] = new Bitmap("../../Content/" + key +".png");
			}
		}
	}
}
