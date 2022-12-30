namespace Flags_Application
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.pctrbGermany = new System.Windows.Forms.PictureBox();
            this.pctrbFrance = new System.Windows.Forms.PictureBox();
            this.pctrbFinland = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbFinland)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click a flag to see the name of the country";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(178, 317);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(420, 35);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrbGermany
            // 
            this.pctrbGermany.Image = global::Flags_Application.Properties.Resources.Germany_Flag;
            this.pctrbGermany.Location = new System.Drawing.Point(558, 163);
            this.pctrbGermany.Name = "pctrbGermany";
            this.pctrbGermany.Size = new System.Drawing.Size(187, 93);
            this.pctrbGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbGermany.TabIndex = 2;
            this.pctrbGermany.TabStop = false;
            this.pctrbGermany.Click += new System.EventHandler(this.pctrbGermany_Click);
            // 
            // pctrbFrance
            // 
            this.pctrbFrance.Image = global::Flags_Application.Properties.Resources.France;
            this.pctrbFrance.Location = new System.Drawing.Point(292, 163);
            this.pctrbFrance.Name = "pctrbFrance";
            this.pctrbFrance.Size = new System.Drawing.Size(187, 93);
            this.pctrbFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbFrance.TabIndex = 1;
            this.pctrbFrance.TabStop = false;
            this.pctrbFrance.Click += new System.EventHandler(this.pctrbFrance_Click);
            // 
            // pctrbFinland
            // 
            this.pctrbFinland.Image = global::Flags_Application.Properties.Resources.finland;
            this.pctrbFinland.Location = new System.Drawing.Point(29, 163);
            this.pctrbFinland.Name = "pctrbFinland";
            this.pctrbFinland.Size = new System.Drawing.Size(187, 93);
            this.pctrbFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbFinland.TabIndex = 0;
            this.pctrbFinland.TabStop = false;
            this.pctrbFinland.Click += new System.EventHandler(this.pctrbFinland_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 405);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrbGermany);
            this.Controls.Add(this.pctrbFrance);
            this.Controls.Add(this.pctrbFinland);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbFinland)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbFinland;
        private System.Windows.Forms.PictureBox pctrbFrance;
        private System.Windows.Forms.PictureBox pctrbGermany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
    }
}

