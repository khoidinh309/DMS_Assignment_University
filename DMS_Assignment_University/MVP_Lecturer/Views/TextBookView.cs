using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMS_Assignment_University.MVP_Lecturer.Models;

namespace DMS_Assignment_University.MVP_Lecturer.Views
{
    public partial class TextBookView : Form
    {
        ILecturerRepository lecturerRepository;
        private string subID;
        public TextBookView(ILecturerRepository lecturerRepository, string subID)
        {
            InitializeComponent();
            this.lecturerRepository = lecturerRepository;
            this.subID = subID;
            Load_TextBook_List();
        }

        private void Load_TextBook_List()
        {
            this.datagrid_textbook_list.DataSource = lecturerRepository.Get_Textbook_List(subID);
        }

        public static TextBookView instance;
        public static void Get_TextbookView_Instance(ILecturerRepository lecturerRepository, string subID)
        {
            if (instance == null)
            {
                instance = new TextBookView(lecturerRepository, subID);
                instance.Show();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }

        }
    }
}
