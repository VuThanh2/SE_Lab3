namespace StudentManagementApp.DepartmentView
{
    partial class AddDepartmentForm
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtDepartmentName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(253, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 58;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(39, 50);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(304, 26);
            txtDepartmentName.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 27);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 55;
            label2.Text = "Department Name";
            // 
            // AddDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 161);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDepartmentName);
            Controls.Add(label2);
            Name = "AddDepartmentForm";
            Text = "AddDepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtDepartmentName;
        private Label label2;
    }
}