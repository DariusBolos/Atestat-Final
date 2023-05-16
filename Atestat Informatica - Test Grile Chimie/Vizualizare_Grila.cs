using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica___Test_Grile_Chimie
{
    public partial class Vizualizare_Grila : MaterialForm
    {
        int answers = 0;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Vizualizare_Grila()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
            InitializeComponent();
        }

        private void getGrid()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT * FROM Grile WHERE Intrebare = '" + Afisare_Grile.instance.intrebare + "'";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                reader.Read();
                richTextBox_intrebare.Text = reader[1].ToString();
                richTextBox_rasp1.Text = reader[2].ToString();
                richTextBox_rasp2.Text = reader[3].ToString();
                richTextBox_rasp3.Text = reader[4].ToString();
                richTextBox_rasp4.Text = reader[5].ToString();
                richTextBox_rasp5.Text = reader[6].ToString();
                answers = Convert.ToInt32(reader[7]);
                
                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Vizualizare_Grila_Load(object sender, EventArgs e)
        {
            getGrid();
            this.Text += Afisare_Grile.instance.id;

            while(answers > 0)
            {
                int answer = answers % 10;
                foreach (Label label in this.Controls.OfType<Label>())
                    if (label.Name.Contains(answer.ToString()))
                        label.BackColor = Color.Green;

                foreach (MaterialMultiLineTextBox tb in this.Controls.OfType<MaterialMultiLineTextBox>())
                    if (tb.Name.Contains(answer.ToString()))
                        tb.BorderStyle = BorderStyle.Fixed3D;

                answers /= 10;
            }
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Afisare_Grile form = new Afisare_Grile();   
            form.ShowDialog();
        }
    }
}
