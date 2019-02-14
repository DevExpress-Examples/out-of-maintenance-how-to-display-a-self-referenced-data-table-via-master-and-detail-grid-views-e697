using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace SelfReferenced
{
    public partial class FormMain : Form
    {
        DataSet dataSet11;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataSet11 = new DataSet();
            dataSet11.Tables.Add(GetProductsDataTable());
            dataSet11.Relations.Add("ProductsProducts", dataSet11.Tables["Products"].Columns["ID"], dataSet11.Tables["Products"].Columns["ParentID"]);
            DataView dv = new DataView(dataSet11.Tables[0]);
            dv.RowFilter = "([ParentID] Is NULL)";
            gridControl1.DataSource = dv;
            gridView1.OptionsDetail.ShowDetailTabs = false;
        }


        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ID", typeof(Int32)));
            table.Columns.Add(new DataColumn("ParentID", typeof(Int32)));
            table.Columns.Add(new DataColumn("ImageIndex", typeof(int)));
            table.Columns.Add(new DataColumn("Department", typeof(string)));
            table.Columns.Add(new DataColumn("Budget", typeof(int)));
            table.Columns.Add(new DataColumn("Location", typeof(string)));
            table.Rows.Add(0, null, 0, "Departament " + 0, 1000, "Location " + 0);
            for (int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add(index, i % 4, i % 5, "Departament " + index, (index % 7) * 1000, "Location " + index);
            }
            return table;
        }

        private void gridView1_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            GridView view = new GridView(gridControl1);
            view.Assign(gridControl1.MainView, true);
            view.OptionsView.ShowGroupPanel = false;
            e.DefaultView = view;
        }
        [STAThread]
        static void Main()
        {
            Application.Run(new FormMain());
        }
    }
}