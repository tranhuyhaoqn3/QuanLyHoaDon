﻿using Main.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            barStaticItem2.Caption = DateTime.Now.ToString();
            mdiManager.MdiParent = this;
            frmIntroduce frm = new frmIntroduce();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem2.Caption = DateTime.Now.ToString();
        }

        private void barBtnBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBill frm = new frmBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void barBtnStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStatistic frm = new frmStatistic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnPrintBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrintBill frm = new frmPrintBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barBtnInforCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCompanyInfor frm = new frmCompanyInfor();
            frm.Show();
        }

        private void barBtnProgramInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProgramInfor frm = new frmProgramInfor();
            frm.Show();
        }

        private void barBtnOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
