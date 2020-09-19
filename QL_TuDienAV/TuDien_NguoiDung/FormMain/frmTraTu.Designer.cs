namespace FormMain
{
    partial class frmTraTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraTu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstTu = new System.Windows.Forms.ListBox();
            this.cboTu = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLike);
            this.panel2.Controls.Add(this.btnEnter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 391);
            this.panel2.TabIndex = 3;
            // 
            // btnLike
            // 
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Location = new System.Drawing.Point(3, 199);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(38, 48);
            this.btnLike.TabIndex = 3;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(4, 60);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(38, 48);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Dịch";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstTu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 391);
            this.panel3.TabIndex = 4;
            // 
            // lstTu
            // 
            this.lstTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTu.FormattingEnabled = true;
            this.lstTu.ItemHeight = 21;
            this.lstTu.Location = new System.Drawing.Point(0, 0);
            this.lstTu.Name = "lstTu";
            this.lstTu.Size = new System.Drawing.Size(497, 391);
            this.lstTu.TabIndex = 2;
            // 
            // cboTu
            // 
            this.cboTu.AllowDrop = true;
            this.cboTu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTu.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboTu.DropDownHeight = 100;
            this.cboTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTu.DropDownWidth = 100;
            this.cboTu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboTu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTu.IntegralHeight = false;
            this.cboTu.ItemHeight = 21;
            this.cboTu.Location = new System.Drawing.Point(33, 0);
            this.cboTu.Name = "cboTu";
            this.cboTu.Size = new System.Drawing.Size(179, 391);
            this.cboTu.Sorted = true;
            this.cboTu.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.cboTu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 391);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // frmTraTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 391);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraTu";
            this.Load += new System.EventHandler(this.frmTraTu_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstTu;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.ComboBox cboTu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}