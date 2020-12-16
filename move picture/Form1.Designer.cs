 namespace move_picture
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
            this.buttonup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttondown = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonup
            // 
            this.buttonup.Location = new System.Drawing.Point(3, 3);
            this.buttonup.Name = "buttonup";
            this.buttonup.Size = new System.Drawing.Size(94, 44);
            this.buttonup.TabIndex = 1;
            this.buttonup.Text = "move up";
            this.buttonup.UseVisualStyleBackColor = true;
            this.buttonup.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::move_picture.Properties.Resources.liverpool_champions_league;
            this.pictureBox1.Location = new System.Drawing.Point(80, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttondown
            // 
            this.buttondown.Location = new System.Drawing.Point(3, 53);
            this.buttondown.Name = "buttondown";
            this.buttondown.Size = new System.Drawing.Size(94, 44);
            this.buttondown.TabIndex = 2;
            this.buttondown.Text = "move down";
            this.buttondown.UseVisualStyleBackColor = true;
            this.buttondown.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.Location = new System.Drawing.Point(103, 53);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(94, 44);
            this.buttonleft.TabIndex = 3;
            this.buttonleft.Text = "move left";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonright
            // 
            this.buttonright.Location = new System.Drawing.Point(103, 3);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(94, 44);
            this.buttonright.TabIndex = 4;
            this.buttonright.Text = "move right";
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonright, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonleft, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttondown, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(668, 373);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonup;
        private System.Windows.Forms.Button buttondown;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

