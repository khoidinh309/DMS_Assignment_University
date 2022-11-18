using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Student.Models;

namespace DMS_Assignment_University.MVP_Student.Views
{
    public partial class StudentView : Form, IStudentView
    {
        public StudentView()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void AssociateAndRaiseEvent()
        {
            btn_register.Click += delegate { Register_Method_Event?.Invoke(this, EventArgs.Empty); };
            btn_textbook_list.Click += delegate { View_textbook_Event?.Invoke(this, EventArgs.Empty); };
            btn_cancel.Click += delegate { Cancel_Class_Event?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler Register_Method_Event;
        public event EventHandler View_textbook_Event;
        public event EventHandler Cancel_Class_Event;

        public void SetListSubject(BindingSource list_subject)
        {
            datagrid_list_sub.DataSource = list_subject;
           
            this.lb_number_registered_subject.Text = "Số môn: " + list_subject.Count.ToString();
            int number_credits = 0;
            IEnumerable<Class> classes = list_subject.OfType<Class>();
            foreach (var item in classes)
            {
                number_credits += item.Num_credit;
            }
            this.lb_number_credit_sum.Text = "Số tín chỉ: " + number_credits.ToString();
            for(int i = 0;i<datagrid_list_sub.Rows.Count;i++)
            {
                if(i%2 != 0)
                {
                    datagrid_list_sub.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_list_sub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_list_sub.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_list_sub.AllowUserToOrderColumns = true;
            datagrid_list_sub.AllowUserToResizeColumns = true;
        }

        public static StudentView instance;
        public static StudentView get_instance(Form parent_form)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentView();
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

        private void StudentView_Load(object sender, EventArgs e)
        {

        }
    }
}
