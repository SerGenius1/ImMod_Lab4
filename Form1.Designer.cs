namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.inputParam1 = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputParam2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inputParam3 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputParam4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.inputSpeed = new System.Windows.Forms.NumericUpDown();
            this.inputScale = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputParam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputParam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputParam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param 1*";
            // 
            // inputParam1
            // 
            this.inputParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParam1.Location = new System.Drawing.Point(157, 31);
            this.inputParam1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputParam1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.inputParam1.Name = "inputParam1";
            this.inputParam1.Size = new System.Drawing.Size(95, 34);
            this.inputParam1.TabIndex = 1;
            this.inputParam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputParam1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(37, 390);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(212, 57);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start/Stop";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Param 2*";
            // 
            // inputParam2
            // 
            this.inputParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParam2.Location = new System.Drawing.Point(157, 94);
            this.inputParam2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputParam2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.inputParam2.Name = "inputParam2";
            this.inputParam2.Size = new System.Drawing.Size(95, 34);
            this.inputParam2.TabIndex = 1;
            this.inputParam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputParam2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Param 3*";
            // 
            // inputParam3
            // 
            this.inputParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParam3.Location = new System.Drawing.Point(157, 158);
            this.inputParam3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputParam3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.inputParam3.Name = "inputParam3";
            this.inputParam3.Size = new System.Drawing.Size(95, 34);
            this.inputParam3.TabIndex = 1;
            this.inputParam3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputParam3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputParam4);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.inputSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.inputScale);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1203, 695);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // inputParam4
            // 
            this.inputParam4.DecimalPlaces = 2;
            this.inputParam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParam4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputParam4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputParam4.Location = new System.Drawing.Point(155, 223);
            this.inputParam4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputParam4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputParam4.Name = "inputParam4";
            this.inputParam4.Size = new System.Drawing.Size(95, 34);
            this.inputParam4.TabIndex = 1;
            this.inputParam4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputParam4.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Param 4*";
            // 
            // inputSpeed
            // 
            this.inputSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSpeed.Location = new System.Drawing.Point(155, 337);
            this.inputSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputSpeed.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.inputSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(95, 34);
            this.inputSpeed.TabIndex = 1;
            this.inputSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // inputScale
            // 
            this.inputScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputScale.Location = new System.Drawing.Point(155, 281);
            this.inputScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputScale.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inputScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputScale.Name = "inputScale";
            this.inputScale.Size = new System.Drawing.Size(95, 34);
            this.inputScale.TabIndex = 1;
            this.inputScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(40, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Speed X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(53, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Scale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 662);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "Param 4 - Number of cells at start\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 601);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Param 3 - How much neighbor is needed \r\n                  for cell BORN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 538);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Param 2 - How much neighbor is needed \r\n                  for cell SURVIVAL (<=)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Param 1 - How much neighbor is needed \r\n                  for cell SURVIVAL (>=)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 691);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 695);
            this.Controls.Add(this.inputParam3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputParam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputParam1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputParam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputParam3)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputParam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputParam1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputParam2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputParam3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown inputScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown inputParam4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown inputSpeed;
        private System.Windows.Forms.Label label10;
    }
}

