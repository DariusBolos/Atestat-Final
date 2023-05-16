namespace Atestat_Informatica___Test_Grile_Chimie
{
    partial class Home
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
            this.button_login = new MaterialSkin.Controls.MaterialButton();
            this.button_inregistrare = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.AutoSize = false;
            this.button_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_login.Depth = 0;
            this.button_login.HighEmphasis = true;
            this.button_login.Icon = null;
            this.button_login.Location = new System.Drawing.Point(666, 396);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_login.Name = "button_login";
            this.button_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_login.Size = new System.Drawing.Size(131, 36);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Autentificare";
            this.button_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_login.UseAccentColor = false;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_inregistrare
            // 
            this.button_inregistrare.AutoSize = false;
            this.button_inregistrare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_inregistrare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_inregistrare.Depth = 0;
            this.button_inregistrare.HighEmphasis = true;
            this.button_inregistrare.Icon = null;
            this.button_inregistrare.Location = new System.Drawing.Point(20, 396);
            this.button_inregistrare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_inregistrare.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_inregistrare.Name = "button_inregistrare";
            this.button_inregistrare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_inregistrare.Size = new System.Drawing.Size(122, 36);
            this.button_inregistrare.TabIndex = 5;
            this.button_inregistrare.Text = "Inregistrare";
            this.button_inregistrare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_inregistrare.UseAccentColor = false;
            this.button_inregistrare.UseVisualStyleBackColor = true;
            this.button_inregistrare.Click += new System.EventHandler(this.button_inregistrare_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(77, 15);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(100, 37);
            this.materialSwitch1.TabIndex = 6;
            this.materialSwitch1.Text = "Inchis";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Deschis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialSwitch1);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(601, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(601, 91);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 17);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Tema:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atestat_Informatica___Test_Grile_Chimie.Properties.Resources.GettyImages_545286316_433dd345105e4c6ebe4cdd8d2317fdaa;
            this.pictureBox1.Location = new System.Drawing.Point(20, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_inregistrare);
            this.Controls.Add(this.button_login);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grile - Pregatire pentru Admitere";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton button_login;
        private MaterialSkin.Controls.MaterialButton button_inregistrare;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}