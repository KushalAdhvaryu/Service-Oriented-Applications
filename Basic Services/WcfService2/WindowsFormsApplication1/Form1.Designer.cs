namespace WindowsFormsApplication1
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
            this.Title_C2F = new System.Windows.Forms.Label();
            this.Input_C = new System.Windows.Forms.Label();
            this.Celsius = new System.Windows.Forms.TextBox();
            this.ConvertC2F = new System.Windows.Forms.Button();
            this.LabelF = new System.Windows.Forms.Label();
            this.OutputF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputC = new System.Windows.Forms.Label();
            this.InputF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_C2F
            // 
            this.Title_C2F.AutoSize = true;
            this.Title_C2F.Location = new System.Drawing.Point(69, 9);
            this.Title_C2F.Name = "Title_C2F";
            this.Title_C2F.Size = new System.Drawing.Size(145, 13);
            this.Title_C2F.TabIndex = 0;
            this.Title_C2F.Text = "Convert Celsuis to Fahrenheit";
            // 
            // Input_C
            // 
            this.Input_C.AutoSize = true;
            this.Input_C.Location = new System.Drawing.Point(28, 39);
            this.Input_C.Name = "Input_C";
            this.Input_C.Size = new System.Drawing.Size(47, 13);
            this.Input_C.TabIndex = 1;
            this.Input_C.Text = "Input C :";
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(98, 39);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(104, 20);
            this.Celsius.TabIndex = 2;
            this.Celsius.Text = "Enter Celusis value.";
            this.Celsius.TextChanged += new System.EventHandler(this.Celsius_TextChanged);
            // 
            // ConvertC2F
            // 
            this.ConvertC2F.Location = new System.Drawing.Point(31, 96);
            this.ConvertC2F.Name = "ConvertC2F";
            this.ConvertC2F.Size = new System.Drawing.Size(75, 23);
            this.ConvertC2F.TabIndex = 3;
            this.ConvertC2F.Text = "Convert C2F";
            this.ConvertC2F.UseVisualStyleBackColor = true;
            this.ConvertC2F.Click += new System.EventHandler(this.ConvertC2F_Click);
            // 
            // LabelF
            // 
            this.LabelF.AutoSize = true;
            this.LabelF.Location = new System.Drawing.Point(28, 71);
            this.LabelF.Name = "LabelF";
            this.LabelF.Size = new System.Drawing.Size(51, 13);
            this.LabelF.TabIndex = 4;
            this.LabelF.Text = "Output F:";
            // 
            // OutputF
            // 
            this.OutputF.AutoSize = true;
            this.OutputF.Location = new System.Drawing.Point(95, 71);
            this.OutputF.Name = "OutputF";
            this.OutputF.Size = new System.Drawing.Size(119, 13);
            this.OutputF.TabIndex = 5;
            this.OutputF.Text = "Output will appear here.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Convert Fahrenheit to Celsuis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input F:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output C :";
            // 
            // OutputC
            // 
            this.OutputC.AutoSize = true;
            this.OutputC.Location = new System.Drawing.Point(95, 200);
            this.OutputC.Name = "OutputC";
            this.OutputC.Size = new System.Drawing.Size(119, 13);
            this.OutputC.TabIndex = 9;
            this.OutputC.Text = "Output will appear here.";
            // 
            // InputF
            // 
            this.InputF.Location = new System.Drawing.Point(98, 163);
            this.InputF.Name = "InputF";
            this.InputF.Size = new System.Drawing.Size(126, 20);
            this.InputF.TabIndex = 10;
            this.InputF.Text = "Enter Fahrenheit value.";
            this.InputF.TextChanged += new System.EventHandler(this.InputF_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Convert F2C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputF);
            this.Controls.Add(this.OutputC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputF);
            this.Controls.Add(this.LabelF);
            this.Controls.Add(this.ConvertC2F);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Input_C);
            this.Controls.Add(this.Title_C2F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_C2F;
        private System.Windows.Forms.Label Input_C;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.Button ConvertC2F;
        private System.Windows.Forms.Label LabelF;
        private System.Windows.Forms.Label OutputF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OutputC;
        private System.Windows.Forms.TextBox InputF;
        private System.Windows.Forms.Button button1;
    }
}

