using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    public partial class AddAssignmentNoteForm : Form
    {
        // AddAssignmentNoteForm Constructor with the passed string from modnote form
        public AddAssignmentNoteForm(string transfer)
        {
            InitializeComponent();
            // Temporary stores the  module Name string in a hidden text for comparison
            TempModuleNameBox.Text = transfer;
        }
        //When the SubmitNoteButton is clicked then run this code
        private void SubmitNoteButton_Click(object sender, EventArgs e)
        {
            //Checks if the  textboxs are validated correctly 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Modnote.Module.addAssignmentNoteName = AddAssignmentNoteNameBox.Text;//Stores the contents of AddAssignmentNoteNameBox in addAssignmentNoteName variable
                Modnote.Module.addAssignmentNoteInfo = AddAssignmentNoteInfoBox.Text;//Stores the contents of AddAssignmentNoteInfoBox in addAssignmentNoteInfo variable
                this.DialogResult = DialogResult.OK;
            }
        }
        //When the CancelNoteButton is clicked then run this code
        private void CancelNoteButton_Click(object sender, EventArgs e)
        {
            AddAssignmentNoteInfoBox.Clear();//Clear the AddAssignmentNoteInfoBox to prevent it displaying old information
            AddAssignmentNoteNameBox.Clear();//Clear the AddAssignmentNoteNameBox to prevent it displaying old information
            this.DialogResult = DialogResult.OK;
        }
        //Validates the AddAssignmentNoteNameBox
        private void AddAssignmentNoteNameBox_Validating(object sender, CancelEventArgs e)
        {
            //Loops through the assignmentNotesList to check for the same assignment note name and module name
            foreach (var note in Modnote.Module.assignmentNotesList)
            {
                //Checks if the note name is the same as the AddAssignmentNoteNameBox  and if the notes module name is equal to the selected module name
                if (note.noteName == AddAssignmentNoteNameBox.Text && note.moduleName == TempModuleNameBox.Text)
                {
                    //If it is true then it labels the errorProvider3 and puts it next to the AddAssignmentNoteNameBox
                    e.Cancel = true; AddAssignmentNoteNameBox.Focus(); errorProvider3.SetError(AddAssignmentNoteNameBox, "You cannot have Assignment notes with the same name ");
                    break;
                }
                else
                {
                    //If it is not true then don't display the message in error provider
                    e.Cancel = false; errorProvider3.SetError(AddAssignmentNoteNameBox, "");
                }
            }
            //Check if the AddAssignmentNoteNameBox is empty 
            if (string.IsNullOrEmpty(AddAssignmentNoteNameBox.Text))
            {
                //display and label the errorProvider1 and put it next to the AddAssignmentNoteNameBox
                e.Cancel = true; AddAssignmentNoteNameBox.Focus(); errorProvider1.SetError(AddAssignmentNoteNameBox, " Assignment note name must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false; errorProvider1.SetError(AddAssignmentNoteNameBox, "");
            }
        }
        //Validates the AddAssignmentNoteInfoBox
        private void AddAssignmentNoteInfoBox_Validating(object sender, CancelEventArgs e)
        {
            //Check if the AddAssignmentNoteInfoBox is empty 
            if (string.IsNullOrEmpty(AddAssignmentNoteInfoBox.Text))
            {
                //display and label the errorProvider2 and put it next to the AddAssignmentNoteInfoBox
                e.Cancel = true; AddAssignmentNoteInfoBox.Focus(); errorProvider2.SetError(AddAssignmentNoteInfoBox, "Assignment note information must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false; errorProvider2.SetError(AddAssignmentNoteInfoBox, "");
            }
        }
    }
}
