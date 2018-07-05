using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading.Tasks;

namespace CaoMedor_App
{
    public partial class FormPrincipal : MetroForm
    {
        int SensorUmidadeLigado = 0;

        public FormPrincipal()
        {
            InitializeComponent();
            if (serialPort.IsOpen == false)
            {
                timerCOM.Enabled = true;
            }
            SpinnerCOM_On();
        }

        public void Conectar()
        {
            SpinnerCOM_On();
            textStatus.Text = "Conectando";
            textStatus.Visible = true;
            comboCOM.Enabled = false;
            boxDebug.Enabled = false;
        }

        public void Conectado()
        {
            SpinnerCOM_Off();
            textStatus.Text = "";
            textStatus.Visible = false;
            metroTabControl.Enabled = true;
            btSalvar.Enabled = true;
            pictureBoxConexao_On(pictureBoxConexao);
        }

        public void Desconectado()
        {
            serialPort.Close();
            timerCOM.Enabled = true;
            comboCOM.Enabled = true;
            btSalvar.Enabled = false;
            metroTabControl.Enabled = false;
            boxDebug.Enabled = true;
            pictureBoxConexao_Off(pictureBoxConexao);
        }

        public void SpinnerCOM_On()
        {
            metroProgressSpinner.Value = 65;
            metroProgressSpinner.Visible = true;
            metroProgressSpinner.Spinning = true;
        }

        public void SpinnerCOM_Off()
        {
            metroProgressSpinner.Value = 0;
            metroProgressSpinner.Visible = false;
            metroProgressSpinner.Spinning = false;
        }

        public void SpinnerSalvar_On()
        {
            metroProgressSpinnerSalvar.Value = 65;
            metroProgressSpinnerSalvar.Visible = true;
            metroProgressSpinnerSalvar.Spinning = true;
        }
        
        public void SpinnerSalvar_Off()
        {
            metroProgressSpinnerSalvar.Value = 0;
            metroProgressSpinnerSalvar.Visible = false;
            metroProgressSpinnerSalvar.Spinning = false;
        }

        public void pictureBoxConexao_On(PictureBox pictureBoxConexao)
        {
            pictureBoxConexao.Image = Properties.Resources.Conectado;
            pictureBoxConexao.Refresh();
        }

        public void pictureBoxConexao_Off(PictureBox pictureBoxConexao)
        {
            pictureBoxConexao.Image = Properties.Resources.Desconectado;
            pictureBoxConexao.Refresh();
         }

        private void atualizaListaCOM()
        {
            int i = 0;
            bool quantDiferente = false;

            if (comboCOM.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboCOM.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
                comboCOM.Items.Clear();
                comboCOM.Text = "";
            }

            if (quantDiferente == false)
            {
                return;
            }

            //limpa comboBox
            comboCOM.Items.Clear();
            comboCOM.Text = "";

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboCOM.Items.Add(s);
            }

            var ports = SerialPort.GetPortNames();

            if (ports.Length != 0)
            {
                comboCOM.SelectedIndex = 0;
                textStatus.Visible = false;
                metroProgressSpinner.Value = 0;
                metroProgressSpinner.Visible = false;
                metroProgressSpinner.Spinning = false;
            }

            if (ports.Length == 0)
            {
                comboCOM.Items.Clear();
                comboCOM.Text = "";
            }

        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOM();
            Task task1 = new Task(new Action(SpinnerCOM_On));
        }

