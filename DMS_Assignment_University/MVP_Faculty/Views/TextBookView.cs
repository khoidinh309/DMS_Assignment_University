using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Faculty.Models;

namespace DMS_Assignment_University.MVP_Faculty.Views
{
    public partial class TextBookView : Form
    {
        IFacultyRepository facultyRepository;
        IEnumerable<Textbook> textbook_list;
        private string subID;
        public TextBookView(IFacultyRepository facultyRepository, string subID, string subject_name)
        {
            InitializeComponent();
            this.facultyRepository = facultyRepository;
            lb_subject_ID.Text = "Mã môn: " + subID;
            lb_subject_name.Text = subject_name;
            this.subID = subID;
            Load_TextBook_List();
        }

        private void Load_TextBook_List()
        {
            textbook_list = facultyRepository.Get_Textbook_List(subID);
            datagrid_textbook_list.DataSource = textbook_list;
            for (int i = 0; i < datagrid_textbook_list.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagrid_textbook_list.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagrid_textbook_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_textbook_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagrid_textbook_list.AllowUserToOrderColumns = true;
            datagrid_textbook_list.AllowUserToResizeColumns = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FacultyView.instance.MdiParent = FacultyMainView.global_view;
            FacultyView.instance.Show();
            this.Close();
        }
    }
}
