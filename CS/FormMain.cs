using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace SelfReferenced {
    public partial class FormMain : Form {
        [STAThread]
        static void Main() {
            Application.Run(new FormMain());
        }

        public FormMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            dataset11.ReadXml("data.xml");
            DataView dv = new DataView(dataset11.Products);
            dv.RowFilter = "([ParentID] Is NULL)";
            gridControl1.DataSource = dv;
            gridView1.OptionsDetail.ShowDetailTabs = false;
        }

        private void gridView1_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e) {
            GridView view = new GridView(gridControl1);
            view.Assign(gridControl1.MainView, true);
            view.OptionsView.ShowGroupPanel = false;
            e.DefaultView = view;
        }
    }
}