namespace Budgeteer
{
    partial class Form1
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
            this.editBudget = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.newItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editBudget
            // 
            this.editBudget.Location = new System.Drawing.Point(37, 28);
            this.editBudget.Name = "editBudget";
            this.editBudget.Size = new System.Drawing.Size(129, 49);
            this.editBudget.TabIndex = 1;
            this.editBudget.Text = "Edit Budget";
            this.editBudget.UseVisualStyleBackColor = true;
            this.editBudget.Click += new System.EventHandler(this.editBudget_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(172, 28);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(129, 49);
            this.report.TabIndex = 2;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(37, 219);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 6;
            this.categoryBox.Visible = false;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // newItem
            // 
            this.newItem.Location = new System.Drawing.Point(189, 220);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(100, 20);
            this.newItem.TabIndex = 7;
            this.newItem.Visible = false;
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 491);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.report);
            this.Controls.Add(this.editBudget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBudget;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox newItem;
    }
}

