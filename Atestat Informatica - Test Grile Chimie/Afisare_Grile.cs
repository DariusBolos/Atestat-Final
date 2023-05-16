using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica___Test_Grile_Chimie
{
    public partial class Afisare_Grile : MaterialForm
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public static Afisare_Grile instance = new Afisare_Grile();
        public string intrebare = String.Empty;
        public int id = 0;
        public Afisare_Grile()
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
            dt.Columns.Add("Nr.");
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                intrebare = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                id = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Vizualizare_Grila form = new Vizualizare_Grila();
                form.ShowDialog();
            }
        }

        private void Afisare_Grile_Load(object sender, EventArgs e)
        {
            DataTable dt = getQuestions();
            dataGridView_grile.DataSource = dt;
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "Click pentru a vizualiza grila!";
            dataGridView_grile.Columns.Add(dataGridViewButtonColumn);   
            
            dataGridView_grile.AutoResizeColumns();
            dataGridView_grile.AutoResizeRows();
            dataGridView_grile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_grile.MultiSelect = false;
            dataGridView_grile.CellContentClick += dataGridView_CellContentClick;
        }

        private void materialButton_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Elev form = new Start_Elev();
            form.ShowDialog();
        }
    }
}
