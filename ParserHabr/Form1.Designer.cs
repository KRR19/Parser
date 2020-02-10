namespace ParserHabr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.EndPoint = new System.Windows.Forms.Label();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(245, 420);
            this.ListTitles.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(264, 13);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(55, 13);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "Start point";
            // 
            // NumericStart
            // 
            this.NumericStart.InterceptArrowKeys = false;
            this.NumericStart.Location = new System.Drawing.Point(264, 30);
            this.NumericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(120, 20);
            this.NumericStart.TabIndex = 2;
            this.NumericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndPoint
            // 
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(264, 57);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(52, 13);
            this.EndPoint.TabIndex = 3;
            this.EndPoint.Text = "End point";
            // 
            // NumericEnd
            // 
            this.NumericEnd.Location = new System.Drawing.Point(264, 74);
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(120, 20);
            this.NumericEnd.TabIndex = 4;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(263, 136);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(120, 26);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonAbort
            // 
            this.ButtonAbort.Location = new System.Drawing.Point(264, 168);
            this.ButtonAbort.Name = "ButtonAbort";
            this.ButtonAbort.Size = new System.Drawing.Size(120, 23);
            this.ButtonAbort.TabIndex = 6;
            this.ButtonAbort.Text = "Abort";
            this.ButtonAbort.UseVisualStyleBackColor = true;
            this.ButtonAbort.Click += new System.EventHandler(this.ButtonAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.ButtonAbort);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.ListTitles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonAbort;
    }
}

