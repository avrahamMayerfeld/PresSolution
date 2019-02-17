using System;

namespace PresGUI
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
            this.citizen = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.presResult = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.yearsResident = new System.Windows.Forms.TextBox();
            this.timesElected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // citizen
            // 
            this.citizen.AutoSize = true;
            this.citizen.Location = new System.Drawing.Point(400, 61);
            this.citizen.Name = "citizen";
            this.citizen.Size = new System.Drawing.Size(270, 17);
            this.citizen.TabIndex = 0;
            this.citizen.Text = "Check this box if you are a natural born U.S. citizen ";
            this.citizen.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(280, 200);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(279, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Click here to see if you are eligible for U.S. Presidency";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // presResult
            // 
            this.presResult.Location = new System.Drawing.Point(118, 240);
            this.presResult.Name = "presResult";
            this.presResult.Size = new System.Drawing.Size(618, 20);
            this.presResult.TabIndex = 5;
            this.presResult.TextChanged += new System.EventHandler(this.presResult_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(459, 84);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 6;
            // 
            // yearsResident
            // 
            this.yearsResident.Location = new System.Drawing.Point(459, 116);
            this.yearsResident.Name = "yearsResident";
            this.yearsResident.Size = new System.Drawing.Size(100, 20);
            this.yearsResident.TabIndex = 7;
            // 
            // timesElected
            // 
            this.timesElected.Location = new System.Drawing.Point(459, 152);
            this.timesElected.Name = "timesElected";
            this.timesElected.Size = new System.Drawing.Size(100, 20);
            this.timesElected.TabIndex = 8;
            this.timesElected.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter the number of years you have been a U.S. resident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter the number of times you have been elected U.S. president. Enter 0 if none.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesElected);
            this.Controls.Add(this.yearsResident);
            this.Controls.Add(this.age);
            this.Controls.Add(this.presResult);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.citizen);
            this.Name = "Form1";
            this.Text = "PGUIwindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void presResult_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox citizen;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox presResult;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox yearsResident;
        private System.Windows.Forms.TextBox timesElected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

