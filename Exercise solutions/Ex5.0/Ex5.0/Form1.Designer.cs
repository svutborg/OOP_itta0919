namespace Ex5._0
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.subtractRadioButton = new System.Windows.Forms.RadioButton();
            this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.moduloRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 1;
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRadioButton.Location = new System.Drawing.Point(13, 44);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(36, 24);
            this.addRadioButton.TabIndex = 2;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "+";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // subtractRadioButton
            // 
            this.subtractRadioButton.AutoSize = true;
            this.subtractRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractRadioButton.Location = new System.Drawing.Point(55, 44);
            this.subtractRadioButton.Name = "subtractRadioButton";
            this.subtractRadioButton.Size = new System.Drawing.Size(32, 24);
            this.subtractRadioButton.TabIndex = 3;
            this.subtractRadioButton.Text = "-";
            this.subtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // multiplyRadioButton
            // 
            this.multiplyRadioButton.AutoSize = true;
            this.multiplyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyRadioButton.Location = new System.Drawing.Point(93, 44);
            this.multiplyRadioButton.Name = "multiplyRadioButton";
            this.multiplyRadioButton.Size = new System.Drawing.Size(33, 24);
            this.multiplyRadioButton.TabIndex = 4;
            this.multiplyRadioButton.Text = "*";
            this.multiplyRadioButton.UseVisualStyleBackColor = true;
            this.multiplyRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRadioButton.Location = new System.Drawing.Point(132, 44);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(31, 24);
            this.divideRadioButton.TabIndex = 5;
            this.divideRadioButton.Text = "/";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            // 
            // moduloRadioButton
            // 
            this.moduloRadioButton.AutoSize = true;
            this.moduloRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloRadioButton.Location = new System.Drawing.Point(169, 44);
            this.moduloRadioButton.Name = "moduloRadioButton";
            this.moduloRadioButton.Size = new System.Drawing.Size(58, 24);
            this.moduloRadioButton.TabIndex = 6;
            this.moduloRadioButton.Text = "mod";
            this.moduloRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(233, 44);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 26);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calc.";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(202, 116);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(137, 23);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "result";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------";
            // 
            // expressionLabel
            // 
            this.expressionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionLabel.Location = new System.Drawing.Point(10, 119);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(154, 18);
            this.expressionLabel.TabIndex = 10;
            this.expressionLabel.Text = "expression";
            this.expressionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal"});
            this.formatComboBox.Location = new System.Drawing.Point(233, 76);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(106, 21);
            this.formatComboBox.TabIndex = 11;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 139);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.moduloRadioButton);
            this.Controls.Add(this.divideRadioButton);
            this.Controls.Add(this.multiplyRadioButton);
            this.Controls.Add(this.subtractRadioButton);
            this.Controls.Add(this.addRadioButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Module 5 calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton subtractRadioButton;
        private System.Windows.Forms.RadioButton multiplyRadioButton;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.RadioButton moduloRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.ComboBox formatComboBox;
    }
}

