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
            this.age = new System.Windows.Forms.CheckBox();
            this.yearsHere = new System.Windows.Forms.CheckBox();
            this.electedTwice = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.presResult = new System.Windows.Forms.TextBox();
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
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(400, 95);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(80, 17);
            this.age.TabIndex = 1;
            this.age.Text = "checkBox2";
            this.age.UseVisualStyleBackColor = true;
            // 
            // yearsHere
            // 
            this.yearsHere.AutoSize = true;
            this.yearsHere.Location = new System.Drawing.Point(400, 128);
            this.yearsHere.Name = "yearsHere";
            this.yearsHere.Size = new System.Drawing.Size(80, 17);
            this.yearsHere.TabIndex = 2;
            this.yearsHere.Text = "checkBox3";
            this.yearsHere.UseVisualStyleBackColor = true;
            // 
            // electedTwice
            // 
            this.electedTwice.AutoSize = true;
            this.electedTwice.Location = new System.Drawing.Point(400, 163);
            this.electedTwice.Name = "electedTwice";
            this.electedTwice.Size = new System.Drawing.Size(80, 17);
            this.electedTwice.TabIndex = 3;
            this.electedTwice.Text = "checkBox4";
            this.electedTwice.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(400, 202);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // presResult
            // 
            this.presResult.Location = new System.Drawing.Point(343, 243);
            this.presResult.Name = "presResult";
            this.presResult.Size = new System.Drawing.Size(197, 20);
            this.presResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.presResult);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.electedTwice);
            this.Controls.Add(this.yearsHere);
            this.Controls.Add(this.age);
            this.Controls.Add(this.citizen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox citizen;
        private System.Windows.Forms.CheckBox age;
        private System.Windows.Forms.CheckBox yearsHere;
        private System.Windows.Forms.CheckBox electedTwice;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox presResult;
    }
}

