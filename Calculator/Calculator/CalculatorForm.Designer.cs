
namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBracketButton = new System.Windows.Forms.Button();
            this.openBracketButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.diffButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(36, 16);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(131, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(190, 16);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(120, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.calculateButton.Location = new System.Drawing.Point(260, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(50, 50);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calculateButton);
            this.panel2.Controls.Add(this.closeBracketButton);
            this.panel2.Controls.Add(this.openBracketButton);
            this.panel2.Controls.Add(this.multiplyButton);
            this.panel2.Controls.Add(this.divideButton);
            this.panel2.Controls.Add(this.diffButton);
            this.panel2.Controls.Add(this.sumButton);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.dotButton);
            this.panel2.Controls.Add(this.zeroButton);
            this.panel2.Controls.Add(this.inputTextBox);
            this.panel2.Controls.Add(this.outputTextBox);
            this.panel2.Controls.Add(this.threeButton);
            this.panel2.Controls.Add(this.twoButton);
            this.panel2.Controls.Add(this.oneButton);
            this.panel2.Controls.Add(this.sixButton);
            this.panel2.Controls.Add(this.fiveButton);
            this.panel2.Controls.Add(this.fourButton);
            this.panel2.Controls.Add(this.nineButton);
            this.panel2.Controls.Add(this.eightButton);
            this.panel2.Controls.Add(this.sevenButton);
            this.panel2.Location = new System.Drawing.Point(216, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 272);
            this.panel2.TabIndex = 3;
            // 
            // closeBracketButton
            // 
            this.closeBracketButton.AllowDrop = true;
            this.closeBracketButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.closeBracketButton.Location = new System.Drawing.Point(260, 98);
            this.closeBracketButton.Name = "closeBracketButton";
            this.closeBracketButton.Size = new System.Drawing.Size(50, 50);
            this.closeBracketButton.TabIndex = 17;
            this.closeBracketButton.Text = ")";
            this.closeBracketButton.UseVisualStyleBackColor = false;
            // 
            // openBracketButton
            // 
            this.openBracketButton.AllowDrop = true;
            this.openBracketButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.openBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.openBracketButton.Location = new System.Drawing.Point(260, 42);
            this.openBracketButton.Name = "openBracketButton";
            this.openBracketButton.Size = new System.Drawing.Size(50, 50);
            this.openBracketButton.TabIndex = 16;
            this.openBracketButton.Text = "(";
            this.openBracketButton.UseVisualStyleBackColor = false;
            // 
            // multiplyButton
            // 
            this.multiplyButton.AllowDrop = true;
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.multiplyButton.Location = new System.Drawing.Point(204, 41);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(50, 50);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            // 
            // divideButton
            // 
            this.divideButton.AllowDrop = true;
            this.divideButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.divideButton.Location = new System.Drawing.Point(204, 98);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(50, 50);
            this.divideButton.TabIndex = 14;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            // 
            // diffButton
            // 
            this.diffButton.AllowDrop = true;
            this.diffButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.diffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.diffButton.Location = new System.Drawing.Point(204, 154);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(50, 50);
            this.diffButton.TabIndex = 13;
            this.diffButton.Text = "-";
            this.diffButton.UseVisualStyleBackColor = false;
            // 
            // sumButton
            // 
            this.sumButton.AllowDrop = true;
            this.sumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.sumButton.Location = new System.Drawing.Point(204, 210);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(50, 50);
            this.sumButton.TabIndex = 12;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.AllowDrop = true;
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.42F);
            this.clearButton.Location = new System.Drawing.Point(148, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // dotButton
            // 
            this.dotButton.AllowDrop = true;
            this.dotButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.dotButton.Location = new System.Drawing.Point(92, 210);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(50, 50);
            this.dotButton.TabIndex = 10;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            // 
            // zeroButton
            // 
            this.zeroButton.AllowDrop = true;
            this.zeroButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.zeroButton.Location = new System.Drawing.Point(36, 210);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(50, 50);
            this.zeroButton.TabIndex = 9;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            // 
            // threeButton
            // 
            this.threeButton.AllowDrop = true;
            this.threeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.threeButton.Location = new System.Drawing.Point(148, 154);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(50, 50);
            this.threeButton.TabIndex = 8;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            // 
            // twoButton
            // 
            this.twoButton.AllowDrop = true;
            this.twoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.twoButton.Location = new System.Drawing.Point(92, 154);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(50, 50);
            this.twoButton.TabIndex = 7;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            // 
            // oneButton
            // 
            this.oneButton.AllowDrop = true;
            this.oneButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.oneButton.Location = new System.Drawing.Point(36, 154);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(50, 50);
            this.oneButton.TabIndex = 6;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            // 
            // sixButton
            // 
            this.sixButton.AllowDrop = true;
            this.sixButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.sixButton.Location = new System.Drawing.Point(148, 98);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(50, 50);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            // 
            // fiveButton
            // 
            this.fiveButton.AllowDrop = true;
            this.fiveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.fiveButton.Location = new System.Drawing.Point(92, 98);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(50, 50);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            // 
            // fourButton
            // 
            this.fourButton.AllowDrop = true;
            this.fourButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.fourButton.Location = new System.Drawing.Point(36, 98);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(50, 50);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            // 
            // nineButton
            // 
            this.nineButton.AllowDrop = true;
            this.nineButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.52F);
            this.nineButton.Location = new System.Drawing.Point(148, 42);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(50, 50);
            this.nineButton.TabIndex = 2;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            // 
            // eightButton
            // 
            this.eightButton.AllowDrop = true;
            this.eightButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.eightButton.Location = new System.Drawing.Point(92, 42);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(50, 50);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            // 
            // sevenButton
            // 
            this.sevenButton.AllowDrop = true;
            this.sevenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.42F);
            this.sevenButton.Location = new System.Drawing.Point(36, 42);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(50, 50);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button closeBracketButton;
        private System.Windows.Forms.Button openBracketButton;
    }
}

