namespace Calculadora
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
            this.TB = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.asterisk = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(12, 12);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(114, 23);
            this.TB.TabIndex = 0;
            this.TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_KeyDown);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(132, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(34, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 41);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(34, 34);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(52, 41);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(34, 34);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(92, 41);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(34, 34);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(132, 41);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(34, 34);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(132, 81);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(34, 34);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(92, 81);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(34, 34);
            this.six.TabIndex = 2;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(52, 81);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(34, 34);
            this.five.TabIndex = 2;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 81);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(34, 34);
            this.four.TabIndex = 2;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // asterisk
            // 
            this.asterisk.Location = new System.Drawing.Point(132, 121);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(34, 34);
            this.asterisk.TabIndex = 2;
            this.asterisk.Text = "*";
            this.asterisk.UseVisualStyleBackColor = true;
            this.asterisk.Click += new System.EventHandler(this.asterisk_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(92, 121);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(34, 34);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(52, 121);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(34, 34);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 121);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(34, 34);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // slash
            // 
            this.slash.Location = new System.Drawing.Point(132, 161);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(34, 34);
            this.slash.TabIndex = 2;
            this.slash.Text = "/";
            this.slash.UseVisualStyleBackColor = true;
            this.slash.Click += new System.EventHandler(this.slash_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(92, 161);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(34, 34);
            this.equal.TabIndex = 2;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            this.equal.Enter += new System.EventHandler(this.equal_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(52, 161);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(34, 34);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(12, 161);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(34, 34);
            this.cero.TabIndex = 2;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 205);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.asterisk);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button slash;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button cero;
    }
}

