<<<<<<< Updated upstream
﻿using QLBanHang.Data;
=======
using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;
>>>>>>> Stashed changes

namespace QLBanHang
{
    public partial class FrmMain : Form
    {
        private readonly OrderBLL _orderBLL = new OrderBLL();

        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            foreach (ToolStripMenuItem item in msMenu.Items) //hover xổ menu
            {
                item.MouseEnter += TopMenu_MouseEnter;
            }
        }
<<<<<<< Updated upstream
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
=======

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            LoadDashboardKpi();
            LoadWeeklyRevenueBarChart(4);
        }

        private void LoadDashboardKpi()
        {
            int threshold = 5;
            var kpi = _orderBLL.GetDashboardKpi(threshold);

            lblRevenueToday.Text = $"{kpi.DoanhThuToday:#,##0} đ";
            lblOrderCount.Text = $"{kpi.SoDonToday}";
            lblProductEx.Text = $"{kpi.LowStockCount} SP (<= {threshold})";

            if (kpi.DoanhThuYesterday <= 0)
            {
                lblSub.Text = (kpi.DoanhThuToday > 0)
                    ? "So với hôm qua: ↑ mới phát sinh"
                    : "So với hôm qua: —";
            }
            else
            {
                decimal pct = (kpi.DoanhThuToday - kpi.DoanhThuYesterday) / kpi.DoanhThuYesterday * 100m;
                string arrow = pct >= 0 ? "↑" : "↓";
                lblSub.Text = $"So với hôm qua: {arrow} {pct:0.##}%";
            }
        }

        private void TopMenu_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                menuItem.ShowDropDown();
        }

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            f.Show();
        }
=======
            f.FormClosed += (s, args) =>
            {
                LoadDashboardKpi();
                LoadWeeklyRevenueBarChart(4);
            };
            f.Show();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            var f = new FormReport();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void LoadWeeklyRevenueBarChart(int weeks = 4)
        {
            var data = _orderBLL.GetWeeklyRevenue(weeks);

            var option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "Doanh thu theo tuần";
            option.ToolTip.Visible = true;

            var s1 = new UIBarSeries();
            s1.Name = "Doanh thu";

            foreach (var item in data)
            {
                option.XAxis.Data.Add(item.WeekLabel);
                s1.AddData(item.Revenue);
            }

            option.Series.Add(s1);
            uiBarChartWeek.SetOption(option);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
>>>>>>> Stashed changes
    }
}
