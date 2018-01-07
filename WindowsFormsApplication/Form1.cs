using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {

        //this arraylist is to store all the students and groups objects
        ArrayList StudentList = new ArrayList();
        ArrayList GroupList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initilize students
            for (int i = 0; i < 9; i++)
            {
                //initialise the array with numberOfstudents student object
                StudentList.Add(new Student("" + (i + 1))); //this is because studentId is declared as string
            }

            // bind the student datagrid to the arraylist
            dataGridView1.DataSource = StudentList;

            //initilize groups
            for (int i = 0; i < 4; i++)
            {
                //initialise the array with numberOfGroups Group object
                GroupList.Add(new Group("" + (i + 1))); //this is because GroupId is declared as string
                ((Group)GroupList[i]).groupName = "groupID" + (i + 1);
            }

            // bind the group datagrid to the arraylist
            dataGridView3.DataSource = GroupList;


            //set the combobox datasource to the group arraylist
            comboGroupID.DataSource = GroupList;
            comboGroupID.DisplayMember = "groupName";
            comboGroupID.ValueMember = "groupID";
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            //You must input student ID before anything else.
            foreach (object o in StudentList)
            {
                string str = (((Student)o).studentID);
                string studentID = textStudentID.Text;
                if (studentID == "")
                {
                    MessageBox.Show("You must input student ID first");
                    return;
                }
            }

            //check the new studentID - must be unique
            foreach (object o in StudentList)
            {
                string str = (((Student)o).studentID).ToUpper();

                //if found an existing student with the same student ID
                if (str.CompareTo((this.textStudentID.Text).ToUpper()) == 0)
                {
                    //MessageBox.Show("A student with ID = " + str + " already exists!");
                    //return;

                    // Initializes the variables to pass to the MessageBox.Show method. 

                    string message = "A Student with ID = " + str + " already exists!\n Do you really want to update this Student's record with new details";
                    string caption = "A Student already exists!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // update the student record

                        ((Student)o).firstName = this.textFirstName.Text;
                        ((Student)o).surname = this.textSurname.Text;
                        ((Student)o).email = this.textEmail.Text;
                        ((Student)o).stuMark = this.textStuMark.Text;
                        ((Student)o).groupID = this.comboGroupID.SelectedValue.ToString();


                        MessageBox.Show(((Student)o).firstName + " record has been updated with new details, except the ID Number.");

                        //refresh the display
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = StudentList;
                    }

                    return;
                }
            }

            Student newStudent = new Student(this.textStudentID.Text);
            newStudent.firstName = this.textFirstName.Text;
            newStudent.surname = this.textSurname.Text;
            newStudent.email = this.textEmail.Text;
            newStudent.stuMark = this.textStuMark.Text;
            newStudent.groupID = this.comboGroupID.SelectedValue.ToString();

            StudentList.Add(newStudent);

            MessageBox.Show(newStudent.firstName + " has been added to the list of students");

            //refresh the display
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

        }

        //add and update groups
        private void buttonCreateGrp_Click(object sender, EventArgs e)
        {
            //ensure group ID is inputted before group marks and group name
            foreach (object o in GroupList)
            {
                string str = (((Group)o).groupID);
                string groupID = textGroupID.Text;
                if (groupID == "")
                {
                    MessageBox.Show("you must input group ID before allocating group marks and group name");
                    return;
                }
            }

            //validate the new groupID - must be unique
            foreach (object o in GroupList)
            {
                string str = (((Group)o).groupID).ToUpper();

                //if found an existing group with the same ID
                if (str.CompareTo((this.textGroupID.Text).ToUpper()) == 0)
                {

                    // Initializes the variables to pass to the MessageBox.Show method. 

                    string message = "A group with ID = " + str + " already exists!\n Do you really want to update this group's record with new details";
                    string caption = "group already exists!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // update the student record

                        ((Group)o).groupName = this.textGroupName.Text;
                        ((Group)o).groupMark = this.textGroupMark.Text;
                        MessageBox.Show(((Group)o).groupID + " record has been updated with new details, except the groupID.");

                        //refresh the combobox
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = GroupList;
                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = GroupList;

                        comboGroupID.DataSource = null;
                        comboGroupID.DataSource = GroupList;
                        comboGroupID.DisplayMember = "groupName";
                        comboGroupID.ValueMember = "groupID";
                    }

                    return;

                }
            }

            //   the value of the entered groupId in the textbox is new

            //   create a new group object
            Group newGroup = new Group(this.textGroupID.Text);
            newGroup.groupName = this.textGroupName.Text;
            GroupList.Add(newGroup);

            MessageBox.Show(newGroup.groupName + " group has been created");

            // refresh the combobox
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = GroupList;
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = GroupList;

            comboGroupID.DataSource = null;
            comboGroupID.DataSource = GroupList;
            comboGroupID.DisplayMember = "groupName";
            comboGroupID.ValueMember = "groupID";
        }


        private void comboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display the students in the selected group

            if (this.comboGroupID.SelectedValue != null)
            {
                string selGroup = this.comboGroupID.SelectedValue.ToString();

                ArrayList GroupStaff = new ArrayList();

                foreach (object obj in StudentList)
                {
                    string str = (((Student)obj).groupID);

                    if (str.CompareTo(selGroup) == 0)
                        GroupStaff.Add((Student)obj);
                }

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = GroupStaff;
            }
        }



        //display the details of the selected row from the datagrid in the textboxes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Student selectedStudent = row.DataBoundItem as Student;
                if (selectedStudent != null)
                {
                    this.textStudentID.Text = selectedStudent.studentID;
                    this.textFirstName.Text = selectedStudent.firstName;
                    this.textSurname.Text = selectedStudent.surname;
                    this.textEmail.Text = selectedStudent.email;
                    this.textStuMark.Text = selectedStudent.stuMark;
                    this.comboGroupID.SelectedValue = selectedStudent.groupID; 

                }
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            //code below is for serialization (save)

            // Open a file and serialize the object into it in binary format.
            // StudentDetails.dat is the file that we are creating. 
            // Note:- you can give any extension you want for your file
            // If you use custom extensions, then the user will now 
            //   that the file is associated with your program.
            Stream stream = File.Open("StudentDetails.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, StudentList);
            stream.Close();

            //save group details
            stream = File.Open("GroupDetails.dat", FileMode.Create);
            bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, GroupList);
            stream.Close();

            MessageBox.Show("student's and Group's Data saved to file");
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {

                //Open the file written above and read values from it.
                Stream stream = File.Open("StudentDetails.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                //Reading Student Information
                StudentList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                //refresh the view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = StudentList;


                //Open the file written above and read values from it.
                stream = File.Open("GroupDetails.dat", FileMode.Open);
                bformatter = new BinaryFormatter();

                //Reading Group Details Information
                GroupList = (ArrayList)bformatter.Deserialize(stream);

                stream.Close();

                //refresh the combobox of groups
                comboGroupID.DataSource = null;
                comboGroupID.DataSource = GroupList;
                comboGroupID.DisplayMember = "groupName";
                comboGroupID.ValueMember = "groupID";

                MessageBox.Show("Student and Group Data is retrieved from file");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR reading file!");
            }


        }

        //Reset text fields so that the user can input new details

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textStudentID.Text = "";
            this.textFirstName.Text = "";
            this.textSurname.Text = "";
            this.textEmail.Text = "";
            this.textStuMark.Text = "";
            this.textGroupID.Text = "";
            this.textGroupName.Text = "";
            this.textGroupMark.Text = "";
        }




        //sort by student names in alphabetical order
        private void SortName_Click(object sender, EventArgs e)
        {
            StudentList.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }

        // sort by student id in numerical order.
        private void SortStudentID_Click(object sender, EventArgs e)
        {

            StudentList.Sort(Student.sortByStudentID());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;
        }

        // sort by group id in numerical order
        private void sortGroupID_Click(object sender, EventArgs e)
        {
            StudentList.Sort(Student.sortByGroupID());

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

        }

        //Exit Application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BulkAssign_Click(object sender, EventArgs e)
        {
            //declare an arraylist to store the students who are not allocated to a group
            ArrayList studentWithoutGroup = new ArrayList();

            foreach (object obj in StudentList)
            {
                string str = (((Student)obj).groupID);

                if (str == null || str.Trim() == "")
                    studentWithoutGroup.Add((Student)obj);
            }

            int numOfStuRemaining = studentWithoutGroup.Count;

            //Initializes the variables to pass

            string message = numOfStuRemaining + " students with no group" + "\nDo you want to execute bulk-assigment ?";

            string caption = "Bulk-Assign";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Displays the MessageBox

            result = MessageBox.Show(message, caption, buttons);

            //bulk asign

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                const int maxPerGrp = 4;
                const int minPerGrp = 2;

                int numberOfRequiredGroups = (numOfStuRemaining + maxPerGrp - 1) / maxPerGrp;
                int remainder = numOfStuRemaining % maxPerGrp;


                int autoGrpCount = 0;
                int memberCount = 0;
                string newgroupID = "";

                // traversing through the arraylist of the students without group, creating new groups to assign them to students

                foreach (object obj in studentWithoutGroup)
                {
                    if (memberCount == 0) // create new group
                    {
                        autoGrpCount++;
                        newgroupID = textGroupID.Text + autoGrpCount;
                        Group newGroup = new Group(newgroupID);
                        newGroup.groupName = textGroupID.Text + autoGrpCount;
                        GroupList.Add(newGroup);
                    }

                    // assign student to a new created group.

                    ((Student)obj).groupID = newgroupID;
                    memberCount++;



                    if ((numberOfRequiredGroups > 1 && remainder > 0 && autoGrpCount == 1 && memberCount == Math.Max(remainder, minPerGrp)) || (memberCount == maxPerGrp))
                    {
                        // reset group members count to create another new group
                        memberCount = 0;
                    }

                    //refresh data grid view

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = StudentList;

                    //refresh combobox

                    comboGroupID.DataSource = null;
                    comboGroupID.DataSource = GroupList;
                    comboGroupID.DisplayMember = "groupName";
                    comboGroupID.ValueMember = "groupID";
                }
            }
        }

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
            //Initializes the variables to pass to the MessageBox.Show method.

            string message = "do you want to replace the current data with the data inside the CSV file ?";
            string caption = "Import from CSV file";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)

                // delete current data in the GroupList Arraylist

                StudentList.Clear();

            // import the group.csv file located in the bin\debug folder within the project folder.

            string CSVfilename = "Student.csv";

            string csvData = "";

            //read from file into a string

            using (StreamReader oStreamReader = new StreamReader(File.OpenRead(CSVfilename)))
            {
                csvData = oStreamReader.ReadToEnd();
            }

            //parse the string csvData to object collection
            string[] rows = csvData.Replace("\r", "").Split('\n');

            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue;

                string[] cols = row.Split(',');

                //Instantiate a new Student object to store the row to import

                Student stuObj = new Student("");

                stuObj.studentID = cols[0];
                stuObj.firstName = cols[1];
                stuObj.surname = cols[2];

                StudentList.Add(stuObj);
            }

            //Refresh view

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

            //reset the textboxes

            this.textStudentID.Text = "";
            this.textFirstName.Text = "";
            this.textSurname.Text = "";
            this.comboGroupID.SelectedValue = 1;

        }




    }


}
