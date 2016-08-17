namespace TaglistCreatorFromIGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AboutStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OPCFileText = new System.Windows.Forms.Label();
            this.UploadOPCFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.IGSFileText = new System.Windows.Forms.Label();
            this.UploadIGSFile = new System.Windows.Forms.Button();
            this.openIGSFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIGS = new System.Windows.Forms.Button();
            this.txtSiteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAONumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openOPCFile = new System.Windows.Forms.OpenFileDialog();
            this.AboutStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutStrip
            // 
            this.AboutStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.AboutStrip.Location = new System.Drawing.Point(0, 0);
            this.AboutStrip.Name = "AboutStrip";
            this.AboutStrip.Size = new System.Drawing.Size(719, 24);
            this.AboutStrip.TabIndex = 0;
            this.AboutStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 159);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.UploadOPCFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(362, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPC";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.OPCFileText);
            this.groupBox4.Location = new System.Drawing.Point(6, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 77);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Uploaded OPC file";
            // 
            // OPCFileText
            // 
            this.OPCFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OPCFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPCFileText.Location = new System.Drawing.Point(3, 16);
            this.OPCFileText.Name = "OPCFileText";
            this.OPCFileText.Size = new System.Drawing.Size(340, 58);
            this.OPCFileText.TabIndex = 0;
            this.OPCFileText.Text = "None Uploaded";
            this.OPCFileText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadOPCFile
            // 
            this.UploadOPCFile.Location = new System.Drawing.Point(93, 19);
            this.UploadOPCFile.Name = "UploadOPCFile";
            this.UploadOPCFile.Size = new System.Drawing.Size(171, 30);
            this.UploadOPCFile.TabIndex = 5;
            this.UploadOPCFile.Text = "Upload OPC File";
            this.UploadOPCFile.UseVisualStyleBackColor = true;
            this.UploadOPCFile.Click += new System.EventHandler(this.UploadOPCFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.UploadIGSFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IGS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.IGSFileText);
            this.groupBox5.Location = new System.Drawing.Point(6, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 77);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uploaded IGS file";
            // 
            // IGSFileText
            // 
            this.IGSFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IGSFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGSFileText.Location = new System.Drawing.Point(3, 16);
            this.IGSFileText.Name = "IGSFileText";
            this.IGSFileText.Size = new System.Drawing.Size(340, 58);
            this.IGSFileText.TabIndex = 0;
            this.IGSFileText.Text = "None Uploaded";
            this.IGSFileText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadIGSFile
            // 
            this.UploadIGSFile.Location = new System.Drawing.Point(91, 19);
            this.UploadIGSFile.Name = "UploadIGSFile";
            this.UploadIGSFile.Size = new System.Drawing.Size(171, 30);
            this.UploadIGSFile.TabIndex = 5;
            this.UploadIGSFile.Text = "Upload IGS File";
            this.UploadIGSFile.UseVisualStyleBackColor = true;
            this.UploadIGSFile.Click += new System.EventHandler(this.UploadIGSFile_Click);
            // 
            // openIGSFile
            // 
            this.openIGSFile.FileName = "IGS_File";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(719, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIGS);
            this.groupBox3.Controls.Add(this.txtSiteBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAONumberBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 102);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TagList";
            // 
            // buttonIGS
            // 
            this.buttonIGS.Location = new System.Drawing.Point(489, 48);
            this.buttonIGS.Name = "buttonIGS";
            this.buttonIGS.Size = new System.Drawing.Size(171, 30);
            this.buttonIGS.TabIndex = 5;
            this.buttonIGS.Text = "Generate TagList";
            this.buttonIGS.UseVisualStyleBackColor = true;
            this.buttonIGS.Click += new System.EventHandler(this.buttonGenerateTagList_Click);
            // 
            // txtSiteBox
            // 
            this.txtSiteBox.Location = new System.Drawing.Point(262, 54);
            this.txtSiteBox.Name = "txtSiteBox";
            this.txtSiteBox.Size = new System.Drawing.Size(150, 20);
            this.txtSiteBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Site Name (ie NorthLake)";
            // 
            // txtAONumberBox
            // 
            this.txtAONumberBox.Location = new System.Drawing.Point(38, 54);
            this.txtAONumberBox.Name = "txtAONumberBox";
            this.txtAONumberBox.Size = new System.Drawing.Size(145, 20);
            this.txtAONumberBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AO Number (ie 500357)";
            // 
            // openOPCFile
            // 
            this.openOPCFile.FileName = "OPC_File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 291);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AboutStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AboutStrip;
            this.Name = "Form1";
            this.Text = "Create TagList from IGS OPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AboutStrip.ResumeLayout(false);
            this.AboutStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AboutStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UploadIGSFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label IGSFileText;
        private System.Windows.Forms.OpenFileDialog openIGSFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIGS;
        private System.Windows.Forms.TextBox txtSiteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAONumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label OPCFileText;
        private System.Windows.Forms.Button UploadOPCFile;
        private System.Windows.Forms.OpenFileDialog openOPCFile;
    }
}

