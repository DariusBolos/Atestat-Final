using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica___Test_Grile_Chimie
{
    public partial class Start_Profesor : MaterialForm
    {
        public static Start_Profesor instance = new Start_Profesor();
        public string modifiedQuestion = String.Empty;
        public int questionID = 0;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Start_Profesor()
        {
            InitializeComponent();
            instance = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private DataTable getQuestions()
        {          
            DataTable dt = new DataTable();
            dt.Columns.Add("Nr. Intrebare");
            dt.Columns.Add("Enunt");
            try
            {
                int index = 1;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT Intrebare FROM Grile";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                    dt.Rows.Add(index++, reader[0].ToString());
                    
                sqlConnection.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        private void deleteGrid(DataGridView dataGridView)
        {
            try
            {
                int index = 0;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                foreach (DataGridViewRow row in dataGridView.Rows)
                    if (row.Selected == true)
                    {
                        index = row.Index;
                        break;
                    }

                sqlConnection.Open();
                string deleteString = "DELETE FROM Grile WHERE Intrebare = '" + dataGridView.Rows[index].Cells[1].Value + "'";
                SqlCommand deleteCommand = new SqlCommand(deleteString, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                sqlConnection.Close();

                dataGridView.Rows.RemoveAt(index);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void modifyGrid(DataGridView dataGridView)
        {
            try
            {
                int index = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                    if (row.Selected == true)
                    {
                        index = row.Index;
                        break;
                    }

                if (dataGridView.Rows[index].Cells[1].Value != null)
                {
                    questionID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    this.Hide();
                    Modificare_Grila form = new Modificare_Grila();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Acest camp nu se poate modifica!");
            }
            catch
            {
                MessageBox.Show("Acest camp nu se poate modifica!");
            }
        }

        private void Start_Profesor_Load(object sender, EventArgs e)
        {
            this.Text = Autentificare.instance.accountName;
            DataTable dt = getQuestions();
            dataGridView_grile.DataSource = dt;
            dataGridView_grile.AutoResizeColumns();
            dataGridView_grile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_grile.MultiSelect = false;
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adaugare_Grila form = new Adaugare_Grila();
            form.ShowDialog();
        }

        private void button_sterge_Click(object sender, EventArgs e)
        {
            deleteGrid(dataGridView_grile);
        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            modifyGrid(dataGridView_grile);
        }
    }
}
