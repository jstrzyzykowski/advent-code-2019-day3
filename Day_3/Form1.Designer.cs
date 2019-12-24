namespace Day_3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusLight = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeaderDistance = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelValueX = new System.Windows.Forms.Label();
            this.labelValueY = new System.Windows.Forms.Label();
            this.labelHeaderPoint = new System.Windows.Forms.Label();
            this.labelValueDistance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.buttonDraw, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 14);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(8, 14, 8, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(412, 50);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDraw.Location = new System.Drawing.Point(0, 0);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(288, 50);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "DRAW!";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            this.buttonDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonDraw_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelStatus, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelStatusLight, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(290, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(120, 46);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(120, 23);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "STATUS";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatusLight
            // 
            this.labelStatusLight.AutoSize = true;
            this.labelStatusLight.BackColor = System.Drawing.Color.DarkGray;
            this.labelStatusLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusLight.Location = new System.Drawing.Point(0, 23);
            this.labelStatusLight.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusLight.Name = "labelStatusLight";
            this.labelStatusLight.Size = new System.Drawing.Size(120, 23);
            this.labelStatusLight.TabIndex = 1;
            this.labelStatusLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelHeaderDistance, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelHeaderPoint, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelValueDistance, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 56);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelHeaderDistance
            // 
            this.labelHeaderDistance.AutoSize = true;
            this.labelHeaderDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderDistance.Location = new System.Drawing.Point(214, 0);
            this.labelHeaderDistance.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelHeaderDistance.Name = "labelHeaderDistance";
            this.labelHeaderDistance.Size = new System.Drawing.Size(198, 28);
            this.labelHeaderDistance.TabIndex = 2;
            this.labelHeaderDistance.Text = "MANHATTAN DISTANCE";
            this.labelHeaderDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelValueX, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelValueY, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(206, 28);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelValueX
            // 
            this.labelValueX.AutoSize = true;
            this.labelValueX.BackColor = System.Drawing.Color.DarkGray;
            this.labelValueX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValueX.Location = new System.Drawing.Point(8, 0);
            this.labelValueX.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelValueX.Name = "labelValueX";
            this.labelValueX.Size = new System.Drawing.Size(87, 28);
            this.labelValueX.TabIndex = 0;
            this.labelValueX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValueY
            // 
            this.labelValueY.AutoSize = true;
            this.labelValueY.BackColor = System.Drawing.Color.DarkGray;
            this.labelValueY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValueY.Location = new System.Drawing.Point(111, 0);
            this.labelValueY.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelValueY.Name = "labelValueY";
            this.labelValueY.Size = new System.Drawing.Size(87, 28);
            this.labelValueY.TabIndex = 1;
            this.labelValueY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeaderPoint
            // 
            this.labelHeaderPoint.AutoSize = true;
            this.labelHeaderPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderPoint.Location = new System.Drawing.Point(0, 0);
            this.labelHeaderPoint.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeaderPoint.Name = "labelHeaderPoint";
            this.labelHeaderPoint.Size = new System.Drawing.Size(206, 28);
            this.labelHeaderPoint.TabIndex = 1;
            this.labelHeaderPoint.Text = "NEAREST CROSSING POINT";
            this.labelHeaderPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValueDistance
            // 
            this.labelValueDistance.AutoSize = true;
            this.labelValueDistance.BackColor = System.Drawing.Color.DarkGray;
            this.labelValueDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValueDistance.Location = new System.Drawing.Point(214, 28);
            this.labelValueDistance.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelValueDistance.Name = "labelValueDistance";
            this.labelValueDistance.Size = new System.Drawing.Size(198, 28);
            this.labelValueDistance.TabIndex = 3;
            this.labelValueDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 6);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 150);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.MaximumSize = new System.Drawing.Size(538, 248);
            this.MinimumSize = new System.Drawing.Size(360, 169);
            this.Name = "Form1";
            this.Text = "ADVENT CODE 2019 - D3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusLight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelHeaderDistance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelValueX;
        private System.Windows.Forms.Label labelValueY;
        private System.Windows.Forms.Label labelHeaderPoint;
        private System.Windows.Forms.Label labelValueDistance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

