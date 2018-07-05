namespace CaoMedor_App
{
    partial class FormEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEsqueciSenha));
            this.metroButtonEnviarSenha = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTextBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinnerLogin = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonEnviarSenha
            // 
            this.metroButtonEnviarSenha.Enabled = false;
            this.metroButtonEnviarSenha.Location = new System.Drawing.Point(137, 260);
            this.metroButtonEnviarSenha.Name = "metroButtonEnviarSenha";
            this.metroButtonEnviarSenha.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEnviarSenha.TabIndex = 10;
            this.metroButtonEnviarSenha.Text = "Enviar";
            this.metroButtonEnviarSenha.UseSelectable = true;
            this.metroButtonEnviarSenha.Click += new System.EventHandler(this.metroButtonEnviarSenha_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.metroTextBoxEmail);
            this.panel1.Location = new System.Drawing.Point(23, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 106);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CaoMedor_App.Properties.Resources.EsqueciSenha;
            this.pictureBox2.Location = new System.Drawing.Point(18, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // metroTextBoxEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxEmail.CustomButton.Image = null;
            this.metroTextBoxEmail.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.metroTextBoxEmail.CustomButton.Name = "";
            this.metroTextBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxEmail.CustomButton.Visible = false;
            this.metroTextBoxEmail.IconRight = true;
            this.metroTextBoxEmail.Lines = new string[0];
            this.metroTextBoxEmail.Location = new System.Drawing.Point(18, 64);
            this.metroTextBoxEmail.MaxLength = 32767;
            this.metroTextBoxEmail.Name = "metroTextBoxEmail";
            this.metroTextBoxEmail.PasswordChar = '\0';
            this.metroTextBoxEmail.PromptText = "Email";
            this.metroTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmail.SelectedText = "";
            this.metroTextBoxEmail.SelectionLength = 0;
            this.metroTextBoxEmail.SelectionStart = 0;
            this.metroTextBoxEmail.ShortcutsEnabled = true;
            this.metroTextBoxEmail.Size = new System.Drawing.Size(261, 23);
            this.metroTextBoxEmail.TabIndex = 3;
            this.metroTextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxEmail.UseSelectable = true;
            this.metroTextBoxEmail.WaterMark = "Email";
            this.metroTextBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxEmail.TextChanged += new System.EventHandler(this.metroTextBoxEmail_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(304, 51);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Enviaremos um lembrete de senha no mesmo email utilizado no cadastro.";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.WrapToLine = true;
            // 
            // metroProgressSpinnerLogin
            // 
            this.metroProgressSpinnerLogin.Location = new System.Drawing.Point(108, 260);
            this.metroProgressSpinnerLogin.Maximum = 100;
            this.metroProgressSpinnerLogin.Name = "metroProgressSpinnerLogin";
            this.metroProgressSpinnerLogin.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinnerLogin.TabIndex = 11;
            this.metroProgressSpinnerLogin.UseSelectable = true;
            this.metroProgressSpinnerLogin.Visible = false;
            // 
            // FormEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.metroProgressSpinnerLogin);
            this.Controls.Add(this.metroButtonEnviarSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEsqueciSenha";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Esqueceu a Senha?";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonEnviarSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public MetroFramework.Controls.MetroTextBox metroTextBoxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerLogin;
    }
}