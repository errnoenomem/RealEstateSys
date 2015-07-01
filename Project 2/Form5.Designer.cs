namespace Project_2
{
    partial class ccForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expdate = new System.Windows.Forms.TextBox();
            this.csc = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mastercard = new System.Windows.Forms.RadioButton();
            this.visa = new System.Windows.Forms.RadioButton();
            this.americanexpress = new System.Windows.Forms.RadioButton();
            this.discovercard = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.expdate);
            this.groupBox1.Controls.Add(this.csc);
            this.groupBox1.Controls.Add(this.cc);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mastercard);
            this.groupBox1.Controls.Add(this.visa);
            this.groupBox1.Controls.Add(this.americanexpress);
            this.groupBox1.Controls.Add(this.discovercard);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 511);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Cards";
            // 
            // expdate
            // 
            this.expdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdate.Location = new System.Drawing.Point(25, 476);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(207, 26);
            this.expdate.TabIndex = 42;
            this.expdate.Text = "Expiration Date";
            // 
            // csc
            // 
            this.csc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csc.Location = new System.Drawing.Point(25, 444);
            this.csc.Name = "csc";
            this.csc.Size = new System.Drawing.Size(207, 26);
            this.csc.TabIndex = 41;
            this.csc.Text = "Card Security Code";
            // 
            // cc
            // 
            this.cc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.Location = new System.Drawing.Point(25, 412);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(208, 26);
            this.cc.TabIndex = 39;
            this.cc.Text = "Credit Card Number";
            // 
            // submit
            // 
            this.submit.AllowDrop = true;
            this.submit.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(238, 461);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(76, 41);
            this.submit.TabIndex = 38;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit2_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(25, 380);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(208, 26);
            this.name.TabIndex = 16;
            this.name.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mastercard
            // 
            this.mastercard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mastercard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastercard.Location = new System.Drawing.Point(66, 43);
            this.mastercard.Name = "mastercard";
            this.mastercard.Size = new System.Drawing.Size(117, 28);
            this.mastercard.TabIndex = 15;
            this.mastercard.TabStop = true;
            this.mastercard.Text = "MasterCard";
            this.mastercard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mastercard.UseVisualStyleBackColor = true;
            this.mastercard.CheckedChanged += new System.EventHandler(this.mastercard_CheckedChanged);
            // 
            // visa
            // 
            this.visa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visa.Location = new System.Drawing.Point(22, 121);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(161, 28);
            this.visa.TabIndex = 14;
            this.visa.TabStop = true;
            this.visa.Text = "Visa";
            this.visa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visa.UseVisualStyleBackColor = true;
            this.visa.CheckedChanged += new System.EventHandler(this.visa_CheckedChanged);
            // 
            // americanexpress
            // 
            this.americanexpress.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.americanexpress.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.americanexpress.Location = new System.Drawing.Point(22, 199);
            this.americanexpress.Name = "americanexpress";
            this.americanexpress.Size = new System.Drawing.Size(161, 28);
            this.americanexpress.TabIndex = 13;
            this.americanexpress.TabStop = true;
            this.americanexpress.Text = "American Express";
            this.americanexpress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.americanexpress.UseVisualStyleBackColor = true;
            this.americanexpress.CheckedChanged += new System.EventHandler(this.americanexpress_CheckedChanged);
            // 
            // discovercard
            // 
            this.discovercard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discovercard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discovercard.Location = new System.Drawing.Point(22, 272);
            this.discovercard.Name = "discovercard";
            this.discovercard.Size = new System.Drawing.Size(161, 28);
            this.discovercard.TabIndex = 12;
            this.discovercard.TabStop = true;
            this.discovercard.Text = "Discover";
            this.discovercard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.discovercard.UseVisualStyleBackColor = true;
            this.discovercard.CheckedChanged += new System.EventHandler(this.discovercard_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Project_2.Properties.Resources.amex;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(201, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 72);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project_2.Properties.Resources.discovercard;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(201, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 72);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project_2.Properties.Resources.visa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(201, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 72);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_2.Properties.Resources.mastercard;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(201, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 72);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "ccForm";
            this.Text = "Select Your Card";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton discovercard;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton mastercard;
        private System.Windows.Forms.RadioButton visa;
        private System.Windows.Forms.RadioButton americanexpress;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox expdate;
        private System.Windows.Forms.TextBox csc;

    }
}