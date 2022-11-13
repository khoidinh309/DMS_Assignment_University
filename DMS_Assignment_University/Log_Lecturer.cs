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
using DMS_Assignment_University.MVP_Lecturer.Views;
using DMS_Assignment_University.MVP_Lecturer.Presenter;

namespace DMS_Assignment_University
{
    public partial class Log_Lecturer : Form
    {
        public Log_Lecturer()
        {
            InitializeComponent();
            panel_error.Visible = false;
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            try
            {
                int lecturer_ID = Convert.ToInt32(txtbox_lecturer_id.Text);
                string student_name = "";
                string fac_name = "";
                string connectionString = @"datasource = localhost; username = khoidinh309; password = khoikhoi; database = university";
                using (var connection = new MySqlConnection(connectionString))
                using (var commnand = new MySqlCommand())
                {
                    connection.Open();
                    commnand.Connection = connection;
                    commnand.CommandText = $"select Full_Name, Fac_Name from lecturer as l,faculty as f where l.FacID = f.FacID and l.lecturer_id = {lecturer_ID}";
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
                        LecturerMainView lecturer_main_view = new LecturerMainView(student_name, fac_name);
                        lecturer_main_view.Show();
                        LecturerMainView.global_view = lecturer_main_view;
                        this.Hide();
                        new MainPresenter(lecturer_main_view, connectionString, lecturer_ID);
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

        private void btn_log_in_MouseEnter(object sender, EventArgs e)
        {
            btn_log_in.ForeColor = Color.Black;
        }

        private void btn_log_in_MouseLeave(object sender, EventArgs e)
        {
            btn_log_in.ForeColor = Color.Aqua;
        }
    }
}
