using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace OddEvenStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowColumn1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowColumn2;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowColumn3;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowColumn4;
		private DevExpress.XtraEditors.RadioGroup radioGroup1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowColumn1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowColumn2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowColumn3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowColumn4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Column3";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Column4";
            this.dataColumn4.DataType = typeof(bool);
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.dataTable1;
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowColumn1,
            this.rowColumn2,
            this.rowColumn3,
            this.rowColumn4});
            this.vGridControl1.Size = new System.Drawing.Size(504, 306);
            this.vGridControl1.TabIndex = 0;
            this.vGridControl1.RecordCellStyle += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventHandler(this.vGridControl1_RecordCellStyle);
            // 
            // rowColumn1
            // 
            this.rowColumn1.Name = "rowColumn1";
            this.rowColumn1.Properties.Caption = "Column1";
            this.rowColumn1.Properties.FieldName = "Column1";
            // 
            // rowColumn2
            // 
            this.rowColumn2.Name = "rowColumn2";
            this.rowColumn2.Properties.Caption = "Column2";
            this.rowColumn2.Properties.FieldName = "Column2";
            // 
            // rowColumn3
            // 
            this.rowColumn3.Name = "rowColumn3";
            this.rowColumn3.Properties.Caption = "Column3";
            this.rowColumn3.Properties.FieldName = "Column3";
            // 
            // rowColumn4
            // 
            this.rowColumn4.Name = "rowColumn4";
            this.rowColumn4.Properties.Caption = "Column4";
            this.rowColumn4.Properties.FieldName = "Column4";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioGroup1.EditValue = true;
            this.radioGroup1.Location = new System.Drawing.Point(0, 306);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Apply to records"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Apply to rows")});
            this.radioGroup1.Size = new System.Drawing.Size(504, 35);
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.radioGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			for(int i = 1; i <= 10; i++)
				dataTable1.Rows.Add(new object[] {i, "Row " + i.ToString(), DateTime.Now.AddMinutes(i), i % 2 == 1});            
		}

		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			vGridControl1.LayoutChanged();
		}

        private void vGridControl1_RecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            int index;
            if (radioGroup1.SelectedIndex == 0)
                index = e.RecordIndex;
            else
                index = e.Row.VisibleIndex;
            if ((index + 1) % 2 == 0)
                e.Appearance.BackColor = Color.SkyBlue;
            else
                e.Appearance.BackColor = Color.LightPink;           
        }
	}
}

