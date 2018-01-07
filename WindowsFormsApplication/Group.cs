using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace WindowsFormsApplication
{

[Serializable()]

   public class Group : ISerializable
    {
        private string GroupID = "";
        private string GroupName = "";
        private string GroupMark = "";


        public Group(string groupIDnum)
        {
            GroupID = groupIDnum;
        }

        public string groupID
        {
            get { return GroupID; }
            set { GroupID = value; }
        }

        public string groupName
        {
            get { return GroupName; }
            set { GroupName = value; }
        }

        public string groupMark
        {
            get { return GroupMark; }
            set { GroupMark = value; }
        }

    
    // Deserialization (Load) Constructor
        public Group(SerializationInfo info, StreamingContext ctxt)
        {


            groupID = (String)info.GetValue("GroupID", typeof(string));
            groupName = (String)info.GetValue("GroupName", typeof(string));
            groupMark = (String)info.GetValue("GroupMark", typeof(string));
        }

    //Serialization (Save) Function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("GroupID", groupID);
            info.AddValue("GroupName", groupName);
            info.AddValue("GroupMark", groupMark);
        }

       


    }
}
