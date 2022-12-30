namespace NumericToWord
{
    partial class NumericToWord
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
            this.btnFive = new System.Windows.Forms.Button();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblNine = new System.Windows.Forms.Label();
            this.btnNine = new System.Windows.Forms.Button();
            this.lblThree = new System.Windows.Forms.Label();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(23, 26);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(225, 80);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // lblFive
            // 
            this.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFive.Location = new System.Drawing.Point(18, 150);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(230, 83);
            this.lblFive.TabIndex = 1;
            this.lblFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNine
            // 
            this.lblNine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNine.Location = new System.Drawing.Point(314, 150);
            this.lblNine.Name = "lblNine";
            this.lblNine.Size = new System.Drawing.Size(230, 83);
            this.lblNine.TabIndex = 3;
            this.lblNine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(319, 26);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(225, 80);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // lblThree
            // 
            this.lblThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThree.Location = new System.Drawing.Point(613, 150);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(230, 83);
            this.lblThree.TabIndex = 5;
            this.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(618, 26);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(225, 80);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(18, 276);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(825, 51);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // NumericToWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.lblNine);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.lblFive);
            this.Controls.Add(this.btnFive);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumericToWord";
            this.Text = "Numeric To Word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblNine;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnQuit;
    }
}

