namespace ClientTestVision2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SendInfo = new System.Windows.Forms.TextBox();
            this.recInfo = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ReSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 44);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SendInfo
            // 
            this.SendInfo.Location = new System.Drawing.Point(1, 90);
            this.SendInfo.Multiline = true;
            this.SendInfo.Name = "SendInfo";
            this.SendInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendInfo.Size = new System.Drawing.Size(486, 113);
            this.SendInfo.TabIndex = 2;
            // 
            // recInfo
            // 
            this.recInfo.Location = new System.Drawing.Point(1, 246);
            this.recInfo.Multiline = true;
            this.recInfo.Name = "recInfo";
            this.recInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.recInfo.Size = new System.Drawing.Size(486, 113);
            this.recInfo.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(322, 209);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ReSend
            // 
            this.ReSend.Location = new System.Drawing.Point(412, 209);
            this.ReSend.Name = "ReSend";
            this.ReSend.Size = new System.Drawing.Size(75, 23);
            this.ReSend.TabIndex = 5;
            this.ReSend.Text = "ReSend";
            this.ReSend.UseVisualStyleBackColor = true;
            this.ReSend.Click += new System.EventHandler(this.ReSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 380);
            this.Controls.Add(this.ReSend);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.recInfo);
            this.Controls.Add(this.SendInfo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SendInfo;
        private System.Windows.Forms.TextBox recInfo;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button ReSend;
    }
}

