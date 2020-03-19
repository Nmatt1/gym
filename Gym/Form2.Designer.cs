namespace Gym
{
    partial class T2
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
            this.OK = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.ComboBox();
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(32, 247);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "Okay";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(134, 247);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 23);
            this.C.TabIndex = 1;
            this.C.Text = "Cancel";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // box1
            // 
            this.box1.FormattingEnabled = true;
            this.box1.Location = new System.Drawing.Point(32, 53);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(177, 21);
            this.box1.TabIndex = 2;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(32, 140);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(177, 23);
            this.test.TabIndex = 3;
            this.test.Text = "submit";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click_1);
            // 
            // T2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 292);
            this.Controls.Add(this.test);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.OK);
            this.Name = "T2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.Button test;
    }
}