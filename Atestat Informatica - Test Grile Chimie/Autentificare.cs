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
    public partial class Autentificare : MaterialForm
    {
        public static Autentificare instance = new Autentificare();
        int accountType = 0;
        public string accountName = string.Empty;
        public int accountID = 0; 
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Autentificare()
        {
            InitializeComponent();
            instance = this;
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

        private bool checkUser()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT * FROM Utilizatori";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                    if (reader[4].ToString() == textBox_email.Text && reader[3].ToString() == textBox_parola.Text)
                    {
                        accountName = reader[2].ToString();
                        accountType = Convert.ToInt32(reader[1]);
                        accountID = Convert.ToInt32(reader[0]);
                        sqlConnection.Close();
                        return true;
                    }
                sqlConnection.Close();

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button_autentificare_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text != "" && textBox_parola.Text != "")
            {
                if (textBox_email.Text.Contains('@') && textBox_email.Text.Contains('.'))
                {
                    if (checkUser())
                    {
                        this.Hide();
                        if(accountType == 1)
                        {
                            Start_Elev form = new Start_Elev();
                            form.ShowDialog();
                        }
                        else
                        {
                            Start_Profesor form = new Start_Profesor();
                            form.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("Nu a fost gasit un cont cu acest email!");
                }
                else
                    MessageBox.Show("Introduceti un email valid!");
            }
            else
                MessageBox.Show("Toate campurile sunt obligatorii!");
        }

        private void checkBox_parola_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_parola.PasswordChar == '*')
                textBox_parola.PasswordChar = '\0';
            else
                textBox_parola.PasswordChar = '*';
        }
    }
}
