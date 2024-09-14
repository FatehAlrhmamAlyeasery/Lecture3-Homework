namespace lect3_fath_motaher_abdoh_saleh_HW5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.labelsum = new System.Windows.Forms.Label();
            this.labelfactorial = new System.Windows.Forms.Label();
            this.labelsqrt = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(94, 20);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(70, 14);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "ادخل العدد";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(151, 89);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(130, 44);
            this.sum.TabIndex = 2;
            this.sum.Text = "المجموع";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(151, 160);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(130, 43);
            this.factorial.TabIndex = 3;
            this.factorial.Text = "المضروب";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(151, 231);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(130, 41);
            this.sqrt.TabIndex = 4;
            this.sqrt.Text = "الجذز";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsum.Location = new System.Drawing.Point(39, 105);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(41, 13);
            this.labelsum.TabIndex = 5;
            this.labelsum.Text = "label1";
            // 
            // labelfactorial
            // 
            this.labelfactorial.AutoSize = true;
            this.labelfactorial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfactorial.Location = new System.Drawing.Point(39, 175);
            this.labelfactorial.Name = "labelfactorial";
            this.labelfactorial.Size = new System.Drawing.Size(41, 13);
            this.labelfactorial.TabIndex = 6;
            this.labelfactorial.Text = "label1";
            // 
            // labelsqrt
            // 
            this.labelsqrt.AutoSize = true;
            this.labelsqrt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsqrt.Location = new System.Drawing.Point(39, 245);
            this.labelsqrt.Name = "labelsqrt";
            this.labelsqrt.Size = new System.Drawing.Size(41, 13);
            this.labelsqrt.TabIndex = 7;
            this.labelsqrt.Text = "label1";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clear.Location = new System.Drawing.Point(151, 304);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(130, 47);
            this.clear.TabIndex = 8;
            this.clear.Text = "مسح";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(12, 304);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(112, 47);
            this.close.TabIndex = 9;
            this.close.Text = "إغلاق";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 363);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.labelsqrt);
            this.Controls.Add(this.labelfactorial);
            this.Controls.Add(this.labelsum);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.Label labelfactorial;
        private System.Windows.Forms.Label labelsqrt;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button close;
    }
}

