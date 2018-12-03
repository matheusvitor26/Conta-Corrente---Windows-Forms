namespace Presentation
{
    partial class FormCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoIni = new System.Windows.Forms.TextBox();
            this.btnNewConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(12, 25);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(316, 20);
            this.txtNomeCad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo Inicial:";
            // 
            // txtSaldoIni
            // 
            this.txtSaldoIni.Location = new System.Drawing.Point(85, 68);
            this.txtSaldoIni.Name = "txtSaldoIni";
            this.txtSaldoIni.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoIni.TabIndex = 3;
            // 
            // btnNewConta
            // 
            this.btnNewConta.Location = new System.Drawing.Point(228, 64);
            this.btnNewConta.Name = "btnNewConta";
            this.btnNewConta.Size = new System.Drawing.Size(100, 27);
            this.btnNewConta.TabIndex = 4;
            this.btnNewConta.Text = "Criar Conta";
            this.btnNewConta.UseVisualStyleBackColor = true;
            this.btnNewConta.Click += new System.EventHandler(this.btnNewConta_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 110);
            this.Controls.Add(this.btnNewConta);
            this.Controls.Add(this.txtSaldoIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCad);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Text = "Nova Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewConta;
        private System.Windows.Forms.TextBox txtSaldoIni;
    }
}