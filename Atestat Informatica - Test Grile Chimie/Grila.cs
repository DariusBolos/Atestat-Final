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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Informatica___Test_Grile_Chimie
{    
    public partial class Grila : MaterialForm
    {
        int nrOfQuestions = 0, nrCorrectQuestions = 0;
        Grid currentGrid;
        public static Grila instance = new Grila();  
        List<Button> answerButtons = new List<Button>();  
        Dictionary<string, int> selectedButtons = new Dictionary<string, int>();
        int type = Start_Elev.instance.type;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Chimie.mdf;Integrated Security=True;Connect Timeout=30";

        public Grila()
        {
            InitializeComponent();
            instance = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Home.instance.TManager.Theme;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void ButtonClick (object sender, EventArgs e)
        {     
            Button button = sender as Button;

            if(!button.Text.Contains("Raspunde"))
            {
                if (button.FlatStyle == FlatStyle.Standard)
                {
                    answerButtons.Add(button);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 2;
                }
                else
                {
                    button.FlatStyle = FlatStyle.Standard;
                    answerButtons.Remove(button);
                }
            }                           
        }

        private void generateNewQuestion()
        {
            answerButtons.Clear();
            foreach(Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Standard;
            }

            if(Start_Elev.instance.grids.Count > 0 && nrOfQuestions < 25)
            {
                nrOfQuestions++;
                Random random = new Random();
                int index = random.Next(0, Start_Elev.instance.grids.Count);
                currentGrid = Start_Elev.instance.grids.ElementAt(index);

                richTextBox_intrebare.Text = currentGrid.question;
                richTextBox1.Text = currentGrid.answer1;
                richTextBox2.Text = currentGrid.answer2;
                richTextBox3.Text = currentGrid.answer3;
                richTextBox4.Text = currentGrid.answer4;
                richTextBox5.Text = currentGrid.answer5;

                Start_Elev.instance.grids.RemoveAt(index);
            }
            else
            {
                insertNewScore();
                MessageBox.Show("Ati terminat testul!");
                this.Hide();
                Start_Elev form = new Start_Elev();
                form.ShowDialog();
            }
        }

        private void addDictionaries()
        {
            int counter = 5;
            foreach(Button button in this.Controls.OfType<Button>())
            {
                if(!button.Name.Contains("Raspunde"))
                {
                    selectedButtons.Add(button.Text, counter + 1);
                    counter--;
                }                    
            }            
        }

        private void Grila_Load(object sender, EventArgs e)
        {
            addDictionaries();
            generateNewQuestion();
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if(!button.Name.Contains("Raspunde"))
                    button.Click += ButtonClick;
            }
        }

        private int Answer()
        {
            List<int> frequency = new List<int>();
            int answer = 0;
            foreach (Button button in answerButtons)
                frequency.Add(selectedButtons[button.Text]);
 
            frequency.Sort();
            frequency.Reverse();
                
            foreach (int element in frequency)
                answer = answer * 10 + element + 1;

            return answer;
        }

        private void insertNewScore()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string insertString = "INSERT INTO Evaluari (ID_Elev, Data, Nota) VALUES (@id, @data, @nota)";
                SqlCommand insertCommand = new SqlCommand(insertString, sqlConnection);
                insertCommand.Parameters.AddWithValue("@id", Autentificare.instance.accountID);
                insertCommand.Parameters.AddWithValue("@data", DateTime.Now);
                insertCommand.Parameters.AddWithValue("@nota", nrCorrectQuestions);
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool verifyClickedButton()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.FlatStyle == FlatStyle.Flat)
                    return true;
            }       

            return false;
        }

        private void button_raspunde_Click(object sender, EventArgs e)
        {
            if (verifyClickedButton())
            {
                if (Answer() == currentGrid.correctAnswers)
                    nrCorrectQuestions++;

                label_score.Text = "Scor: " + nrCorrectQuestions + '/' + nrOfQuestions;

                timer1.Enabled = true;
                timer1.Start();
                int correctAnswer = currentGrid.correctAnswers;

                while (correctAnswer > 0)
                {
                    int answer = correctAnswer % 10;
                    foreach (Button button in this.Controls.OfType<Button>())
                    {
                        if (button.Name.Contains(answer.ToString()))
                            button.BackColor = Color.Green;
                    }

                    correctAnswer /= 10;
                }

                if (nrCorrectQuestions == 25 && type == 1)
                {
                    insertNewScore();
                    MessageBox.Show("Testul a fost incheiat cu puntajul: " + nrCorrectQuestions);
                    this.Hide();
                    Start_Elev form = new Start_Elev();
                    form.ShowDialog();
                }
            }
            else
                MessageBox.Show("Selecteaza un raspuns inainte de a raspunde la intrebare!");
        }

        int second = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if(second % 2 == 0)
            {
                timer1.Stop();
                generateNewQuestion();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_Elev form = new Start_Elev();
            form.ShowDialog();
        }
    }
}
