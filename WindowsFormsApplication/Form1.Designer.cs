namespace WindowsFormsApplication
{
    partial class Form1
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
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textStuMark = new System.Windows.Forms.TextBox();
            this.comboGroupID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddStud = new System.Windows.Forms.Button();
            this.textGroupID = new System.Windows.Forms.TextBox();
            this.textGroupMark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCreateGrp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textGroupName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortGroupID = new System.Windows.Forms.Button();
            this.SortStudentID = new System.Windows.Forms.Button();
            this.SortName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BulkAssign = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // textStudentID
            // 
            this.textStudentID.Location = new System.Drawing.Point(127, 54);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(106, 21);
            this.textStudentID.TabIndex = 1;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(127, 80);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(106, 21);
            this.textFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(127, 106);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(106, 21);
            this.textSurname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(127, 132);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(108, 21);
            this.textEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student Mark";
            // 
            // textStuMark
            // 
            this.textStuMark.Location = new System.Drawing.Point(127, 159);
            this.textStuMark.Name = "textStuMark";
            this.textStuMark.Size = new System.Drawing.Size(108, 21);
            this.textStuMark.TabIndex = 9;
            // 
            // comboGroupID
            // 
            this.comboGroupID.FormattingEnabled = true;
            this.comboGroupID.Location = new System.Drawing.Point(127, 186);
            this.comboGroupID.Name = "comboGroupID";
            this.comboGroupID.Size = new System.Drawing.Size(108, 23);
            this.comboGroupID.TabIndex = 10;
            this.comboGroupID.SelectedIndexChanged += new System.EventHandler(this.comboGroupID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Group ID";
            // 
            // buttonAddStud
            // 
            this.buttonAddStud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStud.Location = new System.Drawing.Point(64, 235);
            this.buttonAddStud.Name = "buttonAddStud";
            this.buttonAddStud.Size = new System.Drawing.Size(140, 41);
            this.buttonAddStud.TabIndex = 12;
            this.buttonAddStud.Text = "Add/Update Student";
            this.buttonAddStud.UseVisualStyleBackColor = false;
            this.buttonAddStud.Click += new System.EventHandler(this.buttonAddStud_Click);
            // 
            // textGroupID
            // 
            this.textGroupID.Location = new System.Drawing.Point(122, 46);
            this.textGroupID.Name = "textGroupID";
            this.textGroupID.Size = new System.Drawing.Size(127, 21);
            this.textGroupID.TabIndex = 15;
            // 
            // textGroupMark
            // 
            this.textGroupMark.Location = new System.Drawing.Point(123, 118);
            this.textGroupMark.Name = "textGroupMark";
            this.textGroupMark.Size = new System.Drawing.Size(127, 21);
            this.textGroupMark.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Group ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Group Mark";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(350, 541);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 31);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(469, 541);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 31);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCreateGrp
            // 
            this.buttonCreateGrp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateGrp.Location = new System.Drawing.Point(9, 226);
            this.buttonCreateGrp.Name = "buttonCreateGrp";
            this.buttonCreateGrp.Size = new System.Drawing.Size(123, 41);
            this.buttonCreateGrp.TabIndex = 24;
            this.buttonCreateGrp.Text = "Create/Update Group";
            this.buttonCreateGrp.UseVisualStyleBackColor = false;
            this.buttonCreateGrp.Click += new System.EventHandler(this.buttonCreateGrp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(469, 582);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 31);
            this.buttonReset.TabIndex = 25;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 171);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(508, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(396, 170);
            this.dataGridView2.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Group Name";
            // 
            // textGroupName
            // 
            this.textGroupName.Location = new System.Drawing.Point(121, 82);
            this.textGroupName.Name = "textGroupName";
            this.textGroupName.Size = new System.Drawing.Size(128, 21);
            this.textGroupName.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Student Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(505, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "Students in a selected group";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortGroupID);
            this.groupBox1.Controls.Add(this.SortStudentID);
            this.groupBox1.Controls.Add(this.SortName);
            this.groupBox1.Controls.Add(this.textStudentID);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Controls.Add(this.textSurname);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textStuMark);
            this.groupBox1.Controls.Add(this.comboGroupID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonAddStud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 434);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // sortGroupID
            // 
            this.sortGroupID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sortGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupID.Location = new System.Drawing.Point(64, 331);
            this.sortGroupID.Name = "sortGroupID";
            this.sortGroupID.Size = new System.Drawing.Size(118, 37);
            this.sortGroupID.TabIndex = 15;
            this.sortGroupID.Text = "Sort by Group ID";
            this.sortGroupID.UseVisualStyleBackColor = false;
            this.sortGroupID.Click += new System.EventHandler(this.sortGroupID_Click);
            // 
            // SortStudentID
            // 
            this.SortStudentID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SortStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortStudentID.Location = new System.Drawing.Point(127, 288);
            this.SortStudentID.Name = "SortStudentID";
            this.SortStudentID.Size = new System.Drawing.Size(122, 37);
            this.SortStudentID.TabIndex = 14;
            this.SortStudentID.Text = "Sort by Student ID";
            this.SortStudentID.UseVisualStyleBackColor = false;
            this.SortStudentID.Click += new System.EventHandler(this.SortStudentID_Click);
            // 
            // SortName
            // 
            this.SortName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortName.Location = new System.Drawing.Point(3, 288);
            this.SortName.Name = "SortName";
            this.SortName.Size = new System.Drawing.Size(107, 37);
            this.SortName.TabIndex = 13;
            this.SortName.Text = "Sort by First Name";
            this.SortName.UseVisualStyleBackColor = false;
            this.SortName.Click += new System.EventHandler(this.SortName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textGroupID);
            this.groupBox2.Controls.Add(this.textGroupName);
            this.groupBox2.Controls.Add(this.textGroupMark);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonCreateGrp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(360, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 278);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Details";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(350, 631);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(116, 36);
            this.ExitButton.TabIndex = 34;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BulkAssign
            // 
            this.BulkAssign.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BulkAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkAssign.Location = new System.Drawing.Point(348, 582);
            this.BulkAssign.Name = "BulkAssign";
            this.BulkAssign.Size = new System.Drawing.Size(113, 31);
            this.BulkAssign.TabIndex = 35;
            this.BulkAssign.Text = "Bulk Assign";
            this.BulkAssign.UseVisualStyleBackColor = false;
            this.BulkAssign.Click += new System.EventHandler(this.BulkAssign_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(629, 252);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(275, 269);
            this.dataGridView3.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Group Details";
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonImportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportCSV.Location = new System.Drawing.Point(472, 631);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(137, 37);
            this.buttonImportCSV.TabIndex = 38;
            this.buttonImportCSV.Text = "Import from CSV File";
            this.buttonImportCSV.UseVisualStyleBackColor = false;
            this.buttonImportCSV.Click += new System.EventHandler(this.buttonImportCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 745);
            this.Controls.Add(this.buttonImportCSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.BulkAssign);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStuMark;
        private System.Windows.Forms.ComboBox comboGroupID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddStud;
        private System.Windows.Forms.TextBox textGroupID;
        private System.Windows.Forms.TextBox textGroupMark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCreateGrp;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textGroupName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortStudentID;
        private System.Windows.Forms.Button SortName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button sortGroupID;
        private System.Windows.Forms.Button BulkAssign;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonImportCSV;
    }
}

