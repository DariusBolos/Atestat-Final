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
    public partial class Modificare_Grila : MaterialForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Modificare_Grila()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void getCurrentQuestion()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT * FROM Grile WHERE ID = '" + Start_Profesor.instance.questionID + "'";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                reader.Read();
                richTextBox_intrebare.Text = reader[1].ToString();
                richTextBox_rasp1.Text = reader[2].ToString();
                richTextBox_rasp2.Text = reader[3].ToString();
                richTextBox_rasp3.Text = reader[4].ToString();
                richTextBox_rasp4.Text = reader[5].ToString();
                richTextBox_rasp5.Text = reader[6].ToString();
                int answers = Convert.ToInt32(reader[7]);
                while(answers > 0)
                {
                    int answer = answers % 10;
                    foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
                    {
                        if (checkBox.Text.Contains(answer.ToString()))
                            checkBox.Checked = true;
                    }
                        
                    answers /= 10;
                }
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modificare_Grila_Load(object sender, EventArgs e)
        {
            getCurrentQuestion();
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Profesor form = new Start_Profesor();
            form.ShowDialog();  
        }

        private void updateGrid()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string updateString = "UPDATE Grile SET Intrebare = @intrebare, Raspuns1 = @rasp1, Raspuns2 = @rasp2, Raspuns3 = @rasp3, " +
                    "Raspuns4 = @rasp4, Raspuns5 = @rasp5, RaspunsCorect = @raspCorect WHERE Intrebare = '" + Start_Profesor.instance.modifiedQuestion + "'";
                SqlCommand updateCommand = new SqlCommand(updateString, sqlConnection); 
                updateCommand.Parameters.AddWithValue("@intrebare", richTextBox_intrebare.Text);
                updateCommand.Parameters.AddWithValue("@rasp1", richTextBox_rasp1.Text);
                updateCommand.Parameters.AddWithValue("@rasp2", richTextBox_rasp2.Text);
                updateCommand.Parameters.AddWithValue("@rasp3", richTextBox_rasp3.Text);
                updateCommand.Parameters.AddWithValue("@rasp4", richTextBox_rasp4.Text);
                updateCommand.Parameters.AddWithValue("@rasp5", richTextBox_rasp5.Text);
                int answer = 0;
                int index = 5;

                foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked == true)
                        answer = answer * 10 + index;

                    index--;
                }

                updateCommand.Parameters.AddWithValue("raspCorect", answer);
                updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            updateGrid();
            MessageBox.Show("Grila a fost modificiata cu succes!");
            this.Hide();
            Start_Profesor form = new Start_Profesor();
            form.ShowDialog();
        }
    }
}
