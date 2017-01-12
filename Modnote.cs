//#define TEST
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    public partial class Modnote : Form
    {
        public Modnote()
        {
            InitializeComponent();
            //Call a function to load the files
            LoadFiles();
        }
        public void LoadFiles()
        {
            //Used a array to hold the module titles because i know how many modules there are 
            string[] moduleTitles = new string[7];
            //Used StreamReader to read the CGP1005M.txt file
            StreamReader inputFile = new StreamReader(@"CGP1005M.txt");
            //Reads the file and stores it as a string
            string fileString = inputFile.ReadToEnd();
            //Adds the file string to a list that holds each module  information
            Module.moduleInfoList.Add(fileString);
            // Gets the module title from the file string 
            string titleSubString = fileString.Substring(5, 9);
            //Then stores the module title in the module title array
            moduleTitles[0] = titleSubString;
            //Gets a assignment date string 
            string assignmentSubString = fileString.Substring(625, 24);
            // Creates a unique name using the module title and the assignment date
            string assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            //Creates  a new assignment object which contains the module assignment id and a date object which contains the date using substrings from the file and the assignment name
            Module.moduleAssignmentList.Add(new Assignments(1, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(14, 2)), Convert.ToInt32(assignmentSubString.Substring(17, 2)), Convert.ToInt32(assignmentSubString.Substring(20, 4)))));
            inputFile.Close();
            //Used StreamReader to read the CMP1005M.txt file
            StreamReader inputFile2 = new StreamReader(@"CMP1005M.txt");
            fileString = inputFile2.ReadToEnd();
            //Adds the file string to a list that holds each module information
            Module.moduleInfoList.Add(fileString);
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[1] = titleSubString;
            //Gets assignment from CMP1005M.txt file 
            assignmentSubString = fileString.Substring(690, 30);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list to the module assignment list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds assignment from the CMP1005M.txt file
            Module.moduleAssignmentList.Add(new Assignments(2, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(20, 2)), Convert.ToInt32(assignmentSubString.Substring(23, 2)), Convert.ToInt32(assignmentSubString.Substring(26, 4)))));
            //Gets another assignment from CMP1005M.txt file 
            assignmentSubString = fileString.Substring(720, 30);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds another  assignment from the CMP1005M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(2, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(20, 2)), Convert.ToInt32(assignmentSubString.Substring(23, 2)), Convert.ToInt32(assignmentSubString.Substring(26, 4)))));
            inputFile2.Close();
            // Used stream reader to read the  CMP1123M.txt file
            StreamReader inputFile3 = new StreamReader(@"CMP1123M.txt");
            fileString = inputFile3.ReadToEnd();
            //Adds the file string to a list that holds each module  information
            Module.moduleInfoList.Add(fileString);
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[2] = titleSubString;
            //Gets assignment from CMP1123M.txt file 
            assignmentSubString = fileString.Substring(543, 24);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds assignment from the CMP1123M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(3, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(14, 2)), Convert.ToInt32(assignmentSubString.Substring(17, 2)), Convert.ToInt32(assignmentSubString.Substring(20, 4)))));
            inputFile3.Close();
            // Used stream reader to read the  CMP1124M.txt file
            StreamReader inputFile4 = new StreamReader(@"CMP1124M.txt");
            fileString = inputFile4.ReadToEnd();
            //Adds the file string to a list that holds each module  information
            Module.moduleInfoList.Add(fileString);
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[3] = titleSubString;
            //Gets assignment from CMP1124M.txt file 
            assignmentSubString = fileString.Substring(999, 30);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            //Because this date for this assignment has 16 instead of 2016 i had to do this as it affects then i am checking its date or comparing the dates when sorting 
            string year = "20" + assignmentSubString.Substring(26, 2);
            // Adds assignment from the CMP1124M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(4, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(20, 2)), Convert.ToInt32(assignmentSubString.Substring(23, 2)), Convert.ToInt32(year))));
            //Gets another assignment from CMP1124M.txt file 
            assignmentSubString = fileString.Substring(1028, 22);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds another assignment from the CMP1124M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(4, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(12, 2)), Convert.ToInt32(assignmentSubString.Substring(15, 2)), Convert.ToInt32(assignmentSubString.Substring(18, 4)))));
            inputFile4.Close();
            // Used stream reader to read the CMP1125M.txt file
            StreamReader inputFile5 = new StreamReader(@"CMP1125M.txt");
            fileString = inputFile5.ReadToEnd();
            //Adds the file string to a list that holds each module information
            Module.moduleInfoList.Add(fileString);
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[4] = titleSubString;
            //Gets assignment from CMP1125M.txt file 
            assignmentSubString = fileString.Substring(650, 30);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds assignment from the CMP1125M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(5, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(19, 2)), Convert.ToInt32(assignmentSubString.Substring(22, 2)), Convert.ToInt32(assignmentSubString.Substring(25, 4)))));
            //Gets another assignment from CMP1125M.txt file 
            assignmentSubString = fileString.Substring(680, 24);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds another assignment from the CMP1125M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(5, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(12, 2)), Convert.ToInt32(assignmentSubString.Substring(15, 2)), Convert.ToInt32(assignmentSubString.Substring(18, 4)))));
            //Gets another assignment from CMP1125M.txt file 
            assignmentSubString = fileString.Substring(702, 30);
             assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds another assignment from the CMP1125M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(5, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(20, 2)), Convert.ToInt32(assignmentSubString.Substring(23, 2)), Convert.ToInt32(assignmentSubString.Substring(26, 4)))));
            inputFile5.Close();
            // Used stream reader to read the  CMP1127M.txt file
            StreamReader inputFile6 = new StreamReader(@"CMP1127M.txt");
            fileString = inputFile6.ReadToEnd();
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[5] = titleSubString;
            //Adds the file string to a list that holds each module  information
            Module.moduleInfoList.Add(fileString);
            //Gets assignment from CMP1127M.txt file 
            assignmentSubString = fileString.Substring(720, 24);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds assignment from the CMP1127M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(6, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(12, 2)), Convert.ToInt32(assignmentSubString.Substring(15, 2)), Convert.ToInt32(assignmentSubString.Substring(18, 4)))));
            //Gets  another assignment from CMP1127M.txt file 
            assignmentSubString = fileString.Substring(744, 21);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds another assignment from the CMP1127M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(6, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(11, 2)), Convert.ToInt32(assignmentSubString.Substring(14, 2)), Convert.ToInt32(assignmentSubString.Substring(17, 4)))));
            inputFile6.Close();
            // Used stream reader to read the  CMP1129M.txt file
            StreamReader inputFile7 = new StreamReader(@"CMP1129M.txt");
            fileString = inputFile7.ReadToEnd();
            titleSubString = fileString.Substring(5, 9);
            moduleTitles[6] = titleSubString;
            //Adds the file string to a list that holds each module  information
            Module.moduleInfoList.Add(fileString);
            //Gets assignment from CMP1129M.txt file 
            assignmentSubString = fileString.Substring(730, 22);
            assignmentName = titleSubString + "  " + assignmentSubString;
            //Adds the unique name to the module assignment name list
            Module.moduleAssignmentNameList.Add(assignmentName);
            // Adds assignment from the CMP1129M.txt file to the module assignment list
            Module.moduleAssignmentList.Add(new Assignments(7, new Dates(assignmentName, Convert.ToInt32(assignmentSubString.Substring(12, 2)), Convert.ToInt32(assignmentSubString.Substring(15, 2)), Convert.ToInt32(assignmentSubString.Substring(18, 4)))));
            inputFile7.Close();
            //Adds each of the module Titles to the moduleNameList
            Module.moduleNameList.Add(moduleTitles[0]);
            Module.moduleNameList.Add(moduleTitles[1]);
            Module.moduleNameList.Add(moduleTitles[2]);
            Module.moduleNameList.Add(moduleTitles[3]);
            Module.moduleNameList.Add(moduleTitles[4]);
            Module.moduleNameList.Add(moduleTitles[5]);
            Module.moduleNameList.Add(moduleTitles[6]);
            //Adds everything in the moduleAssignmentNameList and allows the AssignmentNameBox to display the contents of the moduleAssignmentNameList
            AssignmentNamesBox.Items.AddRange(Module.moduleAssignmentNameList.ToArray());
            //Adds everything in the moduleNameList and allows the ModuleListBox to display the contents of the moduleNameList
            ModuleListBox.Items.AddRange(Module.moduleNameList.ToArray());
            //Adds everything in the moduleInfoList and allows the ModuleInfoListBox to display the contents of the moduleInfoList
            ModuleInfoListBox.Items.AddRange(Module.moduleInfoList.ToArray());
        }
        //When I select from the ModuleListBox.This changes the selected value  and then  runs this code 
        public void ModuleListBox_SelectedValueChanged(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("ModNote:ModuleListBox_SelectedValueChanged(object,EventArgs) called");
            Debug.WriteLine("*****************************************************");
#endif
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
            }
            else
            {
                //Gets the selected module name and stores it in a label
                ModuleNameLabel.Text = ModuleListBox.SelectedItem.ToString();
                //If it is selected then run this code 
                //Display the correct  moduleInfo from the moduleInfoList based on the selected index
                ModuleInfoBox.Text = Module.moduleInfoList[moduleIndex];
#if TEST
                Debug.WriteLine("ModuleNameLabel Value:"+ ModuleNameLabel.Text);
                Debug.WriteLine("ModuleInfoBox Text value:"+ModuleInfoBox.Text);
#endif
                //Clears the NoteNameListBox to refresh it  and  display it 
                NoteNameListBox.Items.Clear();
                //Clears the NoteInfoBox to refresh it and display it 
                NoteInfoBox.Clear();
                //Loops through each note in the lectureNotesList 
                foreach (var note in Module.lectureNotesList)
                {
#if TEST
                    Debug.WriteLine("Note name:" + note.noteName);
                    Debug.WriteLine("Notes Module:" + note.moduleName);
                    Debug.WriteLine("Selected Module:" + ModuleListBox.SelectedItem.ToString());
#endif
                    //if the notes module name is the same as the module selected then 
                    if (note.moduleName == ModuleListBox.SelectedItem.ToString())
                    {
                        //Add the note name to the NoteNameListBox
                        NoteNameListBox.Items.Add(note.noteName);
                    }
                }
            }
