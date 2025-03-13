using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoSimples
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        double limite;
        double taxa = 0.001;

        public Form1()
        {
            InitializeComponent();
        }

        void VerificarSaque()
        {
            if (saldo - (double)numValor.Value >= -(double)numLimite.Value)
            {
                btSacar.Enabled = true;
            }
            else
            {
                btSacar.Enabled = false;
            }
        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            VerificarSaque();
        }

        private void btDepositar_Click(object sender, EventArgs e)
            {
            saldo += (double)numValor.Value;
            lblMontante.Text = saldo.ToString("c");
            VerificarSaque();
        }

        private void numLimite_ValueChanged(object sender, EventArgs e)
        {
            limite = (double)numLimite.Value;
            lblLimite.Text = limite.ToString("c");
            VerificarSaque();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            if ((double)numValor.Value <= saldo)
            {
                saldo -= (double)numValor.Value;
                lblMontante.Text = saldo.ToString("c");
                VerificarSaque();
            }
        }

        private void tmrJuros_Tick(object sender, EventArgs e)
        {
            if (saldo > 0)
            {
                saldo += saldo * taxa;
                lblMontante.Text = saldo.ToString("c");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text = $"* Taxa: {taxa*100}% a.C {tmrJuros.Interval/1000f}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo sair do banco?",
                "Banco moleque Ney",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Torce pra não ser Santos",
                "e Corinthians no Paulistão");
        }
    }
}