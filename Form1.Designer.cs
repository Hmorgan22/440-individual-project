namespace CSC440_GroupProject
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.addNumText = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.addIdText = new System.Windows.Forms.TextBox();
            this.CloseAddFormButton = new System.Windows.Forms.Button();
            this.EnterNewGradeButton = new System.Windows.Forms.Button();
            this.addSemesterText = new System.Windows.Forms.ComboBox();
            this.addPrefixText = new System.Windows.Forms.TextBox();
            this.addYearText = new System.Windows.Forms.TextBox();
            this.addGradeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNameText = new System.Windows.Forms.TextBox();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.CancelDeleteButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.deleteSemesterText = new System.Windows.Forms.ComboBox();
            this.deletePrefixText = new System.Windows.Forms.TextBox();
            this.deleteYearText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteIdText = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UploadExcelButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PrintTranscriptButton = new System.Windows.Forms.Button();
            this.TranscriptPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.CloseTranscriptButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.TranscriptSearchPanel = new System.Windows.Forms.Panel();
            this.CancelTranscriptSearchButton = new System.Windows.Forms.Button();
            this.SearchForTranscriptButton = new System.Windows.Forms.Button();
            this.transcriptIdText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ChangeGradePanel = new System.Windows.Forms.Panel();
            this.updatePrefixText = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CloseChangePanel = new System.Windows.Forms.Button();
            this.EnterChangeButton = new System.Windows.Forms.Button();
            this.updateSemesterText = new System.Windows.Forms.ComboBox();
            this.updateNumText = new System.Windows.Forms.TextBox();
            this.updateYearText = new System.Windows.Forms.TextBox();
            this.updateGradeText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.updateIdText = new System.Windows.Forms.TextBox();
            this.UploadExcelPanel = new System.Windows.Forms.Panel();
            this.CancelExcelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.deleteNumText = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.AddPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.TranscriptPanel.SuspendLayout();
            this.TranscriptSearchPanel.SuspendLayout();
            this.ChangeGradePanel.SuspendLayout();
            this.UploadExcelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade Management System";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(12, 59);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 43);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Grade";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPanel.Controls.Add(this.addNumText);
            this.AddPanel.Controls.Add(this.label24);
            this.AddPanel.Controls.Add(this.label23);
            this.AddPanel.Controls.Add(this.addIdText);
            this.AddPanel.Controls.Add(this.CloseAddFormButton);
            this.AddPanel.Controls.Add(this.EnterNewGradeButton);
            this.AddPanel.Controls.Add(this.addSemesterText);
            this.AddPanel.Controls.Add(this.addPrefixText);
            this.AddPanel.Controls.Add(this.addYearText);
            this.AddPanel.Controls.Add(this.addGradeText);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.Prefix);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.addNameText);
            this.AddPanel.Location = new System.Drawing.Point(571, 9);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(464, 283);
            this.AddPanel.TabIndex = 5;
            this.AddPanel.Visible = false;
            this.AddPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddPanel_Paint);
            // 
            // addNumText
            // 
            this.addNumText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addNumText.Location = new System.Drawing.Point(141, 140);
            this.addNumText.Name = "addNumText";
            this.addNumText.Size = new System.Drawing.Size(174, 20);
            this.addNumText.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 139);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 19);
            this.label24.TabIndex = 13;
            this.label24.Text = "Class Num:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(67, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 19);
            this.label23.TabIndex = 12;
            this.label23.Text = "ID:";
            this.label23.Click += new System.EventHandler(this.label23_Click_1);
            // 
            // addIdText
            // 
            this.addIdText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addIdText.Location = new System.Drawing.Point(141, 73);
            this.addIdText.Name = "addIdText";
            this.addIdText.Size = new System.Drawing.Size(174, 20);
            this.addIdText.TabIndex = 11;
            // 
            // CloseAddFormButton
            // 
            this.CloseAddFormButton.BackColor = System.Drawing.Color.White;
            this.CloseAddFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAddFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseAddFormButton.Location = new System.Drawing.Point(369, 226);
            this.CloseAddFormButton.Name = "CloseAddFormButton";
            this.CloseAddFormButton.Size = new System.Drawing.Size(84, 43);
            this.CloseAddFormButton.TabIndex = 10;
            this.CloseAddFormButton.Text = "Cancel";
            this.CloseAddFormButton.UseVisualStyleBackColor = false;
            this.CloseAddFormButton.Click += new System.EventHandler(this.CloseAddFormButton_Click);
            // 
            // EnterNewGradeButton
            // 
            this.EnterNewGradeButton.BackColor = System.Drawing.Color.White;
            this.EnterNewGradeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterNewGradeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNewGradeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterNewGradeButton.Location = new System.Drawing.Point(369, 176);
            this.EnterNewGradeButton.Name = "EnterNewGradeButton";
            this.EnterNewGradeButton.Size = new System.Drawing.Size(84, 43);
            this.EnterNewGradeButton.TabIndex = 10;
            this.EnterNewGradeButton.Text = "Enter";
            this.EnterNewGradeButton.UseVisualStyleBackColor = false;
            this.EnterNewGradeButton.Click += new System.EventHandler(this.EnterNewGradeButton_Click);
            // 
            // addSemesterText
            // 
            this.addSemesterText.FormattingEnabled = true;
            this.addSemesterText.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.addSemesterText.Location = new System.Drawing.Point(141, 248);
            this.addSemesterText.Name = "addSemesterText";
            this.addSemesterText.Size = new System.Drawing.Size(174, 21);
            this.addSemesterText.TabIndex = 10;
            // 
            // addPrefixText
            // 
            this.addPrefixText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addPrefixText.Location = new System.Drawing.Point(141, 104);
            this.addPrefixText.Name = "addPrefixText";
            this.addPrefixText.Size = new System.Drawing.Size(174, 20);
            this.addPrefixText.TabIndex = 9;
            // 
            // addYearText
            // 
            this.addYearText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addYearText.Location = new System.Drawing.Point(141, 213);
            this.addYearText.Name = "addYearText";
            this.addYearText.Size = new System.Drawing.Size(174, 20);
            this.addYearText.TabIndex = 8;
            // 
            // addGradeText
            // 
            this.addGradeText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addGradeText.Location = new System.Drawing.Point(141, 179);
            this.addGradeText.Name = "addGradeText";
            this.addGradeText.Size = new System.Drawing.Size(174, 20);
            this.addGradeText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semester:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade:";
            // 
            // Prefix
            // 
            this.Prefix.AutoSize = true;
            this.Prefix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prefix.Location = new System.Drawing.Point(14, 103);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(84, 19);
            this.Prefix.TabIndex = 3;
            this.Prefix.Text = "Class Prefix:";
            this.Prefix.Click += new System.EventHandler(this.Class_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please Insert Required Data To Add Student Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // addNameText
            // 
            this.addNameText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addNameText.Location = new System.Drawing.Point(141, 47);
            this.addNameText.Name = "addNameText";
            this.addNameText.Size = new System.Drawing.Size(174, 20);
            this.addNameText.TabIndex = 0;
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePanel.Controls.Add(this.deleteNumText);
            this.DeletePanel.Controls.Add(this.label26);
            this.DeletePanel.Controls.Add(this.CancelDeleteButton);
            this.DeletePanel.Controls.Add(this.DeleteStudentButton);
            this.DeletePanel.Controls.Add(this.deleteSemesterText);
            this.DeletePanel.Controls.Add(this.deletePrefixText);
            this.DeletePanel.Controls.Add(this.deleteYearText);
            this.DeletePanel.Controls.Add(this.label7);
            this.DeletePanel.Controls.Add(this.label8);
            this.DeletePanel.Controls.Add(this.label10);
            this.DeletePanel.Controls.Add(this.label11);
            this.DeletePanel.Controls.Add(this.label12);
            this.DeletePanel.Controls.Add(this.deleteIdText);
            this.DeletePanel.Location = new System.Drawing.Point(468, 304);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(464, 253);
            this.DeletePanel.TabIndex = 11;
            this.DeletePanel.Visible = false;
            // 
            // CancelDeleteButton
            // 
            this.CancelDeleteButton.BackColor = System.Drawing.Color.White;
            this.CancelDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelDeleteButton.Location = new System.Drawing.Point(365, 180);
            this.CancelDeleteButton.Name = "CancelDeleteButton";
            this.CancelDeleteButton.Size = new System.Drawing.Size(84, 43);
            this.CancelDeleteButton.TabIndex = 10;
            this.CancelDeleteButton.Text = "Cancel";
            this.CancelDeleteButton.UseVisualStyleBackColor = false;
            this.CancelDeleteButton.Click += new System.EventHandler(this.CancelDeleteButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.BackColor = System.Drawing.Color.White;
            this.DeleteStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteStudentButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteStudentButton.Location = new System.Drawing.Point(365, 131);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(84, 43);
            this.DeleteStudentButton.TabIndex = 10;
            this.DeleteStudentButton.Text = "Enter";
            this.DeleteStudentButton.UseVisualStyleBackColor = false;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // deleteSemesterText
            // 
            this.deleteSemesterText.FormattingEnabled = true;
            this.deleteSemesterText.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.deleteSemesterText.Location = new System.Drawing.Point(141, 210);
            this.deleteSemesterText.Name = "deleteSemesterText";
            this.deleteSemesterText.Size = new System.Drawing.Size(174, 21);
            this.deleteSemesterText.TabIndex = 10;
            // 
            // deletePrefixText
            // 
            this.deletePrefixText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deletePrefixText.Location = new System.Drawing.Point(141, 91);
            this.deletePrefixText.Name = "deletePrefixText";
            this.deletePrefixText.Size = new System.Drawing.Size(174, 20);
            this.deletePrefixText.TabIndex = 9;
            // 
            // deleteYearText
            // 
            this.deleteYearText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteYearText.Location = new System.Drawing.Point(141, 174);
            this.deleteYearText.Name = "deleteYearText";
            this.deleteYearText.Size = new System.Drawing.Size(174, 20);
            this.deleteYearText.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Semester:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Class Prefix:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(333, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Please Insert Required Data To Delete Student Grade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "ID:";
            // 
            // deleteIdText
            // 
            this.deleteIdText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteIdText.Location = new System.Drawing.Point(141, 47);
            this.deleteIdText.Name = "deleteIdText";
            this.deleteIdText.Size = new System.Drawing.Size(174, 20);
            this.deleteIdText.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditButton.Location = new System.Drawing.Point(12, 108);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(84, 43);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Change Grade";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(12, 157);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 43);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete Grade";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UploadExcelButton
            // 
            this.UploadExcelButton.BackColor = System.Drawing.Color.White;
            this.UploadExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UploadExcelButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadExcelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadExcelButton.Location = new System.Drawing.Point(12, 206);
            this.UploadExcelButton.Name = "UploadExcelButton";
            this.UploadExcelButton.Size = new System.Drawing.Size(84, 43);
            this.UploadExcelButton.TabIndex = 8;
            this.UploadExcelButton.Text = "Upload Excel ";
            this.UploadExcelButton.UseVisualStyleBackColor = false;
            this.UploadExcelButton.Click += new System.EventHandler(this.UploadExcelButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(12, 304);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(84, 43);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PrintTranscriptButton
            // 
            this.PrintTranscriptButton.BackColor = System.Drawing.Color.White;
            this.PrintTranscriptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintTranscriptButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintTranscriptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintTranscriptButton.Location = new System.Drawing.Point(12, 255);
            this.PrintTranscriptButton.Name = "PrintTranscriptButton";
            this.PrintTranscriptButton.Size = new System.Drawing.Size(84, 43);
            this.PrintTranscriptButton.TabIndex = 10;
            this.PrintTranscriptButton.Text = "Print Transcript";
            this.PrintTranscriptButton.UseVisualStyleBackColor = false;
            this.PrintTranscriptButton.Click += new System.EventHandler(this.PrintTranscriptButton_Click);
            // 
            // TranscriptPanel
            // 
            this.TranscriptPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TranscriptPanel.Controls.Add(this.label13);
            this.TranscriptPanel.Controls.Add(this.label18);
            this.TranscriptPanel.Controls.Add(this.listView1);
            this.TranscriptPanel.Controls.Add(this.textBox12);
            this.TranscriptPanel.Controls.Add(this.CloseTranscriptButton);
            this.TranscriptPanel.Controls.Add(this.label17);
            this.TranscriptPanel.Controls.Add(this.textBox11);
            this.TranscriptPanel.Location = new System.Drawing.Point(213, 18);
            this.TranscriptPanel.Name = "TranscriptPanel";
            this.TranscriptPanel.Size = new System.Drawing.Size(464, 239);
            this.TranscriptPanel.TabIndex = 12;
            this.TranscriptPanel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Classes/Grades";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(83, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "GPA:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(141, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 107);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox12.Location = new System.Drawing.Point(141, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(174, 20);
            this.textBox12.TabIndex = 11;
            // 
            // CloseTranscriptButton
            // 
            this.CloseTranscriptButton.BackColor = System.Drawing.Color.White;
            this.CloseTranscriptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseTranscriptButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseTranscriptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseTranscriptButton.Location = new System.Drawing.Point(365, 180);
            this.CloseTranscriptButton.Name = "CloseTranscriptButton";
            this.CloseTranscriptButton.Size = new System.Drawing.Size(84, 43);
            this.CloseTranscriptButton.TabIndex = 10;
            this.CloseTranscriptButton.Text = "Return Home";
            this.CloseTranscriptButton.UseVisualStyleBackColor = false;
            this.CloseTranscriptButton.Click += new System.EventHandler(this.CloseTranscriptButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(76, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "Name:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox11.Location = new System.Drawing.Point(141, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(174, 20);
            this.textBox11.TabIndex = 0;
            // 
            // TranscriptSearchPanel
            // 
            this.TranscriptSearchPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TranscriptSearchPanel.Controls.Add(this.CancelTranscriptSearchButton);
            this.TranscriptSearchPanel.Controls.Add(this.SearchForTranscriptButton);
            this.TranscriptSearchPanel.Controls.Add(this.transcriptIdText);
            this.TranscriptSearchPanel.Controls.Add(this.label14);
            this.TranscriptSearchPanel.Location = new System.Drawing.Point(200, 100);
            this.TranscriptSearchPanel.Name = "TranscriptSearchPanel";
            this.TranscriptSearchPanel.Size = new System.Drawing.Size(313, 98);
            this.TranscriptSearchPanel.TabIndex = 11;
            this.TranscriptSearchPanel.Visible = false;
            // 
            // CancelTranscriptSearchButton
            // 
            this.CancelTranscriptSearchButton.BackColor = System.Drawing.Color.White;
            this.CancelTranscriptSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelTranscriptSearchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelTranscriptSearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelTranscriptSearchButton.Location = new System.Drawing.Point(241, 64);
            this.CancelTranscriptSearchButton.Name = "CancelTranscriptSearchButton";
            this.CancelTranscriptSearchButton.Size = new System.Drawing.Size(69, 27);
            this.CancelTranscriptSearchButton.TabIndex = 12;
            this.CancelTranscriptSearchButton.Text = "Cancel";
            this.CancelTranscriptSearchButton.UseVisualStyleBackColor = false;
            this.CancelTranscriptSearchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForTranscriptButton
            // 
            this.SearchForTranscriptButton.BackColor = System.Drawing.Color.White;
            this.SearchForTranscriptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchForTranscriptButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForTranscriptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchForTranscriptButton.Location = new System.Drawing.Point(239, 17);
            this.SearchForTranscriptButton.Name = "SearchForTranscriptButton";
            this.SearchForTranscriptButton.Size = new System.Drawing.Size(71, 28);
            this.SearchForTranscriptButton.TabIndex = 12;
            this.SearchForTranscriptButton.Text = "Enter";
            this.SearchForTranscriptButton.UseVisualStyleBackColor = false;
            this.SearchForTranscriptButton.Click += new System.EventHandler(this.SearchForTranscriptButton_Click);
            // 
            // transcriptIdText
            // 
            this.transcriptIdText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.transcriptIdText.Location = new System.Drawing.Point(19, 44);
            this.transcriptIdText.Name = "transcriptIdText";
            this.transcriptIdText.Size = new System.Drawing.Size(174, 20);
            this.transcriptIdText.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Enter Student ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // ChangeGradePanel
            // 
            this.ChangeGradePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeGradePanel.Controls.Add(this.updatePrefixText);
            this.ChangeGradePanel.Controls.Add(this.label25);
            this.ChangeGradePanel.Controls.Add(this.CloseChangePanel);
            this.ChangeGradePanel.Controls.Add(this.EnterChangeButton);
            this.ChangeGradePanel.Controls.Add(this.updateSemesterText);
            this.ChangeGradePanel.Controls.Add(this.updateNumText);
            this.ChangeGradePanel.Controls.Add(this.updateYearText);
            this.ChangeGradePanel.Controls.Add(this.updateGradeText);
            this.ChangeGradePanel.Controls.Add(this.label15);
            this.ChangeGradePanel.Controls.Add(this.label16);
            this.ChangeGradePanel.Controls.Add(this.label19);
            this.ChangeGradePanel.Controls.Add(this.label20);
            this.ChangeGradePanel.Controls.Add(this.label21);
            this.ChangeGradePanel.Controls.Add(this.label22);
            this.ChangeGradePanel.Controls.Add(this.updateIdText);
            this.ChangeGradePanel.Location = new System.Drawing.Point(516, 24);
            this.ChangeGradePanel.Name = "ChangeGradePanel";
            this.ChangeGradePanel.Size = new System.Drawing.Size(464, 254);
            this.ChangeGradePanel.TabIndex = 12;
            this.ChangeGradePanel.Visible = false;
            // 
            // updatePrefixText
            // 
            this.updatePrefixText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updatePrefixText.Location = new System.Drawing.Point(141, 83);
            this.updatePrefixText.Name = "updatePrefixText";
            this.updatePrefixText.Size = new System.Drawing.Size(174, 20);
            this.updatePrefixText.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 19);
            this.label25.TabIndex = 11;
            this.label25.Text = "Class Prefix:";
            // 
            // CloseChangePanel
            // 
            this.CloseChangePanel.BackColor = System.Drawing.Color.White;
            this.CloseChangePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseChangePanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseChangePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseChangePanel.Location = new System.Drawing.Point(365, 180);
            this.CloseChangePanel.Name = "CloseChangePanel";
            this.CloseChangePanel.Size = new System.Drawing.Size(84, 43);
            this.CloseChangePanel.TabIndex = 10;
            this.CloseChangePanel.Text = "Cancel";
            this.CloseChangePanel.UseVisualStyleBackColor = false;
            this.CloseChangePanel.Click += new System.EventHandler(this.CloseChangePanel_Click);
            // 
            // EnterChangeButton
            // 
            this.EnterChangeButton.BackColor = System.Drawing.Color.White;
            this.EnterChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnterChangeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnterChangeButton.Location = new System.Drawing.Point(365, 131);
            this.EnterChangeButton.Name = "EnterChangeButton";
            this.EnterChangeButton.Size = new System.Drawing.Size(84, 43);
            this.EnterChangeButton.TabIndex = 10;
            this.EnterChangeButton.Text = "Enter";
            this.EnterChangeButton.UseVisualStyleBackColor = false;
            this.EnterChangeButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // updateSemesterText
            // 
            this.updateSemesterText.FormattingEnabled = true;
            this.updateSemesterText.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.updateSemesterText.Location = new System.Drawing.Point(141, 224);
            this.updateSemesterText.Name = "updateSemesterText";
            this.updateSemesterText.Size = new System.Drawing.Size(174, 21);
            this.updateSemesterText.TabIndex = 10;
            // 
            // updateNumText
            // 
            this.updateNumText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateNumText.Location = new System.Drawing.Point(141, 119);
            this.updateNumText.Name = "updateNumText";
            this.updateNumText.Size = new System.Drawing.Size(174, 20);
            this.updateNumText.TabIndex = 9;
            // 
            // updateYearText
            // 
            this.updateYearText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateYearText.Location = new System.Drawing.Point(141, 192);
            this.updateYearText.Name = "updateYearText";
            this.updateYearText.Size = new System.Drawing.Size(174, 20);
            this.updateYearText.TabIndex = 8;
            // 
            // updateGradeText
            // 
            this.updateGradeText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateGradeText.Location = new System.Drawing.Point(141, 156);
            this.updateGradeText.Name = "updateGradeText";
            this.updateGradeText.Size = new System.Drawing.Size(174, 20);
            this.updateGradeText.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Semester:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(55, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Year:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "New Grade:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "Class Num:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(76, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(340, 19);
            this.label21.TabIndex = 2;
            this.label21.Text = "Please Insert Required Data To Change Student Grade";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(67, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 19);
            this.label22.TabIndex = 1;
            this.label22.Text = "ID:";
            // 
            // updateIdText
            // 
            this.updateIdText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateIdText.Location = new System.Drawing.Point(141, 47);
            this.updateIdText.Name = "updateIdText";
            this.updateIdText.Size = new System.Drawing.Size(174, 20);
            this.updateIdText.TabIndex = 0;
            // 
            // UploadExcelPanel
            // 
            this.UploadExcelPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UploadExcelPanel.Controls.Add(this.CancelExcelButton);
            this.UploadExcelPanel.Controls.Add(this.button2);
            this.UploadExcelPanel.Controls.Add(this.label27);
            this.UploadExcelPanel.Controls.Add(this.TranscriptPanel);
            this.UploadExcelPanel.Location = new System.Drawing.Point(18, 376);
            this.UploadExcelPanel.Name = "UploadExcelPanel";
            this.UploadExcelPanel.Size = new System.Drawing.Size(300, 200);
            this.UploadExcelPanel.TabIndex = 13;
            this.UploadExcelPanel.Visible = false;
            // 
            // CancelExcelButton
            // 
            this.CancelExcelButton.BackColor = System.Drawing.Color.White;
            this.CancelExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelExcelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelExcelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelExcelButton.Location = new System.Drawing.Point(13, 138);
            this.CancelExcelButton.Name = "CancelExcelButton";
            this.CancelExcelButton.Size = new System.Drawing.Size(84, 43);
            this.CancelExcelButton.TabIndex = 10;
            this.CancelExcelButton.Text = "Cancel";
            this.CancelExcelButton.UseVisualStyleBackColor = false;
            this.CancelExcelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(209, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(102, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 19);
            this.label27.TabIndex = 2;
            this.label27.Text = "Select a Folder ";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // deleteNumText
            // 
            this.deleteNumText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteNumText.Location = new System.Drawing.Point(141, 130);
            this.deleteNumText.Name = "deleteNumText";
            this.deleteNumText.Size = new System.Drawing.Size(174, 20);
            this.deleteNumText.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(32, 131);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 19);
            this.label26.TabIndex = 11;
            this.label26.Text = "Class Num:";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1068, 573);
            this.Controls.Add(this.UploadExcelPanel);
            this.Controls.Add(this.ChangeGradePanel);
            this.Controls.Add(this.TranscriptSearchPanel);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.PrintTranscriptButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UploadExcelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.TranscriptPanel.ResumeLayout(false);
            this.TranscriptPanel.PerformLayout();
            this.TranscriptSearchPanel.ResumeLayout(false);
            this.TranscriptSearchPanel.PerformLayout();
            this.ChangeGradePanel.ResumeLayout(false);
            this.ChangeGradePanel.PerformLayout();
            this.UploadExcelPanel.ResumeLayout(false);
            this.UploadExcelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UploadExcelButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Prefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addNameText;
        private System.Windows.Forms.TextBox addPrefixText;
        private System.Windows.Forms.TextBox addYearText;
        private System.Windows.Forms.TextBox addGradeText;
        private System.Windows.Forms.ComboBox addSemesterText;
        private System.Windows.Forms.Button CloseAddFormButton;
        private System.Windows.Forms.Button EnterNewGradeButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button CancelDeleteButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.ComboBox deleteSemesterText;
        private System.Windows.Forms.TextBox deletePrefixText;
        private System.Windows.Forms.TextBox deleteYearText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deleteIdText;
        private System.Windows.Forms.Button PrintTranscriptButton;
        private System.Windows.Forms.Panel TranscriptPanel;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button CloseTranscriptButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel TranscriptSearchPanel;
        private System.Windows.Forms.Button CancelTranscriptSearchButton;
        private System.Windows.Forms.Button SearchForTranscriptButton;
        private System.Windows.Forms.TextBox transcriptIdText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel ChangeGradePanel;
        private System.Windows.Forms.Button CloseChangePanel;
        private System.Windows.Forms.Button EnterChangeButton;
        private System.Windows.Forms.ComboBox updateSemesterText;
        private System.Windows.Forms.TextBox updateNumText;
        private System.Windows.Forms.TextBox updateYearText;
        private System.Windows.Forms.TextBox updateGradeText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox updateIdText;
        private System.Windows.Forms.Panel UploadExcelPanel;
        private System.Windows.Forms.Button CancelExcelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox addIdText;
        private System.Windows.Forms.TextBox addNumText;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox updatePrefixText;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox deleteNumText;
        private System.Windows.Forms.Label label26;
    }
}

