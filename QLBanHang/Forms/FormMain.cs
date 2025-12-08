using QLBanHang.Data;

namespace QLBanHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            foreach (ToolStripMenuItem item in msMenu.Items) //hover xổ menu
            {
                item.MouseEnter += TopMenu_MouseEnter;
            }
        }
        private void TopMenu_MouseEnter(object? sender, EventArgs e) //để hover xổ menu luôn 
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.HasDropDownItems)
                {
                    menuItem.ShowDropDown();
                }
            }
        }
        private void tmrTimeFt_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        //-----------------------------------------------------------------
        private void tsmiCategory_Click(object sender, EventArgs e)
        {
            var f = new FormCategory();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tsmiProduct_Click(object sender, EventArgs e)
        {
            var f = new FormProduct();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tsmiSale_Click(object sender, EventArgs e)
        {
            var f = new FormSale();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
