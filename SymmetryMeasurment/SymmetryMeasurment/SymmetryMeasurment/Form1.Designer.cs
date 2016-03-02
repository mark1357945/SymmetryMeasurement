namespace SymmetryMeasurment
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Past = new System.Windows.Forms.GroupBox();
            this.groupBox_Self = new System.Windows.Forms.GroupBox();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_subjectID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Past
            // 
            this.groupBox_Past.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_Past.Font = new System.Drawing.Font("標楷體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Past.Location = new System.Drawing.Point(1042, 31);
            this.groupBox_Past.Name = "groupBox_Past";
            this.groupBox_Past.Size = new System.Drawing.Size(318, 777);
            this.groupBox_Past.TabIndex = 0;
            this.groupBox_Past.TabStop = false;
            this.groupBox_Past.Text = "與過去比較";
            // 
            // groupBox_Self
            // 
            this.groupBox_Self.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox_Self.Font = new System.Drawing.Font("標楷體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Self.Location = new System.Drawing.Point(706, 31);
            this.groupBox_Self.Name = "groupBox_Self";
            this.groupBox_Self.Size = new System.Drawing.Size(318, 777);
            this.groupBox_Self.TabIndex = 1;
            this.groupBox_Self.TabStop = false;
            this.groupBox_Self.Text = "自身對稱性";
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_main.Location = new System.Drawing.Point(52, 191);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(632, 550);
            this.pictureBox_main.TabIndex = 2;
            this.pictureBox_main.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_start.Location = new System.Drawing.Point(167, 771);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(101, 37);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Start_Capture);
            // 
            // button_pause
            // 
            this.button_pause.Enabled = false;
            this.button_pause.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_pause.Location = new System.Drawing.Point(358, 771);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(101, 37);
            this.button_pause.TabIndex = 5;
            this.button_pause.Text = "暫停";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.Pause_Capture);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(571, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "選擇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Choose_MainDirectory);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "資料存放位置：";
            // 
            // textBox_directory
            // 
            this.textBox_directory.Enabled = false;
            this.textBox_directory.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_directory.Location = new System.Drawing.Point(49, 130);
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(477, 37);
            this.textBox_directory.TabIndex = 9;
            this.textBox_directory.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1166, 834);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Developed by Alfred Mai ...2016.03";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(99, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "病患ID：";
            // 
            // textBox_subjectID
            // 
            this.textBox_subjectID.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subjectID.Location = new System.Drawing.Point(195, 46);
            this.textBox_subjectID.Name = "textBox_subjectID";
            this.textBox_subjectID.Size = new System.Drawing.Size(477, 36);
            this.textBox_subjectID.TabIndex = 12;
            this.textBox_subjectID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(5, 828);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "使用說明";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Show_Instrument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_subjectID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_main);
            this.Controls.Add(this.groupBox_Self);
            this.Controls.Add(this.groupBox_Past);
            this.Name = "Form1";
            this.Text = "Symmetry Measurement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Past;
        private System.Windows.Forms.GroupBox groupBox_Self;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_subjectID;
        private System.Windows.Forms.Button button2;
    }
}

