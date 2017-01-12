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
    public partial class AddModuleForm : Form
    {
        public AddModuleForm()
        {
            InitializeComponent();
        }
        // If the SubmitModuleButton is clicked then run this code 
        private void SubmitModuleButton_Click(object sender, EventArgs e)
        {
            //Checks if the  textboxs are validated correctly 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //Calls AddModule Function
                Modnote.Module.AddModule(AddModuleNameBox.Text, AddModuleInfoBox.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
        //If the CancelModuleButton is clicked then run this code
        private void CancelModuleButton_Click(object sender, EventArgs e)
        {
            AddModuleInfoBox.Clear();//Clear the AddModuleInfoBox to prevent it displaying old information
            AddModuleNameBox.Clear();//Clear the AddModuleNameBox to prevent it displaying old information
            this.DialogResult = DialogResult.OK;
        }
        //Validates the AddModuleNameBox
        private void AddModuleNameBox_Validating(object sender, CancelEventArgs e)
        {
            //Check if the AddModuleNameBox is empty 
            if (string.IsNullOrEmpty(AddModuleNameBox.Text))
            {
                //display and label the errorProvider1 and put it next to the AddModuleNameBox
                e.Cancel = true; AddModuleNameBox.Focus(); errorProvider1.SetError(AddModuleNameBox, "Module name must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false; errorProvider1.SetError(AddModuleNameBox, "");
            }
        }
        //Validates the AddModuleInfoBox
        private void AddModuleInfoBox_Validating(object sender, CancelEventArgs e)
        {
            //Check if the AddModuleInfoBox is empty 
            if (string.IsNullOrEmpty(AddModuleInfoBox.Text))
            {
                //display and label the errorProvider2 and put it next to the AddModuleInfoBox
                e.Cancel = true; AddModuleInfoBox.Focus(); errorProvider2.SetError(AddModuleInfoBox, "Module information must not be empty");
            }
            else
            {
                //If it is not true then don't display the message in error provider
                e.Cancel = false; errorProvider2.SetError(AddModuleInfoBox, "");
            }
        }
    }
}
