namespace SpaceAgencyApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cbShips = new System.Windows.Forms.ComboBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.dgvPlanets = new System.Windows.Forms.DataGridView();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.pbPlanet = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlanet)).BeginInit();
			this.SuspendLayout();
			// 
			// cbShips
			// 
			this.cbShips.BackColor = System.Drawing.Color.Navy;
			this.cbShips.ForeColor = System.Drawing.Color.White;
			this.cbShips.FormattingEnabled = true;
			this.cbShips.Location = new System.Drawing.Point(12, 373);
			this.cbShips.Name = "cbShips";
			this.cbShips.Size = new System.Drawing.Size(256, 24);
			this.cbShips.TabIndex = 0;
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
			this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalculate.ForeColor = System.Drawing.Color.White;
			this.btnCalculate.Location = new System.Drawing.Point(306, 373);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(263, 52);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Рассчитать полет";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// dgvPlanets
			// 
			this.dgvPlanets.BackgroundColor = System.Drawing.Color.Blue;
			this.dgvPlanets.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPlanets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlanets.GridColor = System.Drawing.Color.White;
			this.dgvPlanets.Location = new System.Drawing.Point(12, 12);
			this.dgvPlanets.Name = "dgvPlanets";
			this.dgvPlanets.RowHeadersWidth = 51;
			this.dgvPlanets.RowTemplate.Height = 24;
			this.dgvPlanets.Size = new System.Drawing.Size(1348, 355);
			this.dgvPlanets.TabIndex = 2;
			this.dgvPlanets.SelectionChanged += new System.EventHandler(this.dgvPlanets_SelectionChanged);
			// 
			// lblResult
			// 
			this.lblResult.AllowDrop = true;
			this.lblResult.AutoSize = true;
			this.lblResult.BackColor = System.Drawing.Color.Transparent;
			this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblResult.ForeColor = System.Drawing.Color.Yellow;
			this.lblResult.Location = new System.Drawing.Point(300, 462);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(246, 33);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "Ожидание расчета...";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.BackColor = System.Drawing.Color.Transparent;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lblPrice.Location = new System.Drawing.Point(596, 393);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(257, 32);
			this.lblPrice.TabIndex = 4;
			this.lblPrice.Text = "Стоимость билета";
			// 
			// pbPlanet
			// 
			this.pbPlanet.BackColor = System.Drawing.Color.Transparent;
			this.pbPlanet.Location = new System.Drawing.Point(14, 500);
			this.pbPlanet.Name = "pbPlanet";
			this.pbPlanet.Size = new System.Drawing.Size(221, 151);
			this.pbPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPlanet.TabIndex = 5;
			this.pbPlanet.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(50, 449);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 32);
			this.label1.TabIndex = 6;
			this.label1.Text = "Вид планеты";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1800, 700);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbPlanet);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.dgvPlanets);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.cbShips);
			this.Name = "Form1";
			this.Text = "Form1_Load";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlanet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbShips;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.DataGridView dgvPlanets;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.PictureBox pbPlanet;
		private System.Windows.Forms.Label label1;
	}
}

