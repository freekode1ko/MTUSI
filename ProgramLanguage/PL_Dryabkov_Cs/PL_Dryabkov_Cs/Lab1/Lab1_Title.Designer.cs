namespace PL_Dryabkov_Cs.Lab1
{
    partial class Lab1_Title
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
            this.TB_Forward = new System.Windows.Forms.Button();
            this.BT_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Forward
            // 
            this.TB_Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Forward.Location = new System.Drawing.Point(93, 415);
            this.TB_Forward.Name = "TB_Forward";
            this.TB_Forward.Size = new System.Drawing.Size(75, 23);
            this.TB_Forward.TabIndex = 0;
            this.TB_Forward.Text = "К решению";
            this.TB_Forward.UseVisualStyleBackColor = true;
            this.TB_Forward.Click += new System.EventHandler(this.BT_forward_Click);
            // 
            // BT_Back
            // 
            this.BT_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_Back.Location = new System.Drawing.Point(12, 415);
            this.BT_Back.Name = "BT_Back";
            this.BT_Back.Size = new System.Drawing.Size(75, 23);
            this.BT_Back.TabIndex = 0;
            this.BT_Back.Text = "Назад";
            this.BT_Back.UseVisualStyleBackColor = true;
            this.BT_Back.Click += new System.EventHandler(this.BT_back_Click);
            // 
            // Lab1_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Back);
            this.Controls.Add(this.TB_Forward);
            this.Name = "Lab1_Title";
            this.Text = "Лабораторная работа №1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lab1_Main_FormClosed);
            this.Load += new System.EventHandler(this.Lab1_Title_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TB_Forward;
        private System.Windows.Forms.Button BT_Back;
    }
}