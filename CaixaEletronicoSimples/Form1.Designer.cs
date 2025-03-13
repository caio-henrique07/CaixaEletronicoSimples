namespace CaixaEletronicoSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblMontante = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.tmrJuros = new System.Windows.Forms.Timer(this.components);
            this.lblTaxa = new System.Windows.Forms.Label();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValor.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(156, 200);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 31);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(156, 369);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(101, 46);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblLimite
            // 
            this.lblLimite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLimite.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(156, 308);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(101, 32);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite";
            // 
            // lblMontante
            // 
            this.lblMontante.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontante.Location = new System.Drawing.Point(305, 369);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(184, 46);
            this.lblMontante.TabIndex = 3;
            this.lblMontante.Text = "R$ 0,00";
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(369, 211);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 4;
            this.numValor.ValueChanged += new System.EventHandler(this.numValor_ValueChanged);
            // 
            // btDepositar
            // 
            this.btDepositar.BackColor = System.Drawing.Color.LightCoral;
            this.btDepositar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepositar.Location = new System.Drawing.Point(156, 245);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(158, 41);
            this.btDepositar.TabIndex = 6;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.BackColor = System.Drawing.Color.PaleGreen;
            this.btSacar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacar.Location = new System.Drawing.Point(388, 245);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(101, 41);
            this.btSacar.TabIndex = 7;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = false;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // tmrJuros
            // 
            this.tmrJuros.Enabled = true;
            this.tmrJuros.Interval = 5000;
            this.tmrJuros.Tick += new System.EventHandler(this.tmrJuros_Tick);
            // 
            // lblTaxa
            // 
            this.lblTaxa.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblTaxa.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(153, 446);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(118, 23);
            this.lblTaxa.TabIndex = 8;
            this.lblTaxa.Text = "lblTaxa";
            // 
            // numLimite
            // 
            this.numLimite.Location = new System.Drawing.Point(369, 320);
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(120, 20);
            this.numLimite.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaixaEletronicoSimples.Properties.Resources.atm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 689);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.lblMontante);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico Simples";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblMontante;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Timer tmrJuros;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.NumericUpDown numLimite;
    }
}