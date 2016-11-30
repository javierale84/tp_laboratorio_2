namespace Navegador
{
    partial class frmWebBrowser
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
            this.Ir = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.barraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.BarraDeBusqueda = new System.Windows.Forms.TextBox();
            this.rtxtHtmlCode = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoElHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ir
            // 
            this.Ir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ir.Location = new System.Drawing.Point(858, 25);
            this.Ir.Name = "Ir";
            this.Ir.Size = new System.Drawing.Size(60, 20);
            this.Ir.TabIndex = 0;
            this.Ir.Text = "-->";
            this.Ir.UseVisualStyleBackColor = true;
            this.Ir.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraProgreso});
            this.statusStrip.Location = new System.Drawing.Point(0, 392);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(918, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // barraProgreso
            // 
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(100, 16);
            // 
            // BarraDeBusqueda
            // 
            this.BarraDeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraDeBusqueda.Location = new System.Drawing.Point(0, 26);
            this.BarraDeBusqueda.Name = "BarraDeBusqueda";
            this.BarraDeBusqueda.Size = new System.Drawing.Size(852, 20);
            this.BarraDeBusqueda.TabIndex = 2;
            this.BarraDeBusqueda.Tag = "Introduzca la dirección web";
            this.BarraDeBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            this.BarraDeBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            this.BarraDeBusqueda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUrl_MouseDown);
            this.BarraDeBusqueda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtUrl_MouseMove);
            // 
            // rtxtHtmlCode
            // 
            this.rtxtHtmlCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtHtmlCode.Enabled = false;
            this.rtxtHtmlCode.Location = new System.Drawing.Point(0, 52);
            this.rtxtHtmlCode.Name = "rtxtHtmlCode";
            this.rtxtHtmlCode.Size = new System.Drawing.Size(918, 337);
            this.rtxtHtmlCode.TabIndex = 3;
            this.rtxtHtmlCode.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodoElHistorialToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // mostrarTodoElHistorialToolStripMenuItem
            // 
            this.mostrarTodoElHistorialToolStripMenuItem.Name = "mostrarTodoElHistorialToolStripMenuItem";
            this.mostrarTodoElHistorialToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mostrarTodoElHistorialToolStripMenuItem.Text = "Mostrar todo el Historial";
            this.mostrarTodoElHistorialToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoElHistorialToolStripMenuItem_Click);
            // 
            // frmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 414);
            this.Controls.Add(this.rtxtHtmlCode);
            this.Controls.Add(this.BarraDeBusqueda);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Ir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWebBrowser_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ir;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar barraProgreso;
        private System.Windows.Forms.TextBox BarraDeBusqueda;
        private System.Windows.Forms.RichTextBox rtxtHtmlCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoElHistorialToolStripMenuItem;
    }
}