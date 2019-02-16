Imports Microsoft.VisualBasic
Imports System
Namespace SelfReferenced
	Partial Public Class FormMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBudget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(597, 366)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartment, Me.colBudget, Me.colLocation})
            Me.gridView1.DetailHeight = 1000
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView1.MasterRowGetLevelDefaultView, AddressOf Me.gridView1_MasterRowGetLevelDefaultView
            ' 
            ' colDepartment
            ' 
            Me.colDepartment.Caption = "Department"
            Me.colDepartment.FieldName = "Department"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 0
            ' 
            ' colBudget
            ' 
            Me.colBudget.Caption = "Budget"
            Me.colBudget.DisplayFormat.FormatString = "c0"
            Me.colBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget.FieldName = "Budget"
            Me.colBudget.Name = "colBudget"
            Me.colBudget.Visible = True
            Me.colBudget.VisibleIndex = 1
            ' 
            ' colLocation
            ' 
            Me.colLocation.Caption = "Location"
            Me.colLocation.FieldName = "Location"
            Me.colLocation.Name = "colLocation"
            Me.colLocation.Visible = True
            Me.colLocation.VisibleIndex = 2
            ' 
            ' FormMain
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(597, 366)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "FormMain"
            Me.Text = "FormMain"
            AddHandler Me.Load, AddressOf Me.Form1_Load
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colDepartment As DevExpress.XtraGrid.Columns.GridColumn
		Private colBudget As DevExpress.XtraGrid.Columns.GridColumn
		Private colLocation As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace