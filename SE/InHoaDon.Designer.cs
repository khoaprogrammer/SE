namespace SE
{
    public partial class InHoaDon
    {
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportMain;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.reportMain = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportMain
            // 
            this.reportMain.ActiveViewIndex = -1;
            this.reportMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportMain.Location = new System.Drawing.Point(0, 0);
            this.reportMain.Name = "reportMain";
            this.reportMain.Size = new System.Drawing.Size(569, 427);
            this.reportMain.TabIndex = 0;
            this.reportMain.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 427);
            this.Controls.Add(this.reportMain);
            this.Name = "InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}