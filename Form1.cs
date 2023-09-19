using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show("File Path Does Not Exist", "Excel Upload Message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadExcelPanel.Visible = false;          
        }
    }
}
