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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// Բեռնում ենք մոլորակները աղյուսակի մեջ
			dgvPlanets.DataSource = Connector.Load("SELECT * FROM Planets");

			// Բեռնում ենք տիեզերանավերը ComboBox-ի մեջ
			DataTable ships = Connector.Load("SELECT * FROM Starships");
			cbShips.DataSource = ships;
			cbShips.DisplayMember = "ship_name"; // Ցույց կտա անունը
			cbShips.ValueMember = "ship_speed"; // Կպահի արագությունը

			// --- ԱՅՍՏԵՂԻՑ  ՍՅՈՒՆԱԿՆԵՐԸ ԹԱՔՑՆԵԼՈՒ ԿՈԴԸ ---
			if (dgvPlanets.Columns.Count > 0)
			{
				dgvPlanets.Columns["planet_id"].Visible = false;
				dgvPlanets.Columns["name_en"].Visible = false;
				dgvPlanets.Columns["name_ru"].Visible = false;
				dgvPlanets.Columns["desc_en"].Visible = false;
				dgvPlanets.Columns["desc_ru"].Visible = false;

				// Սիրունացնում ենք վերնագրերը
				dgvPlanets.Columns["name_am"].HeaderText = "Մոլորակ";
				dgvPlanets.Columns["distance_from_earth"].HeaderText = "Հեռավորություն";
				dgvPlanets.Columns["price_per_ticket"].HeaderText = "Տոմսի արժեք";
				dgvPlanets.Columns["desc_am"].HeaderText = "Նկարագրություն";

				// Աղյուսակը ձգում ենք ամբողջ լայնությամբ
				dgvPlanets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
		} 

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (dgvPlanets.CurrentRow != null && cbShips.SelectedItem != null)
			{
				// 1. Վերցնում ենք հեռավորությունը միլիոնավոր կմ-ով
				double distanceRaw = Convert.ToDouble(dgvPlanets.CurrentRow.Cells["distance_from_earth"].Value);
				double distanceKm = distanceRaw * 1000000;

				// 2. Վերցնում ենք նավի արագությունը կմ/ժ-ով
				DataRowView selectedShip = (DataRowView)cbShips.SelectedItem;
				double speedKmh = Convert.ToDouble(selectedShip["ship_speed"]);

				if (speedKmh > 0)
				{
					double timeHours = distanceKm / speedKmh;

					if (timeHours < 1)
						lblResult.Text = $"Продолжительность полета: {(timeHours * 60):F1} минут";
					else if (timeHours < 24)
						lblResult.Text = $"Продолжительность полета: {timeHours:F1} часов";
					else
						lblResult.Text = $"Продолжительность полета: {(timeHours / 24):F1} день/дней";
				}
			}
		}
	}
}
