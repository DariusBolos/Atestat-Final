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
    public partial class Home : MaterialForm
    {
        public MaterialSkinManager TManager = MaterialSkinManager.Instance;
        public static Home instance = new Home();
        public Home()
        {
            InitializeComponent();
            instance = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void button_inregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inregistrare form = new Inregistrare();
            form.ShowDialog();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare form = new Autentificare();
            form.ShowDialog();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(TManager.Theme == MaterialSkinManager.Themes.LIGHT)
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void clearGrile()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
                string deleteString = "DELETE FROM Grile";
                string resetIdentity = String.Format("DBCC CHECKIDENT ('Grile', RESEED, 0)");
                SqlCommand deleteCommand = new SqlCommand(deleteString, sqlConnection);
                SqlCommand resetIdentityCommand = new SqlCommand(resetIdentity, sqlConnection);
                deleteCommand.ExecuteNonQuery();
                resetIdentityCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //clearGrile();
        }
    }
}
