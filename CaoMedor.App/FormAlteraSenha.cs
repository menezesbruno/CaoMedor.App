using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;


namespace CaoMedor_App
{
    public partial class FormAlteraSenha : MetroForm
    {
        public FormAlteraSenha()
        {
            InitializeComponent();
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

        private void CarregaFormPrincipal()
        {
            FormPrincipal FormPrincipal = new FormPrincipal();
            FormPrincipal.Show();
            this.Hide();
        }

        private void AlterarSenha()
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=CaoMedor.db; Version = 3"))
                {
                    conn.Open();
                    using (var AlterarDadosPadrao = new SQLiteCommand("UPDATE users SET password = @AlterarSenha, email = @Email where id = 1", conn))
                    {
                        try
                        {
                            AlterarDadosPadrao.Parameters.AddWithValue("@AlterarSenha", metroTextBoxAlteraSenha1.Text);
                            AlterarDadosPadrao.Parameters.AddWithValue("@Email", metroTextBoxEmail.Text);

                            int row = AlterarDadosPadrao.ExecuteNonQuery();
                            //AlterarDadosPadrao.Connection.Close();
                            EnviarEmail();

                            MessageBox.Show("Senha alterada!", "CãoMedor",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1);
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show(ex.Message);
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

        private void EnviarEmail()
        {
            string fromEmail = "contato@caomedor.com.br";
            MailMessage mailMessage = new MailMessage(fromEmail, metroTextBoxEmail.Text, "Sua nova senha", "Olá!" + System.Environment.NewLine + "Este é apenas um lembrete da sua nova senha do CãoMedor." + System.Environment.NewLine + "A senha é: " + metroTextBoxAlteraSenha1.Text + System.Environment.NewLine + "" + System.Environment.NewLine + "CãoMedor - Alimente seu Pet em horários pré-definidos!");
            SmtpClient smtpClient = new SmtpClient("smtp.caomedor.com.br", 587);
            smtpClient.EnableSsl = false;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential(fromEmail, "warlockX1991");
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CãoMedor",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
            }


        }

        private void metroTextBoxAlteraSenha1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxAlteraSenha1.Text == metroTextBoxAlteraSenha2.Text)
            {
                errorProvider.SetError(metroTextBoxAlteraSenha2, "");
            }
            else
            {
                errorProvider.SetError(metroTextBoxAlteraSenha2, "Senhas não conferem");
            }
            if (metroTextBoxEmail.Text != "" && metroTextBoxAlteraSenha1.Text == metroTextBoxAlteraSenha2.Text)
            {
                metroButtonSalvarSenha.Enabled = true;
            }
            else
            {
                metroButtonSalvarSenha.Enabled = false;
            }
        }

        private void metroTextBoxAlteraSenha2_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxAlteraSenha2.Text == metroTextBoxAlteraSenha1.Text)
            {
                errorProvider.SetError(metroTextBoxAlteraSenha2, "");
            }
            else
            {
                errorProvider.SetError(metroTextBoxAlteraSenha2, "Senhas não conferem");
            }
            if (metroTextBoxEmail.Text != "" && metroTextBoxAlteraSenha1.Text == metroTextBoxAlteraSenha2.Text)
            {
                metroButtonSalvarSenha.Enabled = true;
            }
            else
            {
                metroButtonSalvarSenha.Enabled = false;
            }
        }

        private void metroTextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxEmail.Text != "")
            {
                errorProvider.SetError(metroTextBoxEmail, "");
            }
            else
            {
                errorProvider.SetError(metroTextBoxEmail, "Insira o seu email");
            }

            if (metroTextBoxEmail.Text != "" && metroTextBoxAlteraSenha1.Text == metroTextBoxAlteraSenha2.Text)
            {
                metroButtonSalvarSenha.Enabled = true;
            }
            else
            {
                metroButtonSalvarSenha.Enabled = false;
            }
        }

        private void metroButtonSalvarSenha_Click(object sender, EventArgs e)
        {
            SpinnerOn();

            AlterarSenha();
            CarregaFormPrincipal();

            SpinnerOff();
        }

        private void FormAlteraSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaFormPrincipal();
        }
    }
}