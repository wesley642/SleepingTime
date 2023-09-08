using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace teste
{
    public partial class SleepingTime : Form
    {
        public SleepingTime()
        {
            InitializeComponent();
            btnh1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnh1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ///////////////////////////////////////////////////////////
            btnh2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnh2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ///////////////////////////////////////////////////////////
            btnh3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnh3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ///////////////////////////////////////////////////////////
            btnh4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnh4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ///////////////////////////////////////////////////////////
            btncancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btncancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ///////////////////////////////////////////////////////////
            txtManual.MaxLength = 2;
        }

        int tempo = 0;
        int horas = 0;
        int horas1 = 0;
        int minuto = 0;
        int segundo = 0;

        private void btnh1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 3600");

            tempo = 3600;

            if (tempo >= 60)
            {
                horas = 0;
                minuto = 59;
                segundo = 59;
            }
            lbldesligamento.Visible = true;
            lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
            timershut.Enabled = true;
        }

        private void btnh2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 7200");

            tempo = 7200;

            if (tempo >= 60)
            {
                horas = 1;
                minuto = 59;
                segundo = 59;
            }
            lbldesligamento.Visible = true;
            lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
            timershut.Enabled = true;
        }

        private void btnh3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 10800");

            tempo = 10800;

            if (tempo >= 60)
            {
                horas = 2;
                minuto = 59;
                segundo = 59;
            }
            lbldesligamento.Visible = true;
            lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
            timershut.Enabled = true;
        }

        private void btnh4_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 14400");

            tempo = 14400;

            if (tempo >= 60)
            {
                horas = 3;
                minuto = 59;
                segundo = 59;
            }
            lbldesligamento.Visible = true;
            lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
            timershut.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            timershut.Stop();
            MessageBox.Show("Desligamento cancelado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            horas = 0;
            minuto = 0;
            segundo = 0;

            lbldesligamento.Visible = false;
        }

        private void timershut_Tick(object sender, EventArgs e)
        {
            segundo--;

            if (horas > 0)
            {
                if (minuto > 0)
                {
                    if (segundo < 0)
                    {
                        segundo = 59;
                        minuto--;
                    }
                }
            }
            else
            {
                if (minuto > 0)
                {
                    if (segundo < 0)
                    {
                        segundo = 59;
                        minuto--;
                    }
                }
            }

            lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
            if (horas == 00 && minuto == 0 && segundo == 0)
            {
                timershut.Enabled = false;
            }
        }

        private void txtManual_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    int HoraManual = 0;
                    int HoraManualConta = 0;

                    HoraManual = Convert.ToInt32(txtManual.Text);
                    HoraManualConta = (HoraManual * 3600);
                    Process.Start("shutdown", "/s /t " + HoraManualConta);

                    tempo = HoraManualConta;

                    if (tempo >= 60)
                    {
                        horas1 = tempo / 60;
                        horas = (horas1 / 60) - 1;
                        minuto = 59;
                        segundo = 59;
                    }
                    lbldesligamento.Visible = true;
                    lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: " + (horas + ":" + minuto + ":" + segundo).ToString();
                    timershut.Enabled = true;
                    txtManual.Text = string.Empty;

                }
                catch
                {
                    MessageBox.Show("Coloque o valor de horas inteiras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtManual.Text = string.Empty;
                }
            }
        }

        private void txtManual_Leave(object sender, EventArgs e)
        {
            txtManual.Text = string.Empty;
        }
    }
}
