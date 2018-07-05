using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace CaoMedor_App
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void Login()
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=CaoMedor.db; Version = 3"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT username,password FROM users WHERE username=@Username AND password=@Password", conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", metroTextBoxUsuario.Text);
                        cmd.Parameters.AddWithValue("@Password", metroTextBoxSenha.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            var count = 0;
                            while (reader.Read())
                            {
                                count = count + 1;
                            }
                            if (count == 1 && metroTextBoxSenha.Text == "admin")
                            {
                                FormAlteraSenha FormAlteraSenha = new FormAlteraSenha();
                                FormAlteraSenha.Show();
                                this.Hide();
                            }

                            else if (count == 1 && metroTextBoxSenha.Text != "admin")
                            {
                                FormPrincipal FormPrincipal = new FormPrincipal();
                                FormPrincipal.Show();
                                this.Hide();
                            }

                            else if (count == 0)
                            {
                                MessageBox.Show("Usuário e/ou senha inválidos!", "CãoMedor",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SpinnerOn()
        {
            metroProgressSpinnerLogin.Value = 65;
            metroProgressSpinnerLogin.Visible = true;
            metroProgressSpinnerLogin.Spinning = true;
        }

        private void SpinnerOff()
        {
            metroProgressSpinnerLogin.Value = 0;
            metroProgressSpinnerLogin.Visible = false;
            metroProgressSpinnerLogin.Spinning = false;
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            metroPanelLogin.Enabled = false;

            SpinnerOn();
            Login();
            SpinnerOff();

            metroPanelLogin.Enabled = true;
        }

        private void metroTextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxUsuario.Text != "" && metroTextBoxSenha.Text != "")
            {
                metroButtonLogin.Enabled = true;
            }
            else
            {
                metroButtonLogin.Enabled = false;
            }
        }

        private void metroTextBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxUsuario.Text != "" && metroTextBoxSenha.Text != "")
            {
                metroButtonLogin.Enabled = true;
            }
            else
            {
                metroButtonLogin.Enabled = false;
            }
        }

        private void metroLinkEsqueciSenha_Click(object sender, EventArgs e)
        {
            FormEsqueciSenha newFormEsqueciSenha = new FormEsqueciSenha();
            newFormEsqueciSenha.Show();
        }

        private void btSobre_Click(object sender, EventArgs e)
        {

            FormSobre newFormSobre = new FormSobre();
            newFormSobre.Show();

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
