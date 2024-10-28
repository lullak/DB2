namespace DemoGymRepo
{
    partial class FormInstructor
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
            listBoxInstructorName = new ListBox();
            textBoxName = new TextBox();
            buttonSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxInstructorName
            // 
            listBoxInstructorName.FormattingEnabled = true;
            listBoxInstructorName.Location = new Point(37, 30);
            listBoxInstructorName.Name = "listBoxInstructorName";
            listBoxInstructorName.Size = new Size(275, 384);
            listBoxInstructorName.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(473, 96);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(260, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(621, 184);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(109, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 63);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Namn";
            // 
            // FormInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(listBoxInstructorName);
            Name = "FormInstructor";
            Text = "FormInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxInstructorName;
        private TextBox textBoxName;
        private Button buttonSave;
        private Label label1;
    }
}