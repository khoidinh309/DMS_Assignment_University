using MySql.Data.MySqlClient;
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
using DMS_Assignment_University.MVP_Student.Views;
using DMS_Assignment_University.MVP_Student.Presenter;

namespace DMS_Assignment_University
{
    public partial class Log_Student : Form
    {
        public Log_Student()
        {
            InitializeComponent();
            panel_error.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txt_student_id.Text);
                string student_name = "";
                string fac_name = "";
                string connectionString = @"datasource = localhost; username = khoidinh309; password = khoikhoi; database = university";
                using (var connection = new MySqlConnection(connectionString))
                using (var commnand = new MySqlCommand())
                {
                    connection.Open();
                    commnand.Connection = connection;
                    commnand.CommandText = $"select Full_Name, Fac_Name from student as s,faculty as f where s.FacID = f.FacID and s.Student_Id = {studentID}";
                    int count = 0;
                    using (var reader = commnand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student_name = reader[0].ToString();
                            fac_name = reader[1].ToString();
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        MainStudentView main_student_view = new MainStudentView(student_name, fac_name);
                        main_student_view.Show();
                        MainStudentView.global_view = main_student_view;
                        this.Hide();
                        new MainPresenter(main_student_view, connectionString, studentID);
                    }
                    else
                    {
                        panel_error.Visible = true;
                    }
                }
            }
            catch
            {
                panel_error.Visible = true; 
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Aqua;
        }
    }
}
