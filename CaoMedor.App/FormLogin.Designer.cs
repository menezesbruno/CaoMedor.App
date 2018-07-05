namespace CaoMedor_App
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.metroPanelLogin = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinnerLogin = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLinkEsqueciSenha = new MetroFramework.Controls.MetroLink();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btSobre = new System.Windows.Forms.PictureBox();
            this.metroPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanelLogin
            // 
            this.metroPanelLogin.Controls.Add(this.metroTextBoxSenha);
            this.metroPanelLogin.Controls.Add(this.metroTextBoxUsuario);
            this.metroPanelLogin.HorizontalScrollbarBarColor = true;
            this.metroPanelLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelLogin.HorizontalScrollbarSize = 10;
            this.metroPanelLogin.Location = new System.Drawing.Point(23, 232);
            this.metroPanelLogin.Name = "metroPanelLogin";
            this.metroPanelLogin.Size = new System.Drawing.Size(250, 93);
            this.metroPanelLogin.TabIndex = 1;
            this.metroPanelLogin.VerticalScrollbarBarColor = true;
            this.metroPanelLogin.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelLogin.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxSenha
            // 
            // 
            // 
            // 
            this.metroTextBoxSenha.CustomButton.Image = null;
            this.metroTextBoxSenha.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.metroTextBoxSenha.CustomButton.Name = "";
            this.metroTextBoxSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSenha.CustomButton.TabIndex = 1;
            this.metroTextBoxSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSenha.CustomButton.UseSelectable = true;
            this.metroTextBoxSenha.CustomButton.Visible = false;
            this.metroTextBoxSenha.Lines = new string[0];
            this.metroTextBoxSenha.Location = new System.Drawing.Point(46, 60);
            this.metroTextBoxSenha.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.metroTextBoxSenha.MaxLength = 32767;
            this.metroTextBoxSenha.Name = "metroTextBoxSenha";
            this.metroTextBoxSenha.PasswordChar = '●';
            //this.metroTextBoxSenha.PromptText = "Senha";
            this.metroTextBoxSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSenha.SelectedText = "";
            this.metroTextBoxSenha.SelectionLength = 0;
            this.metroTextBoxSenha.SelectionStart = 0;
            this.metroTextBoxSenha.ShortcutsEnabled = true;
            this.metroTextBoxSenha.ShowClearButton = true;
            this.metroTextBoxSenha.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxSenha.TabIndex = 2;
            this.metroTextBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxSenha.UseSelectable = true;
            this.metroTextBoxSenha.UseSystemPasswordChar = true;
            this.metroTextBoxSenha.WaterMark = "Senha";
            this.metroTextBoxSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSenha.TextChanged += new System.EventHandler(this.metroTextBoxSenha_TextChanged);
            // 
            // metroTextBoxUsuario
            // 
            // 
            // 
            // 
            this.metroTextBoxUsuario.CustomButton.Image = null;
            this.metroTextBoxUsuario.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.metroTextBoxUsuario.CustomButton.Name = "";
            this.metroTextBoxUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsuario.CustomButton.TabIndex = 1;
            this.metroTextBoxUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsuario.CustomButton.UseSelectable = true;
            this.metroTextBoxUsuario.CustomButton.Visible = false;
            this.metroTextBoxUsuario.Lines = new string[0];
            this.metroTextBoxUsuario.Location = new System.Drawing.Point(46, 9);
            this.metroTextBoxUsuario.Margin = new System.Windows.Forms.Padding(25);
            this.metroTextBoxUsuario.MaxLength = 32767;
            this.metroTextBoxUsuario.Name = "metroTextBoxUsuario";
            this.metroTextBoxUsuario.PasswordChar = '\0';
            //this.metroTextBoxUsuario.PromptText = "Usuário";
            this.metroTextBoxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsuario.SelectedText = "";
            this.metroTextBoxUsuario.SelectionLength = 0;
            this.metroTextBoxUsuario.SelectionStart = 0;
            this.metroTextBoxUsuario.ShortcutsEnabled = true;
            this.metroTextBoxUsuario.ShowClearButton = true;
            this.metroTextBoxUsuario.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxUsuario.TabIndex = 1;
            this.metroTextBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxUsuario.UseSelectable = true;
            this.metroTextBoxUsuario.WaterMark = "Usuário";
            this.metroTextBoxUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxUsuario.TextChanged += new System.EventHandler(this.metroTextBoxUsuario_TextChanged);
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Enabled = false;
            this.metroButtonLogin.Location = new System.Drawing.Point(106, 340);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.metroButtonLogin.TabIndex = 3;
            this.metroButtonLogin.Text = "&Login";
            this.metroButtonLogin.UseSelectable = true;
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroProgressSpinnerLogin
            // 
            this.metroProgressSpinnerLogin.Location = new System.Drawing.Point(77, 340);
            this.metroProgressSpinnerLogin.Maximum = 100;
            this.metroProgressSpinnerLogin.Name = "metroProgressSpinnerLogin";
            this.metroProgressSpinnerLogin.Size = new System.Drawing.Size(23, 23);
            this.metroProgressSpinnerLogin.Speed = 2F;
            this.metroProgressSpinnerLogin.Spinning = false;
            this.metroProgressSpinnerLogin.TabIndex = 3;
            this.metroProgressSpinnerLogin.TabStop = false;
            this.metroProgressSpinnerLogin.UseSelectable = true;
            this.metroProgressSpinnerLogin.Visible = false;
            // 
            // metroLinkEsqueciSenha
            // 
            this.metroLinkEsqueciSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLinkEsqueciSenha.Location = new System.Drawing.Point(69, 376);
            this.metroLinkEsqueciSenha.Name = "metroLinkEsqueciSenha";
            this.metroLinkEsqueciSenha.Size = new System.Drawing.Size(150, 23);
            this.metroLinkEsqueciSenha.TabIndex = 4;
            this.metroLinkEsqueciSenha.Text = "&Esqueci a senha";
            this.metroLinkEsqueciSenha.UseSelectable = true;
            this.metroLinkEsqueciSenha.Click += new System.EventHandler(this.metroLinkEsqueciSenha_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CaoMedor_App.Properties.Resources.CaoMedor_Login;
            this.pictureBoxLogo.Location = new System.Drawing.Point(23, 63);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.Transparent;
            this.btSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSobre.Image = global::CaoMedor_App.Properties.Resources.Sobre;
            this.btSobre.Location = new System.Drawing.Point(241, 38);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(32, 32);
            this.btSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSobre.TabIndex = 53;
            this.btSobre.TabStop = false;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.metroButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(296, 407);
            this.Controls.Add(this.btSobre);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.metroLinkEsqueciSenha);
            this.Controls.Add(this.metroPanelLogin);
            this.Controls.Add(this.metroProgressSpinnerLogin);
            this.Controls.Add(this.metroButtonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "CãoMedor Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.metroPanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MetroFramework.Controls.MetroPanel metroPanelLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSenha;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsuario;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerLogin;
        private MetroFramework.Controls.MetroLink metroLinkEsqueciSenha;
        private System.Windows.Forms.PictureBox btSobre;
    }
}

