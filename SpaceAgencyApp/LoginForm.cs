using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceAgencyApp
{
	public partial class LoginForm : Form
	{
		// Հիմա ստուգումը կկատարվի ՄԻԱՅՆ կոճակը սեղմելիս
		public LoginForm()
		{
			InitializeComponent();
		}

		// Ամբողջ տրամաբանությունը պետք է լինի այս մեթոդի ներսում
		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUser.Text == "Admin" && txtPass.Text == "123")
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			this.ActiveControl = txtUser;
		}

		private void txtUser_Enter(object sender, EventArgs e)
		{
			if (txtUser.Text == "Login")
			{
				txtUser.Text = ""; // Մաքրում է տեքստը
			}
		}

		private void txtUser_Leave(object sender, EventArgs e)
		{
			if (txtUser.Text == "")
			{
				txtUser.Text = "Login"; // Հետ է բերում հուշումը
			}
		}

		private void txtPass_Enter(object sender, EventArgs e)
		{
			if (txtPass.Text == "Password")
			{
				txtPass.Text = "";
				txtPass.UseSystemPasswordChar = true; // Միացնում է աստղիկները
			}
		}

		private void txtPass_Leave(object sender, EventArgs e)
		{
			if (txtPass.Text == "")
			{
				txtPass.Text = "Password";
				txtPass.UseSystemPasswordChar = false; // Անջատում է աստղիկները, որ բառը երևա
			}
		}
	}
}