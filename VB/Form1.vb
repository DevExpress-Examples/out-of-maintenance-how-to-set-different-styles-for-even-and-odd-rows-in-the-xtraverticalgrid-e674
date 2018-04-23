Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils

Namespace OddEvenStyles
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private rowColumn1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowColumn2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowColumn3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowColumn4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.rowColumn1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowColumn2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowColumn3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowColumn4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Column3"
			Me.dataColumn3.DataType = GetType(System.DateTime)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "Column4"
			Me.dataColumn4.DataType = GetType(Boolean)
			' 
			' vGridControl1
			' 
			Me.vGridControl1.DataSource = Me.dataTable1
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowColumn1, Me.rowColumn2, Me.rowColumn3, Me.rowColumn4})
			Me.vGridControl1.Size = New System.Drawing.Size(504, 306)
			Me.vGridControl1.TabIndex = 0
'			Me.vGridControl1.RecordCellStyle += New DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventHandler(Me.vGridControl1_RecordCellStyle);
			' 
			' rowColumn1
			' 
			Me.rowColumn1.Name = "rowColumn1"
			Me.rowColumn1.Properties.Caption = "Column1"
			Me.rowColumn1.Properties.FieldName = "Column1"
			' 
			' rowColumn2
			' 
			Me.rowColumn2.Name = "rowColumn2"
			Me.rowColumn2.Properties.Caption = "Column2"
			Me.rowColumn2.Properties.FieldName = "Column2"
			' 
			' rowColumn3
			' 
			Me.rowColumn3.Name = "rowColumn3"
			Me.rowColumn3.Properties.Caption = "Column3"
			Me.rowColumn3.Properties.FieldName = "Column3"
			' 
			' rowColumn4
			' 
			Me.rowColumn4.Name = "rowColumn4"
			Me.rowColumn4.Properties.Caption = "Column4"
			Me.rowColumn4.Properties.FieldName = "Column4"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.radioGroup1.EditValue = True
			Me.radioGroup1.Location = New System.Drawing.Point(0, 306)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Columns = 2
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Apply to records"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Apply to rows")})
			Me.radioGroup1.Size = New System.Drawing.Size(504, 35)
			Me.radioGroup1.TabIndex = 1
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(504, 341)
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.radioGroup1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			For i As Integer = 1 To 10
				dataTable1.Rows.Add(New Object() {i, "Row " & i.ToString(), DateTime.Now.AddMinutes(i), i Mod 2 = 1})
			Next i
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			vGridControl1.LayoutChanged()
		End Sub

		Private Sub vGridControl1_RecordCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs) Handles vGridControl1.RecordCellStyle
			Dim index As Integer
			If radioGroup1.SelectedIndex = 0 Then
				index = e.RecordIndex
			Else
				index = e.Row.VisibleIndex
			End If
			If (index + 1) Mod 2 = 0 Then
				e.Appearance.BackColor = Color.SkyBlue
			Else
				e.Appearance.BackColor = Color.LightPink
			End If
		End Sub
	End Class
End Namespace

