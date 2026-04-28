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
				// Փոխում ենք սյունակների վերնագրերը ռուսերեն
				dgvPlanets.Columns["name_am"].Visible = false; // Հայերենը թաքցնում ենք
				dgvPlanets.Columns["name_ru"].Visible = true;
				dgvPlanets.Columns["name_ru"].HeaderText = "Планета";
				dgvPlanets.Columns["distance_from_earth"].HeaderText = "Расстояние (млн км)";
				dgvPlanets.Columns["price_per_ticket"].HeaderText = "Цена билета";
				dgvPlanets.Columns["desc_ru"].Visible = true;
				dgvPlanets.Columns["desc_ru"].HeaderText = "Описание";

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

					// Հաշվում ենք ընդհանուր օրերը
					int totalDays = (int)(timeHours / 24);

					int years = totalDays / 365;       // Տարիները
					int days = totalDays % 365;        // Մնացած օրերը

					// Ցուցադրում ենք արդյունքը ռուսերեն
					if (years > 0)
					{
						lblResult.Text = $"Время полета: {years} лет и {days} дней";
					}
					else if (totalDays > 0)
					{
						lblResult.Text = $"Время полета: {totalDays} дней";
					}
					else
					{
						// Եթե 1 օրից պակաս է, ցույց է տալիս ժամերը (օրինակ՝ 15.4 часов)
						lblResult.Text = $"Время полета: {timeHours:F1} часов";
					}
					if (dgvPlanets.CurrentRow != null)
					{
						decimal totalPrice = Convert.ToDecimal(dgvPlanets.CurrentRow.Cells["price_per_ticket"].Value);
						lblPrice.Text = $"Стоимость билета: {totalPrice:N0} руб.";
						lblPrice.Visible = true; // Համոզվիր, որ Label-ը տեսանելի է
					}

					lblResult.ForeColor = Color.Cyan;
				}
			}
		}

		private void dgvPlanets_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPlanets.CurrentRow != null)
			{
				// Վերցնում ենք մոլորակի անունը name_en սյունակից (որ ֆայլի անունը ճիշտ լինի)
				string planetName = dgvPlanets.CurrentRow.Cells["name_en"].Value.ToString();
				string folderPath = Application.StartupPath + @"\Images\";
				string fullPath = folderPath + planetName + ".jpg";

				if (System.IO.File.Exists(fullPath))
				{
					pbPlanet.Image = Image.FromFile(fullPath);
				}
				else
				{
					pbPlanet.Image = null; // Եթե նկարը չկա, դատարկ ենք թողնում
				}
			}
		}
	}
}
