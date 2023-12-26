
namespace myFlightInfo.school
{
    partial class school
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(school));
            this.btn_choose_school = new System.Windows.Forms.Button();
            this.rdobtn_lt_gransden = new System.Windows.Forms.RadioButton();
            this.rdobtn_rochester = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_choose_school
            // 
            this.btn_choose_school.Location = new System.Drawing.Point(12, 163);
            this.btn_choose_school.Name = "btn_choose_school";
            this.btn_choose_school.Size = new System.Drawing.Size(418, 53);
            this.btn_choose_school.TabIndex = 0;
            this.btn_choose_school.Text = "Go";
            this.btn_choose_school.UseVisualStyleBackColor = true;
            this.btn_choose_school.Click += new System.EventHandler(this.btn_choose_school_Click);
            // 
            // rdobtn_lt_gransden
            // 
            this.rdobtn_lt_gransden.AutoSize = true;
            this.rdobtn_lt_gransden.Checked = true;
            this.rdobtn_lt_gransden.Location = new System.Drawing.Point(55, 54);
            this.rdobtn_lt_gransden.Name = "rdobtn_lt_gransden";
            this.rdobtn_lt_gransden.Size = new System.Drawing.Size(143, 24);
            this.rdobtn_lt_gransden.TabIndex = 1;
            this.rdobtn_lt_gransden.TabStop = true;
            this.rdobtn_lt_gransden.Text = "Little Gransden";
            this.rdobtn_lt_gransden.UseVisualStyleBackColor = true;
            // 
            // rdobtn_rochester
            // 
            this.rdobtn_rochester.AutoSize = true;
            this.rdobtn_rochester.Location = new System.Drawing.Point(236, 54);
            this.rdobtn_rochester.Name = "rdobtn_rochester";
            this.rdobtn_rochester.Size = new System.Drawing.Size(108, 24);
            this.rdobtn_rochester.TabIndex = 2;
            this.rdobtn_rochester.Text = "Rochester";
            this.rdobtn_rochester.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_rochester);
            this.groupBox1.Controls.Add(this.rdobtn_lt_gransden);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // school
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 228);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_choose_school);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "school";
            this.Text = "Which School?";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_choose_school;
        private System.Windows.Forms.RadioButton rdobtn_lt_gransden;
        private System.Windows.Forms.RadioButton rdobtn_rochester;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}