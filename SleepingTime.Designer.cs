namespace teste
{
    partial class SleepingTime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SleepingTime));
            this.btnh1 = new System.Windows.Forms.Button();
            this.btnh2 = new System.Windows.Forms.Button();
            this.btnh3 = new System.Windows.Forms.Button();
            this.btnh4 = new System.Windows.Forms.Button();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.lbldesligamento = new System.Windows.Forms.Label();
            this.timershut = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnh1
            // 
            this.btnh1.BackColor = System.Drawing.Color.Transparent;
            this.btnh1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnh1.FlatAppearance.BorderSize = 0;
            this.btnh1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnh1.ForeColor = System.Drawing.Color.Transparent;
            this.btnh1.Location = new System.Drawing.Point(168, 49);
            this.btnh1.Name = "btnh1";
            this.btnh1.Size = new System.Drawing.Size(262, 55);
            this.btnh1.TabIndex = 0;
            this.btnh1.UseVisualStyleBackColor = false;
            this.btnh1.Click += new System.EventHandler(this.btnh1_Click);
            // 
            // btnh2
            // 
            this.btnh2.BackColor = System.Drawing.Color.Transparent;
            this.btnh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnh2.FlatAppearance.BorderSize = 0;
            this.btnh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnh2.Location = new System.Drawing.Point(168, 156);
            this.btnh2.Name = "btnh2";
            this.btnh2.Size = new System.Drawing.Size(262, 57);
            this.btnh2.TabIndex = 1;
            this.btnh2.UseVisualStyleBackColor = false;
            this.btnh2.Click += new System.EventHandler(this.btnh2_Click);
            // 
            // btnh3
            // 
            this.btnh3.BackColor = System.Drawing.Color.Transparent;
            this.btnh3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnh3.FlatAppearance.BorderSize = 0;
            this.btnh3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnh3.Location = new System.Drawing.Point(168, 264);
            this.btnh3.Name = "btnh3";
            this.btnh3.Size = new System.Drawing.Size(262, 56);
            this.btnh3.TabIndex = 2;
            this.btnh3.UseVisualStyleBackColor = false;
            this.btnh3.Click += new System.EventHandler(this.btnh3_Click);
            // 
            // btnh4
            // 
            this.btnh4.BackColor = System.Drawing.Color.Transparent;
            this.btnh4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnh4.FlatAppearance.BorderSize = 0;
            this.btnh4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnh4.Location = new System.Drawing.Point(167, 377);
            this.btnh4.Name = "btnh4";
            this.btnh4.Size = new System.Drawing.Size(262, 64);
            this.btnh4.TabIndex = 3;
            this.btnh4.UseVisualStyleBackColor = false;
            this.btnh4.Click += new System.EventHandler(this.btnh4_Click);
            // 
            // txtManual
            // 
            this.txtManual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtManual.Location = new System.Drawing.Point(167, 487);
            this.txtManual.MaximumSize = new System.Drawing.Size(505, 558);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(58, 13);
            this.txtManual.TabIndex = 5;
            this.txtManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtManual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManual_KeyDown);
            this.txtManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManual_KeyPress_1);
            this.txtManual.Leave += new System.EventHandler(this.txtManual_Leave);
            // 
            // lbldesligamento
            // 
            this.lbldesligamento.AutoSize = true;
            this.lbldesligamento.BackColor = System.Drawing.Color.Transparent;
            this.lbldesligamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldesligamento.Location = new System.Drawing.Point(45, 12);
            this.lbldesligamento.Name = "lbldesligamento";
            this.lbldesligamento.Size = new System.Drawing.Size(251, 13);
            this.lbldesligamento.TabIndex = 8;
            this.lbldesligamento.Text = "O SEU COMPUTADOR DESLIGARÁ EM: 00:00:00";
            this.lbldesligamento.Visible = false;
            // 
            // timershut
            // 
            this.timershut.Interval = 1000;
            this.timershut.Tick += new System.EventHandler(this.timershut_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(156, 509);
            this.label2.MaximumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "pressione enter";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btncancelar.Location = new System.Drawing.Point(296, 474);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(140, 39);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::teste.Properties.Resources._419_show_com_sombra_q_funciona2;
            this.ClientSize = new System.Drawing.Size(488, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldesligamento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtManual);
            this.Controls.Add(this.btnh4);
            this.Controls.Add(this.btnh3);
            this.Controls.Add(this.btnh2);
            this.Controls.Add(this.btnh1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleeping Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnh1;
        private System.Windows.Forms.Button btnh2;
        private System.Windows.Forms.Button btnh3;
        private System.Windows.Forms.Button btnh4;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.Label lbldesligamento;
        private System.Windows.Forms.Timer timershut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
    }
}