#if TEST
            Debug.WriteLine("Return: Void");
            Debug.WriteLine("*****************************************************");
#endif
        }
        //When the AddModuleButton  is clicked it runs this code
        private void AddModuleButton_Click(object sender, EventArgs e)
        {
            //It shows the AddModuleForm 
            AddModuleForm moduleForm = new AddModuleForm();
            // Gets the DialogResult.Ok and checks if it has been reached
            if (moduleForm.ShowDialog(this) == DialogResult.OK)
            {
                //Clears ModuleListBox to refresh it 
                ModuleListBox.Items.Clear();
                //Updates the ModuleListBox with the moduleNameList values
                ModuleListBox.Items.AddRange(Module.moduleNameList.ToArray());
                //Clears ModuleInfoListBox to refresh it 
                ModuleInfoListBox.Items.Clear();
                //Updates the ModuleInfoListBox with the moduleInfoList values
                ModuleInfoListBox.Items.AddRange(Module.moduleInfoList.ToArray());
            }
        }
        //When the DeleteModuleButton is clicked it runs this code
        private void DeleteModuleButton_Click(object sender, EventArgs e)
        {
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
            }
            else
            {
                ModuleNameLabel.Text = ""; //Clears the module name label for the notes tab
                //Clears the ModuleInfoBox to prevent displaying old data
                ModuleInfoBox.Clear();
                //Clears the NoteNameListBox
                NoteNameListBox.Items.Clear();
                //Clears the NoteInfoBox
                NoteInfoBox.Clear();
                //Calls the Delete Module function
                Module.DeleteModule(moduleIndex);
                //Clears the ModuleListBox to refresh it 
                ModuleListBox.Items.Clear();
                //Updates the ModuleListBox with values from moduleNameList
                ModuleListBox.Items.AddRange(Module.moduleNameList.ToArray());
                //Clears  the ModuleInfoListBox  to refresh it 
                ModuleInfoListBox.Items.Clear();
                //Updates the ModuleInfoListBox with values from moduleInfoList
                ModuleInfoListBox.Items.AddRange(Module.moduleInfoList.ToArray());
            }
        }
        //When I select from the NoteNameListBox.This changes the selected value and then runs this code 
        private void NoteNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
            }
            else
            {
                //Stores the Selected index from NoteNameListBox and stores it in noteIndex
                int noteIndex = NoteNameListBox.SelectedIndex;
                //Check if no index is selected
                if (noteIndex == -1)
                {
                    //This prevent errors
                }
                else
                {
                    //Else display the correct  lecture note information
                    //Loops through each of the notes in the lectureNotesList
                    foreach (var note in Module.lectureNotesList)
                    {
                        //If the notes name is equal to the selected note name  and the notes module name is equal to the module selected then display the notes information in NoteInfoBox
                        if (note.noteName == NoteNameListBox.SelectedItem.ToString() && note.moduleName == ModuleListBox.SelectedItem.ToString())
                        {
                            NoteInfoBox.Text = note.noteInfo;
                        }
                    }
                }
            }
        }
        //If Add Note Button is clicked it runs this code 
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("ModNote:AddNoteButton_Click(object,EventArgs) called");
            Debug.WriteLine("*****************************************************");
