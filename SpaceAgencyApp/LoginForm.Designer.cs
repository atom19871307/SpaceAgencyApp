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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogin.Location = new System.Drawing.Point(333, 429);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(139, 40);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.Color.Blue;
			this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUser.Location = new System.Drawing.Point(333, 252);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(139, 38);
			this.txtUser.TabIndex = 0;
			this.txtUser.Text = "Login";
			this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
			this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.Blue;
			this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPass.Location = new System.Drawing.Point(333, 352);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(139, 38);
			this.txtPass.TabIndex = 1;
			this.txtPass.Text = "Password";
			this.txtPass.UseSystemPasswordChar = true;
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(327, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(333, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SpaceAgencyApp.Properties.Resources.космос;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(819, 721);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.btnLogin);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}