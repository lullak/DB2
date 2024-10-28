namespace Ado1
{
    partial class FormAdo1
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
            listBoxEmp = new ListBox();
            SuspendLayout();
            // 
            // listBoxEmp
            // 
            listBoxEmp.FormattingEnabled = true;
            listBoxEmp.Location = new Point(57, 24);
            listBoxEmp.Name = "listBoxEmp";
            listBoxEmp.Size = new Size(712, 404);
            listBoxEmp.TabIndex = 0;
            // 
            // FormAdo1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxEmp);
            Name = "FormAdo1";
            Text = "FormAdo1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEmp;
    }
}