namespace LAN145254583_CMP1127M_Assignment_Item_2
{
    partial class AddModuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddModuleNameBox = new System.Windows.Forms.TextBox();
            this.AddModuleInfoBox = new System.Windows.Forms.RichTextBox();
            this.SubmitModuleButton = new System.Windows.Forms.Button();
            this.CancelModuleButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Name:";
            // 
            // AddModuleNameBox
            // 
            this.AddModuleNameBox.Location = new System.Drawing.Point(104, 12);
            this.AddModuleNameBox.Name = "AddModuleNameBox";
            this.AddModuleNameBox.Size = new System.Drawing.Size(163, 20);
            this.AddModuleNameBox.TabIndex = 1;
            this.AddModuleNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddModuleNameBox_Validating);
            // 
            // AddModuleInfoBox
            // 
            this.AddModuleInfoBox.Location = new System.Drawing.Point(12, 53);
            this.AddModuleInfoBox.Name = "AddModuleInfoBox";
            this.AddModuleInfoBox.Size = new System.Drawing.Size(254, 154);
            this.AddModuleInfoBox.TabIndex = 2;
            this.AddModuleInfoBox.Text = "";
            this.AddModuleInfoBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddModuleInfoBox_Validating);
            // 
            // SubmitModuleButton
            // 
            this.SubmitModuleButton.Location = new System.Drawing.Point(12, 219);
            this.SubmitModuleButton.Name = "SubmitModuleButton";
            this.SubmitModuleButton.Size = new System.Drawing.Size(123, 30);
            this.SubmitModuleButton.TabIndex = 3;
            this.SubmitModuleButton.Text = "Submit";
            this.SubmitModuleButton.UseVisualStyleBackColor = true;
            this.SubmitModuleButton.Click += new System.EventHandler(this.SubmitModuleButton_Click);
            // 
            // CancelModuleButton
            // 
            this.CancelModuleButton.Location = new System.Drawing.Point(141, 219);
            this.CancelModuleButton.Name = "CancelModuleButton";
            this.CancelModuleButton.Size = new System.Drawing.Size(123, 30);
            this.CancelModuleButton.TabIndex = 4;
            this.CancelModuleButton.Text = "Cancel";
            this.CancelModuleButton.UseVisualStyleBackColor = true;
            this.CancelModuleButton.Click += new System.EventHandler(this.CancelModuleButton_Click);
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
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Module Information:";
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AddModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelModuleButton);
            this.Controls.Add(this.SubmitModuleButton);
            this.Controls.Add(this.AddModuleInfoBox);
            this.Controls.Add(this.AddModuleNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddModuleForm";
            this.Text = "AddModuleForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddModuleNameBox;
        private System.Windows.Forms.RichTextBox AddModuleInfoBox;
        private System.Windows.Forms.Button SubmitModuleButton;
        private System.Windows.Forms.Button CancelModuleButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}