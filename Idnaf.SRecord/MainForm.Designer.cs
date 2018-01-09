namespace Idnaf.SRecord
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonMap = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonGetDir = new System.Windows.Forms.Button();
            this.richTextBoxHex = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHeadHexOutline = new System.Windows.Forms.Label();
            this.gotoAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(168, 34);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(96, 20);
            this.buttonMap.TabIndex = 1;
            this.buttonMap.Text = "Map Memory";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 8);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(387, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // buttonGetDir
            // 
            this.buttonGetDir.Location = new System.Drawing.Point(405, 8);
            this.buttonGetDir.Name = "buttonGetDir";
            this.buttonGetDir.Size = new System.Drawing.Size(31, 20);
            this.buttonGetDir.TabIndex = 3;
            this.buttonGetDir.Text = "...";
            this.buttonGetDir.UseVisualStyleBackColor = true;
            this.buttonGetDir.Click += new System.EventHandler(this.buttonGetDir_Click);
            // 
            // richTextBoxHex
            // 
            this.richTextBoxHex.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBoxHex.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxHex.Location = new System.Drawing.Point(11, 77);
            this.richTextBoxHex.Name = "richTextBoxHex";
            this.richTextBoxHex.Size = new System.Drawing.Size(425, 337);
            this.richTextBoxHex.TabIndex = 4;
            this.richTextBoxHex.Text = "";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoAddressToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // labelHeadHexOutline
            // 
            this.labelHeadHexOutline.AutoSize = true;
            this.labelHeadHexOutline.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadHexOutline.Location = new System.Drawing.Point(12, 61);
            this.labelHeadHexOutline.Name = "labelHeadHexOutline";
            this.labelHeadHexOutline.Size = new System.Drawing.Size(399, 15);
            this.labelHeadHexOutline.TabIndex = 5;
            this.labelHeadHexOutline.Text = "Address| 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // gotoAddressToolStripMenuItem
            // 
            this.gotoAddressToolStripMenuItem.Name = "gotoAddressToolStripMenuItem";
            this.gotoAddressToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gotoAddressToolStripMenuItem.Text = "Goto address";
            this.gotoAddressToolStripMenuItem.Click += new System.EventHandler(this.gotoAddressToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(445, 417);
            this.Controls.Add(this.labelHeadHexOutline);
            this.Controls.Add(this.richTextBoxHex);
            this.Controls.Add(this.buttonGetDir);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S Record Memory Mapper";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonGetDir;
        private System.Windows.Forms.RichTextBox richTextBoxHex;
        private System.Windows.Forms.Label labelHeadHexOutline;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoAddressToolStripMenuItem;

    }
}

