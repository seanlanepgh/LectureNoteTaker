namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    partial class Modnote
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
            this.ModuleInfoBox = new System.Windows.Forms.RichTextBox();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.DeleteModuleButton = new System.Windows.Forms.Button();
            this.ModuleListBox = new System.Windows.Forms.ListBox();
            this.ModuleInfo = new System.Windows.Forms.TabControl();
            this.ModuleInfoTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModuleInfoListBox = new System.Windows.Forms.ListBox();
            this.LectureNoteTab = new System.Windows.Forms.TabPage();
            this.ModuleNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NoteInfoBox = new System.Windows.Forms.RichTextBox();
            this.NoteNameListBox = new System.Windows.Forms.ListBox();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.AssignmentTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckDateButton = new System.Windows.Forms.Button();
            this.SortDates = new System.Windows.Forms.Button();
            this.AssignmentNamesBox = new System.Windows.Forms.ListBox();
            this.AssignmentNotesTab = new System.Windows.Forms.TabPage();
            this.AssignmentNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AssignmentNoteInfoBox = new System.Windows.Forms.RichTextBox();
            this.AddAssignmentNoteButton = new System.Windows.Forms.Button();
            this.AssignmentNoteNames = new System.Windows.Forms.ListBox();
            this.ModuleInfo.SuspendLayout();
            this.ModuleInfoTab.SuspendLayout();
            this.LectureNoteTab.SuspendLayout();
            this.AssignmentTab.SuspendLayout();
            this.AssignmentNotesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModuleInfoBox
            // 
            this.ModuleInfoBox.Location = new System.Drawing.Point(177, 29);
            this.ModuleInfoBox.Name = "ModuleInfoBox";
            this.ModuleInfoBox.Size = new System.Drawing.Size(493, 316);
            this.ModuleInfoBox.TabIndex = 1;
            this.ModuleInfoBox.Text = "";
            this.ModuleInfoBox.TextChanged += new System.EventHandler(this.ModuleInfoBox_TextChanged);
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Location = new System.Drawing.Point(6, 350);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(149, 47);
            this.AddModuleButton.TabIndex = 2;
            this.AddModuleButton.Text = "Add Module";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // DeleteModuleButton
            // 
            this.DeleteModuleButton.Location = new System.Drawing.Point(177, 350);
            this.DeleteModuleButton.Name = "DeleteModuleButton";
            this.DeleteModuleButton.Size = new System.Drawing.Size(149, 47);
            this.DeleteModuleButton.TabIndex = 3;
            this.DeleteModuleButton.Text = "Delete Module";
            this.DeleteModuleButton.UseVisualStyleBackColor = true;
            this.DeleteModuleButton.Click += new System.EventHandler(this.DeleteModuleButton_Click);
            // 
            // ModuleListBox
            // 
            this.ModuleListBox.FormattingEnabled = true;
            this.ModuleListBox.Location = new System.Drawing.Point(3, 29);
            this.ModuleListBox.Name = "ModuleListBox";
            this.ModuleListBox.Size = new System.Drawing.Size(152, 316);
            this.ModuleListBox.TabIndex = 7;
            this.ModuleListBox.SelectedValueChanged += new System.EventHandler(this.ModuleListBox_SelectedValueChanged);
            // 
            // ModuleInfo
            // 
            this.ModuleInfo.Controls.Add(this.ModuleInfoTab);
            this.ModuleInfo.Controls.Add(this.LectureNoteTab);
            this.ModuleInfo.Controls.Add(this.AssignmentTab);
            this.ModuleInfo.Controls.Add(this.AssignmentNotesTab);
            this.ModuleInfo.Location = new System.Drawing.Point(12, 1);
            this.ModuleInfo.Name = "ModuleInfo";
            this.ModuleInfo.SelectedIndex = 0;
            this.ModuleInfo.Size = new System.Drawing.Size(712, 437);
            this.ModuleInfo.TabIndex = 8;
            // 
            // ModuleInfoTab
            // 
            this.ModuleInfoTab.Controls.Add(this.label2);
            this.ModuleInfoTab.Controls.Add(this.label1);
            this.ModuleInfoTab.Controls.Add(this.ModuleInfoListBox);
            this.ModuleInfoTab.Controls.Add(this.ModuleInfoBox);
            this.ModuleInfoTab.Controls.Add(this.DeleteModuleButton);
            this.ModuleInfoTab.Controls.Add(this.ModuleListBox);
            this.ModuleInfoTab.Controls.Add(this.AddModuleButton);
            this.ModuleInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ModuleInfoTab.Name = "ModuleInfoTab";
            this.ModuleInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModuleInfoTab.Size = new System.Drawing.Size(704, 411);
            this.ModuleInfoTab.TabIndex = 0;
            this.ModuleInfoTab.Text = "Module Information";
            this.ModuleInfoTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(186, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Module Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modules";
            // 
            // ModuleInfoListBox
            // 
            this.ModuleInfoListBox.FormattingEnabled = true;
            this.ModuleInfoListBox.Location = new System.Drawing.Point(6, 184);
            this.ModuleInfoListBox.Name = "ModuleInfoListBox";
            this.ModuleInfoListBox.Size = new System.Drawing.Size(149, 160);
            this.ModuleInfoListBox.TabIndex = 8;
            this.ModuleInfoListBox.Visible = false;
            
            // 
            // LectureNoteTab
            // 
            this.LectureNoteTab.Controls.Add(this.ModuleNameLabel);
            this.LectureNoteTab.Controls.Add(this.label4);
            this.LectureNoteTab.Controls.Add(this.label3);
            this.LectureNoteTab.Controls.Add(this.NoteInfoBox);
            this.LectureNoteTab.Controls.Add(this.NoteNameListBox);
            this.LectureNoteTab.Controls.Add(this.AddNoteButton);
            this.LectureNoteTab.Location = new System.Drawing.Point(4, 22);
            this.LectureNoteTab.Name = "LectureNoteTab";
            this.LectureNoteTab.Padding = new System.Windows.Forms.Padding(3);
            this.LectureNoteTab.Size = new System.Drawing.Size(704, 411);
            this.LectureNoteTab.TabIndex = 1;
            this.LectureNoteTab.Text = "Lecture Notes";
            this.LectureNoteTab.UseVisualStyleBackColor = true;
            // 
            // ModuleNameLabel
            // 
            this.ModuleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModuleNameLabel.Location = new System.Drawing.Point(6, 3);
            this.ModuleNameLabel.Name = "ModuleNameLabel";
            this.ModuleNameLabel.Size = new System.Drawing.Size(151, 68);
            this.ModuleNameLabel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(175, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lecture Note Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lecture Notes";
            // 
            // NoteInfoBox
            // 
            this.NoteInfoBox.Location = new System.Drawing.Point(179, 34);
            this.NoteInfoBox.Name = "NoteInfoBox";
            this.NoteInfoBox.Size = new System.Drawing.Size(521, 303);
            this.NoteInfoBox.TabIndex = 9;
            this.NoteInfoBox.Text = "";
            this.NoteInfoBox.TextChanged += new System.EventHandler(this.NoteInfoBox_TextChanged);
            // 
            // NoteNameListBox
            // 
            this.NoteNameListBox.FormattingEnabled = true;
            this.NoteNameListBox.Location = new System.Drawing.Point(5, 126);
            this.NoteNameListBox.Name = "NoteNameListBox";
            this.NoteNameListBox.Size = new System.Drawing.Size(152, 212);
            this.NoteNameListBox.TabIndex = 12;
            this.NoteNameListBox.SelectedIndexChanged += new System.EventHandler(this.NoteNameListBox_SelectedIndexChanged);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Location = new System.Drawing.Point(5, 343);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(152, 47);
            this.AddNoteButton.TabIndex = 10;
            this.AddNoteButton.Text = "Add Lecture Note";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // AssignmentTab
            // 
            this.AssignmentTab.Controls.Add(this.label5);
            this.AssignmentTab.Controls.Add(this.CheckDateButton);
            this.AssignmentTab.Controls.Add(this.SortDates);
            this.AssignmentTab.Controls.Add(this.AssignmentNamesBox);
            this.AssignmentTab.Location = new System.Drawing.Point(4, 22);
            this.AssignmentTab.Name = "AssignmentTab";
            this.AssignmentTab.Size = new System.Drawing.Size(704, 411);
            this.AssignmentTab.TabIndex = 2;
            this.AssignmentTab.Text = "Assignments";
            this.AssignmentTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(17, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Assignment List";
            // 
            // CheckDateButton
            // 
            this.CheckDateButton.Location = new System.Drawing.Point(180, 351);
            this.CheckDateButton.Name = "CheckDateButton";
            this.CheckDateButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckDateButton.Size = new System.Drawing.Size(153, 46);
            this.CheckDateButton.TabIndex = 14;
            this.CheckDateButton.Text = "Check If Date Is Reached";
            this.CheckDateButton.UseVisualStyleBackColor = true;
            this.CheckDateButton.Click += new System.EventHandler(this.CheckDateButton_Click);
            // 
            // SortDates
            // 
            this.SortDates.Location = new System.Drawing.Point(21, 351);
            this.SortDates.Name = "SortDates";
            this.SortDates.Size = new System.Drawing.Size(153, 46);
            this.SortDates.TabIndex = 13;
            this.SortDates.Text = "Sort Assignment Dates";
            this.SortDates.UseVisualStyleBackColor = true;
            this.SortDates.Click += new System.EventHandler(this.SortDates_Click);
            // 
            // AssignmentNamesBox
            // 
            this.AssignmentNamesBox.FormattingEnabled = true;
            this.AssignmentNamesBox.Location = new System.Drawing.Point(21, 29);
            this.AssignmentNamesBox.Name = "AssignmentNamesBox";
            this.AssignmentNamesBox.Size = new System.Drawing.Size(666, 316);
            this.AssignmentNamesBox.TabIndex = 11;
            this.AssignmentNamesBox.SelectedIndexChanged += new System.EventHandler(this.AssignmentNamesBox_SelectedIndexChanged);
            // 
            // AssignmentNotesTab
            // 
            this.AssignmentNotesTab.Controls.Add(this.AssignmentNameLabel);
            this.AssignmentNotesTab.Controls.Add(this.label7);
            this.AssignmentNotesTab.Controls.Add(this.label6);
            this.AssignmentNotesTab.Controls.Add(this.AssignmentNoteInfoBox);
            this.AssignmentNotesTab.Controls.Add(this.AddAssignmentNoteButton);
            this.AssignmentNotesTab.Controls.Add(this.AssignmentNoteNames);
            this.AssignmentNotesTab.Location = new System.Drawing.Point(4, 22);
            this.AssignmentNotesTab.Name = "AssignmentNotesTab";
            this.AssignmentNotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssignmentNotesTab.Size = new System.Drawing.Size(704, 411);
            this.AssignmentNotesTab.TabIndex = 3;
            this.AssignmentNotesTab.Text = "Assignment Notes";
            this.AssignmentNotesTab.UseVisualStyleBackColor = true;
            // 
            // AssignmentNameLabel
            // 
            this.AssignmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AssignmentNameLabel.Location = new System.Drawing.Point(6, -22);
            this.AssignmentNameLabel.Name = "AssignmentNameLabel";
            this.AssignmentNameLabel.Size = new System.Drawing.Size(145, 131);
            this.AssignmentNameLabel.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(173, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Assignment  Note Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(2, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Assignment  Notes";
            // 
            // AssignmentNoteInfoBox
            // 
            this.AssignmentNoteInfoBox.Location = new System.Drawing.Point(177, 32);
            this.AssignmentNoteInfoBox.Name = "AssignmentNoteInfoBox";
            this.AssignmentNoteInfoBox.Size = new System.Drawing.Size(521, 303);
            this.AssignmentNoteInfoBox.TabIndex = 18;
            this.AssignmentNoteInfoBox.Text = "";
            this.AssignmentNoteInfoBox.TextChanged += new System.EventHandler(this.AssignmentNoteInfoBox_TextChanged);
            // 
            // AddAssignmentNoteButton
            // 
            this.AddAssignmentNoteButton.Location = new System.Drawing.Point(6, 341);
            this.AddAssignmentNoteButton.Name = "AddAssignmentNoteButton";
            this.AddAssignmentNoteButton.Size = new System.Drawing.Size(145, 47);
            this.AddAssignmentNoteButton.TabIndex = 16;
            this.AddAssignmentNoteButton.Text = "Add Assignment Note";
            this.AddAssignmentNoteButton.UseVisualStyleBackColor = true;
            this.AddAssignmentNoteButton.Click += new System.EventHandler(this.AddAssignmentNote_Click);
            // 
            // AssignmentNoteNames
            // 
            this.AssignmentNoteNames.FormattingEnabled = true;
            this.AssignmentNoteNames.Location = new System.Drawing.Point(6, 136);
            this.AssignmentNoteNames.Name = "AssignmentNoteNames";
            this.AssignmentNoteNames.Size = new System.Drawing.Size(145, 199);
            this.AssignmentNoteNames.TabIndex = 15;
            this.AssignmentNoteNames.SelectedIndexChanged += new System.EventHandler(this.AssignmentNoteNames_SelectedIndexChanged);
            // 
            // Modnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.ModuleInfo);
            this.Name = "Modnote";
            this.Text = "Modnote";
            this.ModuleInfo.ResumeLayout(false);
            this.ModuleInfoTab.ResumeLayout(false);
            this.ModuleInfoTab.PerformLayout();
            this.LectureNoteTab.ResumeLayout(false);
            this.LectureNoteTab.PerformLayout();
            this.AssignmentTab.ResumeLayout(false);
            this.AssignmentTab.PerformLayout();
            this.AssignmentNotesTab.ResumeLayout(false);
            this.AssignmentNotesTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddModuleButton;
        private System.Windows.Forms.Button DeleteModuleButton;
        private System.Windows.Forms.TabPage ModuleInfoTab;
        private System.Windows.Forms.Button SortDates;
        private System.Windows.Forms.ListBox AssignmentNamesBox;
        private System.Windows.Forms.ListBox ModuleInfoListBox;
        public System.Windows.Forms.TabControl ModuleInfo;
        public System.Windows.Forms.RichTextBox ModuleInfoBox;
        public System.Windows.Forms.TabPage AssignmentTab;
        private System.Windows.Forms.TabPage AssignmentNotesTab;
        public System.Windows.Forms.RichTextBox AssignmentNoteInfoBox;
        private System.Windows.Forms.Button AddAssignmentNoteButton;
        private System.Windows.Forms.ListBox AssignmentNoteNames;
        private System.Windows.Forms.Button CheckDateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage LectureNoteTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox NoteInfoBox;
        private System.Windows.Forms.ListBox NoteNameListBox;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox ModuleListBox;
        private System.Windows.Forms.Label ModuleNameLabel;
        private System.Windows.Forms.Label AssignmentNameLabel;
    }
}

