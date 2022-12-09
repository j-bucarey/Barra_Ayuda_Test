namespace Final_Calidad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioDeAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.demandasToolStripMenuItem,
            this.casosToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTecnicoToolStripMenuItem,
            this.reportarUnProblemaToolStripMenuItem,
            this.servicioDeAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // soporteTecnicoToolStripMenuItem
            // 
            this.soporteTecnicoToolStripMenuItem.Name = "soporteTecnicoToolStripMenuItem";
            this.soporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.soporteTecnicoToolStripMenuItem.Text = "Soporte Tecnico";
            // 
            // reportarUnProblemaToolStripMenuItem
            // 
            this.reportarUnProblemaToolStripMenuItem.Name = "reportarUnProblemaToolStripMenuItem";
            this.reportarUnProblemaToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.reportarUnProblemaToolStripMenuItem.Text = "Reportar un problema";
            // 
            // servicioDeAyudaToolStripMenuItem
            // 
            this.servicioDeAyudaToolStripMenuItem.Name = "servicioDeAyudaToolStripMenuItem";
            this.servicioDeAyudaToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.servicioDeAyudaToolStripMenuItem.Text = "Servicio de Ayuda";
            // 
            // demandasToolStripMenuItem
            // 
            this.demandasToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.demandasToolStripMenuItem.Name = "demandasToolStripMenuItem";
            this.demandasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.demandasToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.demandasToolStripMenuItem.Text = "Demandas";
            // 
            // casosToolStripMenuItem
            // 
            this.casosToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.casosToolStripMenuItem.Name = "casosToolStripMenuItem";
            this.casosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.casosToolStripMenuItem.Size = new System.Drawing.Size(93, 28);
            this.casosToolStripMenuItem.Text = "Casos";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem soporteTecnicoToolStripMenuItem;
        private ToolStripMenuItem reportarUnProblemaToolStripMenuItem;
        private ToolStripMenuItem servicioDeAyudaToolStripMenuItem;
        private ToolStripMenuItem demandasToolStripMenuItem;
        private ToolStripMenuItem casosToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        public ToolStripMenuItem ayudaToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}