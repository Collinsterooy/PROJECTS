namespace Cards_Project__Methods_
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
            this.btnShowCards = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctBxKingOfclubs = new System.Windows.Forms.PictureBox();
            this.pctBx10ofHearts = new System.Windows.Forms.PictureBox();
            this.pctBxAceOfspades = new System.Windows.Forms.PictureBox();
            this.lstBxCards = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxKingOfclubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx10ofHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxAceOfspades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowCards
            // 
            this.btnShowCards.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCards.Location = new System.Drawing.Point(172, 462);
            this.btnShowCards.Name = "btnShowCards";
            this.btnShowCards.Size = new System.Drawing.Size(167, 70);
            this.btnShowCards.TabIndex = 4;
            this.btnShowCards.Text = "Show Card";
            this.btnShowCards.UseVisualStyleBackColor = true;
            this.btnShowCards.Click += new System.EventHandler(this.btnShowCards_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pctBxKingOfclubs);
            this.panel1.Controls.Add(this.pctBx10ofHearts);
            this.panel1.Controls.Add(this.pctBxAceOfspades);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 290);
            this.panel1.TabIndex = 5;
            // 
            // pctBxKingOfclubs
            // 
            this.pctBxKingOfclubs.Image = ((System.Drawing.Image)(resources.GetObject("pctBxKingOfclubs.Image")));
            this.pctBxKingOfclubs.Location = new System.Drawing.Point(472, 23);
            this.pctBxKingOfclubs.Name = "pctBxKingOfclubs";
            this.pctBxKingOfclubs.Size = new System.Drawing.Size(161, 243);
            this.pctBxKingOfclubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxKingOfclubs.TabIndex = 5;
            this.pctBxKingOfclubs.TabStop = false;
            // 
            // pctBx10ofHearts
            // 
            this.pctBx10ofHearts.Image = ((System.Drawing.Image)(resources.GetObject("pctBx10ofHearts.Image")));
            this.pctBx10ofHearts.Location = new System.Drawing.Point(246, 23);
            this.pctBx10ofHearts.Name = "pctBx10ofHearts";
            this.pctBx10ofHearts.Size = new System.Drawing.Size(161, 243);
            this.pctBx10ofHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBx10ofHearts.TabIndex = 4;
            this.pctBx10ofHearts.TabStop = false;
            // 
            // pctBxAceOfspades
            // 
            this.pctBxAceOfspades.Image = ((System.Drawing.Image)(resources.GetObject("pctBxAceOfspades.Image")));
            this.pctBxAceOfspades.Location = new System.Drawing.Point(26, 23);
            this.pctBxAceOfspades.Name = "pctBxAceOfspades";
            this.pctBxAceOfspades.Size = new System.Drawing.Size(161, 243);
            this.pctBxAceOfspades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBxAceOfspades.TabIndex = 3;
            this.pctBxAceOfspades.TabStop = false;
            // 
            // lstBxCards
            // 
            this.lstBxCards.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxCards.FormattingEnabled = true;
            this.lstBxCards.ItemHeight = 27;
            this.lstBxCards.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.lstBxCards.Location = new System.Drawing.Point(255, 326);
            this.lstBxCards.Name = "lstBxCards";
            this.lstBxCards.Size = new System.Drawing.Size(192, 112);
            this.lstBxCards.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(365, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 70);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowCards);
            this.Controls.Add(this.lstBxCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBxKingOfclubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx10ofHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxAceOfspades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctBxKingOfclubs;
        private System.Windows.Forms.PictureBox pctBx10ofHearts;
        private System.Windows.Forms.PictureBox pctBxAceOfspades;
        private System.Windows.Forms.ListBox lstBxCards;
        private System.Windows.Forms.Button btnExit;
    }
}

