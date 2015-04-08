namespace SystemMonitor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CoreUsagetextBox = new System.Windows.Forms.TextBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Monitortimer = new System.Windows.Forms.Timer(this.components);
            this.Stopbutton = new System.Windows.Forms.Button();
            this.MemoryUsagetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Core Usage :";
            // 
            // CoreUsagetextBox
            // 
            this.CoreUsagetextBox.Location = new System.Drawing.Point(143, 18);
            this.CoreUsagetextBox.Name = "CoreUsagetextBox";
            this.CoreUsagetextBox.Size = new System.Drawing.Size(90, 20);
            this.CoreUsagetextBox.TabIndex = 1;
            this.CoreUsagetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(62, 350);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(109, 33);
            this.Startbutton.TabIndex = 2;
            this.Startbutton.Text = "Start Monitoring";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Monitortimer
            // 
            this.Monitortimer.Interval = 1000;
            this.Monitortimer.Tick += new System.EventHandler(this.Monitortimer_Tick);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(177, 350);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(109, 33);
            this.Stopbutton.TabIndex = 3;
            this.Stopbutton.Text = "Stop Monitoring";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // MemoryUsagetextBox
            // 
            this.MemoryUsagetextBox.Location = new System.Drawing.Point(143, 44);
            this.MemoryUsagetextBox.Name = "MemoryUsagetextBox";
            this.MemoryUsagetextBox.Size = new System.Drawing.Size(90, 20);
            this.MemoryUsagetextBox.TabIndex = 5;
            this.MemoryUsagetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Memory Usage :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 395);
            this.Controls.Add(this.MemoryUsagetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.CoreUsagetextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "System Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoreUsagetextBox;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Timer Monitortimer;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.TextBox MemoryUsagetextBox;
        private System.Windows.Forms.Label label2;
    }
}

