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
    public partial class Inregistrare : MaterialForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        List<MaterialTextBox2> textBoxes = new List<MaterialTextBox2>();
        public Inregistrare()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void button_anulare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.ShowDialog();  
        }

        private void checkBox_parola_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_parola.PasswordChar == '*')
                textBox_parola.PasswordChar = '\0';
            else
                textBox_parola.PasswordChar = '*';
        }

        private void checkBox_confirmareParola_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_confirmareParola.PasswordChar == '*')
                textBox_confirmareParola.PasswordChar = '\0';
            else
                textBox_confirmareParola.PasswordChar = '*';
        }

        private bool checkBlankTextbox(List<MaterialTextBox2> textBoxes)
        {
            foreach (MaterialTextBox2 textBox in textBoxes)
                if (textBox.Text == "")
                    return false;
            return true;
        }

        private bool checkNewUser()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT Email FROM Utilizatori";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                    if (reader[0].ToString() == textBox_email.Text)
                    {
                        sqlConnection.Close();
                        return false;
                    }
                sqlConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void insertNewUser()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string insertString = "INSERT INTO Utilizatori (Tip, NumePrenume, Parola, Email) VALUES (@tip, @nume, @parola, @email)";
                SqlCommand insertCommand = new SqlCommand(insertString, sqlConnection);
                int typeOfAccount = 0;

                if (radioButton_elev.Checked == true)
                    typeOfAccount = 1;
                else
                    typeOfAccount = 2;

                insertCommand.Parameters.AddWithValue("@tip", typeOfAccount);
                insertCommand.Parameters.AddWithValue("@nume", textBox_nume.Text);
                insertCommand.Parameters.AddWithValue("@parola", textBox_parola.Text);
                insertCommand.Parameters.AddWithValue("@email", textBox_email.Text);
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void button_inregistrare_Click(object sender, EventArgs e)
        {
            if (checkBlankTextbox(textBoxes))
            {
                if (textBox_email.Text.Contains('@') && textBox_email.Text.Contains('.'))
                {
                    if (textBox_parola.Text == textBox_confirmareParola.Text)
                    {
                        if (radioButton_elev.Checked == true || radioButton_profesor.Checked == true)
                        {
                            if (checkNewUser())
                            {
                                insertNewUser();
                                this.Hide();
                                Autentificare form = new Autentificare();
                                form.ShowDialog(); 
                            }                               
                            else
                                MessageBox.Show("Exista deja un utilizator inregistrat cu acest email!");
                        }                            
                        else
                            MessageBox.Show("Selecteaza un tip de cont!");
                    }
                    else
                        MessageBox.Show("Parolele nu coincid!");
                }
                else
                    MessageBox.Show("Introduceti un email valid!");
            }
            else
                MessageBox.Show("Toate campurile sunt obligatorii!");
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {            
            textBoxes.Add(textBox_nume);
            textBoxes.Add(textBox_email);
            textBoxes.Add(textBox_parola);
            textBoxes.Add(textBox_confirmareParola);
        }
    }
}