#endif
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
#if TEST
                Debug.WriteLine("**AddNoteButton_Click**");
                Debug.WriteLine("Branch 1");
                Debug.WriteLine("Module Not selected from the list of modules");
#endif
            }
            else
            {
#if TEST
                Debug.WriteLine("**AddNoteButton_Click**");
                Debug.WriteLine("Branch 2");
                Debug.WriteLine("Module is  selected from the list of modules");
#endif
                //Else show the AddNoteForm and pass the currently selected module name
                AddNoteForm noteForm = new AddNoteForm(ModuleListBox.SelectedItem.ToString());
                // Gets the DialogResult.Ok and checks if it has been reached
                if (noteForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Clear NoteNameListBox to refresh it 
                    NoteNameListBox.Items.Clear();
                    //Clear NoteInfoBox to prevent displaying old information
                    NoteInfoBox.Clear();
                    Module.numOfLectureNotes = 0;//Used to calculate the note ID 
                    //Loops through the notes in the lectureNoteList
                    foreach (var note in Module.lectureNotesList)
                    {
                        //Checks if the notes moduleName is the same as the Module Selected in the ModuleListBox
                        if (note.moduleName == ModuleListBox.SelectedItem.ToString())
                        {
                            //Increments the numOfLectureNote for that moduleName
                            Module.numOfLectureNotes++;
                        }
                    }
                    //Function creates a Notes Object using the selected Module as the moduleName ,the numOfLectureNotes to create a noteId and passes the NoteName and NoteInfo from the AddNoteForm
                    Notes Note = Notes.CreateLectureNote(ModuleListBox.SelectedItem.ToString(), Module.numOfLectureNotes, Module.addNoteName, Module.addNoteInfo);
                    //Function that adds a lecture note to the lectureNoteList
                    Module.AddLectureNote(Note);
                    //Loops through each note of lectureNotesList 
                    foreach (var note in Module.lectureNotesList)
                    {
                        //If notes moduleName is the same as the module Name selected 
                        if (note.moduleName == ModuleListBox.SelectedItem.ToString())
                        {
                            //Then add it to the NoteNameListBox so it can be displayed
                            NoteNameListBox.Items.Add(note.noteName);
                        }
                    }
                }
            }
