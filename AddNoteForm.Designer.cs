namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    partial class AddNoteForm
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
            this.AddNoteInfoBox = new System.Windows.Forms.RichTextBox();
            this.AddNoteNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TempModuleNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelNoteButton
            // 
            this.CancelNoteButton.Location = new System.Drawing.Point(144, 219);
            this.CancelNoteButton.Name = "CancelNoteButton";
            this.CancelNoteButton.Size = new System.Drawing.Size(123, 30);
            this.CancelNoteButton.TabIndex = 9;
            this.CancelNoteButton.Text = "Cancel";
            this.CancelNoteButton.UseVisualStyleBackColor = true;
            this.CancelNoteButton.Click += new System.EventHandler(this.CancelNoteButton_Click);
            // 
            // SubmitNoteButton
            // 
            this.SubmitNoteButton.Location = new System.Drawing.Point(15, 219);
            this.SubmitNoteButton.Name = "SubmitNoteButton";
            this.SubmitNoteButton.Size = new System.Drawing.Size(123, 30);
            this.SubmitNoteButton.TabIndex = 8;
            this.SubmitNoteButton.Text = "Submit";
            this.SubmitNoteButton.UseVisualStyleBackColor = true;
            this.SubmitNoteButton.Click += new System.EventHandler(this.SubmitNoteButton_Click);
            // 
            // AddNoteInfoBox
            // 
            this.AddNoteInfoBox.Location = new System.Drawing.Point(15, 61);
            this.AddNoteInfoBox.Name = "AddNoteInfoBox";
            this.AddNoteInfoBox.Size = new System.Drawing.Size(254, 146);
            this.AddNoteInfoBox.TabIndex = 7;
            this.AddNoteInfoBox.Text = "";
            this.AddNoteInfoBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddNoteInfoBox_Validating);
            // 
            // AddNoteNameBox
            // 
            this.AddNoteNameBox.Location = new System.Drawing.Point(107, 12);
            this.AddNoteNameBox.Name = "AddNoteNameBox";
            this.AddNoteNameBox.Size = new System.Drawing.Size(163, 20);
            this.AddNoteNameBox.TabIndex = 6;
            this.AddNoteNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddNoteNameBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lecture Note Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lecture Note Information:";
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // TempModuleNameBox
            // 
            this.TempModuleNameBox.Location = new System.Drawing.Point(198, 35);
            this.TempModuleNameBox.Name = "TempModuleNameBox";
            this.TempModuleNameBox.Size = new System.Drawing.Size(100, 20);
            this.TempModuleNameBox.TabIndex = 11;
            this.TempModuleNameBox.Visible = false;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.TempModuleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelNoteButton);
            this.Controls.Add(this.SubmitNoteButton);
            this.Controls.Add(this.AddNoteInfoBox);
            this.Controls.Add(this.AddNoteNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNoteForm";
            this.Text = "AddNoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelNoteButton;
        private System.Windows.Forms.Button SubmitNoteButton;
        private System.Windows.Forms.RichTextBox AddNoteInfoBox;
        private System.Windows.Forms.TextBox AddNoteNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox TempModuleNameBox;
    }
}