namespace Get_Country__Read_to_End_of_File_
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
            this.lstbxCountries = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetCntry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxCountries
            // 
            this.lstbxCountries.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxCountries.FormattingEnabled = true;
            this.lstbxCountries.ItemHeight = 27;
            this.lstbxCountries.Location = new System.Drawing.Point(116, 96);
            this.lstbxCountries.Name = "lstbxCountries";
            this.lstbxCountries.Size = new System.Drawing.Size(522, 463);
            this.lstbxCountries.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(388, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 52);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetCntry
            // 
            this.btnGetCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCntry.Location = new System.Drawing.Point(207, 577);
            this.btnGetCntry.Name = "btnGetCntry";
            this.btnGetCntry.Size = new System.Drawing.Size(158, 52);
            this.btnGetCntry.TabIndex = 11;
            this.btnGetCntry.Text = "Get Countries";
            this.btnGetCntry.UseVisualStyleBackColor = true;
            this.btnGetCntry.Click += new System.EventHandler(this.btnGetCntry_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "The Countries of South America";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 655);
            this.Controls.Add(this.lstbxCountries);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetCntry);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxCountries;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetCntry;
        private System.Windows.Forms.Label label3;
    }
}

