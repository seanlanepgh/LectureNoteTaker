#define TEST
using System;
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
    public partial class AddNoteForm : Form
    {
        // AddNoteForm Constructor with the passed string from modnote form
        public AddNoteForm(string stringTransfer)
        {
            InitializeComponent();
            // Temporary stores the  module Name string in a hidden text for comparison
            TempModuleNameBox.Text = stringTransfer;
        }
        //When the SubmitNoteButton is clicked then run this code
        private void SubmitNoteButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("AddNoteForm:SubmitNoteButton_Click(object,EventArgs) called");
            Debug.WriteLine("*****************************************************");
#endif
            //Checks if the textboxs are validated correctly 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Modnote.Module.addNoteName = AddNoteNameBox.Text;//Stores the contents of AddNoteNameBox in addNoteName variable
                Modnote.Module.addNoteInfo = AddNoteInfoBox.Text;//Stores the contents of AddNoteInfoBox in addNoteInfo variable
#if TEST
                Debug.WriteLine("**SubmitNoteButton_Click**");
                Debug.WriteLine("Branch 1 selected");
                Debug.WriteLine("NoteName:" + Modnote.Module.addNoteName);
                Debug.WriteLine("NoteInfo:" + Modnote.Module.addNoteInfo);
                Debug.WriteLine("this.DialogResult = DialogResult.Ok");
#endif
                this.DialogResult = DialogResult.OK;
            }
#if TEST
            Debug.WriteLine("Return: Void");
            Debug.WriteLine("*****************************************************");
#endif
        }
        //When the CancelNoteButton is clicked then run this code
        private void CancelNoteButton_Click(object sender, EventArgs e)
        {
            AddNoteInfoBox.Clear();//Clear the AddNoteInfoBox to prevent it displaying old information
            AddNoteNameBox.Clear();//Clear the AddNoteNameBox to prevent it displaying old information
            this.DialogResult = DialogResult.OK;
        }
        //Validates the AddNoteNameBox
        private void AddNoteNameBox_Validating(object sender, CancelEventArgs e)
        {
            //Loops through the lectureNotesList to check for the same lecture note name and module name
            foreach (var note in Modnote.Module.lectureNotesList)
            {
                //Checks if the note name is the same as the AddNoteNameBox and if the notes module name is equal to the selected module name
                if (note.noteName == AddNoteNameBox.Text && note.moduleName == TempModuleNameBox.Text)
                {
                    //If it is true then it labels the errorProvider3 and puts it next to the AddNoteNameBox
                    e.Cancel = true;AddNoteNameBox.Focus();errorProvider3.SetError(AddNoteNameBox, "You cannot have lecture notes with the same name ");
                }
                else
                {
                    //If it is not true then don't display the message in error provider
                    e.Cancel = false;errorProvider3.SetError(AddNoteNameBox, "");
                }
            }
            //Check if the AddNoteNameBox is empty 
            if (string.IsNullOrEmpty(AddNoteNameBox.Text))
            {
                //display and label the errorProvider1 and put it next to the AddNoteNameBox
                e.Cancel = true;AddNoteNameBox.Focus();errorProvider1.SetError(AddNoteNameBox, "Lecture note name must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false;errorProvider1.SetError(AddNoteNameBox, "");
            }
        }
        //Validates the AddNoteInfoBox
        private void AddNoteInfoBox_Validating(object sender, CancelEventArgs e)
        {
            //Check if the AddNoteInfoBox is empty 
            if (string.IsNullOrEmpty(AddNoteInfoBox.Text))
            {
                //display and label the errorProvider2 and put it next to the AddNoteInfoBox
                e.Cancel = true; AddNoteInfoBox.Focus(); errorProvider2.SetError(AddNoteInfoBox, "Lecture note information must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false; errorProvider2.SetError(AddNoteInfoBox, "");
            }
        }
    }
}
