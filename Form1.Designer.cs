namespace empty
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
            this.label_count_money = new System.Windows.Forms.Label();
            this.button_run = new System.Windows.Forms.Button();
            this.textbox_HRR = new System.Windows.Forms.TextBox();
            this.label_do = new System.Windows.Forms.Label();
            this.label_count_time = new System.Windows.Forms.Label();
            this.label_cm_text = new System.Windows.Forms.Label();
            this.label_ct_text = new System.Windows.Forms.Label();
            this.label_ts_text = new System.Windows.Forms.Label();
            this.label_time_started = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_break = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_count_money
            // 
            this.label_count_money.AutoSize = true;
            this.label_count_money.Location = new System.Drawing.Point(292, 78);
            this.label_count_money.Name = "label_count_money";
            this.label_count_money.Size = new System.Drawing.Size(60, 25);
            this.label_count_money.TabIndex = 0;
            this.label_count_money.Text = "count";
            this.label_count_money.Visible = false;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(167, 284);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(82, 41);
            this.button_run.TabIndex = 1;
            this.button_run.Text = "Go";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // textbox_HRR
            // 
            this.textbox_HRR.Location = new System.Drawing.Point(297, 28);
            this.textbox_HRR.Name = "textbox_HRR";
            this.textbox_HRR.Size = new System.Drawing.Size(82, 29);
            this.textbox_HRR.TabIndex = 2;
            this.textbox_HRR.Text = "25";
            this.textbox_HRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_do
            // 
            this.label_do.AutoSize = true;
            this.label_do.Location = new System.Drawing.Point(29, 28);
            this.label_do.Name = "label_do";
            this.label_do.Size = new System.Drawing.Size(164, 25);
            this.label_do.TabIndex = 3;
            this.label_do.Text = "Enter Hourly Rate";
            // 
            // label_count_time
            // 
            this.label_count_time.AutoSize = true;
            this.label_count_time.Location = new System.Drawing.Point(292, 130);
            this.label_count_time.Name = "label_count_time";
            this.label_count_time.Size = new System.Drawing.Size(60, 25);
            this.label_count_time.TabIndex = 4;
            this.label_count_time.Text = "count";
            this.label_count_time.Visible = false;
            // 
            // label_cm_text
            // 
            this.label_cm_text.AutoSize = true;
            this.label_cm_text.Location = new System.Drawing.Point(29, 78);
            this.label_cm_text.Name = "label_cm_text";
            this.label_cm_text.Size = new System.Drawing.Size(129, 25);
            this.label_cm_text.TabIndex = 5;
            this.label_cm_text.Text = "Money Earnt:";
            // 
            // label_ct_text
            // 
            this.label_ct_text.AutoSize = true;
            this.label_ct_text.Location = new System.Drawing.Point(29, 130);
            this.label_ct_text.Name = "label_ct_text";
            this.label_ct_text.Size = new System.Drawing.Size(119, 25);
            this.label_ct_text.TabIndex = 6;
            this.label_ct_text.Text = "Time Spent:";
            // 
            // label_ts_text
            // 
            this.label_ts_text.AutoSize = true;
            this.label_ts_text.Location = new System.Drawing.Point(28, 181);
            this.label_ts_text.Name = "label_ts_text";
            this.label_ts_text.Size = new System.Drawing.Size(130, 25);
            this.label_ts_text.TabIndex = 7;
            this.label_ts_text.Text = "Time Started:";
            // 
            // label_time_started
            // 
            this.label_time_started.AutoSize = true;
            this.label_time_started.Location = new System.Drawing.Point(292, 181);
            this.label_time_started.Name = "label_time_started";
            this.label_time_started.Size = new System.Drawing.Size(71, 25);
            this.label_time_started.TabIndex = 8;
            this.label_time_started.Text = "started";
            this.label_time_started.Visible = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(29, 231);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(120, 25);
            this.label_status.TabIndex = 9;
            this.label_status.Text = "Not Working";
            // 
            // button_break
            // 
            this.button_break.Location = new System.Drawing.Point(297, 223);
            this.button_break.Name = "button_break";
            this.button_break.Size = new System.Drawing.Size(82, 41);
            this.button_break.TabIndex = 10;
            this.button_break.Text = "Break";
            this.button_break.UseVisualStyleBackColor = true;
            this.button_break.Visible = false;
            this.button_break.Click += new System.EventHandler(this.Button_Break);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 337);
            this.Controls.Add(this.button_break);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_time_started);
            this.Controls.Add(this.label_ts_text);
            this.Controls.Add(this.label_ct_text);
            this.Controls.Add(this.label_cm_text);
            this.Controls.Add(this.label_count_time);
            this.Controls.Add(this.label_do);
            this.Controls.Add(this.textbox_HRR);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.label_count_money);
            this.Name = "Form1";
            this.Text = "Earnings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.TextBox textbox_HRR;
        private System.Windows.Forms.Label label_do;
        private System.Windows.Forms.Label label_count_money;
        private System.Windows.Forms.Label label_count_time;
        private System.Windows.Forms.Label label_cm_text;
        private System.Windows.Forms.Label label_ct_text;
        private System.Windows.Forms.Label label_ts_text;
        private System.Windows.Forms.Label label_time_started;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_break;
    }
}

