
namespace Zipse_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lane2 = new System.Windows.Forms.TextBox();
            this.lane3 = new System.Windows.Forms.TextBox();
            this.lane4 = new System.Windows.Forms.TextBox();
            this.lane5 = new System.Windows.Forms.TextBox();
            this.lane1 = new System.Windows.Forms.TextBox();
            this.lane6 = new System.Windows.Forms.TextBox();
            this.lane7 = new System.Windows.Forms.TextBox();
            this.lane8 = new System.Windows.Forms.TextBox();
            this.lane9 = new System.Windows.Forms.TextBox();
            this.lane10 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(75, 48);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(49, 31);
            this.counter.TabIndex = 1;
            this.counter.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lane2
            // 
            this.lane2.Location = new System.Drawing.Point(204, 237);
            this.lane2.Name = "lane2";
            this.lane2.Size = new System.Drawing.Size(150, 31);
            this.lane2.TabIndex = 4;
            this.lane2.Text = "Lane 2";
            // 
            // lane3
            // 
            this.lane3.Location = new System.Drawing.Point(387, 237);
            this.lane3.Name = "lane3";
            this.lane3.Size = new System.Drawing.Size(150, 31);
            this.lane3.TabIndex = 5;
            this.lane3.Text = "Lane 3";
            // 
            // lane4
            // 
            this.lane4.Location = new System.Drawing.Point(565, 237);
            this.lane4.Name = "lane4";
            this.lane4.Size = new System.Drawing.Size(150, 31);
            this.lane4.TabIndex = 6;
            this.lane4.Text = "Lane 4";
            // 
            // lane5
            // 
            this.lane5.Location = new System.Drawing.Point(738, 237);
            this.lane5.Name = "lane5";
            this.lane5.Size = new System.Drawing.Size(150, 31);
            this.lane5.TabIndex = 7;
            this.lane5.Text = "Lane 5";
            // 
            // lane1
            // 
            this.lane1.Location = new System.Drawing.Point(23, 237);
            this.lane1.Name = "lane1";
            this.lane1.Size = new System.Drawing.Size(150, 31);
            this.lane1.TabIndex = 8;
            this.lane1.Text = "Lane 1";
            this.lane1.TextChanged += new System.EventHandler(this.lane1_TextChanged);
            // 
            // lane6
            // 
            this.lane6.Location = new System.Drawing.Point(23, 303);
            this.lane6.Name = "lane6";
            this.lane6.Size = new System.Drawing.Size(150, 31);
            this.lane6.TabIndex = 9;
            this.lane6.Text = "Lane 6";
            // 
            // lane7
            // 
            this.lane7.Location = new System.Drawing.Point(204, 303);
            this.lane7.Name = "lane7";
            this.lane7.Size = new System.Drawing.Size(150, 31);
            this.lane7.TabIndex = 10;
            this.lane7.Text = "Lane 7";
            // 
            // lane8
            // 
            this.lane8.Location = new System.Drawing.Point(387, 303);
            this.lane8.Name = "lane8";
            this.lane8.Size = new System.Drawing.Size(150, 31);
            this.lane8.TabIndex = 11;
            this.lane8.Text = "Lane 8";
            // 
            // lane9
            // 
            this.lane9.Location = new System.Drawing.Point(565, 303);
            this.lane9.Name = "lane9";
            this.lane9.Size = new System.Drawing.Size(150, 31);
            this.lane9.TabIndex = 12;
            this.lane9.Text = "Lane 9";
            // 
            // lane10
            // 
            this.lane10.Location = new System.Drawing.Point(738, 303);
            this.lane10.Name = "lane10";
            this.lane10.Size = new System.Drawing.Size(150, 31);
            this.lane10.TabIndex = 13;
            this.lane10.Text = "Lane 10";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(204, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 154);
            this.listBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Trigger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Zipcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lane10);
            this.Controls.Add(this.lane9);
            this.Controls.Add(this.lane8);
            this.Controls.Add(this.lane7);
            this.Controls.Add(this.lane6);
            this.Controls.Add(this.lane1);
            this.Controls.Add(this.lane5);
            this.Controls.Add(this.lane4);
            this.Controls.Add(this.lane3);
            this.Controls.Add(this.lane2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Box Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox counter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox lane2;
        private System.Windows.Forms.TextBox lane3;
        private System.Windows.Forms.TextBox lane4;
        private System.Windows.Forms.TextBox lane5;
        private System.Windows.Forms.TextBox lane1;
        private System.Windows.Forms.TextBox lane6;
        private System.Windows.Forms.TextBox lane7;
        private System.Windows.Forms.TextBox lane8;
        private System.Windows.Forms.TextBox lane9;
        private System.Windows.Forms.TextBox lane10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

