using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public partial class FacultyView : Form, IFacultyView
    {
        public FacultyView()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
        }

        private void AssociateAndRaiseEvent()
        {
            btn_add_new_class.Click += delegate { Add_New_Class_Event?.Invoke(this, EventArgs.Empty); };
            btn_add_new_subject.Click += delegate { Add_New_Subject_Event?.Invoke(this, EventArgs.Empty); };
            btn_view_textbook.Click += delegate { View_TextBook_Event?.Invoke(this, EventArgs.Empty); };
            btn_lecturer_view.Click += delegate { View_Lecturer_Event?.Invoke(this, EventArgs.Empty); };
        }

        public void Set_Released_Subject_List(BindingSource subject_list)
        {
           this.datagrid_released_subject.DataSource = subject_list;
        }

        public event EventHandler Add_New_Class_Event;
        public event EventHandler Add_New_Subject_Event;
        public event EventHandler View_Lecturer_Event;
        public event EventHandler View_TextBook_Event;

        public static FacultyView instance;
        public static FacultyView Get_Faculty_View_Instance(Form parent_form)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FacultyView();
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
