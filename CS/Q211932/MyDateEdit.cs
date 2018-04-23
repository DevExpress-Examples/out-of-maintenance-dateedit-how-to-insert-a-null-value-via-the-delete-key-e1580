using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;

namespace DXSample {
    public class MyDateEdit : DateEdit {
        static MyDateEdit() { RepositoryItemMyDateEdit.RegisterMyDateEdit(); }

        public MyDateEdit() : base() { }

        public override string EditorTypeName { get { return RepositoryItemMyDateEdit.MyDateEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyDateEdit Properties { 
            get { 
                return (RepositoryItemMyDateEdit)base.Properties; 
            } 
        }

        protected override PopupBaseForm CreatePopupForm() {
            if (Properties.IsVistaDisplayModeInternal()) return new MyVistaPopupDateEditForm(this);
            return base.CreatePopupForm();
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                EditValue = null;
                e.Handled = true;
            } else base.OnKeyDown(e);
        }
    }

    [UserRepositoryItem("RegisterMyDateEdit")]
    public class RepositoryItemMyDateEdit : RepositoryItemDateEdit {
        static RepositoryItemMyDateEdit() { RegisterMyDateEdit(); }

        public RepositoryItemMyDateEdit() : base() { }
        
        internal const string MyDateEditName = "MyDateEdit";
        
        public override string EditorTypeName { get { return MyDateEditName; } }

        public static void RegisterMyDateEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyDateEditName, typeof(MyDateEdit),
                typeof(RepositoryItemMyDateEdit), typeof(DateEditViewInfo), new ButtonEditPainter(), true));
        }

        internal bool IsVistaDisplayModeInternal() { return IsVistaDisplayMode(); }
    }

    public class MyVistaPopupDateEditForm : VistaPopupDateEditForm {
        public MyVistaPopupDateEditForm(DateEdit ownerEdit) : base(ownerEdit) { }

        protected override DateEditCalendar CreateCalendar() {
            MyVistaDateEditCalendar result = new MyVistaDateEditCalendar(OwnerEdit.Properties,
                OwnerEdit.EditValue);
            result.OkClick += new EventHandler(OnOkClick);
            return result;
        }
    }

    public class MyVistaDateEditCalendar : VistaDateEditCalendar {
        public MyVistaDateEditCalendar(RepositoryItemDateEdit item, object date) : base(item, date) { }

        protected override void OnKeyDownCore(KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                OnDateTimeCommit(null, true);
                e.Handled = true;
                return;
            }
            base.OnKeyDownCore(e);
        }
    }
}