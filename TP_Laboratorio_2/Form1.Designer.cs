namespace TP_Prog2
{
    partial class Form1
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(35, 231);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 61);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "CC";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(239, 232);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(112, 60);
            this.btnOperar.TabIndex = 1;
            this.btnOperar.Text = "=";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(32, 27);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(24, 95);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(96, 22);
            this.txtNumero1.TabIndex = 3;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(279, 95);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(99, 22);
            this.txtNumero2.TabIndex = 4;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(151, 93);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(95, 24);
            this.cmbOperacion.TabIndex = 5;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 375);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbOperacion;
    }
}