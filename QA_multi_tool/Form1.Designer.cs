namespace QA_multi_tool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btm_exit = new System.Windows.Forms.Button();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tbx_string = new System.Windows.Forms.TextBox();
            this.tbx_count = new System.Windows.Forms.TextBox();
            this.btm_CreateString = new System.Windows.Forms.Button();
            this.btn_clearString = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_mil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btm_exit);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btm_exit
            // 
            this.btm_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btm_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_exit.Location = new System.Drawing.Point(490, 3);
            this.btm_exit.Name = "btm_exit";
            this.btm_exit.Size = new System.Drawing.Size(28, 28);
            this.btm_exit.TabIndex = 1;
            this.btm_exit.Text = "X";
            this.btm_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btm_exit.UseVisualStyleBackColor = false;
            this.btm_exit.Click += new System.EventHandler(this.btm_exit_Click);
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Min.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Min.Location = new System.Drawing.Point(90, 56);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(96, 69);
            this.lbl_Min.TabIndex = 1;
            this.lbl_Min.Text = "00";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(102, 142);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(84, 53);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(220, 142);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(84, 53);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(341, 142);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 53);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tbx_string
            // 
            this.tbx_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_string.Location = new System.Drawing.Point(34, 222);
            this.tbx_string.Multiline = true;
            this.tbx_string.Name = "tbx_string";
            this.tbx_string.Size = new System.Drawing.Size(332, 156);
            this.tbx_string.TabIndex = 5;
            this.tbx_string.TextChanged += new System.EventHandler(this.tbx_string_TextChanged);
            // 
            // tbx_count
            // 
            this.tbx_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_count.Location = new System.Drawing.Point(384, 222);
            this.tbx_count.Name = "tbx_count";
            this.tbx_count.Size = new System.Drawing.Size(100, 30);
            this.tbx_count.TabIndex = 6;
            // 
            // btm_CreateString
            // 
            this.btm_CreateString.Location = new System.Drawing.Point(384, 278);
            this.btm_CreateString.Name = "btm_CreateString";
            this.btm_CreateString.Size = new System.Drawing.Size(100, 38);
            this.btm_CreateString.TabIndex = 7;
            this.btm_CreateString.Text = "Create";
            this.btm_CreateString.UseVisualStyleBackColor = true;
            this.btm_CreateString.Click += new System.EventHandler(this.btm_CreateString_Click);
            // 
            // btn_clearString
            // 
            this.btn_clearString.Location = new System.Drawing.Point(384, 340);
            this.btn_clearString.Name = "btn_clearString";
            this.btn_clearString.Size = new System.Drawing.Size(100, 38);
            this.btn_clearString.TabIndex = 8;
            this.btn_clearString.Text = "Clear";
            this.btn_clearString.UseVisualStyleBackColor = true;
            this.btn_clearString.Click += new System.EventHandler(this.btn_clearString_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_sec.Location = new System.Drawing.Point(208, 56);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(96, 69);
            this.lbl_sec.TabIndex = 9;
            this.lbl_sec.Text = "00";
            // 
            // lbl_mil
            // 
            this.lbl_mil.AutoSize = true;
            this.lbl_mil.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mil.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_mil.Location = new System.Drawing.Point(329, 56);
            this.lbl_mil.Name = "lbl_mil";
            this.lbl_mil.Size = new System.Drawing.Size(96, 69);
            this.lbl_mil.TabIndex = 10;
            this.lbl_mil.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(175, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 69);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(290, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 69);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(525, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_mil);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.btn_clearString);
            this.Controls.Add(this.btm_CreateString);
            this.Controls.Add(this.tbx_count);
            this.Controls.Add(this.tbx_string);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_Min);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btm_exit;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tbx_string;
        private System.Windows.Forms.TextBox tbx_count;
        private System.Windows.Forms.Button btm_CreateString;
        private System.Windows.Forms.Button btn_clearString;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_mil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

