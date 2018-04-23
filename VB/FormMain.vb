Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace SelfReferenced
	Partial Public Class FormMain
		Inherits Form
		<STAThread> _
		Shared Sub Main()
			Application.Run(New FormMain())
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			dataset11.ReadXml("data.xml")
			Dim dv As New DataView(dataset11.Products)
			dv.RowFilter = "([ParentID] Is NULL)"
			gridControl1.DataSource = dv
			gridView1.OptionsDetail.ShowDetailTabs = False
		End Sub

		Private Sub gridView1_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles gridView1.MasterRowGetLevelDefaultView
			Dim view As New GridView(gridControl1)
			view.Assign(gridControl1.MainView, True)
			view.OptionsView.ShowGroupPanel = False
			e.DefaultView = view
		End Sub
	End Class
End Namespace