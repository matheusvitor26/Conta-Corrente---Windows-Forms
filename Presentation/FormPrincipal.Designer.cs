namespace Presentation
{
    partial class FormPrincipal
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
            this.btnAbrirConta = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTransact = new System.Windows.Forms.TextBox();
            this.txtContaTransact = new System.Windows.Forms.TextBox();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorReal = new System.Windows.Forms.TextBox();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.btnListarContas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirConta
            // 
            this.btnAbrirConta.Location = new System.Drawing.Point(61, 14);
            this.btnAbrirConta.Name = "btnAbrirConta";
            this.btnAbrirConta.Size = new System.Drawing.Size(105, 27);
            this.btnAbrirConta.TabIndex = 0;
            this.btnAbrirConta.Text = "Abertura de Conta";
            this.btnAbrirConta.UseVisualStyleBackColor = true;
            this.btnAbrirConta.Click += new System.EventHandler(this.btnAbrirConta_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(235, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 27);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Conta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados da Conta";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 132);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(316, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transações";
            // 
            // txtValorTransact
            // 
            this.txtValorTransact.Location = new System.Drawing.Point(272, 270);
            this.txtValorTransact.Name = "txtValorTransact";
            this.txtValorTransact.Size = new System.Drawing.Size(100, 20);
            this.txtValorTransact.TabIndex = 5;
            // 
            // txtContaTransact
            // 
            this.txtContaTransact.Location = new System.Drawing.Point(110, 270);
            this.txtContaTransact.Name = "txtContaTransact";
            this.txtContaTransact.Size = new System.Drawing.Size(100, 20);
            this.txtContaTransact.TabIndex = 6;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(218, 308);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(75, 23);
            this.btnDebito.TabIndex = 7;
            this.btnDebito.Text = "Débito";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(91, 308);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(75, 23);
            this.btnCredito.TabIndex = 8;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número da conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor:";
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(110, 77);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumConta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Saldo em Reais (R$):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Saldo em Dólar (US$):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número da conta:";
            // 
            // txtValorReal
            // 
            this.txtValorReal.Location = new System.Drawing.Point(196, 165);
            this.txtValorReal.Name = "txtValorReal";
            this.txtValorReal.ReadOnly = true;
            this.txtValorReal.Size = new System.Drawing.Size(100, 20);
            this.txtValorReal.TabIndex = 16;
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(196, 191);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.ReadOnly = true;
            this.txtValorDolar.Size = new System.Drawing.Size(100, 20);
            this.txtValorDolar.TabIndex = 17;
            // 
            // btnListarContas
            // 
            this.btnListarContas.Location = new System.Drawing.Point(218, 14);
            this.btnListarContas.Name = "btnListarContas";
            this.btnListarContas.Size = new System.Drawing.Size(105, 27);
            this.btnListarContas.TabIndex = 18;
            this.btnListarContas.Text = "Listar Contas";
            this.btnListarContas.UseVisualStyleBackColor = true;
            this.btnListarContas.Click += new System.EventHandler(this.btnListarContas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(361, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "___________________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(361, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "___________________________________________________________";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 344);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnListarContas);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.txtValorReal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.txtContaTransact);
            this.Controls.Add(this.txtValorTransact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAbrirConta);
            this.Name = "FormPrincipal";
            this.Text = "Conta Corrente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirConta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTransact;
        private System.Windows.Forms.TextBox txtContaTransact;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorReal;
        private System.Windows.Forms.TextBox txtValorDolar;
        private System.Windows.Forms.Button btnListarContas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

