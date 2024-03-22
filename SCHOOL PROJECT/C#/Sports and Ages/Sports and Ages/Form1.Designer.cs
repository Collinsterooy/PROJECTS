namespace Sports_and_Ages
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
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBaseball = new System.Windows.Forms.RadioButton();
            this.rdbFootball = new System.Windows.Forms.RadioButton();
            this.rdbSoccer = new System.Windows.Forms.RadioButton();
            this.rdbVolleyball = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb13U = new System.Windows.Forms.RadioButton();
            this.rdb12U = new System.Windows.Forms.RadioButton();
            this.rdb11U = new System.Windows.Forms.RadioButton();
            this.rdb10U = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserNum
            // 
            this.txtUserNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNum.Location = new System.Drawing.Point(222, 28);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(264, 33);
            this.txtUserNum.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVolleyball);
            this.groupBox1.Controls.Add(this.rdbSoccer);
            this.groupBox1.Controls.Add(this.rdbFootball);
            this.groupBox1.Controls.Add(this.rdbBaseball);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sports";
            // 
            // rdbBaseball
            // 
            this.rdbBaseball.AutoSize = true;
            this.rdbBaseball.Location = new System.Drawing.Point(16, 32);
            this.rdbBaseball.Name = "rdbBaseball";
            this.rdbBaseball.Size = new System.Drawing.Size(106, 31);
            this.rdbBaseball.TabIndex = 0;
            this.rdbBaseball.TabStop = true;
            this.rdbBaseball.Text = "Baseball";
            this.rdbBaseball.UseVisualStyleBackColor = true;
            // 
            // rdbFootball
            // 
            this.rdbFootball.AutoSize = true;
            this.rdbFootball.Location = new System.Drawing.Point(16, 58);
            this.rdbFootball.Name = "rdbFootball";
            this.rdbFootball.Size = new System.Drawing.Size(104, 31);
            this.rdbFootball.TabIndex = 1;
            this.rdbFootball.TabStop = true;
            this.rdbFootball.Text = "Football";
            this.rdbFootball.UseVisualStyleBackColor = true;
            // 
            // rdbSoccer
            // 
            this.rdbSoccer.AutoSize = true;
            this.rdbSoccer.Location = new System.Drawing.Point(16, 84);
            this.rdbSoccer.Name = "rdbSoccer";
            this.rdbSoccer.Size = new System.Drawing.Size(94, 31);
            this.rdbSoccer.TabIndex = 2;
            this.rdbSoccer.TabStop = true;
            this.rdbSoccer.Text = "Soccer";
            this.rdbSoccer.UseVisualStyleBackColor = true;
            // 
            // rdbVolleyball
            // 
            this.rdbVolleyball.AutoSize = true;
            this.rdbVolleyball.Location = new System.Drawing.Point(16, 110);
            this.rdbVolleyball.Name = "rdbVolleyball";
            this.rdbVolleyball.Size = new System.Drawing.Size(118, 31);
            this.rdbVolleyball.TabIndex = 3;
            this.rdbVolleyball.TabStop = true;
            this.rdbVolleyball.Text = "Volleyball";
            this.rdbVolleyball.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb13U);
            this.groupBox2.Controls.Add(this.rdb12U);
            this.groupBox2.Controls.Add(this.rdb11U);
            this.groupBox2.Controls.Add(this.rdb10U);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(445, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Age Groups";
            // 
            // rdb13U
            // 
            this.rdb13U.AutoSize = true;
            this.rdb13U.Location = new System.Drawing.Point(16, 110);
            this.rdb13U.Name = "rdb13U";
            this.rdb13U.Size = new System.Drawing.Size(66, 31);
            this.rdb13U.TabIndex = 3;
            this.rdb13U.TabStop = true;
            this.rdb13U.Text = "13U";
            this.rdb13U.UseVisualStyleBackColor = true;
            // 
            // rdb12U
            // 
            this.rdb12U.AutoSize = true;
            this.rdb12U.Location = new System.Drawing.Point(16, 84);
            this.rdb12U.Name = "rdb12U";
            this.rdb12U.Size = new System.Drawing.Size(66, 31);
            this.rdb12U.TabIndex = 2;
            this.rdb12U.TabStop = true;
            this.rdb12U.Text = "12U";
            this.rdb12U.UseVisualStyleBackColor = true;
            // 
            // rdb11U
            // 
            this.rdb11U.AutoSize = true;
            this.rdb11U.Location = new System.Drawing.Point(16, 58);
            this.rdb11U.Name = "rdb11U";
            this.rdb11U.Size = new System.Drawing.Size(63, 31);
            this.rdb11U.TabIndex = 1;
            this.rdb11U.TabStop = true;
            this.rdb11U.Text = "11U";
            this.rdb11U.UseVisualStyleBackColor = true;
            // 
            // rdb10U
            // 
            this.rdb10U.AutoSize = true;
            this.rdb10U.Location = new System.Drawing.Point(16, 32);
            this.rdb10U.Name = "rdb10U";
            this.rdb10U.Size = new System.Drawing.Size(66, 31);
            this.rdb10U.TabIndex = 0;
            this.rdb10U.TabStop = true;
            this.rdb10U.Text = "10U";
            this.rdb10U.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(57, 290);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(525, 50);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(57, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(526, 64);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sports Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVolleyball;
        private System.Windows.Forms.RadioButton rdbSoccer;
        private System.Windows.Forms.RadioButton rdbFootball;
        private System.Windows.Forms.RadioButton rdbBaseball;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb13U;
        private System.Windows.Forms.RadioButton rdb12U;
        private System.Windows.Forms.RadioButton rdb11U;
        private System.Windows.Forms.RadioButton rdb10U;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSubmit;
    }
}

