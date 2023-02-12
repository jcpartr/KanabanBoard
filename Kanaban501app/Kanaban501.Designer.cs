namespace Kanaban501app
{
    partial class Kanaban501
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
            this.uxNewButton = new System.Windows.Forms.Button();
            this.uxEditButton = new System.Windows.Forms.Button();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxToDo = new System.Windows.Forms.ListBox();
            this.uxWorkingOn = new System.Windows.Forms.ListBox();
            this.uxDone = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Working On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Done";
            // 
            // uxNewButton
            // 
            this.uxNewButton.Location = new System.Drawing.Point(96, 368);
            this.uxNewButton.Name = "uxNewButton";
            this.uxNewButton.Size = new System.Drawing.Size(75, 23);
            this.uxNewButton.TabIndex = 6;
            this.uxNewButton.Text = "New";
            this.uxNewButton.UseVisualStyleBackColor = true;
            this.uxNewButton.Click += new System.EventHandler(this.uxNewButton_Click);
            // 
            // uxEditButton
            // 
            this.uxEditButton.Location = new System.Drawing.Point(351, 368);
            this.uxEditButton.Name = "uxEditButton";
            this.uxEditButton.Size = new System.Drawing.Size(75, 23);
            this.uxEditButton.TabIndex = 7;
            this.uxEditButton.Text = "Edit";
            this.uxEditButton.UseVisualStyleBackColor = true;
            this.uxEditButton.Click += new System.EventHandler(this.uxEditButton_Click);
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Location = new System.Drawing.Point(614, 368);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.uxDeleteButton.TabIndex = 8;
            this.uxDeleteButton.Text = "Delete";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "My Kanaban";
            // 
            // uxToDo
            // 
            this.uxToDo.FormattingEnabled = true;
            this.uxToDo.ItemHeight = 16;
            this.uxToDo.Location = new System.Drawing.Point(27, 68);
            this.uxToDo.Name = "uxToDo";
            this.uxToDo.Size = new System.Drawing.Size(225, 276);
            this.uxToDo.TabIndex = 10;
            this.uxToDo.SelectedIndexChanged += new System.EventHandler(this.uxToDo_SelectedIndexChanged);
            // 
            // uxWorkingOn
            // 
            this.uxWorkingOn.FormattingEnabled = true;
            this.uxWorkingOn.ItemHeight = 16;
            this.uxWorkingOn.Location = new System.Drawing.Point(279, 68);
            this.uxWorkingOn.Name = "uxWorkingOn";
            this.uxWorkingOn.Size = new System.Drawing.Size(225, 276);
            this.uxWorkingOn.TabIndex = 11;
            this.uxWorkingOn.SelectedIndexChanged += new System.EventHandler(this.uxWorkingOn_SelectedIndexChanged);
            // 
            // uxDone
            // 
            this.uxDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDone.FormattingEnabled = true;
            this.uxDone.ItemHeight = 16;
            this.uxDone.Location = new System.Drawing.Point(527, 68);
            this.uxDone.Name = "uxDone";
            this.uxDone.Size = new System.Drawing.Size(225, 276);
            this.uxDone.TabIndex = 12;
            this.uxDone.SelectedIndexChanged += new System.EventHandler(this.uxDone_SelectedIndexChanged);
            // 
            // Kanaban501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.uxDone);
            this.Controls.Add(this.uxWorkingOn);
            this.Controls.Add(this.uxToDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxEditButton);
            this.Controls.Add(this.uxNewButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kanaban501";
            this.ShowIcon = false;
            this.Text = "Kanaband501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxNewButton;
        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox uxToDo;
        private System.Windows.Forms.ListBox uxWorkingOn;
        private System.Windows.Forms.ListBox uxDone;
    }
}

