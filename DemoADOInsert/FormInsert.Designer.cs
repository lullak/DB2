namespace DemoADOInsert
{
    partial class FormInsert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEmployee = new ListBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxEmployee
            // 
            listBoxEmployee.FormattingEnabled = true;
            listBoxEmployee.Location = new Point(52, 27);
            listBoxEmployee.Name = "listBoxEmployee";
            listBoxEmployee.Size = new Size(376, 364);
            listBoxEmployee.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(459, 197);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Lägg till";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(618, 197);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Radera";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(460, 33);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(252, 27);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(460, 88);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(252, 27);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(460, 141);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(252, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "Förnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 63);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Efternamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 118);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 8;
            label3.Text = "Titel";
            // 
            // FormInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxEmployee);
            Name = "FormInsert";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEmployee;
        private Button buttonAdd;
        private Button buttonRemove;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxTitle;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
