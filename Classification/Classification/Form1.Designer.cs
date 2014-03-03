namespace Classification
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxLetter = new System.Windows.Forms.ComboBox();
			this.comboBoxPercentOfNoise = new System.Windows.Forms.ComboBox();
			this.buttonGenerateNoise = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
			this.pictureBoxResult = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.79646F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 339);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21299F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.51625F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27076F));
			this.tableLayoutPanel2.Controls.Add(this.comboBoxLetter, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.comboBoxPercentOfNoise, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.buttonGenerateNoise, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonStart, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(563, 93);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// comboBoxLetter
			// 
			this.comboBoxLetter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxLetter.FormattingEnabled = true;
			this.comboBoxLetter.Items.AddRange(new object[] {
            "К",
            "Л",
            "М",
            "Н"});
			this.comboBoxLetter.Location = new System.Drawing.Point(3, 49);
			this.comboBoxLetter.Name = "comboBoxLetter";
			this.comboBoxLetter.Size = new System.Drawing.Size(180, 21);
			this.comboBoxLetter.TabIndex = 0;
			this.comboBoxLetter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBoxPercentOfNoise
			// 
			this.comboBoxPercentOfNoise.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxPercentOfNoise.FormattingEnabled = true;
			this.comboBoxPercentOfNoise.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
			this.comboBoxPercentOfNoise.Location = new System.Drawing.Point(189, 49);
			this.comboBoxPercentOfNoise.Name = "comboBoxPercentOfNoise";
			this.comboBoxPercentOfNoise.Size = new System.Drawing.Size(227, 21);
			this.comboBoxPercentOfNoise.TabIndex = 1;
			this.comboBoxPercentOfNoise.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// buttonGenerateNoise
			// 
			this.buttonGenerateNoise.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonGenerateNoise.Location = new System.Drawing.Point(422, 49);
			this.buttonGenerateNoise.Name = "buttonGenerateNoise";
			this.buttonGenerateNoise.Size = new System.Drawing.Size(138, 41);
			this.buttonGenerateNoise.TabIndex = 2;
			this.buttonGenerateNoise.Text = "Generate noise";
			this.buttonGenerateNoise.UseVisualStyleBackColor = true;
			this.buttonGenerateNoise.Click += new System.EventHandler(this.buttonGenerateNoise_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 46);
			this.label1.TabIndex = 3;
			this.label1.Text = "Select letter:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(189, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 46);
			this.label2.TabIndex = 4;
			this.label2.Text = "Percent of noise:";
			// 
			// buttonStart
			// 
			this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonStart.Location = new System.Drawing.Point(422, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(138, 40);
			this.buttonStart.TabIndex = 5;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.pictureBoxOriginal, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.pictureBoxResult, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 102);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(563, 234);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// pictureBoxOriginal
			// 
			this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxOriginal.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxOriginal.MinimumSize = new System.Drawing.Size(100, 100);
			this.pictureBoxOriginal.Name = "pictureBoxOriginal";
			this.pictureBoxOriginal.Size = new System.Drawing.Size(275, 228);
			this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxOriginal.TabIndex = 1;
			this.pictureBoxOriginal.TabStop = false;
			// 
			// pictureBoxResult
			// 
			this.pictureBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxResult.Location = new System.Drawing.Point(284, 3);
			this.pictureBoxResult.Name = "pictureBoxResult";
			this.pictureBoxResult.Size = new System.Drawing.Size(276, 228);
			this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxResult.TabIndex = 2;
			this.pictureBoxResult.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 339);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "lab 2 Classification";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBoxOriginal;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox comboBoxLetter;
		private System.Windows.Forms.ComboBox comboBoxPercentOfNoise;
		private System.Windows.Forms.Button buttonGenerateNoise;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox pictureBoxResult;
	}
}

