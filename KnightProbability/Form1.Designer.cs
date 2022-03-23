
namespace KnightProbability
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.n_textBox = new System.Windows.Forms.NumericUpDown();
            this.k_textBox = new System.Windows.Forms.NumericUpDown();
            this.row_textBox = new System.Windows.Forms.NumericUpDown();
            this.column_textBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.column_textBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Column";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.result_buttonClick);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(41, 207);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(183, 64);
            this.result_textBox.TabIndex = 9;
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(94, 30);
            this.n_textBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(133, 20);
            this.n_textBox.TabIndex = 10;
            this.n_textBox.ValueChanged += new System.EventHandler(this.n_textBox_ValueChanged);
            // 
            // k_textBox
            // 
            this.k_textBox.Location = new System.Drawing.Point(94, 62);
            this.k_textBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.k_textBox.Name = "k_textBox";
            this.k_textBox.Size = new System.Drawing.Size(133, 20);
            this.k_textBox.TabIndex = 11;
            this.k_textBox.ValueChanged += new System.EventHandler(this.k_textBox_ValueChanged);
            // 
            // row_textBox
            // 
            this.row_textBox.Location = new System.Drawing.Point(94, 100);
            this.row_textBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.row_textBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.row_textBox.Name = "row_textBox";
            this.row_textBox.Size = new System.Drawing.Size(133, 20);
            this.row_textBox.TabIndex = 12;
            this.row_textBox.ValueChanged += new System.EventHandler(this.row_textBox_ValueChanged);
            // 
            // column_textBox
            // 
            this.column_textBox.Location = new System.Drawing.Point(94, 139);
            this.column_textBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.column_textBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.column_textBox.Name = "column_textBox";
            this.column_textBox.Size = new System.Drawing.Size(133, 20);
            this.column_textBox.TabIndex = 13;
            this.column_textBox.ValueChanged += new System.EventHandler(this.column_textBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 312);
            this.Controls.Add(this.column_textBox);
            this.Controls.Add(this.row_textBox);
            this.Controls.Add(this.k_textBox);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.n_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.column_textBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.NumericUpDown n_textBox;
        private System.Windows.Forms.NumericUpDown k_textBox;
        private System.Windows.Forms.NumericUpDown row_textBox;
        private System.Windows.Forms.NumericUpDown column_textBox;
    }
}

