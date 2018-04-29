namespace OutOfClass5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radio_carl = new System.Windows.Forms.RadioButton();
            this.radio_wendy = new System.Windows.Forms.RadioButton();
            this.radio_md = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radio_carl);
            this.groupBox1.Controls.Add(this.radio_wendy);
            this.groupBox1.Controls.Add(this.radio_md);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a Fast Food Restaurant:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // radio_carl
            // 
            this.radio_carl.AutoSize = true;
            this.radio_carl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_carl.ForeColor = System.Drawing.Color.White;
            this.radio_carl.Location = new System.Drawing.Point(32, 123);
            this.radio_carl.Name = "radio_carl";
            this.radio_carl.Size = new System.Drawing.Size(105, 34);
            this.radio_carl.TabIndex = 3;
            this.radio_carl.TabStop = true;
            this.radio_carl.Text = "Carl\'s Jr";
            this.radio_carl.UseVisualStyleBackColor = true;
            this.radio_carl.CheckedChanged += new System.EventHandler(this.radio_carl_CheckedChanged);
            // 
            // radio_wendy
            // 
            this.radio_wendy.AutoSize = true;
            this.radio_wendy.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_wendy.ForeColor = System.Drawing.Color.White;
            this.radio_wendy.Location = new System.Drawing.Point(32, 81);
            this.radio_wendy.Name = "radio_wendy";
            this.radio_wendy.Size = new System.Drawing.Size(110, 34);
            this.radio_wendy.TabIndex = 2;
            this.radio_wendy.TabStop = true;
            this.radio_wendy.Text = "Wendy\'s";
            this.radio_wendy.UseVisualStyleBackColor = true;
            this.radio_wendy.CheckedChanged += new System.EventHandler(this.radio_wendy_CheckedChanged);
            // 
            // radio_md
            // 
            this.radio_md.AutoSize = true;
            this.radio_md.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_md.ForeColor = System.Drawing.Color.White;
            this.radio_md.Location = new System.Drawing.Point(32, 41);
            this.radio_md.Name = "radio_md";
            this.radio_md.Size = new System.Drawing.Size(140, 34);
            this.radio_md.TabIndex = 1;
            this.radio_md.TabStop = true;
            this.radio_md.Text = "McDonald\'s";
            this.radio_md.UseVisualStyleBackColor = true;
            this.radio_md.CheckedChanged += new System.EventHandler(this.radio_md_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(493, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Nutrition Facts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_carl;
        private System.Windows.Forms.RadioButton radio_wendy;
        private System.Windows.Forms.RadioButton radio_md;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

