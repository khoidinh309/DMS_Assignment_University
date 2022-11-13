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
using DMS_Assignment_University.MVP_Faculty.Views;
using DMS_Assignment_University.MVP_Faculty.Presenter;

namespace DMS_Assignment_University
{
    public partial class Log_Faculty : Form
    {
        public Log_Faculty()
        {
            InitializeComponent();
            panel_error.Visible = false;
        }

        private void btn_faculty_log_in_Click(object sender, EventArgs e)
        {
            int facultyID = 0;
            try
            {
                facultyID = Convert.ToInt32(txtbox_faculty_ID.Text);
                string fac_name = "";
                string connectionString = @"datasource = localhost; username = khoidinh309; password = khoikhoi; database = university";
                using (var connection = new MySqlConnection(connectionString))
                using (var commnand = new MySqlCommand())
                {
                    connection.Open();
                    commnand.Connection = connection;
                    commnand.CommandText = $"select Fac_Name from faculty as f where f.FacID = {facultyID}";
                    int count = 0;
                    using (var reader = commnand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fac_name = reader[0].ToString();
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        FacultyMainView main_faculty_view = new FacultyMainView(facultyID, fac_name);
                        main_faculty_view.Show();
                        FacultyMainView.global_view = main_faculty_view;
                        this.Hide();
                        new MainPresenter(main_faculty_view, connectionString, facultyID);
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
    }
}
