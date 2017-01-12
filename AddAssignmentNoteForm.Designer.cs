namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    partial class AddAssignmentNoteForm
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
            this.components = new System.ComponentModel.Container();
            this.CancelNoteButton = new System.Windows.Forms.Button();
            this.SubmitNoteButton = new System.Windows.Forms.Button();
            this.AddAssignmentNoteInfoBox = new System.Windows.Forms.RichTextBox();
            this.AddAssignmentNoteNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TempModuleNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelNoteButton
            // 
            this.CancelNoteButton.Location = new System.Drawing.Point(152, 219);
            this.CancelNoteButton.Name = "CancelNoteButton";
            this.CancelNoteButton.Size = new System.Drawing.Size(123, 30);
            this.CancelNoteButton.TabIndex = 14;
            this.CancelNoteButton.Text = "Cancel";
            this.CancelNoteButton.UseVisualStyleBackColor = true;
            this.CancelNoteButton.Click += new System.EventHandler(this.CancelNoteButton_Click);
            // 
            // SubmitNoteButton
            // 
            this.SubmitNoteButton.Location = new System.Drawing.Point(23, 219);
            this.SubmitNoteButton.Name = "SubmitNoteButton";
            this.SubmitNoteButton.Size = new System.Drawing.Size(123, 30);
            this.SubmitNoteButton.TabIndex = 13;
            this.SubmitNoteButton.Text = "Submit";
            this.SubmitNoteButton.UseVisualStyleBackColor = true;
            this.SubmitNoteButton.Click += new System.EventHandler(this.SubmitNoteButton_Click);
            // 
            // AddAssignmentNoteInfoBox
            // 
            this.AddAssignmentNoteInfoBox.Location = new System.Drawing.Point(23, 57);
            this.AddAssignmentNoteInfoBox.Name = "AddAssignmentNoteInfoBox";
            this.AddAssignmentNoteInfoBox.Size = new System.Drawing.Size(254, 150);
            this.AddAssignmentNoteInfoBox.TabIndex = 12;
            this.AddAssignmentNoteInfoBox.Text = "";
            this.AddAssignmentNoteInfoBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddAssignmentNoteInfoBox_Validating);
            // 
            // AddAssignmentNoteNameBox
            // 
            this.AddAssignmentNoteNameBox.Location = new System.Drawing.Point(133, 12);
            this.AddAssignmentNoteNameBox.Name = "AddAssignmentNoteNameBox";
            this.AddAssignmentNoteNameBox.Size = new System.Drawing.Size(145, 20);
            this.AddAssignmentNoteNameBox.TabIndex = 11;
            this.AddAssignmentNoteNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddAssignmentNoteNameBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Assignment Note Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Assignment Note Information:";
            // 
            // TempModuleNameBox
            // 
            this.TempModuleNameBox.Location = new System.Drawing.Point(211, 34);
            this.TempModuleNameBox.Name = "TempModuleNameBox";
            this.TempModuleNameBox.Size = new System.Drawing.Size(100, 20);
            this.TempModuleNameBox.TabIndex = 16;
            this.TempModuleNameBox.Visible = false;
            // 
            // AddAssignmentNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.TempModuleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelNoteButton);
            this.Controls.Add(this.SubmitNoteButton);
            this.Controls.Add(this.AddAssignmentNoteInfoBox);
            this.Controls.Add(this.AddAssignmentNoteNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddAssignmentNoteForm";
            this.Text = "AddAssignmentNoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelNoteButton;
        private System.Windows.Forms.Button SubmitNoteButton;
        private System.Windows.Forms.RichTextBox AddAssignmentNoteInfoBox;
        private System.Windows.Forms.TextBox AddAssignmentNoteNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TempModuleNameBox;
    }
}