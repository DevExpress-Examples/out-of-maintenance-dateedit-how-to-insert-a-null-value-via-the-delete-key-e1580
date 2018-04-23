Namespace Q211932
	Partial Public Class Form1
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
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource()
			Me.nwindDataSet = New Q211932.nwindDataSet()
			Me.ordersTableAdapter = New Q211932.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ordersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(456, 310)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colCustomerID, Me.colOrderDate})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 1
			' 
			' colOrderDate
			' 
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 2
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(456, 310)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet As nwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As Q211932.nwindDataSetTableAdapters.OrdersTableAdapter
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyDateEdit1 As DXSample.RepositoryItemMyDateEdit
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

	End Class
End Namespace

