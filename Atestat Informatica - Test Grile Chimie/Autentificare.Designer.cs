namespace Atestat_Informatica___Test_Grile_Chimie
{
    partial class Autentificare
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
            this.button_autentificare = new MaterialSkin.Controls.MaterialButton();
            this.button_anulare = new MaterialSkin.Controls.MaterialButton();
            this.textBox_parola = new MaterialSkin.Controls.MaterialTextBox2();
            this.checkBox_parola = new MaterialSkin.Controls.MaterialCheckbox();
            this.textBox_email = new MaterialSkin.Controls.MaterialTextBox2();
            this.label_email = new MaterialSkin.Controls.MaterialLabel();
            this.label_parola = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // button_autentificare
            // 
            this.button_autentificare.AutoSize = false;
            this.button_autentificare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_autentificare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_autentificare.Depth = 0;
            this.button_autentificare.HighEmphasis = true;
            this.button_autentificare.Icon = null;
            this.button_autentificare.Location = new System.Drawing.Point(629, 379);
            this.button_autentificare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_autentificare.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_autentificare.Name = "button_autentificare";
            this.button_autentificare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_autentificare.Size = new System.Drawing.Size(157, 47);
            this.button_autentificare.TabIndex = 14;
            this.button_autentificare.Text = "Autentificare";
            this.button_autentificare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_autentificare.UseAccentColor = false;
            this.button_autentificare.UseVisualStyleBackColor = true;
            this.button_autentificare.Click += new System.EventHandler(this.button_autentificare_Click);
            // 
            // button_anulare
            // 
            this.button_anulare.AutoSize = false;
            this.button_anulare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_anulare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button_anulare.Depth = 0;
            this.button_anulare.HighEmphasis = true;
            this.button_anulare.Icon = null;
            this.button_anulare.Location = new System.Drawing.Point(208, 390);
            this.button_anulare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_anulare.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_anulare.Name = "button_anulare";
            this.button_anulare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button_anulare.Size = new System.Drawing.Size(117, 36);
            this.button_anulare.TabIndex = 15;
            this.button_anulare.Text = "Inapoi";
            this.button_anulare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button_anulare.UseAccentColor = false;
            this.button_anulare.UseVisualStyleBackColor = true;
            this.button_anulare.Click += new System.EventHandler(this.button_anulare_Click);
            // 
            // textBox_parola
            // 
            this.textBox_parola.AnimateReadOnly = false;
            this.textBox_parola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox_parola.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox_parola.Depth = 0;
            this.textBox_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_parola.HideSelection = true;
            this.textBox_parola.LeadingIcon = null;
            this.textBox_parola.Location = new System.Drawing.Point(396, 212);
            this.textBox_parola.MaxLength = 32767;
            this.textBox_parola.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '*';
            this.textBox_parola.PrefixSuffixText = null;
            this.textBox_parola.ReadOnly = false;
            this.textBox_parola.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_parola.SelectedText = "";
            this.textBox_parola.SelectionLength = 0;
            this.textBox_parola.SelectionStart = 0;
            this.textBox_parola.ShortcutsEnabled = true;
            this.textBox_parola.Size = new System.Drawing.Size(302, 48);
            this.textBox_parola.TabIndex = 17;
            this.textBox_parola.TabStop = false;
            this.textBox_parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_parola.TrailingIcon = null;
            this.textBox_parola.UseSystemPasswordChar = false;
            // 
            // checkBox_parola
            // 
            this.checkBox_parola.AutoSize = true;
            this.checkBox_parola.Depth = 0;
            this.checkBox_parola.Location = new System.Drawing.Point(396, 263);
            this.checkBox_parola.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_parola.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_parola.Name = "checkBox_parola";
            this.checkBox_parola.ReadOnly = false;
            this.checkBox_parola.Ripple = true;
            this.checkBox_parola.Size = new System.Drawing.Size(147, 37);
            this.checkBox_parola.TabIndex = 18;
            this.checkBox_parola.Text = "Afiseaza Parola";
            this.checkBox_parola.UseVisualStyleBackColor = true;
            this.checkBox_parola.CheckedChanged += new System.EventHandler(this.checkBox_parola_CheckedChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.AnimateReadOnly = false;
            this.textBox_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox_email.Depth = 0;
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_email.HideSelection = true;
            this.textBox_email.LeadingIcon = null;
            this.textBox_email.Location = new System.Drawing.Point(396, 154);
            this.textBox_email.MaxLength = 32767;
            this.textBox_email.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.PasswordChar = '\0';
            this.textBox_email.PrefixSuffixText = null;
            this.textBox_email.ReadOnly = false;
            this.textBox_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_email.SelectedText = "";
            this.textBox_email.SelectionLength = 0;
            this.textBox_email.SelectionStart = 0;
            this.textBox_email.ShortcutsEnabled = true;
            this.textBox_email.Size = new System.Drawing.Size(302, 48);
            this.textBox_email.TabIndex = 19;
            this.textBox_email.TabStop = false;
            this.textBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_email.TrailingIcon = null;
            this.textBox_email.UseSystemPasswordChar = false;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Depth = 0;
            this.label_email.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_email.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.label_email.Location = new System.Drawing.Point(258, 164);
            this.label_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(67, 29);
            this.label_email.TabIndex = 20;
            this.label_email.Text = "Email:";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Depth = 0;
            this.label_parola.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_parola.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.label_parola.Location = new System.Drawing.Point(258, 222);
            this.label_parola.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(76, 29);
            this.label_parola.TabIndex = 21;
            this.label_parola.Text = "Parola:";
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 497);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.checkBox_parola);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.button_anulare);
            this.Controls.Add(this.button_autentificare);
            this.Name = "Autentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton button_autentificare;
        private MaterialSkin.Controls.MaterialButton button_anulare;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_parola;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_parola;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_email;
        private MaterialSkin.Controls.MaterialLabel label_email;
        private MaterialSkin.Controls.MaterialLabel label_parola;
    }
}