# WindowsFormsApplication

This is a C# desktop application that helps a tutor to manage grouping and marks of students doing a group coursework built using visual studios using the object oriented approach. The front end of the application was built using the Windows Forms tools in Visual Studios.

The application provides the following functionality:

1. Allow importing a class list from a text file (e.g. in .CSV format), or manually entering student details, which include student ID number, first name, last name, and email address.

2. Assign students to existing or new groups as described below. A group has a minimum of two and a maximum of four students from the class list. A student can only be in one group. Three methods of assigning students to groups should be implemented as follows:-
a. Create a new group, then assign from 1 to 4 new members to the group, allowing the user to select them from the class list.
b. Manually assign a student from the class list to an existing group, which can be identified by the group unique ID or by its existing member. Display a message if the group has already had the maximum of 4 members.
c. Bulk-assign the students who are not in any group to groups which have less than two members, and new groups if required.

3. Display the membership of the existing groups and the unassigned students on the computer screen. Your implementation should allow the user to select from at least two different sorting orders, e.g. by student last names and by group ID.

4. For each group, allow the user to record the group mark, and the individual student’s weighting out of 100% of their group’s mark.
5. Display the coursework mark for groups and individual students in a format of your own choice.

6. Save and retrieve the grouping status and the mark between program runs.

7. Quit the application.
