namespace Lab3
{
    partial class Main
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
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(12, 12);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(358, 87);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "1";
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.TB_Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(12, 105);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(358, 87);
            this.Task2.TabIndex = 0;
            this.Task2.Text = "2";
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.TB_Task2_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(12, 198);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(358, 87);
            this.Task3.TabIndex = 0;
            this.Task3.Text = "3";
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.TB_Task3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 301);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button Task3;
    }
}

