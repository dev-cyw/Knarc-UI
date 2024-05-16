namespace Knarc_UI {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UnpackTab = new System.Windows.Forms.TabPage();
            this.UnpackNarcBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ContentsPathBTN = new System.Windows.Forms.Button();
            this.ContentsPathTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewFolderCB = new System.Windows.Forms.CheckBox();
            this.NarcPathBTN = new System.Windows.Forms.Button();
            this.NarcPathTxt = new System.Windows.Forms.TextBox();
            this.PackTab = new System.Windows.Forms.TabPage();
            this.PackNarcBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewNarcPathBTN = new System.Windows.Forms.Button();
            this.NewNarcPathTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UnpackedFolderBTN = new System.Windows.Forms.Button();
            this.UnpackedFolderPathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.UnpackTab.SuspendLayout();
            this.PackTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UnpackTab);
            this.tabControl1.Controls.Add(this.PackTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 192);
            this.tabControl1.TabIndex = 0;
            // 
            // UnpackTab
            // 
            this.UnpackTab.Controls.Add(this.UnpackNarcBTN);
            this.UnpackTab.Controls.Add(this.label3);
            this.UnpackTab.Controls.Add(this.ContentsPathBTN);
            this.UnpackTab.Controls.Add(this.ContentsPathTxt);
            this.UnpackTab.Controls.Add(this.label2);
            this.UnpackTab.Controls.Add(this.NewFolderCB);
            this.UnpackTab.Controls.Add(this.NarcPathBTN);
            this.UnpackTab.Controls.Add(this.NarcPathTxt);
            this.UnpackTab.Location = new System.Drawing.Point(4, 22);
            this.UnpackTab.Name = "UnpackTab";
            this.UnpackTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnpackTab.Size = new System.Drawing.Size(236, 166);
            this.UnpackTab.TabIndex = 0;
            this.UnpackTab.Text = "Unpack";
            this.UnpackTab.UseVisualStyleBackColor = true;
            // 
            // UnpackNarcBTN
            // 
            this.UnpackNarcBTN.Location = new System.Drawing.Point(72, 137);
            this.UnpackNarcBTN.Name = "UnpackNarcBTN";
            this.UnpackNarcBTN.Size = new System.Drawing.Size(92, 23);
            this.UnpackNarcBTN.TabIndex = 7;
            this.UnpackNarcBTN.Text = "Unpack Narc";
            this.UnpackNarcBTN.UseVisualStyleBackColor = true;
            this.UnpackNarcBTN.Click += new System.EventHandler(this.UnpackNarcBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contents:";
            // 
            // ContentsPathBTN
            // 
            this.ContentsPathBTN.Location = new System.Drawing.Point(162, 80);
            this.ContentsPathBTN.Name = "ContentsPathBTN";
            this.ContentsPathBTN.Size = new System.Drawing.Size(71, 24);
            this.ContentsPathBTN.TabIndex = 5;
            this.ContentsPathBTN.Text = "Open";
            this.ContentsPathBTN.UseVisualStyleBackColor = true;
            this.ContentsPathBTN.Click += new System.EventHandler(this.ContentsPathBTN_Click);
            // 
            // ContentsPathTxt
            // 
            this.ContentsPathTxt.Location = new System.Drawing.Point(6, 81);
            this.ContentsPathTxt.Name = "ContentsPathTxt";
            this.ContentsPathTxt.ReadOnly = true;
            this.ContentsPathTxt.Size = new System.Drawing.Size(150, 22);
            this.ContentsPathTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Narc:";
            // 
            // NewFolderCB
            // 
            this.NewFolderCB.AutoSize = true;
            this.NewFolderCB.Location = new System.Drawing.Point(6, 109);
            this.NewFolderCB.Name = "NewFolderCB";
            this.NewFolderCB.Size = new System.Drawing.Size(126, 17);
            this.NewFolderCB.TabIndex = 2;
            this.NewFolderCB.Text = "Make A New Folder";
            this.NewFolderCB.UseVisualStyleBackColor = true;
            // 
            // NarcPathBTN
            // 
            this.NarcPathBTN.Location = new System.Drawing.Point(162, 25);
            this.NarcPathBTN.Name = "NarcPathBTN";
            this.NarcPathBTN.Size = new System.Drawing.Size(71, 24);
            this.NarcPathBTN.TabIndex = 1;
            this.NarcPathBTN.Text = "Open";
            this.NarcPathBTN.UseVisualStyleBackColor = true;
            this.NarcPathBTN.Click += new System.EventHandler(this.NarcPathBTN_Click);
            // 
            // NarcPathTxt
            // 
            this.NarcPathTxt.Location = new System.Drawing.Point(6, 26);
            this.NarcPathTxt.Name = "NarcPathTxt";
            this.NarcPathTxt.ReadOnly = true;
            this.NarcPathTxt.Size = new System.Drawing.Size(150, 22);
            this.NarcPathTxt.TabIndex = 0;
            // 
            // PackTab
            // 
            this.PackTab.Controls.Add(this.PackNarcBTN);
            this.PackTab.Controls.Add(this.label4);
            this.PackTab.Controls.Add(this.NewNarcPathBTN);
            this.PackTab.Controls.Add(this.NewNarcPathTxt);
            this.PackTab.Controls.Add(this.label5);
            this.PackTab.Controls.Add(this.UnpackedFolderBTN);
            this.PackTab.Controls.Add(this.UnpackedFolderPathTxt);
            this.PackTab.Location = new System.Drawing.Point(4, 22);
            this.PackTab.Name = "PackTab";
            this.PackTab.Padding = new System.Windows.Forms.Padding(3);
            this.PackTab.Size = new System.Drawing.Size(236, 166);
            this.PackTab.TabIndex = 1;
            this.PackTab.Text = "Pack";
            this.PackTab.UseVisualStyleBackColor = true;
            // 
            // PackNarcBTN
            // 
            this.PackNarcBTN.Location = new System.Drawing.Point(72, 137);
            this.PackNarcBTN.Name = "PackNarcBTN";
            this.PackNarcBTN.Size = new System.Drawing.Size(92, 23);
            this.PackNarcBTN.TabIndex = 13;
            this.PackNarcBTN.Text = "Pack Narc";
            this.PackNarcBTN.UseVisualStyleBackColor = true;
            this.PackNarcBTN.Click += new System.EventHandler(this.PackNarcBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Narc:";
            // 
            // NewNarcPathBTN
            // 
            this.NewNarcPathBTN.Location = new System.Drawing.Point(162, 80);
            this.NewNarcPathBTN.Name = "NewNarcPathBTN";
            this.NewNarcPathBTN.Size = new System.Drawing.Size(71, 24);
            this.NewNarcPathBTN.TabIndex = 11;
            this.NewNarcPathBTN.Text = "Open";
            this.NewNarcPathBTN.UseVisualStyleBackColor = true;
            this.NewNarcPathBTN.Click += new System.EventHandler(this.NewNarcPathBTN_Click);
            // 
            // NewNarcPathTxt
            // 
            this.NewNarcPathTxt.Location = new System.Drawing.Point(6, 81);
            this.NewNarcPathTxt.Name = "NewNarcPathTxt";
            this.NewNarcPathTxt.ReadOnly = true;
            this.NewNarcPathTxt.Size = new System.Drawing.Size(150, 22);
            this.NewNarcPathTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unpacked Folder:";
            // 
            // UnpackedFolderBTN
            // 
            this.UnpackedFolderBTN.Location = new System.Drawing.Point(162, 25);
            this.UnpackedFolderBTN.Name = "UnpackedFolderBTN";
            this.UnpackedFolderBTN.Size = new System.Drawing.Size(71, 24);
            this.UnpackedFolderBTN.TabIndex = 8;
            this.UnpackedFolderBTN.Text = "Open";
            this.UnpackedFolderBTN.UseVisualStyleBackColor = true;
            this.UnpackedFolderBTN.Click += new System.EventHandler(this.UnpackedFolderBTN_Click);
            // 
            // UnpackedFolderPathTxt
            // 
            this.UnpackedFolderPathTxt.Location = new System.Drawing.Point(6, 26);
            this.UnpackedFolderPathTxt.Name = "UnpackedFolderPathTxt";
            this.UnpackedFolderPathTxt.ReadOnly = true;
            this.UnpackedFolderPathTxt.Size = new System.Drawing.Size(150, 22);
            this.UnpackedFolderPathTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "A UI for Knarc";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(268, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knarc-UI";
            this.tabControl1.ResumeLayout(false);
            this.UnpackTab.ResumeLayout(false);
            this.UnpackTab.PerformLayout();
            this.PackTab.ResumeLayout(false);
            this.PackTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UnpackTab;
        private System.Windows.Forms.TabPage PackTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NarcPathBTN;
        private System.Windows.Forms.TextBox NarcPathTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ContentsPathBTN;
        private System.Windows.Forms.TextBox ContentsPathTxt;
        private System.Windows.Forms.Button UnpackNarcBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NewNarcPathBTN;
        private System.Windows.Forms.TextBox NewNarcPathTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UnpackedFolderBTN;
        private System.Windows.Forms.TextBox UnpackedFolderPathTxt;
        private System.Windows.Forms.CheckBox NewFolderCB;
        private System.Windows.Forms.Button PackNarcBTN;
    }
}

