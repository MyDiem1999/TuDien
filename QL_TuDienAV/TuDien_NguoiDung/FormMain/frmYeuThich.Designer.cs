namespace FormMain
{
    partial class frmYeuThich
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
            this.dgvYT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYT
            // 
            this.dgvYT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYT.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYT.GridColor = System.Drawing.Color.Black;
            this.dgvYT.Location = new System.Drawing.Point(0, 0);
            this.dgvYT.Name = "dgvYT";
            this.dgvYT.Size = new System.Drawing.Size(540, 450);
            this.dgvYT.TabIndex = 0;
            // 
            // frmYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.dgvYT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYeuThich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYeuThich";
            this.Load += new System.EventHandler(this.frmYeuThich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYT;
    }
}