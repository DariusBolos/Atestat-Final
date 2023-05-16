namespace Atestat_Informatica___Test_Grile_Chimie
{
    partial class Afisare_Grile
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
            this.dataGridView_grile = new System.Windows.Forms.DataGridView();
            this.materialButton_back = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_grile
            // 
            this.dataGridView_grile.AllowUserToAddRows = false;
            this.dataGridView_grile.AllowUserToDeleteRows = false;
            this.dataGridView_grile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_grile.Location = new System.Drawing.Point(28, 81);
            this.dataGridView_grile.Name = "dataGridView_grile";
            this.dataGridView_grile.ReadOnly = true;
            this.dataGridView_grile.Size = new System.Drawing.Size(764, 291);
            this.dataGridView_grile.TabIndex = 0;
            // 
            // materialButton_back
            // 
            this.materialButton_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_back.Depth = 0;
            this.materialButton_back.HighEmphasis = true;
            this.materialButton_back.Icon = null;
            this.materialButton_back.Location = new System.Drawing.Point(634, 399);
            this.materialButton_back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_back.Name = "materialButton_back";
            this.materialButton_back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_back.Size = new System.Drawing.Size(158, 36);
            this.materialButton_back.TabIndex = 1;
            this.materialButton_back.Text = "Inapoi";
            this.materialButton_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_back.UseAccentColor = false;
            this.materialButton_back.UseVisualStyleBackColor = true;
            this.materialButton_back.Click += new System.EventHandler(this.materialButton_back_Click);
            // 
            // Afisare_Grile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 456);
            this.Controls.Add(this.materialButton_back);
            this.Controls.Add(this.dataGridView_grile);
            this.Name = "Afisare_Grile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Grile";
            this.Load += new System.EventHandler(this.Afisare_Grile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_grile;
        private MaterialSkin.Controls.MaterialButton materialButton_back;
    }
}