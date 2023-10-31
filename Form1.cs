using System;
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
        }
        private void CloseAddFormButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void EnterNewGradeButton_Click(object sender, EventArgs e)
        {
            //will eventually add an if condition after the data is in the database and is checked. 
            MessageBox.Show("This record already exists!", "Add Record Error");

        }

        private void CancelDeleteButton_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = true;
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            //will eventually add if condition to see if delete was successful
            MessageBox.Show("This record does not exist!", "Delete Record Error");
        }

        private void PrintTranscriptButton_Click(object sender, EventArgs e)
        {
            TranscriptSearchPanel.Visible = true;
        }

        private void CloseTranscriptButton_Click(object sender, EventArgs e)
        {
            TranscriptPanel.Visible = false;
        }

        private void UploadExcelButton_Click(object sender, EventArgs e)
        {
            UploadExcelPanel.Visible = true;
        }

        //Method used to import student data from the excel file.
        public void ImportStudentDataFromExcel(string folderPath)
        {
            // Get a list of all Excel files in the specified folder.
            string[] excelFiles = Directory.GetFiles(folderPath, "*.xls*");

            if (excelFiles.Length == 0)
            {
                MessageBox.Show("No Excel files found in the selected folder.");
                return;
            }

            // Define your SQL Server connection string.
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
                            // Handle unsupported file format or display an error message.
                            MessageBox.Show($"Unsupported file format for {excelFile}");
                            continue;
                        }

                        DataSet result = reader.AsDataSet();

                        // Process the data and insert names into the database.
                        DataTable table = result.Tables[0]; // Assuming the data is in the first table of the DataSet.

                        foreach (DataRow row in table.Rows)
                        {
                            string name = row["name"].ToString(); // Replace "NameColumn" with the actual column name in your Excel file.

                            // Insert the name into the database.
                            string insertQuery = "INSERT INTO Students (name) VALUES (@name)";
                            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@name", name);
                                command.ExecuteNonQuery();
                            }
                        }

                        reader.Close();
                    }
                }

                connection.Close();
            }

            MessageBox.Show($"Processed and inserted names from {excelFiles.Length} Excel files into the database.");
        }

        //Method used to see if the student exists in the database by checking if the name returns a count.
        private bool StudentExists(MySqlConnection connection, string name)
        {
            var query = "SELECT COUNT(*) FROM Students WHERE Name = @Name";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void SearchForTranscriptButton_Click(object sender, EventArgs e)
        {
            TranscriptPanel.Visible = true;
            TranscriptSearchPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TranscriptSearchPanel.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ChangeGradePanel.Visible = true;
        }

        private void CloseChangePanel_Click(object sender, EventArgs e)
        {
            ChangeGradePanel.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Student does not exist!", "Transcript Record Error");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            string path = filePathTextBox.Text;
            Console.WriteLine(path);
            ImportStudentDataFromExcel(path);

            //******************* USE THIS INSTEAD OF THE TOP LINE ONCE CODE IS DONE TESTING **********************
            //try
            //{
            //    string path = filePathTextBox.Text;
            //    Console.WriteLine(path);
            //    ImportStudentDataFromExcel(path);
            //}catch(Exception ex)
            //{

            //    MessageBox.Show("File Path Does Not Exist", "Excel Upload Message");
            //    filePathTextBox.Text = "";
            //    UploadExcelPanel.Visible = false;

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadExcelPanel.Visible = false;
        }
    }
}
