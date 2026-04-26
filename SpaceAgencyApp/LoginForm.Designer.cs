namespace SpaceAgencyApp
{
	partial class LoginForm
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogin.Location = new System.Drawing.Point(262, 213);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(139, 40);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(262, 278);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(100, 22);
			this.txtUser.TabIndex = 1;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(262, 323);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(100, 22);
			this.txtPass.TabIndex = 2;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnLogin);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
	}
}