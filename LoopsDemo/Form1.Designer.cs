namespace LoopsDemo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnForLoop2 = new System.Windows.Forms.Button();
            this.btnForLoop3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 364);
            this.listBox1.TabIndex = 0;
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(190, 12);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(75, 23);
            this.btnForLoop.TabIndex = 1;
            this.btnForLoop.Text = "For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnForLoop2
            // 
            this.btnForLoop2.Location = new System.Drawing.Point(190, 41);
            this.btnForLoop2.Name = "btnForLoop2";
            this.btnForLoop2.Size = new System.Drawing.Size(75, 23);
            this.btnForLoop2.TabIndex = 2;
            this.btnForLoop2.Text = "For Loop 2";
            this.btnForLoop2.UseVisualStyleBackColor = true;
            this.btnForLoop2.Click += new System.EventHandler(this.btnForLoop2_Click);
            // 
            // btnForLoop3
            // 
            this.btnForLoop3.Location = new System.Drawing.Point(190, 70);
            this.btnForLoop3.Name = "btnForLoop3";
            this.btnForLoop3.Size = new System.Drawing.Size(75, 23);
            this.btnForLoop3.TabIndex = 3;
            this.btnForLoop3.Text = "For Loop 3";
            this.btnForLoop3.UseVisualStyleBackColor = true;
            this.btnForLoop3.Click += new System.EventHandler(this.btnForLoop3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Value";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(435, 47);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 23);
            this.txtStart.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(435, 76);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 23);
            this.txtEnd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Value";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(435, 105);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 23);
            this.txtIncrement.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Increment";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForLoop3);
            this.Controls.Add(this.btnForLoop2);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnForLoop;
        private Button btnForLoop2;
        private Button btnForLoop3;
        private Label label1;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Label label2;
        private TextBox txtIncrement;
        private Label label3;
    }
}