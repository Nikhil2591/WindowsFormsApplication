using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication
{

    [Serializable()]    
    public class Student : ISerializable, IComparable
    {
        private string StudentID;
        private string FirstName = "";
        private string Surname = "";
        private string Email = "";
        private string StudentMark ="";
        private string GroupID = "";
       


        public Student(string studentIDnum)
        {
            StudentID = studentIDnum;
        }


        public string studentID
        {
            get { return StudentID; }
            set { StudentID = value; }
        }

        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string stuMark
        {
            get { return StudentMark; }
            set { StudentMark = value; }
        }

        public string groupID
        {
            get { return GroupID; }
            set { GroupID = value; }
        }


        // Deserialization (Load) Constructor
        public Student(SerializationInfo info, StreamingContext ctxt)
        {

            studentID = (String)info.GetValue("StudentID", typeof(string));
            firstName = (String)info.GetValue("FirstName", typeof(string));
            surname = (String)info.GetValue("Surname", typeof(string));
            email = (String)info.GetValue("Email", typeof(string));
            stuMark = (String)info.GetValue("StudentMark", typeof(string));
            groupID = (String)info.GetValue("GroupID", typeof(string));
        }


        //Serialization (Save) Function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {

            info.AddValue("StudentID", studentID);
            info.AddValue("FirstName", firstName);
            info.AddValue("Surname", surname);
            info.AddValue("Email", email);
            info.AddValue("StudentMark", stuMark);
            info.AddValue("GroupID", groupID);
 
        }

        //provide default sort order for the student objects
        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                Student temp = (Student)obj;

                return this.firstName.CompareTo(temp.firstName);
            }

            throw new ArgumentException("object is not a Student");
        }

        // Nested class to do the sorting by student id
        private class sortByStudentIDHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student stu1 = (Student)a;
                Student stu2 = (Student)b;
                return stu1.studentID.CompareTo(stu2.studentID);
            }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortByStudentID()
        {
            return (IComparer)new sortByStudentIDHelper();
        }

        public int CompareGroupTo(object obj)
        {
            if (obj is Student)
            {
                Student temp = (Student)obj;

                return this.groupID.CompareTo(temp.groupID);
            }

            throw new ArgumentException("object is not a Group");
        }

        // Nested class to do the sorting by group name
        private class sortByGroupIDHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student grp1 = (Student)a;
                Student grp2 = (Student)b;
                return grp1.groupID.CompareTo(grp2.groupID);

            }
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortByGroupID()
        {
            return (IComparer)new sortByGroupIDHelper();
        }


   }
}
