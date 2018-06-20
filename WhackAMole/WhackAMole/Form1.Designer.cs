namespace WhackAMole
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pLives = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMole12 = new System.Windows.Forms.Panel();
            this.pMole10 = new System.Windows.Forms.Panel();
            this.pMole11 = new System.Windows.Forms.Panel();
            this.pMole9 = new System.Windows.Forms.Panel();
            this.pMole8 = new System.Windows.Forms.Panel();
            this.pMole4 = new System.Windows.Forms.Panel();
            this.pMole6 = new System.Windows.Forms.Panel();
            this.pMole7 = new System.Windows.Forms.Panel();
            this.pMole2 = new System.Windows.Forms.Panel();
            this.pMole5 = new System.Windows.Forms.Panel();
            this.pMole3 = new System.Windows.Forms.Panel();
            this.pMole1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WhackAMole.Properties.Resources.layoutFinished;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pLives);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pLevel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pPoints);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pMole12);
            this.panel1.Controls.Add(this.pMole10);
            this.panel1.Controls.Add(this.pMole11);
            this.panel1.Controls.Add(this.pMole9);
            this.panel1.Controls.Add(this.pMole8);
            this.panel1.Controls.Add(this.pMole4);
            this.panel1.Controls.Add(this.pMole6);
            this.panel1.Controls.Add(this.pMole7);
            this.panel1.Controls.Add(this.pMole2);
            this.panel1.Controls.Add(this.pMole5);
            this.panel1.Controls.Add(this.pMole3);
            this.panel1.Controls.Add(this.pMole1);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pLives
            // 
            this.pLives.AutoSize = true;
            this.pLives.Enabled = false;
            this.pLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pLives.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pLives.Location = new System.Drawing.Point(1229, 184);
            this.pLives.Name = "pLives";
            this.pLives.Size = new System.Drawing.Size(29, 31);
            this.pLives.TabIndex = 19;
            this.pLives.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(1136, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lives:";
            // 
            // pLevel
            // 
            this.pLevel.AutoSize = true;
            this.pLevel.Enabled = false;
            this.pLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pLevel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pLevel.Location = new System.Drawing.Point(1229, 133);
            this.pLevel.Name = "pLevel";
            this.pLevel.Size = new System.Drawing.Size(29, 31);
            this.pLevel.TabIndex = 17;
            this.pLevel.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(1136, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Level:";
            // 
            // pTime
            // 
            this.pTime.AutoSize = true;
            this.pTime.Enabled = false;
            this.pTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pTime.Location = new System.Drawing.Point(1224, 85);
            this.pTime.Name = "pTime";
            this.pTime.Size = new System.Drawing.Size(82, 31);
            this.pTime.TabIndex = 15;
            this.pTime.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1136, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time:";
            // 
            // pPoints
            // 
            this.pPoints.AutoSize = true;
            this.pPoints.Enabled = false;
            this.pPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pPoints.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pPoints.Location = new System.Drawing.Point(1240, 40);
            this.pPoints.Name = "pPoints";
            this.pPoints.Size = new System.Drawing.Size(0, 31);
            this.pPoints.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(1136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Points:";
            // 
            // pMole12
            // 
            this.pMole12.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole12.Location = new System.Drawing.Point(1009, 526);
            this.pMole12.Name = "pMole12";
            this.pMole12.Size = new System.Drawing.Size(90, 107);
            this.pMole12.TabIndex = 11;
            this.pMole12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole12Click);
            // 
            // pMole10
            // 
            this.pMole10.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole10.Location = new System.Drawing.Point(437, 526);
            this.pMole10.Name = "pMole10";
            this.pMole10.Size = new System.Drawing.Size(90, 107);
            this.pMole10.TabIndex = 9;
            this.pMole10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole10Click);
            // 
            // pMole11
            // 
            this.pMole11.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole11.Location = new System.Drawing.Point(735, 526);
            this.pMole11.Name = "pMole11";
            this.pMole11.Size = new System.Drawing.Size(90, 107);
            this.pMole11.TabIndex = 10;
            this.pMole11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole11Click);
            // 
            // pMole9
            // 
            this.pMole9.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole9.Location = new System.Drawing.Point(170, 526);
            this.pMole9.Name = "pMole9";
            this.pMole9.Size = new System.Drawing.Size(90, 107);
            this.pMole9.TabIndex = 8;
            this.pMole9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole9Click);
            // 
            // pMole8
            // 
            this.pMole8.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole8.Location = new System.Drawing.Point(1009, 291);
            this.pMole8.Name = "pMole8";
            this.pMole8.Size = new System.Drawing.Size(90, 107);
            this.pMole8.TabIndex = 7;
            this.pMole8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole8Click);
            // 
            // pMole4
            // 
            this.pMole4.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole4.Location = new System.Drawing.Point(996, 40);
            this.pMole4.Name = "pMole4";
            this.pMole4.Size = new System.Drawing.Size(90, 107);
            this.pMole4.TabIndex = 3;
            this.pMole4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole4Click);
            // 
            // pMole6
            // 
            this.pMole6.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole6.Location = new System.Drawing.Point(437, 291);
            this.pMole6.Name = "pMole6";
            this.pMole6.Size = new System.Drawing.Size(90, 107);
            this.pMole6.TabIndex = 5;
            this.pMole6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole6Click);
            // 
            // pMole7
            // 
            this.pMole7.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole7.Location = new System.Drawing.Point(735, 291);
            this.pMole7.Name = "pMole7";
            this.pMole7.Size = new System.Drawing.Size(90, 107);
            this.pMole7.TabIndex = 6;
            this.pMole7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole7Click);
            // 
            // pMole2
            // 
            this.pMole2.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole2.Location = new System.Drawing.Point(418, 40);
            this.pMole2.Name = "pMole2";
            this.pMole2.Size = new System.Drawing.Size(90, 107);
            this.pMole2.TabIndex = 1;
            this.pMole2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole2Click);
            // 
            // pMole5
            // 
            this.pMole5.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole5.Location = new System.Drawing.Point(170, 291);
            this.pMole5.Name = "pMole5";
            this.pMole5.Size = new System.Drawing.Size(90, 107);
            this.pMole5.TabIndex = 4;
            this.pMole5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole5Click);
            // 
            // pMole3
            // 
            this.pMole3.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole3.Location = new System.Drawing.Point(716, 40);
            this.pMole3.Name = "pMole3";
            this.pMole3.Size = new System.Drawing.Size(90, 107);
            this.pMole3.TabIndex = 2;
            this.pMole3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole3Click);
            // 
            // pMole1
            // 
            this.pMole1.BackgroundImage = global::WhackAMole.Properties.Resources.mole1;
            this.pMole1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMole1.Location = new System.Drawing.Point(151, 40);
            this.pMole1.Name = "pMole1";
            this.pMole1.Size = new System.Drawing.Size(90, 107);
            this.pMole1.TabIndex = 0;
            this.pMole1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mole1Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMole1;
        private System.Windows.Forms.Panel pMole12;
        private System.Windows.Forms.Panel pMole10;
        private System.Windows.Forms.Panel pMole11;
        private System.Windows.Forms.Panel pMole9;
        private System.Windows.Forms.Panel pMole8;
        private System.Windows.Forms.Panel pMole4;
        private System.Windows.Forms.Panel pMole6;
        private System.Windows.Forms.Panel pMole7;
        private System.Windows.Forms.Panel pMole2;
        private System.Windows.Forms.Panel pMole5;
        private System.Windows.Forms.Panel pMole3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pLevel;
        private System.Windows.Forms.Label pLives;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

