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
			this.cbShips = new System.Windows.Forms.ComboBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.dgvPlanets = new System.Windows.Forms.DataGridView();
			this.lblResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).BeginInit();
			this.SuspendLayout();
			// 
			// cbShips
			// 
			this.cbShips.FormattingEnabled = true;
			this.cbShips.Location = new System.Drawing.Point(21, 431);
			this.cbShips.Name = "cbShips";
			this.cbShips.Size = new System.Drawing.Size(252, 24);
			this.cbShips.TabIndex = 0;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalculate.Location = new System.Drawing.Point(12, 373);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(263, 52);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Рассчитать полет";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// dgvPlanets
			// 
			this.dgvPlanets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlanets.Location = new System.Drawing.Point(12, 12);
			this.dgvPlanets.Name = "dgvPlanets";
			this.dgvPlanets.RowHeadersWidth = 51;
			this.dgvPlanets.RowTemplate.Height = 24;
			this.dgvPlanets.Size = new System.Drawing.Size(1431, 355);
			this.dgvPlanets.TabIndex = 2;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblResult.Location = new System.Drawing.Point(300, 431);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(359, 32);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "Результат появится здесь";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1455, 535);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.dgvPlanets);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.cbShips);
			this.Name = "Form1";
			this.Text = "Form1_Load";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPlanets)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbShips;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.DataGridView dgvPlanets;
		private System.Windows.Forms.Label lblResult;
	}
}

