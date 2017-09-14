namespace CaixaEletronico
{
    partial class TelaCaixaEletronico
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
            this.combConta = new System.Windows.Forms.ComboBox();
            this.Cliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione Uma Conta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combConta
            // 
            this.combConta.DisplayMember = "Conta 1";
            this.combConta.FormattingEnabled = true;
            this.combConta.Items.AddRange(new object[] {
            "Conta 1",
            "Conta 2",
            "Conta 3"});
            this.combConta.Location = new System.Drawing.Point(128, 6);
            this.combConta.Name = "combConta";
            this.combConta.Size = new System.Drawing.Size(121, 21);
            this.combConta.TabIndex = 1;
            this.combConta.SelectedIndexChanged += new System.EventHandler(this.combConta_SelectedIndexChanged);
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(715, 14);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(45, 13);
            this.Cliente.TabIndex = 2;
            this.Cliente.Text = "Cliente: ";
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(767, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 3;
            // 
            // TelaCaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 655);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.combConta);
            this.Controls.Add(this.label1);
            this.Name = "TelaCaixaEletronico";
            this.Text = "CAIXA";
            this.Load += new System.EventHandler(this.TelaCaixaEletronico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combConta;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label lblCliente;

    }
}

