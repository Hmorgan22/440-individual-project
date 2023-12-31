﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
using ExcelDataReader;

namespace CSC440_GroupProject
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            DeletePanel.Visible = false;
            ChangeGradePanel.Visible = false;
            UploadExcelPanel.Visible = false;
            TranscriptPanel.Visible = false;
            TranscriptSearchPanel.Visible = false;
        }
        private void CloseAddFormButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void EnterNewGradeButton_Click(object sender, EventArgs e)
        {
            //Method to add a student to the database.
            try
            {
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //variables for inserting the student into tables
                    string Name = addNameText.Text;
                    string Id = addIdText.Text;
                    string Grade = addGradeText.Text.ToUpper();
                    string Prefix = addPrefixText.Text;
                    string Number = addNumText.Text;
                    string year = addYearText.Text;
                    string semester = addSemesterText.Text;

                    if (!StudentExists(connection, Id))
                    {
                        //Insert the name and ID  into the student table.
                        string insertQuery = "INSERT INTO 440_hunter_student (Name, StudentId) VALUES (@Name, @Id)";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Name", Name);
                            command.Parameters.AddWithValue("@Id", Id);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (!GradeExists(connection, Id, Prefix, Number, year, semester))
                    {
                        //Insert the Id, prefix, course num, grade, year, semester into the database.
                        string insertQueryGrades = "INSERT INTO 440_hunter_student_grades (StudentId, CoursePrefix, CourseNum, Grade, Year, Semester) VALUES (@Id, @Prefix, @Num, @Grade, @Year, @Semester)";
                        using (MySqlCommand command = new MySqlCommand(insertQueryGrades, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            command.Parameters.AddWithValue("@Prefix", Prefix);
                            command.Parameters.AddWithValue("@Num", Number);
                            command.Parameters.AddWithValue("@Grade", Grade);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Semester", semester);
                            command.ExecuteNonQuery();
                        }

                        CalculateGradePoints(Id);
                    }

                    if (!CourseExists(connection, Prefix, Number, year, semester))
                    {
                        //Insert the prefix, course num, year, semester, hours into the database.
                        string insertQueryHours = "INSERT INTO 440_hunter_course_credit_hours (CoursePrefix, CourseNum, Year, Semester) VALUES (@Prefix, @Num, @Year, @Semester)";
                        using (MySqlCommand command = new MySqlCommand(insertQueryHours, connection))
                        {
                            command.Parameters.AddWithValue("@Prefix", Prefix);
                            command.Parameters.AddWithValue("@Num", Number);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Semester", semester);
                            command.ExecuteNonQuery();
                        }
                    }

                    connection.Close();

                    //reset add student screen
                    MessageBox.Show("Student grade added successfully.");
                    addNameText.Text = "";
                    addIdText.Text = "";
                    addGradeText.Text = "";
                    addPrefixText.Text = "";
                    addNumText.Text = "";
                    addYearText.Text = "";
                    addSemesterText.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add student to the database.");
            }
        }

        private void CancelDeleteButton_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = true;
            ChangeGradePanel.Visible = false;
            UploadExcelPanel.Visible = false;
            TranscriptPanel.Visible = false;
            TranscriptSearchPanel.Visible = false;
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            //Method to delete a student from the database.
            try
            {
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //variables for deleteing the student's grade
                    string Id = deleteIdText.Text;
                    string Prefix = deletePrefixText.Text;
                    string Number = deleteNumText.Text;
                    string year = deleteYearText.Text;
                    string semester = deleteSemesterText.Text;

                    if (GradeExists(connection, Id, Prefix, Number, year, semester))
                    {
                        //Delete student's grade from the DB for a specific class and time.
                        string deleteQueryGrades = "DELETE FROM 440_hunter_student_grades WHERE StudentId = @Id AND CoursePrefix = @Prefix AND CourseNum = @Num AND Year = @Year AND Semester = @Semester";
                        using (MySqlCommand command = new MySqlCommand(deleteQueryGrades, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            command.Parameters.AddWithValue("@Prefix", Prefix);
                            command.Parameters.AddWithValue("@Num", Number);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Semester", semester);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();

                        //reset delete grade screen
                        MessageBox.Show("Student grade deleted succesfully.");
                        deleteIdText.Text = "";
                        deletePrefixText.Text = "";
                        deleteNumText.Text = "";
                        deleteYearText.Text = "";
                        deleteSemesterText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete student grade");
                        deleteIdText.Text = "";
                        deletePrefixText.Text = "";
                        deleteNumText.Text = "";
                        deleteYearText.Text = "";
                        deleteSemesterText.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete student grade from database.");
            }
        }

        private void PrintTranscriptButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            ChangeGradePanel.Visible = false;
            UploadExcelPanel.Visible = false;
            TranscriptPanel.Visible = false;
            TranscriptSearchPanel.Visible = true;
        }

        private void CloseTranscriptButton_Click(object sender, EventArgs e)
        {
            TranscriptPanel.Visible = false;
        }

        private void UploadExcelButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            ChangeGradePanel.Visible = false;
            UploadExcelPanel.Visible = true;
            TranscriptPanel.Visible = false;
            TranscriptSearchPanel.Visible = false;
        }

        //Method used to import student data from the excel files.
        public void ImportStudentDataFromExcel(string folderPath)
        {
            // Get a list of all Excel files in the specified folder
            string[] excelFiles = Directory.GetFiles(folderPath, "*.xls*");

            if (excelFiles.Length == 0)
            {
                MessageBox.Show("No Excel files found in the selected folder.");
                return;
            }

            // DB connection string
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (string excelFile in excelFiles)
                {
                    using (FileStream stream = File.Open(excelFile, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader reader;

                        if (Path.GetExtension(excelFile) == ".xls")
                        {
                            reader = ExcelReaderFactory.CreateBinaryReader(stream);
                        }
                        else if (Path.GetExtension(excelFile) == ".xlsx")
                        {
                            reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        }
                        else
                        {
                            // error message if not in excel file format
                            MessageBox.Show($"Unsupported file format for {excelFile}");
                            continue;
                        }

                        DataSet result = reader.AsDataSet();

                        // Process the data and insert names into the database.
                        DataTable table = result.Tables[0];

                        foreach (DataRow row in table.Rows)
                        {
                            try
                            {
                                //get data from the excel files
                                string excelName = row[0].ToString();
                                string excelId = row[1].ToString();
                                string excelGrade = row[2].ToString().ToUpper();

                                //get the file name
                                string fileName = Path.GetFileName(excelFile);
                                string[] words = fileName.Split(' ');

                                //get the needed variables from the file name
                                string coursePrefix = "";
                                string courseNumber = "";
                                string year = "";
                                string semester = "";

                                if (words.Length >= 4)
                                {
                                    coursePrefix = words[0];
                                    courseNumber = words[1];
                                    year = words[2];
                                    semester = words[3];

                                    //removes .xlsx extension
                                    if (semester.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                                    {
                                        semester = semester.Substring(0, semester.Length - 5);
                                    }

                                    //removes .xls extension
                                    if (semester.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
                                    {
                                        semester = semester.Substring(0, semester.Length - 4);
                                    }
                                }

                                try
                                {
                                    if (!StudentExists(connection, excelId))
                                    {
                                        //Insert the name and ID  into the student table.
                                        string insertQuery = "INSERT INTO 440_hunter_student (Name, StudentId) VALUES (@Name, @Id)";
                                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                                        {
                                            command.Parameters.AddWithValue("@Name", excelName);
                                            command.Parameters.AddWithValue("@Id", excelId);
                                            command.ExecuteNonQuery();
                                        }
                                    }

                                    if (!GradeExists(connection, excelId, coursePrefix, courseNumber, year, semester))
                                    {
                                        //Insert the Id, prefix, course num, grade, year, semester into the database.
                                        string insertQueryGrades = "INSERT INTO 440_hunter_student_grades (StudentId, CoursePrefix, CourseNum, Grade, Year, Semester) VALUES (@Id, @Prefix, @Num, @Grade, @Year, @Semester)";
                                        using (MySqlCommand command = new MySqlCommand(insertQueryGrades, connection))
                                        {
                                            command.Parameters.AddWithValue("@Id", excelId);
                                            command.Parameters.AddWithValue("@Prefix", coursePrefix);
                                            command.Parameters.AddWithValue("@Num", courseNumber);
                                            command.Parameters.AddWithValue("@Grade", excelGrade);
                                            command.Parameters.AddWithValue("@Year", year);
                                            command.Parameters.AddWithValue("@Semester", semester);
                                            command.ExecuteNonQuery();
                                        }

                                        CalculateGradePoints(excelId);
                                    }

                                    if (!CourseExists(connection, coursePrefix, courseNumber, year, semester))
                                    {
                                        //Insert the prefix, course num, year, semester, hours into the database.
                                        string insertQueryHours = "INSERT INTO 440_hunter_course_credit_hours (CoursePrefix, CourseNum, Year, Semester) VALUES (@Prefix, @Num, @Year, @Semester)";
                                        using (MySqlCommand command = new MySqlCommand(insertQueryHours, connection))
                                        {
                                            command.Parameters.AddWithValue("@Prefix", coursePrefix);
                                            command.Parameters.AddWithValue("@Num", courseNumber);
                                            command.Parameters.AddWithValue("@Year", year);
                                            command.Parameters.AddWithValue("@Semester", semester);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Unable to add student to database");
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }

                        reader.Close();
                    }
                }

                connection.Close();
            }

            MessageBox.Show($"Processed and inserted student information from {excelFiles.Length} Excel files into the database.");
        }

        //Method used to see if the student exists in the database by checking if the name returns a count.
        static bool StudentExists(MySqlConnection connection, string Id)
        {
            var query = "SELECT COUNT(*) FROM 440_hunter_student WHERE StudentId = @Id";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }

        //method to check if a grade record already exists in the DB
        static bool GradeExists(MySqlConnection connection, string studentId, string coursePrefix, string courseNum, string year, string semester)
        {
            var query = "SELECT COUNT(*) FROM 440_hunter_student_grades WHERE StudentId = @StudentId AND CoursePrefix = @CoursePrefix AND CourseNum = @CourseNum AND Year = @Year AND Semester = @Semester";

            var command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
            command.Parameters.AddWithValue("@CourseNum", courseNum);
            command.Parameters.AddWithValue("@Year", year);
            command.Parameters.AddWithValue("@Semester", semester);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }

        //method to check if a course exists in the DB
        static bool CourseExists(MySqlConnection connection, string coursePrefix, string courseNum, string year, string semester)
        {
            var query = "SELECT COUNT(*) FROM 440_hunter_course_credit_hours WHERE CoursePrefix = @CoursePrefix AND CourseNum = @CourseNum AND Year = @Year AND Semester = @Semester";

            var command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
            command.Parameters.AddWithValue("@CourseNum", courseNum);
            command.Parameters.AddWithValue("@Year", year);
            command.Parameters.AddWithValue("@Semester", semester);

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }

            return false;
        }

        //method to get the folder path by using the file manager.
        static string GetSelectedFolderPath()
        {
            string selectedFolderPath = null;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a Folder Containing Excel Files";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderBrowserDialog.SelectedPath;
                }
            }
            return selectedFolderPath;
        }

        private void SearchForTranscriptButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            ChangeGradePanel.Visible = false;
            UploadExcelPanel.Visible = false;
            TranscriptPanel.Visible = true;
            TranscriptSearchPanel.Visible = false;
            outputTextBox.Clear();

            //Method for creating a students transcript
            try
            {
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //variable to save student ID
                    string Id = transcriptIdText.Text;
                    List<string> results = new List<string>();

                    if (StudentExists(connection, Id))
                    {
                        //select student name and gpa from student table
                        string selectStudentQuery = "SELECT * FROM 440_hunter_student WHERE StudentId = @Id";
                        using (MySqlCommand command = new MySqlCommand(selectStudentQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string studentId = reader["StudentId"].ToString();
                                    string Name = reader["Name"].ToString();
                                    string Gpa = reader["OverallGPA"].ToString();
                                    outputIdText.Text = studentId;
                                    outputNameText.Text = Name;
                                    outputGpaText.Text = Gpa;
                                }
                            };
                        }

                        //select grade information from student grade table
                        string selectGradeQuery = "SELECT* FROM 440_hunter_student_grades WHERE StudentId = @Id";
                        using (MySqlCommand command = new MySqlCommand(selectGradeQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prefix = reader["CoursePrefix"].ToString();
                                    string number = reader["CourseNum"].ToString();
                                    string grade = reader["Grade"].ToString();
                                    string year = reader["Year"].ToString();
                                    string semester = reader["Semester"].ToString();
                                    outputTextBox.AppendText(prefix);
                                    outputTextBox.AppendText("\t" + number);
                                    outputTextBox.AppendText("\t" + year);
                                    outputTextBox.AppendText("\t" + semester);
                                    outputTextBox.AppendText("\t" + grade);
                                    outputTextBox.AppendText(Environment.NewLine);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to find student in database.");
                        transcriptIdText.Text = "";
                    }

                    connection.Close();
                    transcriptIdText.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find student in the database.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TranscriptSearchPanel.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            ChangeGradePanel.Visible = true;
            UploadExcelPanel.Visible = false;
            TranscriptPanel.Visible = false;
            TranscriptSearchPanel.Visible = false;
        }

        private void CloseChangePanel_Click(object sender, EventArgs e)
        {
            ChangeGradePanel.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Method to update students grades in DB.
            try
            {
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //variables for updating the student's grade
                    string Id = updateIdText.Text;
                    string Prefix = updatePrefixText.Text;
                    string Number = updateNumText.Text;
                    string Grade = updateGradeText.Text.ToUpper();
                    string year = updateYearText.Text;
                    string semester = updateSemesterText.Text;

                    if (GradeExists(connection, Id, Prefix, Number, year, semester))
                    {
                        // Update a student's grade
                        string updateQueryGrades = "UPDATE 440_hunter_student_grades SET Grade = @Grade WHERE StudentId = @Id AND CoursePrefix = @Prefix AND CourseNum = @Num AND Year = @Year AND Semester = @Semester";
                        using (MySqlCommand command = new MySqlCommand(updateQueryGrades, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            command.Parameters.AddWithValue("@Prefix", Prefix);
                            command.Parameters.AddWithValue("@Num", Number);
                            command.Parameters.AddWithValue("@Grade", Grade);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Semester", semester);
                            command.ExecuteNonQuery();
                        }

                        CalculateGradePoints(Id);

                        connection.Close();

                        //reset update grade screen
                        MessageBox.Show("Student grade changed succesfully.");
                        updateIdText.Text = "";
                        updatePrefixText.Text = "";
                        updateNumText.Text = "";
                        updateGradeText.Text = "";
                        updateYearText.Text = "";
                        updateSemesterText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Unable to change student grade");
                        updateIdText.Text = "";
                        updatePrefixText.Text = "";
                        updateNumText.Text = "";
                        updateGradeText.Text = "";
                        updateYearText.Text = "";
                        updateSemesterText.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to change student grade in database.");
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string path = GetSelectedFolderPath();
            ImportStudentDataFromExcel(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadExcelPanel.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - AddPanel.Width) / 2;
            int centerY = (this.ClientSize.Height - AddPanel.Height) / 2;

            // Set the panel's location
            AddPanel.Location = new Point(centerX, centerY);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Class_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TranscriptSearchPanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - TranscriptSearchPanel.Width) / 2;
            int centerY = (this.ClientSize.Height - TranscriptSearchPanel.Height) / 2;

            // Set the panel's location
            TranscriptSearchPanel.Location = new Point(centerX, centerY);
        }

        private void UploadExcelPanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - UploadExcelPanel.Width) / 2;
            int centerY = (this.ClientSize.Height - UploadExcelPanel.Height) / 2;

            // Set the panel's location
            UploadExcelPanel.Location = new Point(centerX, centerY);
        }

        private void ChangeGradePanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - ChangeGradePanel.Width) / 2;
            int centerY = (this.ClientSize.Height - ChangeGradePanel.Height) / 2;

            // Set the panel's location
            ChangeGradePanel.Location = new Point(centerX, centerY);
        }

        private void TranscriptPanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - TranscriptPanel.Width) / 2;
            int centerY = (this.ClientSize.Height - TranscriptPanel.Height) / 2;

            // Set the panel's location
            TranscriptPanel.Location = new Point(centerX, centerY);
        }

        private void DeletePanel_Paint(object sender, PaintEventArgs e)
        {
            int centerX = (this.ClientSize.Width - DeletePanel.Width) / 2;
            int centerY = (this.ClientSize.Height - DeletePanel.Height) / 2;

            // Set the panel's location
            DeletePanel.Location = new Point(centerX, centerY);
        }

        static double CalculateGradePoints(string Id)
        {
            double gpa = 0;
            double gpaTotal = 0;
            //Method to calculate GPA
            try
            {
                string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    List<string> results = new List<string>();

                    if (StudentExists(connection, Id))
                    {
                        //select student name and gpa from student table
                        string selectStudentQuery = "SELECT Grade FROM 440_hunter_student_grades WHERE StudentId = @Id";
                        using (MySqlCommand command = new MySqlCommand(selectStudentQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", Id);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    results.Add(reader["Grade"].ToString());
                                }

                                foreach (var grade in results)
                                {
                                    gpaTotal += getGpa(grade);
                                }
                            };
                        }

                        gpa = gpaTotal / results.Count();

                        //Insert the GPA into the student table.
                        string insertQuery = "UPDATE 440_hunter_student SET OverallGPA = @GPA WHERE StudentId = @Id";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@GPA", gpa);
                            command.Parameters.AddWithValue("@Id", Id);
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                    return gpa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating GPA.");
                return gpa;
            }

        }

        static double getGpa(string courseGrade)
        {
            switch (courseGrade)
            {
                case "A":
                    return 4.0;
                case "B":
                    return 3.0;
                case "C":
                    return 2.0;
                case "D":
                    return 1.0;
                case "F":
                    return 0.0;
                default:
                    return 0.0;
            }
        }
    }
}
