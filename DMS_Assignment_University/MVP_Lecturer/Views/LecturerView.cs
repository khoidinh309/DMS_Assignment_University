using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class LecturerView : Form,ILecturerView
    {
        public LecturerView()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
        }

        private void AssociateAndRaiseEvent()
        {
            btn_view_Student.Click += delegate { View_Student_List_Event?.Invoke(this, EventArgs.Empty); };
            btn_add_textbook.Click += delegate { Add_TextBook_Event?.Invoke(this, EventArgs.Empty); };
            btn_View_TextBook.Click += delegate { View_TextBook_Event?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler View_Student_List_Event;
        public event EventHandler Add_TextBook_Event;
        public event EventHandler View_TextBook_Event;

        public void SetListClass(BindingSource list_subject)
        {
            this.datagrid_class_list.DataSource = list_subject;
        }

        public static LecturerView instance;
        public static LecturerView Get_Instance_Lecturer_View(Form parent_form)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LecturerView();
                instance.MdiParent = parent_form;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
