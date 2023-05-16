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
    public partial class Start_Elev : MaterialForm
    {
        public int type = 0;
        public static Start_Elev instance = new Start_Elev();
        public List<Grid> grids = new List<Grid>();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
        public Start_Elev()
        {
            InitializeComponent();
            instance = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void loadResults()
        {
            try
            {
                int index = 0;
                string[] columns = { "Nr.", "Punctaj", "Data" };
                DataTable dt = new DataTable(); 
                for(int iterator = 0; iterator < columns.Length; iterator++)
                    dt.Columns.Add(columns[iterator]); 
                System.Globalization.CultureInfo enUs = new System.Globalization.CultureInfo("en-US");

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string selectString = "SELECT Nota, Data FROM Evaluari WHERE ID_ELEV = '" + Autentificare.instance.accountID + "'";
                SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    index++;
                    dt.Rows.Add(index, reader[0].ToString(), reader[1].ToString());
                }

                sqlConnection.Close();
                dataGridView_punctaje.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void getGrids()
        {
            grids.Clear();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string selectString = "SELECT * FROM Grile";
            SqlCommand selectCommand = new SqlCommand(selectString, sqlConnection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Grid grid = new Grid(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                    reader[5].ToString(), reader[6].ToString(), Convert.ToInt32(reader[7]));
                grids.Add(grid);
            }

            sqlConnection.Close();
        }

        private void Start_Elev_Load(object sender, EventArgs e)
        {
            this.Text = Autentificare.instance.accountName;
            comboBox1.Items.Add("Simulare");
            comboBox1.Items.Add("Antrenament (Grile Amestecate)");
            getGrids();
            loadResults();
            dataGridView_punctaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_punctaje.AutoResizeColumns();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Antrenament (Grile Amestecate)")
            {
                type = 2;
                this.Hide();
                Grila form = new Grila();
                form.ShowDialog();
            }
            else
                if (comboBox1.Text == "Simulare")
            {
                type = 1;
                this.Hide();
                Grila form = new Grila();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Selecteaza tipul testului!");
        }

        private void button_grile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Afisare_Grile form = new Afisare_Grile();
            form.ShowDialog();
        }
    }
}
