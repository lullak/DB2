namespace Ado2222
{
    partial class FormViewCustomer
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
            listBoxCustomers = new ListBox();
            buttonView = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxCompanyName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxCity = new TextBox();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.Location = new Point(36, 25);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(322, 364);
            listBoxCustomers.TabIndex = 0;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(264, 409);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(94, 29);
            buttonView.TabIndex = 1;
            buttonView.Text = "View";
            buttonView.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 76);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Company name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 174);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 4;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 219);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(509, 73);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(125, 27);
            textBoxCompanyName.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(509, 122);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(509, 171);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(509, 216);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 9;
            // 
            // FormViewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonView);
            Controls.Add(listBoxCustomers);
            Name = "FormViewCustomer";
            Text = "FormViewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCustomers;
        private Button buttonView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCompanyName;
        private TextBox textBoxAddress;
        private TextBox textBoxCity;
        private TextBox textBoxPhone;
    }
}