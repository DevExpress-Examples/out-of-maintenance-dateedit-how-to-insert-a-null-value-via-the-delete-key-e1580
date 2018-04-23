Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Windows.Forms

Namespace DXSample
	Public Class MyDateEdit
		Inherits DateEdit
		Shared Sub New()
			RepositoryItemMyDateEdit.RegisterMyDateEdit()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyDateEdit.MyDateEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.IsVistaDisplayModeInternal() Then
				Return New MyVistaPopupDateEditForm(Me)
			End If
			Return MyBase.CreatePopupForm()
		End Function

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Delete Then
				EditValue = Nothing
				e.Handled = True
			Else
				MyBase.OnKeyDown(e)
			End If
		End Sub
	End Class

	<UserRepositoryItem("RegisterMyDateEdit")> _
	Public Class RepositoryItemMyDateEdit
		Inherits RepositoryItemDateEdit
		Shared Sub New()
			RegisterMyDateEdit()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Friend Const MyDateEditName As String = "MyDateEdit"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyDateEditName
			End Get
		End Property

		Public Shared Sub RegisterMyDateEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyDateEditName, GetType(MyDateEdit), GetType(RepositoryItemMyDateEdit), GetType(DateEditViewInfo), New ButtonEditPainter(), True))
		End Sub

		Friend Function IsVistaDisplayModeInternal() As Boolean
			Return IsVistaDisplayMode()
		End Function
	End Class

	Public Class MyVistaPopupDateEditForm
		Inherits VistaPopupDateEditForm
		Public Sub New(ByVal ownerEdit As DateEdit)
			MyBase.New(ownerEdit)
		End Sub

		Protected Overrides Function CreateCalendar() As DateEditCalendar
			Dim result As New MyVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)
			AddHandler result.OkClick, AddressOf OnOkClick
			Return result
		End Function
	End Class

	Public Class MyVistaDateEditCalendar
		Inherits VistaDateEditCalendar
		Public Sub New(ByVal item As RepositoryItemDateEdit, ByVal [date] As Object)
			MyBase.New(item, [date])
		End Sub

		Protected Overrides Sub OnKeyDownCore(ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Delete Then
				OnDateTimeCommit(Nothing, True)
				e.Handled = True
				Return
			End If
			MyBase.OnKeyDownCore(e)
		End Sub
	End Class
End Namespace