namespace Gym
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.EM = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MNB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SF1 = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(213, 20);
            this.name.TabIndex = 1;
            this.name.Text = " ";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(16, 57);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(213, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // EM
            // 
            this.EM.FormattingEnabled = true;
            this.EM.Location = new System.Drawing.Point(13, 162);
            this.EM.Name = "EM";
            this.EM.Size = new System.Drawing.Size(216, 94);
            this.EM.TabIndex = 3;
            this.EM.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "What exercise machines are you using";
            // 
            // MNB
            // 
            this.MNB.FormattingEnabled = true;
            this.MNB.Location = new System.Drawing.Point(13, 102);
            this.MNB.Name = "MNB";
            this.MNB.Size = new System.Drawing.Size(216, 21);
            this.MNB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many machines are you using";
            // 
            // SF1
            // 
            this.SF1.Location = new System.Drawing.Point(13, 272);
            this.SF1.Name = "SF1";
            this.SF1.Size = new System.Drawing.Size(216, 23);
            this.SF1.TabIndex = 7;
            this.SF1.Text = "Next";
            this.SF1.UseVisualStyleBackColor = true;
            this.SF1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(12, 301);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(216, 23);
            this.quit.TabIndex = 8;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 339);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.SF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MNB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EM);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fitness Centre App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckedListBox EM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MNB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SF1;
        private System.Windows.Forms.Button quit;
    }
}

