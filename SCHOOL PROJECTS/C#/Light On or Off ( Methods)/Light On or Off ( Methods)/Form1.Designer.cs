namespace Light_On_or_Off___Methods_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSwitchLight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pctBxON = new System.Windows.Forms.PictureBox();
            this.pctBxOff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(232, 361);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(134, 47);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitchLight
            // 
            this.btnSwitchLight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchLight.Location = new System.Drawing.Point(73, 427);
            this.btnSwitchLight.Name = "btnSwitchLight";
            this.btnSwitchLight.Size = new System.Drawing.Size(188, 62);
            this.btnSwitchLight.TabIndex = 1;
            this.btnSwitchLight.Text = "Switch Light";
            this.btnSwitchLight.UseVisualStyleBackColor = true;
            this.btnSwitchLight.Click += new System.EventHandler(this.btnSwitchLight_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(320, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pctBxON
            // 
            this.pctBxON.Image = ((System.Drawing.Image)(resources.GetObject("pctBxON.Image")));
            this.pctBxON.Location = new System.Drawing.Point(73, 12);
            this.pctBxON.Name = "pctBxON";
            this.pctBxON.Size = new System.Drawing.Size(435, 324);
            this.pctBxON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBxON.TabIndex = 4;
            this.pctBxON.TabStop = false;
            // 
            // pctBxOff
            // 
            this.pctBxOff.Image = ((System.Drawing.Image)(resources.GetObject("pctBxOff.Image")));
            this.pctBxOff.Location = new System.Drawing.Point(73, 12);
            this.pctBxOff.Name = "pctBxOff";
            this.pctBxOff.Size = new System.Drawing.Size(435, 324);
            this.pctBxOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBxOff.TabIndex = 5;
            this.pctBxOff.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 522);
            this.Controls.Add(this.pctBxOff);
            this.Controls.Add(this.pctBxON);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitchLight);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBxON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSwitchLight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pctBxON;
        private System.Windows.Forms.PictureBox pctBxOff;
    }
}

