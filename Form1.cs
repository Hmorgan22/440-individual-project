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

        public void ImportStudentDataFromExcel(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "*.xlsx");

            using (var connection = new SqlConnection("YourDatabaseConnectionString"))
            {
                connection.Open();

                foreach (var file in files)
                {
                    string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={file};Extended Properties=Excel 12.0";

                    using (var excelConnection = new OleDbConnection(connectionString))
                    {
                        excelConnection.Open();
                        var command = new OleDbCommand("SELECT * FROM [Sheet1$]", excelConnection);
                        var reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            var name = reader["Name"].ToString();
                            if (!StudentExists(connection, name))
                            {
                                var insertCommand = new SqlCommand("INSERT INTO Students (Name, Address, GPA) VALUES (@Name, @Address, @GPA)", connection);
                                insertCommand.Parameters.AddWithValue("@Name", name);
                                insertCommand.Parameters.AddWithValue("@Address", reader["Address"].ToString());
                                insertCommand.Parameters.AddWithValue("@GPA", Convert.ToDouble(reader["GPA"]));
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private bool StudentExists(SqlConnection connection, string name)
        {
            var query = "SELECT COUNT(*) FROM Students WHERE Name = @Name";
            var command = new SqlCommand(query, connection);
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
            string x = filePathTextBox.Text;
            Console.WriteLine(x);

            ImportStudentDataFromExcel(x);

           // MessageBox.Show("File Path Does Not Exist", "Excel Upload Message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadExcelPanel.Visible = false;          
        }
    }
}