#if TEST
            Debug.WriteLine("Return: Void");
            Debug.WriteLine("*****************************************************");
#endif
        }
        public class Module
        {
            public static List<string> moduleNameList = new List<string>();//Store all the module names in a list
            public static List<string> moduleInfoList = new List<string>();//Stores each module information in a list 
            public static List<Notes> lectureNotesList = new List<Notes>();//Stores the lecture notes for all the modules in a list 
            public static List<Notes> assignmentNotesList = new List<Notes>();//Stores the assignment notes for all the modules in a list
            public static List<Assignments> moduleAssignmentList = new List<Assignments>();//Stores all the assignments in a list 
            public static List<string> moduleAssignmentNameList = new List<string>();//Stores the assignment names in a list 
            public static string addNoteName;//Stores the notes name that is going to be add to the lectureNotesList
            public static string addNoteInfo;//Stores the notes information that is going to be add to the lectureNotesList
            public static string addAssignmentNoteName;//Stores the assignment notes name that is going to be add to the assignmentNotesList
            public static string addAssignmentNoteInfo;//Stores the assignment notes information that  is going to be add to the assignmentNotesList
            public static int numOfLectureNotes;//Used to calculate the noteId by counting the lecture notes and store it 
            public static int numOfAssignmentNotes;//Used to calculate the noteId by counting the assignment notes and store it
            //Add Module Function
            public static void AddModule(string moduleName, string moduleInfo)
            {
                moduleNameList.Add(moduleName);//Adds the contents from AddModuleNameBox to the moduleNameList
                moduleInfoList.Add(moduleInfo);//Adds the contents from AddModuleInfoBox to the moduleInfoList
            }
            //Delete Module Function
            public static void DeleteModule(int deleteIndex)
            {
                //Deletes the module name where the selected index from ModuleListBox is  in the moduleNameList
                moduleNameList.RemoveAt(deleteIndex);
                //Deletes the module info where the selected index from ModuleListBox is  in the moduleInfoList
                moduleInfoList.RemoveAt(deleteIndex);
            }
            //Add Lecture Notes Function 
            public static void AddLectureNote(Notes lectureNote)
            {
                //Adds the newNote to the lectureNotesList
                lectureNotesList.Add(lectureNote);
            }
            //Add  Assignment Notes Function 
            public static void AddAssignmentNote(Notes assignmentNote)
            {
                //Adds the new assignment note to the assignmentNotesList
                assignmentNotesList.Add(assignmentNote);
            }
        }
        //This class is used to store notes for lectures and assignments 
        public class Notes
        {
            public string moduleName;//Stores the moduleName for the lecture notes or for the assignment notes the module name and the assignment name
            public int noteId;//Stores the noteId
            public string noteName;//Stores the notes name
            public string noteInfo;//Stores the notes information
            public Notes(string modName, int noId, string name, string info)
            {
                moduleName = modName;
                noteId = noId;
                noteName = name;
                noteInfo = info;
            }
            //Function creates a lecture note
            public static Notes CreateLectureNote(string newModuleName,int newNoteId,string newNoteName,string newNoteInfo)
            {
#if TEST
                Debug.WriteLine("Notes:CreateLectureNote(string,int,string,string) called");
                Debug.WriteLine("*****************************************************");
                Debug.WriteLine("ModuleName:" + newModuleName);
                Debug.WriteLine("Note Id:" + newNoteId);
                Debug.WriteLine("Note Name:" + newNoteName);
                Debug.WriteLine("Note Info:" + newNoteInfo);
#endif
                //Creates a Notes Object using the selected Module as the moduleName ,the numOfLectureNotes to create a noteId and passes the NoteName and NoteInfo from the AddNoteForm
                Notes newNote = new Notes(newModuleName,newNoteId,newNoteName,newNoteInfo);
#if TEST
                Debug.WriteLine("Return:" + newNote);
                Debug.WriteLine("*****************************************************");
#endif
                //Returns the note object
                return newNote;
     
            }
            //Function creates a assignment note
            public static Notes CreateAssignmentNote(string newAssignmentName, int newAssignmentNoteId, string newAssignmentNoteName, string newAssignmnentNoteInfo)
            {
                /*Creates a new assignment note using the current selected assignment name as the module name , passes the numOfAssignmentNotes as the noteId.
                then passes the addAssignmentNoteName and the addAssignmentNoteInfo from the addAssignmentNoteForm*/
                Notes newNote = new Notes(newAssignmentName,newAssignmentNoteId,newAssignmentNoteName,newAssignmnentNoteInfo);
                //Returns the note object
                return newNote;
            }
        }
        //This class is used to store the assignments 
        public class Assignments
        {
            public int moduleAssignmentId;//Stores the assignment id 
            public Dates assignmentDate;//Stores the date for the assignment
            public Assignments(int modId, Dates dueDate)
            {
                moduleAssignmentId = modId;
                assignmentDate = dueDate;
            }
            //Function checks the date of an assignment
            public static void CheckDate(string selectedAssignment)
            {
                //Loop through each assignment of the moduleAssignmentList 
                foreach (var assignment in Module.moduleAssignmentList)
                {
                    //If the assignment Name is equal to the selected assignment name then 
                    if (assignment.assignmentDate.assignmentDateName == selectedAssignment)
                    {
                        //Get the assignment date in terms of day , month and year 
                        int dueDay = assignment.assignmentDate.assignmentDay;
                        int dueMonth = assignment.assignmentDate.assignmentMonth;
                        int dueYear = assignment.assignmentDate.assignmentYear;
                        //Get the date for today
                        DateTime today = DateTime.Today;
                        string todayDate = today.ToString("d");//Convert todays date to a string  format so it can be compared 
                        int todayDay = Convert.ToInt32(todayDate.Substring(0, 2));//Get the day using a substring  created from todays date string 
                        int todayMonth = Convert.ToInt32(todayDate.Substring(3, 2));//Get the month using a substring created from todays date string
                        int todayYear = Convert.ToInt32(todayDate.Substring(6, 4));//Get the year using a substring created from todays date string
                        //Compare the year values 
                        if (dueYear > todayYear)
                        {
                            //If the dueYear is greater then display this
                            MessageBox.Show("The due date has not been reached");
                        }
                        else if (dueYear < todayYear)
                        {
                            //If the dueYear is less than then display this 
                            MessageBox.Show("The due date has been reached");
                        }
                        //If the years are equal then compare the month values
                        else if (dueYear == todayYear)
                        {
                            //Compare month values
                            if (dueMonth > todayMonth)
                            {
                                //If the dueMonth is greater then display this 
                                MessageBox.Show("The due date has not been reached");
                            }
                            else if (dueMonth < todayMonth)
                            {
                                //If the dueMonth is less than then display this 
                                MessageBox.Show("The due date has been reached");
                            }
                            //If the Months are equal then compare the day values
                            else if (dueMonth == todayMonth)
                            {
                                //Compare day values
                                if (dueDay > todayDay)
                                {
                                    //If the dueDay is greater then display this 
                                    MessageBox.Show("The due date has not been reached");
                                }
                                else if (dueDay < todayDay)
                                {
                                    //If the dueDay is less than then display this 
                                    MessageBox.Show("The due date has been reached");
                                }
                            }
                        }
                    }
                }
            }
            //Function sorts the assignment dates
            public static Dates[] SortDates()
            {
                Dates[] temporaryDateArray = new Dates[12];//Create a temporaryDateArray to store the dates to sort them 
                int tempIndex = 0;//Used to store a index for the temporaryDateArray
                                  //Loop through each assignment in the moduleAssignmentList 
                foreach (var assignment in Module.moduleAssignmentList)
                {
                    //Function transfers the assignment name and the assignment date in terms of day , month and year from the list into an temporaryDateArray
                    temporaryDateArray[tempIndex]= Dates.TransferDate(assignment.assignmentDate.assignmentDateName, assignment.assignmentDate.assignmentDay, assignment.assignmentDate.assignmentMonth, assignment.assignmentDate.assignmentYear);
                   
                    tempIndex++;//Increment the tempIndex
                }
                // Perform a bubble sort to sort the dates
                //The two for loops are used to get and compare the two adjacent indexs in the array
                for (int adjacentDate = 0; adjacentDate < temporaryDateArray.Length; adjacentDate++)
                {
                    for (int adjacentDate2 = 0; adjacentDate2 < temporaryDateArray.Length - 1; adjacentDate2++)
                    {
                        //If the year value is greater than the other year then perform swaps
                        if (temporaryDateArray[adjacentDate2].assignmentYear > temporaryDateArray[adjacentDate2 + 1].assignmentYear)
                        {
                            //Create temp variables for Name ,Year ,Month and Day and then swap variable values
                            string tempName = temporaryDateArray[adjacentDate2 + 1].assignmentDateName;
                            int tempYear = temporaryDateArray[adjacentDate2 + 1].assignmentYear;
                            int tempMonth = temporaryDateArray[adjacentDate2 + 1].assignmentMonth;
                            int tempDay = temporaryDateArray[adjacentDate2 + 1].assignmentDay;
                            temporaryDateArray[adjacentDate2 + 1].assignmentDateName = temporaryDateArray[adjacentDate2].assignmentDateName;
                            temporaryDateArray[adjacentDate2 + 1].assignmentYear = temporaryDateArray[adjacentDate2].assignmentYear;
                            temporaryDateArray[adjacentDate2 + 1].assignmentMonth = temporaryDateArray[adjacentDate2].assignmentMonth;
                            temporaryDateArray[adjacentDate2 + 1].assignmentDay = temporaryDateArray[adjacentDate2].assignmentDay;
                            temporaryDateArray[adjacentDate2].assignmentDateName = tempName;
                            temporaryDateArray[adjacentDate2].assignmentYear = tempYear;
                            temporaryDateArray[adjacentDate2].assignmentMonth = tempMonth;
                            temporaryDateArray[adjacentDate2].assignmentDay = tempDay;
                        }
                        //If the years are equal then compare the month values 
                        else if (temporaryDateArray[adjacentDate2].assignmentYear == temporaryDateArray[adjacentDate2 + 1].assignmentYear)
                        {
                            //Compare the months and check if one is greater than the other if so then swap
                            if (temporaryDateArray[adjacentDate2].assignmentMonth > temporaryDateArray[adjacentDate2 + 1].assignmentMonth)
                            {
                                //Create temp variables for Name ,Year ,Month and Day and then swap variable values
                                string tempName = temporaryDateArray[adjacentDate2 + 1].assignmentDateName;
                                int tempYear = temporaryDateArray[adjacentDate2 + 1].assignmentYear;
                                int tempMonth = temporaryDateArray[adjacentDate2 + 1].assignmentMonth;
                                int tempDay = temporaryDateArray[adjacentDate2 + 1].assignmentDay;
                                temporaryDateArray[adjacentDate2 + 1].assignmentDateName = temporaryDateArray[adjacentDate2].assignmentDateName;
                                temporaryDateArray[adjacentDate2 + 1].assignmentYear = temporaryDateArray[adjacentDate2].assignmentYear;
                                temporaryDateArray[adjacentDate2 + 1].assignmentMonth = temporaryDateArray[adjacentDate2].assignmentMonth;
                                temporaryDateArray[adjacentDate2 + 1].assignmentDay = temporaryDateArray[adjacentDate2].assignmentDay;
                                temporaryDateArray[adjacentDate2].assignmentDateName = tempName;
                                temporaryDateArray[adjacentDate2].assignmentYear = tempYear;
                                temporaryDateArray[adjacentDate2].assignmentMonth = tempMonth;
                                temporaryDateArray[adjacentDate2].assignmentDay = tempDay;
                            }
                            // If the months are equal  then compare the day values
                            else if (temporaryDateArray[adjacentDate2].assignmentMonth == temporaryDateArray[adjacentDate2 + 1].assignmentMonth)
                            {
                                //If one of the day values is greater then perform a swap 
                                if (temporaryDateArray[adjacentDate2].assignmentDay > temporaryDateArray[adjacentDate2 + 1].assignmentDay)
                                {
                                    //Create temp variables for Name ,Year ,Month and Day and then swap variable values
                                    string tempName = temporaryDateArray[adjacentDate2 + 1].assignmentDateName;
                                    int tempYear = temporaryDateArray[adjacentDate2 + 1].assignmentYear;
                                    int tempMonth = temporaryDateArray[adjacentDate2 + 1].assignmentMonth;
                                    int tempDay = temporaryDateArray[adjacentDate2 + 1].assignmentDay;
                                    temporaryDateArray[adjacentDate2 + 1].assignmentDateName = temporaryDateArray[adjacentDate2].assignmentDateName;
                                    temporaryDateArray[adjacentDate2 + 1].assignmentYear = temporaryDateArray[adjacentDate2].assignmentYear;
                                    temporaryDateArray[adjacentDate2 + 1].assignmentMonth = temporaryDateArray[adjacentDate2].assignmentMonth;
                                    temporaryDateArray[adjacentDate2 + 1].assignmentDay = temporaryDateArray[adjacentDate2].assignmentDay;
                                    temporaryDateArray[adjacentDate2].assignmentDateName = tempName;
                                    temporaryDateArray[adjacentDate2].assignmentYear = tempYear;
                                    temporaryDateArray[adjacentDate2].assignmentMonth = tempMonth;
                                    temporaryDateArray[adjacentDate2].assignmentDay = tempDay;
                                }
                            }
                        }
                    }
                }
                //Returns the array of sorted dates
                return temporaryDateArray;
            }
        }
        //This Class is used to store the assignment Dates
        public class Dates
        {
            public string assignmentDateName;//Stores the assignment Dates Name
            public int assignmentYear; //Stores the year  for the assignment date
            public int assignmentMonth;//Stores the month for the assignment date
            public int assignmentDay;//Stores the day for the assignment date
            public Dates(string name, int day, int month, int year)
            {
                assignmentDateName = name;
                assignmentMonth = month;
                assignmentYear = year;
                assignmentDay = day;
            }
            //Function used to get the assignment name and date from the moduleAssignmentlList 
            public static Dates TransferDate(string transferAssignmentName,int transferAssignmentDay,int transferAssignmentMonth,int transferAssignmentYear)
            {
                //Gets the assignment name and date for each assignment and stores it in a Dates Object
                Dates Date = new Dates(transferAssignmentName,transferAssignmentDay,transferAssignmentMonth,transferAssignmentYear);
                return Date;
            }
        }
        //When I select from the AssignmentNamesBox .This changes the selected value and then  runs this code 
        private void AssignmentNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the AssignmentNoteNames to refresh it 
            AssignmentNoteNames.Items.Clear();
            //Clears the AssignmentNoteInfoBox to prevent the text box from displaying old information
            AssignmentNoteInfoBox.Clear();
            int assignmentIndex = AssignmentNamesBox.SelectedIndex;//Stores the Selected assignment index from AssignmentNamesBox
            //Checks if index is not selected
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Please select a assignment from the list of assignment name box");
            }
            else
            {
                //Adds the selected assignment name and adds it to a label
                AssignmentNameLabel.Text = AssignmentNamesBox.SelectedItem.ToString();
                //if the index is selected then loop through the notes of the assignmentNotesList
                foreach (var note in Module.assignmentNotesList)
                {
                    //If the notes module Name which contains the module name and the assignment name is the same as the assignment name selected in assignmentNamesBox then
                    if (note.moduleName == AssignmentNamesBox.SelectedItem.ToString())
                    {
                        //Add the assignment notes name to the AssignmentNotesNames Listbox to display it 
                        AssignmentNoteNames.Items.Add(note.noteName);
                    }
                }
            }
        }
        //If the Sort Dates button is clicked then run this code 
        private void SortDates_Click(object sender, EventArgs e)
        {
            //Clears the AssignmentNamesBox to refresh it 
            AssignmentNamesBox.Items.Clear();
            Dates[] assignmentDateArray = new Dates[12];//Create a temporaryDateArray to store the dates to sort them 
            //Calls the sort dates function and gets the sorted dates array
            assignmentDateArray = Assignments.SortDates();
            int arrayIndex = 0;//Reset the arrayIndex
            //Loop through the assignmentDateArray
            for (arrayIndex = 0; arrayIndex < 12; arrayIndex++)
            {
                //Add sorted assignment Name to the AssignmentNamesBox to display the sort assignment dates
                AssignmentNamesBox.Items.Add(assignmentDateArray[arrayIndex].assignmentDateName);
            }
        }
        //If the CheckDateButton is clicked then run this code
        private void CheckDateButton_Click(object sender, EventArgs e)
        {
            int assignmentIndex = AssignmentNamesBox.SelectedIndex;//Stores the Selected assignment index from AssignmentNamesBox
            //Checks if index is not selected
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Please select a assignment from the list of assignment name box");
            }
            //If it is selected then run this code 
            else if (AssignmentNamesBox.SelectedIndex != -1)
            {
                //Calls the CheckDate function
                Assignments.CheckDate(AssignmentNamesBox.SelectedItem.ToString());
            }
        }
        //If Add assignment Note button is clicked then run this code 
        private void AddAssignmentNote_Click(object sender, EventArgs e)
        {
            int assignmentIndex = AssignmentNamesBox.SelectedIndex;//Stores the Selected assignment index from AssignmentNamesBox
            //Checks if index is not selected
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Please select a assignment from the list of assignment name box");
            }
            //If it is selected then run this code 
            else if (AssignmentNamesBox.SelectedIndex != -1)
            {
                // Show the AddAssignmentNoteForm 
                AddAssignmentNoteForm assignmentNoteForm = new AddAssignmentNoteForm(AssignmentNamesBox.SelectedItem.ToString());
                // Gets the DialogResult.Ok and checks if it has been reached
                if (assignmentNoteForm.ShowDialog(this) == DialogResult.OK)
                {
                    //Clear the AssignmentNoteNames list box to refresh it 
                    AssignmentNoteNames.Items.Clear();
                    //Clear the AssignmentNoteInfoBox to prevent it displaying old information
                    AssignmentNoteInfoBox.Clear();
                    Module.numOfAssignmentNotes = 0;//Set the numOfAssignmentNotes and is used to create a note id 
                    //Loop through each assignment note in the assignmentNotesList
                    foreach (var note in Module.assignmentNotesList)
                    {
                        //Check if the notes module name which is made of the module name and the assignment name is equal to the selected assignment name in AssignmentNamesBox 
                        if (note.moduleName == AssignmentNamesBox.SelectedItem.ToString())
                        {
                            //Increment the numOfAssignmentNotes to calculate the noteId 
                            Module.numOfAssignmentNotes++;
                        }
                    }
                    /*Function creates a new assignment note using the current selected assignment name as the module name , passes the numOfAssignmentNotes as the noteId.
                    then passes the addAssignmentNoteName and the addAssignmentNoteInfo from the addAssignmentNoteForm*/
                    Notes newAssignmentNote = Notes.CreateAssignmentNote(AssignmentNamesBox.SelectedItem.ToString(), Module.numOfAssignmentNotes, Module.addAssignmentNoteName, Module.addAssignmentNoteInfo);
                    //Function adds  a new assignment note to the assignmentNotesList
                    Module.AddAssignmentNote(newAssignmentNote);
                    // Loops through each of the assignment notes in the assignmentNotesList
                    foreach (var note in Module.assignmentNotesList)
                    {
                        //Check if the notes module name which is made of the module name and the assignment name is equal to the selected assignment name in AssignmentNamesBox 
                        if (note.moduleName == AssignmentNamesBox.SelectedItem.ToString())
                        {
                            //Add the notes name to the AssignmentNoteNames list box to display it 
                            AssignmentNoteNames.Items.Add(note.noteName);
                        }
                    }
                }
            }
        }
        //When I select from the AssignmentNoteNames.This changes the selected value and then runs this code 
        private void AssignmentNoteNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int assignmentIndex = AssignmentNamesBox.SelectedIndex;//Stores the Selected assignment index from AssignmentNamesBox
            //Checks if index is not selected
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Please select a assignment from the list of assignment name box");
            }
            //If it is selected then run this code 
            else 
            {
                int assignmentNoteIndex = AssignmentNoteNames.SelectedIndex;//Stores the Selected assignment note index from AssignmentNoteNames
                //Checks if index is not selected
                if (assignmentNoteIndex == -1)
                {
                    //This prevent errors
                }
                else
                {
                    //If it is selected then run this code 
                    //Loops through the assignment notes in the assignmentNotesList 
                    foreach (var note in Module.assignmentNotesList)
                    {
                        //Checks if the noteName is equal to the selected Note Name  in the AssignmentNoteNames ListBox and if the notes module name is equal to the selected assignment in AssignmentNamesBox
                        if (note.noteName == AssignmentNoteNames.SelectedItem.ToString() && note.moduleName == AssignmentNamesBox.SelectedItem.ToString())
                        {
                            //Displays the notes Information for that note in the AssignmentNoteInfoBox 
                            AssignmentNoteInfoBox.Text = note.noteInfo;
                        }
                    }
                }
            }
        }
        //When you change the ModuleInfoBox it runs this code
        private void ModuleInfoBox_TextChanged(object sender, EventArgs e)
        {
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
            }
            else
            {
                //if index is selected loop through each module in the moduleNameList
                for (int moduleCount = Module.moduleNameList.Count - 1; moduleCount >= 0; moduleCount--)
                {
                    //Checks if the module name in the list is equal to the module selected
                    if (Module.moduleNameList[moduleCount] == ModuleListBox.SelectedItem.ToString())
                    {
                        //if so update the correct  module info with the ModuleInfoBox text
                        Module.moduleInfoList[moduleCount] = ModuleInfoBox.Text;
                    }
                }
            }
        }
        //When you change the NoteInfoBox it runs this code 
        private void NoteInfoBox_TextChanged(object sender, EventArgs e)
        {
            //Stores the Selected Index of ModuleListBox
            int moduleIndex = ModuleListBox.SelectedIndex;
            //Check if no index is selected
            if (moduleIndex == -1)
            {
                MessageBox.Show("Please select a module from the list of modules ");
            }
            else
            {
                int lectureNoteIndex = NoteNameListBox.SelectedIndex;//Stores the Selected lecture note index from NoteNameListBox
                //Checks if index is not selected
                if (lectureNoteIndex == -1)
                {
                    //This prevent errors
                }
                else
                {
                    //if the index is selected then loop through the notes of the lectureNotesList
                    foreach (var note in Module.lectureNotesList)
                    {
                        //If the notes module Name which contains the module name is equal to the ModuleListBox and the notes name is equal to the selected note name from NoteNameListBox then 
                        if (note.noteName == NoteNameListBox.SelectedItem.ToString() && note.moduleName == ModuleListBox.SelectedItem.ToString())
                        {
                            // update this notes information using the NoteInfoBox text
                            note.noteInfo = NoteInfoBox.Text;
                        }
                    }
                }
            }
        }
        //When you change the AssignmentNoteInfoBox it runs this code 
        private void AssignmentNoteInfoBox_TextChanged(object sender, EventArgs e)
        {
            int assignmentIndex = AssignmentNamesBox.SelectedIndex;//Stores the Selected assignment index from AssignmentNamesBox
            //Checks if index is not selected
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Please select a assignment from the list of assignment name box");
            }
            //If it is selected then run this code 
            else
            {
                int assignmentNoteIndex = AssignmentNoteNames.SelectedIndex;//Stores the Selected assignment index from AssignmentNoteNames
                //Checks if index is not selected
                if (assignmentNoteIndex == -1)
                {
                    //This prevent errors
                }
                else
                {
                    //if the index is selected then loop through the notes of the assignmentNotesList
                    foreach (var note in Module.assignmentNotesList)
                    {
                        /*If the notes module Name which contains the module name and the assignment name is the same as the assignment name selected in assignmentNamesBox  
                        and the notes name is equal to the selected assignment note name in the AssignmentNoteName then */
                        if (note.noteName == AssignmentNoteNames.SelectedItem.ToString() && note.moduleName == AssignmentNamesBox.SelectedItem.ToString())
                        {
                            // updates the  assignment notes information using the  AssignmentNoteInfoBox text
                            note.noteInfo = AssignmentNoteInfoBox.Text;
                        }
                    }
                }
            }
        }
    }
}
