using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace Grouppps
{
    public partial class Form1 : Form
    {
        string filePath = "attendance.json";
        List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();
        
        public Form1()
        {
            InitializeComponent();
            SetDGV();
        }

        public class AttendanceRecord
        {
            public string StudentNumber { get; set; }
            public string StudentName { get; set; }
            public DateTime Date { get; set; }
        }
        

        private void addbtn_Click(object sender, EventArgs e)
        {
            string studentNumber = studnumtxt.Text;
            string studentName = studnametxt.Text;
            DateTime date = datetimepick.Value;

            if (string.IsNullOrEmpty(studentNumber) || string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Student number and name is required");
                return;
            }

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    attendanceRecords = JsonConvert.DeserializeObject<List<AttendanceRecord>>(json);
                }
            }catch (Exception)
            {
                MessageBox.Show($"Error");
                return;
            }

            attendanceRecords.Add(new AttendanceRecord
            {
                StudentNumber = studentNumber,
                StudentName = studentName,
                Date = date

            });

            try
            {
                string updateJson = JsonConvert.SerializeObject(attendanceRecords);
                File.WriteAllText(filePath, updateJson);
                MessageBox.Show("Attendance added Succesfully.");
                studnametxt.Text = "";
                studnumtxt.Text = "";
            }catch (Exception)
            {
                MessageBox.Show($"Unsucessful saving attendance");
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            string filePath = "attendance.json";
            try
            {
                if ( File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    List<AttendanceRecord> attendanceRecords = JsonConvert.DeserializeObject<List<AttendanceRecord>>(json);

                    attendancetbl.Rows.Clear();

                    foreach (var record in attendanceRecords)
                    {
                        attendancetbl.Rows.Add(record.StudentNumber, record.StudentName, record.Date.Date.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("Attendance not found.");
                }
            }catch (Exception)
            {
                MessageBox.Show($"Loading attendance Error");
            }
        }

        private void SetDGV()
        {
            attendancetbl.Columns.AddRange(
                new DataGridViewTextBoxColumn() { HeaderText = "Student Number", Name = "colStudentNumber" },
                new DataGridViewTextBoxColumn() { HeaderText = "Student Name", Name = "colStudentName" },
                new DataGridViewTextBoxColumn() { HeaderText = "Date", Name = "colDate" }

            );


        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedIndex = attendancetbl.SelectedRows.Count > 0 ? attendancetbl.SelectedRows[0].Index : -1;

                if (selectedIndex >= 0)
                {
                    attendancetbl.Rows.RemoveAt(selectedIndex);

                    string filePath = "attendance.json";

                    if (File.Exists(filePath))
                    {
                        string json = File.ReadAllText(filePath);
                        List<AttendanceRecord> attendanceRecords = JsonConvert.DeserializeObject<List<AttendanceRecord>>(json);

                        attendanceRecords.RemoveAt(selectedIndex);

                        string updatedJson = JsonConvert.SerializeObject(attendanceRecords, Formatting.Indented);
                        File.WriteAllText(filePath, updatedJson);

                        MessageBox.Show("Attendance deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Attendance record not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error deleting attendance");
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            attendancetbl.Rows.Clear();
        }
    }
}
