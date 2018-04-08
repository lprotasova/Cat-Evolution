namespace _18._04._07_cat
{
	partial class mainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.dog1 = new System.Windows.Forms.PictureBox();
			this.food1 = new System.Windows.Forms.PictureBox();
			this.cat1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.food1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cat1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(543, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 1;
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(493, 372);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(57, 16);
			this.scoreLabel.TabIndex = 2;
			this.scoreLabel.Text = "Score: 0";
			// 
			// dog1
			// 
			this.dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.dog1.Location = new System.Drawing.Point(130, 245);
			this.dog1.Name = "dog1";
			this.dog1.Size = new System.Drawing.Size(50, 50);
			this.dog1.TabIndex = 4;
			this.dog1.TabStop = false;
			// 
			// food1
			// 
			this.food1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.food1.Location = new System.Drawing.Point(375, 150);
			this.food1.Name = "food1";
			this.food1.Size = new System.Drawing.Size(50, 50);
			this.food1.TabIndex = 3;
			this.food1.TabStop = false;
			// 
			// cat1
			// 
			this.cat1.BackgroundImage = global::_18._04._07_cat.Properties.Resources.c1;
			this.cat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cat1.Location = new System.Drawing.Point(0, 0);
			this.cat1.Name = "cat1";
			this.cat1.Size = new System.Drawing.Size(50, 50);
			this.cat1.TabIndex = 0;
			this.cat1.TabStop = false;
			// 
			// mainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(145)))));
			this.ClientSize = new System.Drawing.Size(600, 397);
			this.Controls.Add(this.dog1);
			this.Controls.Add(this.food1);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cat1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "mainForm";
			this.Text = "Cat Factory";
			((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.food1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cat1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox cat1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.PictureBox food1;
		private System.Windows.Forms.PictureBox dog1;
	}
}

