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
    public partial class FormEsqueciSenha : MetroForm
    {
        string Email = "";
        string Senha = "";

        public FormEsqueciSenha()
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

        private void EnviarEmail()
        {
            string fromEmail = "contato@caomedor.com.br";
            MailMessage mailMessage = new MailMessage(fromEmail, Email, "Recuperação de senha", "Olá!" + System.Environment.NewLine + "Este é apenas um lembrete com a sua senha do CãoMedor." + System.Environment.NewLine + "A senha é: " + Senha + System.Environment.NewLine + "" + System.Environment.NewLine + "CãoMedor - Alimente seu Pet em horários pré-definidos!");
            SmtpClient smtpClient = new SmtpClient("smtp.caomedor.com.br", 587);
            smtpClient.EnableSsl = false;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential(fromEmail, "warlockX1991");
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Senha enviada para o email: " + Email , "CãoMedor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CãoMedor",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
            }
        }

        private void BuscaEmail()
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=CaoMedor.db; Version = 3"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT email FROM users WHERE email=@Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", metroTextBoxEmail.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            var count = 0;
                            while (reader.Read())
                            {
                                count = count + 1;
                            }
                            if (count == 1)
                            {
                                using (var email = new SQLiteCommand("SELECT email FROM users WHERE id=1", conn))
                                {
                                    try
                                    {
                                        email.CommandText = email.ExecuteScalar().ToString();
                                        Email = Convert.ToString(email.CommandText);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                using (var senha = new SQLiteCommand("SELECT password FROM users WHERE id=1", conn))
                                {
                                    try
                                    {
                                        senha.CommandText = senha.ExecuteScalar().ToString();
                                        Senha = Convert.ToString(senha.CommandText);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                EnviarEmail();
                            }
                            else if (count == 0)
                            {
                                MessageBox.Show("Email inválido", "CãoMedor",
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

        private void metroButtonEnviarSenha_Click(object sender, EventArgs e)
        {
            SpinnerOn();

            BuscaEmail();

            SpinnerOff();
        }

        private void metroTextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxEmail.Text == "")
            {
                metroButtonEnviarSenha.Enabled = false;
            }

            else if (metroTextBoxEmail.Text != "")
            {
                metroButtonEnviarSenha.Enabled = true;
            }
        }
    }
}
