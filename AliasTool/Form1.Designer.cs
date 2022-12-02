namespace AliasTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eXTRACTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8SCRIPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNICODESCRIPTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPSFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8SCRIPTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF16SCRIPTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPSSCRIPTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(62, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXTRACTToolStripMenuItem,
            this.iNSERTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eXTRACTToolStripMenuItem
            // 
            this.eXTRACTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8SCRIPSToolStripMenuItem,
            this.uNICODESCRIPTSToolStripMenuItem,
            this.pPSFILESToolStripMenuItem});
            this.eXTRACTToolStripMenuItem.Name = "eXTRACTToolStripMenuItem";
            this.eXTRACTToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.eXTRACTToolStripMenuItem.Text = "EXTRACT";
            // 
            // uTF8SCRIPSToolStripMenuItem
            // 
            this.uTF8SCRIPSToolStripMenuItem.Name = "uTF8SCRIPSToolStripMenuItem";
            this.uTF8SCRIPSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uTF8SCRIPSToolStripMenuItem.Text = "UTF-8 SCRIPTS";
            this.uTF8SCRIPSToolStripMenuItem.Click += new System.EventHandler(this.uTF8SCRIPSToolStripMenuItem_Click);
            // 
            // uNICODESCRIPTSToolStripMenuItem
            // 
            this.uNICODESCRIPTSToolStripMenuItem.Name = "uNICODESCRIPTSToolStripMenuItem";
            this.uNICODESCRIPTSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uNICODESCRIPTSToolStripMenuItem.Text = "UNICODE SCRIPTS";
            this.uNICODESCRIPTSToolStripMenuItem.Click += new System.EventHandler(this.uNICODESCRIPTSToolStripMenuItem_Click);
            // 
            // pPSFILESToolStripMenuItem
            // 
            this.pPSFILESToolStripMenuItem.Name = "pPSFILESToolStripMenuItem";
            this.pPSFILESToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pPSFILESToolStripMenuItem.Text = "CAT FILES";
            this.pPSFILESToolStripMenuItem.Click += new System.EventHandler(this.pPSFILESToolStripMenuItem_Click);
            // 
            // iNSERTToolStripMenuItem
            // 
            this.iNSERTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTF8SCRIPTSToolStripMenuItem,
            this.uTF16SCRIPTSToolStripMenuItem,
            this.pPSSCRIPTSToolStripMenuItem});
            this.iNSERTToolStripMenuItem.Name = "iNSERTToolStripMenuItem";
            this.iNSERTToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.iNSERTToolStripMenuItem.Text = "INSERT";
            // 
            // uTF8SCRIPTSToolStripMenuItem
            // 
            this.uTF8SCRIPTSToolStripMenuItem.Name = "uTF8SCRIPTSToolStripMenuItem";
            this.uTF8SCRIPTSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uTF8SCRIPTSToolStripMenuItem.Text = "UTF-8 SCRIPTS";
            this.uTF8SCRIPTSToolStripMenuItem.Click += new System.EventHandler(this.uTF8SCRIPTSToolStripMenuItem_Click);
            // 
            // uTF16SCRIPTSToolStripMenuItem
            // 
            this.uTF16SCRIPTSToolStripMenuItem.Name = "uTF16SCRIPTSToolStripMenuItem";
            this.uTF16SCRIPTSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uTF16SCRIPTSToolStripMenuItem.Text = "UNICODE SCRIPTS";
            this.uTF16SCRIPTSToolStripMenuItem.Click += new System.EventHandler(this.uTF16SCRIPTSToolStripMenuItem_Click);
            // 
            // pPSSCRIPTSToolStripMenuItem
            // 
            this.pPSSCRIPTSToolStripMenuItem.Name = "pPSSCRIPTSToolStripMenuItem";
            this.pPSSCRIPTSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pPSSCRIPTSToolStripMenuItem.Text = "CAT FILES";
            this.pPSSCRIPTSToolStripMenuItem.Click += new System.EventHandler(this.pPSSCRIPTSToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FILE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UTF-8 = EXEMPLO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UNICODE = E X E M P L O";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Abrir o arquivo em um Editor Hexidecimal e verificar qual é o padrão de leitura U" +
    "TF-8 ou UNICODE.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = ".CAT SÃO ARQUIVOS DE CONTAINER QUE CONTÉM OS VÍDEOS DO JOGO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 164);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AliasTool 1.0b";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXTRACTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8SCRIPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNICODESCRIPTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPSFILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF8SCRIPTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF16SCRIPTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPSSCRIPTSToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

