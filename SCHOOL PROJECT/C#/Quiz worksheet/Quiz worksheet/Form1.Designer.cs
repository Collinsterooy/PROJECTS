namespace Quiz_worksheet
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
            this.btnSubmit_Click = new System.Windows.Forms.Button();
            this.llblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit_Click
            // 
            this.btnSubmit_Click.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_Click.Location = new System.Drawing.Point(206, 227);
            this.btnSubmit_Click.Name = "btnSubmit_Click";
            this.btnSubmit_Click.Size = new System.Drawing.Size(323, 58);
            this.btnSubmit_Click.TabIndex = 0;
            this.btnSubmit_Click.Text = "Submit";
            this.btnSubmit_Click.UseVisualStyleBackColor = true;
            this.btnSubmit_Click.Click += new System.EventHandler(this.btnSubmit_Click_Click);
            // 
            // llblResult
            // 
            this.llblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llblResult.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblResult.Location = new System.Drawing.Point(180, 137);
            this.llblResult.Name = "llblResult";
            this.llblResult.Size = new System.Drawing.Size(392, 48);
            this.llblResult.TabIndex = 1;
            this.llblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblResult);
            this.Controls.Add(this.btnSubmit_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit_Click;
        private System.Windows.Forms.Label llblResult;
    }
}