        private void metroLinkSite_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.caomedor.com"); // abre o site
        }

        private void trackbarQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (trackbarQuantidade.Value % 25 == 0)
            {
                QuantRacao.Text = Convert.ToString(trackbarQuantidade.Value);

            }
            else
            {
                trackbarQuantidade.Value = trackbarQuantidade.Value - (trackbarQuantidade.Value % 25);
                QuantRacao.Text = Convert.ToString(trackbarQuantidade.Value);
            }
        }

        private void trackbarVezes_ValueChanged(object sender, EventArgs e)
        {
            switch (trackbarVezes.Value)
            {
                
                case 1:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    break;

                case 2:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    break;

                case 3:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = false;
                    break;

                case 4:
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    break;
            }
        }

        private void pictureBoxConexao_Click(object sender, EventArgs e)
        {
            // conecta
            if (serialPort.IsOpen == false)
            {
                try
                {
                    serialPort.PortName = comboCOM.Items[comboCOM.SelectedIndex].ToString();
                    serialPort.Open();
                }

                catch
                {
                    return;
                }

                if (serialPort.IsOpen == true)
                {
                    if (boxDebug.Checked == false)
                    {
                        int verificador = 0;
                        serialPort.WriteLine("#");
                        verificador = (Convert.ToInt32(serialPort.ReadByte()));

                        // verifica se de fato o caomedor esta conectado a porta COM

                        if (verificador == 0)
                        {
                            Desconectado();

                            MessageBox.Show("O dispositivo selecionado não é o CãoMedor", "CãoMedor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                        }

                        else if (verificador == 1)
                        {
                            Conectar();

                            // versao do firmware do caomedor
                            serialPort.WriteLine("0");
                            textInfoFirmwareValor.Text = (Convert.ToString(serialPort.ReadLine()));
                            serialPort.WriteLine("1");
                            textInfoDataValor.Text = (Convert.ToString(serialPort.ReadLine()));

                            // quantas vezes a racao sera servida
                            serialPort.WriteLine("A");
                            trackbarVezes.Value = (Convert.ToInt32(serialPort.ReadLine()));

                            // horario 1
                            serialPort.Write("B");
                            updownHora1.Value = (Convert.ToInt32(serialPort.ReadLine()));   // adquire a hora1 com o Arduino
                            serialPort.Write("C");
                            updownMinuto1.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o minuto1 com o Arduino

                            // horario 2
                            serialPort.Write("D");
                            updownHora2.Value = (Convert.ToInt32(serialPort.ReadLine()));   // adquire a hora2 com o Arduino
                            serialPort.Write("E");
                            updownMinuto2.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o minuto2 com o Arduino

                            // horario 3
                            serialPort.Write("F");
                            updownHora3.Value = (Convert.ToInt32(serialPort.ReadLine()));   // adquire a hora3 com o Arduino
                            serialPort.Write("G");
                            updownMinuto3.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o minuto3 com o Arduino

                            // horario 4
                            serialPort.Write("H");
                            updownHora4.Value = (Convert.ToInt32(serialPort.ReadLine()));   // adquire a hora4 com o Arduino
                            serialPort.Write("I");
                            updownMinuto4.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o minuto4 com o Arduino

                            // quantidade de racao a ser servida
                            serialPort.Write("J");
                            trackbarQuantidade.Value = (Convert.ToInt32(serialPort.ReadLine()));  // adquire a quantidade de racao com o Arduino
                            QuantRacao.Text = Convert.ToString(trackbarQuantidade.Value);

                            // umidade
                            serialPort.Write("Q");
                            SensorUmidadeLigado = (Convert.ToInt32(serialPort.ReadLine()));    // adquire o LigaSensorUmidade com o Arduino

                            if (SensorUmidadeLigado == 1)
                            {
                                boxSensorUmidadeOn.Checked = true;
                            }

                            else if (SensorUmidadeLigado == 0)
                            {
                                boxSensorUmidadeOn.Checked = false;
                            }

                            serialPort.Write("R");
                            updownUmidadeMin.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire a umidademin com o Arduino
                            serialPort.Write("S");
                            updownUmidadeMax.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o umidademax com o Arduino

                            Conectado();
                        }

                        else
                        {
                            Desconectado();
                            MessageBox.Show("Ocorreu um erro. Tente novamente por favor.", "CãoMedor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);

                        }
                    }

                    else if (boxDebug.Checked == true)
                    {
                        Conectar();
                        Conectado();
                    }
                }
            }

            // desconecta
            else
            {
                try
                {
                    Desconectado();
                }

                catch
                {
                    return;
                }
            }
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            FormSobre newMDIChild = new FormSobre();
            newMDIChild.Show();
        }

        private void tabAjustarHora_Enter(object sender, EventArgs e)
        {
            /*
            if (boxDebug.Checked == false)
            {
                // ajuste do relogio
                serialPort.Write("K");
                updownHora.Value = (Convert.ToInt32(serialPort.ReadLine()));   // adquire a hora com o RTC do Arduino
                serialPort.Write("L");
                updownMinuto.Value = (Convert.ToInt32(serialPort.ReadLine())); // adquire o minuto com o RTC do Arduino
                serialPort.Write("M");
                updownDia.Value = (Convert.ToInt32(serialPort.ReadLine()));    // adquire o dia com o RTC do Arduino
                serialPort.Write("N");
                updownMes.Value = (Convert.ToInt32(serialPort.ReadLine()));    // adquire o mes com o RTC do Arduino
                serialPort.Write("O");
                updownAno.Value = (Convert.ToInt32(serialPort.ReadLine()));    // adquire o ano com RTC do Arduino
            }
            */
        }

        private void btHoraSincPC_Click(object sender, EventArgs e)
        {
            // adquire parametros com o PC
            updownHora.Value = Convert.ToInt32(DateTime.Now.ToString("HH"));    // sincroniza a hora com o PC
            updownMinuto.Value = Convert.ToInt32(DateTime.Now.ToString("mm"));  // sincroniza o minuto com o PC
            updownDia.Value = Convert.ToInt32(DateTime.Now.ToString("dd"));     // sincroniza o dia com o PC
            updownMes.Value = Convert.ToInt32(DateTime.Now.ToString("MM"));     // sincroniza o mes com o PC
            updownAno.Value = Convert.ToInt32(DateTime.Now.ToString("yyyy"));   // sincroniza o ano com PC

            /*
            // grava informacoes no Arduino
            serialPort.Write("k");
            serialPort.Write(Convert.ToString(updownHora.Value));
            serialPort.Write("l");
            serialPort.Write(Convert.ToString(updownMinuto.Value));
            serialPort.Write("m");
            serialPort.Write(Convert.ToString(updownDia.Value));
            serialPort.Write("n");
            serialPort.Write(Convert.ToString(updownMes.Value));
            serialPort.Write("o");
            serialPort.Write(Convert.ToString(updownAno.Value));
            serialPort.Write("P");
            */

            MessageBox.Show("Horário ajustado com sucesso!", "CãoMedor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void boxChecarUmidade_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSensorUmidadeOn.Checked == true)
            {
                metroLabelIndicadorUmidade.Text = "Ligado";
                panelUmidade.Enabled = true;
                SensorUmidadeLigado = 1;
            }
            else if (boxSensorUmidadeOn.Checked == false)
            {
                metroLabelIndicadorUmidade.Text = "Desligado";
                panelUmidade.Enabled = false;
                SensorUmidadeLigado = 0;
            }
        }

        private void boxAvisoSonoro_CheckedChanged(object sender, EventArgs e)
        {
            if (boxAvisoSonoro.Checked == true)
            {
                metroLabelAvisoSonoro.Text = "Ligado";
            }
            else if (boxAvisoSonoro.Checked == false)
            {
                metroLabelAvisoSonoro.Text = "Desligado";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SpinnerSalvar_On();

            serialPort.Write("a");
            serialPort.Write(Convert.ToString(trackbarVezes.Value));

            serialPort.Write("b");
            serialPort.Write(Convert.ToString(updownHora1.Value));

            serialPort.Write("c");
            serialPort.Write(Convert.ToString(updownMinuto1.Value));

            serialPort.Write("d");
            serialPort.Write(Convert.ToString(updownHora2.Value));

            serialPort.Write("e");
            serialPort.Write(Convert.ToString(updownMinuto2.Value));

            serialPort.Write("f");
            serialPort.Write(Convert.ToString(updownHora3.Value));

            serialPort.Write("g");
            serialPort.Write(Convert.ToString(updownMinuto3.Value));

            serialPort.Write("h");
            serialPort.Write(Convert.ToString(updownHora4.Value));

            serialPort.Write("i");
            serialPort.Write(Convert.ToString(updownMinuto4.Value));

            serialPort.Write("j");
            serialPort.Write(Convert.ToString(trackbarQuantidade.Value));

            serialPort.Write("q");
            serialPort.Write(Convert.ToString(SensorUmidadeLigado));

            serialPort.Write("r");
            serialPort.Write(Convert.ToString(updownUmidadeMin.Value));

            serialPort.Write("s");
            serialPort.Write(Convert.ToString(updownUmidadeMax.Value));

            MessageBox.Show("Ajustes salvos com sucesso!", "CãoMedor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk,
            MessageBoxDefaultButton.Button1);

            SpinnerSalvar_Off();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen == true)  // se a porta COM estiver aberta
            {
                serialPort.Close();         // fecha a porta COM ao fechar o programa
            }

            Application.Exit();
        }

    }
}
