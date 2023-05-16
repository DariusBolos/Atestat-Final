namespace Atestat_Informatica___Test_Grile_Chimie
{
    partial class Start_Profesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sterge = new MaterialSkin.Controls.MaterialButton();
            this.button_adauga = new MaterialSkin.Controls.MaterialButton();
            this.button_modifica = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView_grile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sterge
            // 
            this.button_sterge.AutoSize = false;
            this.button_sterge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_sterge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_sterge.Depth = 0;
            this.button_sterge.HighEmphasis = true;
            this.button_sterge.Icon = null;
            this.button_sterge.Location = new System.Drawing.Point(694, 428);
            this.button_sterge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_sterge.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_sterge.Size = new System.Drawing.Size(168, 49);
            this.button_sterge.TabIndex = 16;
            this.button_sterge.Text = "Sterge";
            this.button_sterge.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_sterge.UseAccentColor = false;
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.button_sterge_Click);
            // 
            // button_adauga
            // 
            this.button_adauga.AutoSize = false;
            this.button_adauga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_adauga.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_adauga.Depth = 0;
            this.button_adauga.HighEmphasis = true;
            this.button_adauga.Icon = null;
            this.button_adauga.Location = new System.Drawing.Point(413, 428);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_adauga.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_adauga.Size = new System.Drawing.Size(168, 49);
            this.button_adauga.TabIndex = 15;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_adauga.UseAccentColor = false;
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button_modifica
            // 
            this.button_modifica.AutoSize = false;
            this.button_modifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_modifica.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_modifica.Depth = 0;
            this.button_modifica.HighEmphasis = true;
            this.button_modifica.Icon = null;
            this.button_modifica.Location = new System.Drawing.Point(131, 428);
            this.button_modifica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_modifica.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_modifica.Size = new System.Drawing.Size(168, 49);
            this.button_modifica.TabIndex = 14;
            this.button_modifica.Text = "Modifica";
            this.button_modifica.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_modifica.UseAccentColor = false;
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // dataGridView_grile
            // 
            this.dataGridView_grile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_grile.Location = new System.Drawing.Point(131, 138);
            this.dataGridView_grile.Name = "dataGridView_grile";
            this.dataGridView_grile.ReadOnly = true;
            this.dataGridView_grile.Size = new System.Drawing.Size(731, 247);
            this.dataGridView_grile.TabIndex = 13;
            // 
            // Start_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 567);
            this.Controls.Add(this.button_sterge);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.button_modifica);
            this.Controls.Add(this.dataGridView_grile);
            this.Name = "Start_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina de start";
            this.Load += new System.EventHandler(this.Start_Profesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton button_sterge;
        private MaterialSkin.Controls.MaterialButton button_adauga;
        private MaterialSkin.Controls.MaterialButton button_modifica;
        private System.Windows.Forms.DataGridView dataGridView_grile;
    }
}