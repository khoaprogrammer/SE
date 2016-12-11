namespace SE
{
    using System;
    using System.Windows.Forms;

    public partial class InHoaDon : Form
    {
        private object source;

        public InHoaDon(object source)
        {
            this.InitializeComponent();
            this.source = source;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            this.reportMain.ReportSource = this.source;
            this.reportMain.Refresh();
        }
    }
}
