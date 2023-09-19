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
            this.CloseAddFormButton = new System.Windows.Forms.Button();
            this.EnterNewGradeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.CancelDeleteButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ChangeGradePanel = new System.Windows.Forms.Panel();
            this.UploadExcelPanel = new System.Windows.Forms.Panel();
            this.CancelExcelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.CloseChangePanel = new System.Windows.Forms.Button();
            this.EnterChangeButton = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
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
            this.AddPanel.Controls.Add(this.CloseAddFormButton);
            this.AddPanel.Controls.Add(this.EnterNewGradeButton);
            this.AddPanel.Controls.Add(this.comboBox1);
            this.AddPanel.Controls.Add(this.textBox3);
            this.AddPanel.Controls.Add(this.textBox2);
            this.AddPanel.Controls.Add(this.textBox1);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.Class);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.studentNameBox);
            this.AddPanel.Location = new System.Drawing.Point(134, 59);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(464, 239);
            this.AddPanel.TabIndex = 5;
            this.AddPanel.Visible = false;
            // 
            // CloseAddFormButton
            // 
            this.CloseAddFormButton.BackColor = System.Drawing.Color.White;
            this.CloseAddFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAddFormButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddFormButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseAddFormButton.Location = new System.Drawing.Point(365, 180);
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
            this.EnterNewGradeButton.Location = new System.Drawing.Point(365, 131);
            this.EnterNewGradeButton.Name = "EnterNewGradeButton";
            this.EnterNewGradeButton.Size = new System.Drawing.Size(84, 43);
            this.EnterNewGradeButton.TabIndex = 10;
            this.EnterNewGradeButton.Text = "Enter";
            this.EnterNewGradeButton.UseVisualStyleBackColor = false;
            this.EnterNewGradeButton.Click += new System.EventHandler(this.EnterNewGradeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.comboBox1.Location = new System.Drawing.Point(141, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Location = new System.Drawing.Point(141, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(141, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(141, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semester:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade:";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(32, 82);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(45, 19);
            this.Class.TabIndex = 3;
            this.Class.Text = "Class:";
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
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // studentNameBox
            // 
            this.studentNameBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.studentNameBox.Location = new System.Drawing.Point(141, 47);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(174, 20);
            this.studentNameBox.TabIndex = 0;
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePanel.Controls.Add(this.CancelDeleteButton);
            this.DeletePanel.Controls.Add(this.DeleteStudentButton);
            this.DeletePanel.Controls.Add(this.comboBox2);
            this.DeletePanel.Controls.Add(this.textBox4);
            this.DeletePanel.Controls.Add(this.textBox5);
            this.DeletePanel.Controls.Add(this.textBox6);
            this.DeletePanel.Controls.Add(this.label7);
            this.DeletePanel.Controls.Add(this.label8);
            this.DeletePanel.Controls.Add(this.label9);
            this.DeletePanel.Controls.Add(this.label10);
            this.DeletePanel.Controls.Add(this.label11);
            this.DeletePanel.Controls.Add(this.label12);
            this.DeletePanel.Controls.Add(this.textBox7);
            this.DeletePanel.Location = new System.Drawing.Point(134, 59);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(464, 239);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.comboBox2.Location = new System.Drawing.Point(141, 193);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.Location = new System.Drawing.Point(141, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.Location = new System.Drawing.Point(141, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox6.Location = new System.Drawing.Point(141, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(174, 20);
            this.textBox6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Year:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Class:";
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
            this.label12.Location = new System.Drawing.Point(29, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name: ";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox7.Location = new System.Drawing.Point(141, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 20);
            this.textBox7.TabIndex = 0;
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
            this.TranscriptPanel.Location = new System.Drawing.Point(134, 59);
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
            this.TranscriptSearchPanel.Controls.Add(this.textBox8);
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
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox8.Location = new System.Drawing.Point(19, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(174, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Enter Student Name";
            // 
            // ChangeGradePanel
            // 
            this.ChangeGradePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChangeGradePanel.Controls.Add(this.CloseChangePanel);
            this.ChangeGradePanel.Controls.Add(this.EnterChangeButton);
            this.ChangeGradePanel.Controls.Add(this.comboBox3);
            this.ChangeGradePanel.Controls.Add(this.textBox9);
            this.ChangeGradePanel.Controls.Add(this.textBox10);
            this.ChangeGradePanel.Controls.Add(this.textBox13);
            this.ChangeGradePanel.Controls.Add(this.label15);
            this.ChangeGradePanel.Controls.Add(this.label16);
            this.ChangeGradePanel.Controls.Add(this.label19);
            this.ChangeGradePanel.Controls.Add(this.label20);
            this.ChangeGradePanel.Controls.Add(this.label21);
            this.ChangeGradePanel.Controls.Add(this.label22);
            this.ChangeGradePanel.Controls.Add(this.textBox14);
            this.ChangeGradePanel.Location = new System.Drawing.Point(133, 60);
            this.ChangeGradePanel.Name = "ChangeGradePanel";
            this.ChangeGradePanel.Size = new System.Drawing.Size(464, 239);
            this.ChangeGradePanel.TabIndex = 12;
            this.ChangeGradePanel.Visible = false;
            // 
            // UploadExcelPanel
            // 
            this.UploadExcelPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UploadExcelPanel.Controls.Add(this.CancelExcelButton);
            this.UploadExcelPanel.Controls.Add(this.button2);
            this.UploadExcelPanel.Controls.Add(this.label27);
            this.UploadExcelPanel.Controls.Add(this.textBox18);
            this.UploadExcelPanel.Location = new System.Drawing.Point(200, 100);
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
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(66, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(165, 19);
            this.label27.TabIndex = 2;
            this.label27.Text = "Please Insert the File Path";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox18.Location = new System.Drawing.Point(61, 82);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(174, 20);
            this.textBox18.TabIndex = 0;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Spring",
            "Fall"});
            this.comboBox3.Location = new System.Drawing.Point(141, 193);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(174, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox9.Location = new System.Drawing.Point(141, 81);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(174, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox10.Location = new System.Drawing.Point(141, 157);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(174, 20);
            this.textBox10.TabIndex = 8;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox13.Location = new System.Drawing.Point(141, 121);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(174, 20);
            this.textBox13.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Semester:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(42, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Year:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "New Grade:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(32, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "Class:";
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
            this.label22.Location = new System.Drawing.Point(29, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 19);
            this.label22.TabIndex = 1;
            this.label22.Text = "Name: ";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox14.Location = new System.Drawing.Point(141, 47);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(174, 20);
            this.textBox14.TabIndex = 0;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(672, 364);
            this.Controls.Add(this.UploadExcelPanel);
            this.Controls.Add(this.ChangeGradePanel);
            this.Controls.Add(this.TranscriptSearchPanel);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.TranscriptPanel);
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
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CloseAddFormButton;
        private System.Windows.Forms.Button EnterNewGradeButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button CancelDeleteButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
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
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel ChangeGradePanel;
        private System.Windows.Forms.Button CloseChangePanel;
        private System.Windows.Forms.Button EnterChangeButton;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Panel UploadExcelPanel;
        private System.Windows.Forms.Button CancelExcelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox18;
    }
}

