Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace SelfReferenced
    Partial Public Class FormMain
        Inherits Form

        Private dataSet11 As DataSet

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            dataSet11 = New DataSet()
            dataSet11.Tables.Add(GetProductsDataTable())
            dataSet11.Relations.Add("ProductsProducts", dataSet11.Tables("Products").Columns("ID"), dataSet11.Tables("Products").Columns("ParentID"))
            Dim dv As New DataView(dataSet11.Tables(0))
            dv.RowFilter = "([ParentID] Is NULL)"
            gridControl1.DataSource = dv
            gridView1.OptionsDetail.ShowDetailTabs = False
        End Sub


        Private Function GetProductsDataTable() As DataTable
            Dim table As New DataTable()
            table.TableName = "Products"
            table.Columns.Add(New DataColumn("ID", GetType(Int32)))
            table.Columns.Add(New DataColumn("ParentID", GetType(Int32)))
            table.Columns.Add(New DataColumn("ImageIndex", GetType(Integer)))
            table.Columns.Add(New DataColumn("Department", GetType(String)))
            table.Columns.Add(New DataColumn("Budget", GetType(Integer)))
            table.Columns.Add(New DataColumn("Location", GetType(String)))
            table.Rows.Add(0, Nothing, 0, "Departament " & 0, 1000, "Location " & 0)
            For i As Integer = 0 To 19
                Dim index As Integer = i + 1
                table.Rows.Add(index, i Mod 4, i Mod 5, "Departament " & index, (index Mod 7) * 1000, "Location " & index)
            Next i
            Return table
        End Function

        Private Sub gridView1_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles gridView1.MasterRowGetLevelDefaultView
            Dim view As New GridView(gridControl1)
            view.Assign(gridControl1.MainView, True)
            view.OptionsView.ShowGroupPanel = False
            e.DefaultView = view
        End Sub
        <STAThread> _
        Shared Sub Main()
            Application.Run(New FormMain())
        End Sub
    End Class
End Namespace