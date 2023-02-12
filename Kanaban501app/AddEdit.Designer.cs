namespace Kanaban501app
{
    partial class AddEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxToDoRB = new System.Windows.Forms.RadioButton();
            this.uxWorkingOnRB = new System.Windows.Forms.RadioButton();
            this.uxDoneRB = new System.Windows.Forms.RadioButton();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.uxNameTB = new System.Windows.Forms.TextBox();
            this.uxResourcesTB = new System.Windows.Forms.TextBox();
            this.uxCompleteBy = new System.Windows.Forms.DateTimePicker();
            this.uxStatusGB = new System.Windows.Forms.GroupBox();
            this.uxStatusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resources";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complete By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // uxToDoRB
            // 
            this.uxToDoRB.AutoSize = true;
            this.uxToDoRB.Location = new System.Drawing.Point(15, 21);
            this.uxToDoRB.Name = "uxToDoRB";
            this.uxToDoRB.Size = new System.Drawing.Size(66, 20);
            this.uxToDoRB.TabIndex = 4;
            this.uxToDoRB.TabStop = true;
            this.uxToDoRB.Text = "To Do";
            this.uxToDoRB.UseVisualStyleBackColor = true;
            // 
            // uxWorkingOnRB
            // 
            this.uxWorkingOnRB.AutoSize = true;
            this.uxWorkingOnRB.Location = new System.Drawing.Point(15, 48);
            this.uxWorkingOnRB.Name = "uxWorkingOnRB";
            this.uxWorkingOnRB.Size = new System.Drawing.Size(98, 20);
            this.uxWorkingOnRB.TabIndex = 5;
            this.uxWorkingOnRB.TabStop = true;
            this.uxWorkingOnRB.Text = "Working On";
            this.uxWorkingOnRB.UseVisualStyleBackColor = true;
            // 
            // uxDoneRB
            // 
            this.uxDoneRB.AutoSize = true;
            this.uxDoneRB.Location = new System.Drawing.Point(15, 74);
            this.uxDoneRB.Name = "uxDoneRB";
            this.uxDoneRB.Size = new System.Drawing.Size(61, 20);
            this.uxDoneRB.TabIndex = 6;
            this.uxDoneRB.TabStop = true;
            this.uxDoneRB.Text = "Done";
            this.uxDoneRB.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(268, 311);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Ok
            // 
            this.button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Ok.Location = new System.Drawing.Point(111, 311);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 8;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // uxNameTB
            // 
            this.uxNameTB.Location = new System.Drawing.Point(111, 22);
            this.uxNameTB.Name = "uxNameTB";
            this.uxNameTB.Size = new System.Drawing.Size(232, 22);
            this.uxNameTB.TabIndex = 9;
            // 
            // uxResourcesTB
            // 
            this.uxResourcesTB.Location = new System.Drawing.Point(111, 79);
            this.uxResourcesTB.Multiline = true;
            this.uxResourcesTB.Name = "uxResourcesTB";
            this.uxResourcesTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxResourcesTB.Size = new System.Drawing.Size(232, 152);
            this.uxResourcesTB.TabIndex = 10;
            // 
            // uxCompleteBy
            // 
            this.uxCompleteBy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxCompleteBy.Location = new System.Drawing.Point(111, 265);
            this.uxCompleteBy.Name = "uxCompleteBy";
            this.uxCompleteBy.Size = new System.Drawing.Size(232, 22);
            this.uxCompleteBy.TabIndex = 11;
            // 
            // uxStatusGB
            // 
            this.uxStatusGB.Controls.Add(this.uxToDoRB);
            this.uxStatusGB.Controls.Add(this.uxWorkingOnRB);
            this.uxStatusGB.Controls.Add(this.uxDoneRB);
            this.uxStatusGB.Location = new System.Drawing.Point(367, 40);
            this.uxStatusGB.Name = "uxStatusGB";
            this.uxStatusGB.Size = new System.Drawing.Size(126, 100);
            this.uxStatusGB.TabIndex = 12;
            this.uxStatusGB.TabStop = false;
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(505, 346);
            this.Controls.Add(this.uxStatusGB);
            this.Controls.Add(this.uxCompleteBy);
            this.Controls.Add(this.uxResourcesTB);
            this.Controls.Add(this.uxNameTB);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddEdit";
            this.Text = "Add/Edit";
            this.uxStatusGB.ResumeLayout(false);
            this.uxStatusGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton uxToDoRB;
        private System.Windows.Forms.RadioButton uxWorkingOnRB;
        private System.Windows.Forms.RadioButton uxDoneRB;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox uxNameTB;
        private System.Windows.Forms.TextBox uxResourcesTB;
        private System.Windows.Forms.DateTimePicker uxCompleteBy;
        private System.Windows.Forms.GroupBox uxStatusGB;
    }
}