namespace WordNumberConverter
{
    partial class FormConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConverter));
            this.pnlTextBoxes = new System.Windows.Forms.Panel();
            this.gBResult = new System.Windows.Forms.GroupBox();
            this.txtBResult = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gBFiles = new System.Windows.Forms.GroupBox();
            this.txtBFiles = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBConvertToNumbers = new System.Windows.Forms.ToolStripButton();
            this.tSBGenerateNumbers = new System.Windows.Forms.ToolStripButton();
            this.pnlTextBoxes.SuspendLayout();
            this.gBResult.SuspendLayout();
            this.gBFiles.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBoxes
            // 
            this.pnlTextBoxes.Controls.Add(this.gBResult);
            this.pnlTextBoxes.Controls.Add(this.splitter1);
            this.pnlTextBoxes.Controls.Add(this.gBFiles);
            this.pnlTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBoxes.Location = new System.Drawing.Point(0, 25);
            this.pnlTextBoxes.Name = "pnlTextBoxes";
            this.pnlTextBoxes.Size = new System.Drawing.Size(654, 522);
            this.pnlTextBoxes.TabIndex = 1;
            // 
            // gBResult
            // 
            this.gBResult.Controls.Add(this.txtBResult);
            this.gBResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBResult.Location = new System.Drawing.Point(0, 134);
            this.gBResult.Name = "gBResult";
            this.gBResult.Size = new System.Drawing.Size(654, 388);
            this.gBResult.TabIndex = 1;
            this.gBResult.TabStop = false;
            this.gBResult.Text = "Результат";
            // 
            // txtBResult
            // 
            this.txtBResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBResult.Location = new System.Drawing.Point(3, 16);
            this.txtBResult.Multiline = true;
            this.txtBResult.Name = "txtBResult";
            this.txtBResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBResult.Size = new System.Drawing.Size(648, 369);
            this.txtBResult.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 131);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(654, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gBFiles
            // 
            this.gBFiles.Controls.Add(this.txtBFiles);
            this.gBFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBFiles.Location = new System.Drawing.Point(0, 0);
            this.gBFiles.Name = "gBFiles";
            this.gBFiles.Size = new System.Drawing.Size(654, 131);
            this.gBFiles.TabIndex = 0;
            this.gBFiles.TabStop = false;
            this.gBFiles.Text = "Файлы";
            // 
            // txtBFiles
            // 
            this.txtBFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBFiles.Location = new System.Drawing.Point(3, 16);
            this.txtBFiles.Multiline = true;
            this.txtBFiles.Name = "txtBFiles";
            this.txtBFiles.Size = new System.Drawing.Size(648, 112);
            this.txtBFiles.TabIndex = 0;
            this.txtBFiles.Text = "..\\..\\..\\Big List.txt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBConvertToNumbers,
            this.tSBGenerateNumbers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(654, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSBConvertToNumbers
            // 
            this.tSBConvertToNumbers.Image = ((System.Drawing.Image)(resources.GetObject("tSBConvertToNumbers.Image")));
            this.tSBConvertToNumbers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBConvertToNumbers.Name = "tSBConvertToNumbers";
            this.tSBConvertToNumbers.Size = new System.Drawing.Size(112, 22);
            this.tSBConvertToNumbers.Text = "Конвертировать";
            this.tSBConvertToNumbers.Click += new System.EventHandler(this.tSBConvertToNumbers_Click);
            // 
            // tSBGenerateNumbers
            // 
            this.tSBGenerateNumbers.Image = ((System.Drawing.Image)(resources.GetObject("tSBGenerateNumbers.Image")));
            this.tSBGenerateNumbers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBGenerateNumbers.Name = "tSBGenerateNumbers";
            this.tSBGenerateNumbers.Size = new System.Drawing.Size(105, 22);
            this.tSBGenerateNumbers.Text = "Сгенерировать";
            this.tSBGenerateNumbers.ToolTipText = "Сгенерировать числа";
            this.tSBGenerateNumbers.Click += new System.EventHandler(this.tSBGenerateNumbers_Click);
            // 
            // FormConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 547);
            this.Controls.Add(this.pnlTextBoxes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormConverter";
            this.Text = "Form1";
            this.pnlTextBoxes.ResumeLayout(false);
            this.gBResult.ResumeLayout(false);
            this.gBResult.PerformLayout();
            this.gBFiles.ResumeLayout(false);
            this.gBFiles.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextBoxes;
        private System.Windows.Forms.TextBox txtBFiles;
        private System.Windows.Forms.GroupBox gBFiles;
        private System.Windows.Forms.GroupBox gBResult;
        private System.Windows.Forms.TextBox txtBResult;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBConvertToNumbers;
        private System.Windows.Forms.ToolStripButton tSBGenerateNumbers;
    }
}

