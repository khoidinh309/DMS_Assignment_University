using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_Assignment_University.MVP_Student.Views
{
    public partial class Textbook_View : Form
    {
        public Textbook_View(IEnumerable<Textbook> textbook_list, string subject_name)
        {
            InitializeComponent();
            datagid_textbook.DataSource = textbook_list;
            for (int i = 0; i < datagid_textbook.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    datagid_textbook.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0D324D");
                }
            }
            datagid_textbook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagid_textbook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            datagid_textbook.AllowUserToOrderColumns = true;
            datagid_textbook.AllowUserToResizeColumns = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentView.instance.MdiParent = MainStudentView.global_view;
            StudentView.instance.Show();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
