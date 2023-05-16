using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica___Test_Grile_Chimie
{    
    public partial class Adaugare_Grila : MaterialForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Adaugare_Grila()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private bool checkBlankFields()
        {
            foreach(RichTextBox richTextBox in this.Controls.OfType<RichTextBox>())
                if(richTextBox.Text == string.Empty)
                    return false;

            return true;
        }

        private int countCorrectAnswers()
        {
            int counter = 0;
            foreach(CheckBox checkBox in this.Controls.OfType<CheckBox>())
                if(checkBox.Checked == true)
                    counter++;

            return counter;
        }

        private void insertNewGrid()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string insertString = "INSERT INTO Grile (Intrebare, Raspuns1, Raspuns2, Raspuns3, Raspuns4, Raspuns5, RaspunsCorect) " +
                    "VALUES (@intrebare, @rasp1, @rasp2, @rasp3, @rasp4, @rasp5, @raspCorect)";
                SqlCommand insertCommand = new SqlCommand(insertString, sqlConnection);
                insertCommand.Parameters.AddWithValue("@intrebare", richTextBox_intrebare.Text);
                insertCommand.Parameters.AddWithValue("@rasp1", richTextBox_rasp1.Text);
                insertCommand.Parameters.AddWithValue("@rasp2", richTextBox_rasp2.Text);
                insertCommand.Parameters.AddWithValue("@rasp3", richTextBox_rasp3.Text);
                insertCommand.Parameters.AddWithValue("@rasp4", richTextBox_rasp4.Text);
                insertCommand.Parameters.AddWithValue("@rasp5", richTextBox_rasp5.Text);
                int answer = 0;
                int index = 5;

                foreach(CheckBox checkBox in this.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked == true)
                        answer = answer * 10 + index;

                    index--;
                }

                insertCommand.Parameters.AddWithValue("@raspCorect", answer);
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            if (checkBlankFields())
            {
                int countMarked = countCorrectAnswers();
                if (countMarked < 5 && countMarked > 0)
                {
                    insertNewGrid();
                    MessageBox.Show("Grila inserata cu succes!");
                    this.Hide();
                    Start_Profesor form = new Start_Profesor();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Minim unul si maxim 4 raspunsuri corecte pot fi selectate!");
            }
            else
                MessageBox.Show("Completati toate campurile!");
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Profesor form = new Start_Profesor();
            form.ShowDialog();
        }
    }
}
