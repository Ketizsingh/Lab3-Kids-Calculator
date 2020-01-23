namespace Lab3___Kids_Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.MultiplicationButton = new System.Windows.Forms.RadioButton();
            this.SubtractionButton = new System.Windows.Forms.RadioButton();
            this.AdditionButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValueBox3 = new System.Windows.Forms.TextBox();
            this.ValueBox2 = new System.Windows.Forms.TextBox();
            this.ValueBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.eualLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivisionButton);
            this.groupBox1.Controls.Add(this.MultiplicationButton);
            this.groupBox1.Controls.Add(this.SubtractionButton);
            this.groupBox1.Controls.Add(this.AdditionButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1553, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator Box";
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.Location = new System.Drawing.Point(1223, 72);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(119, 29);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.TabStop = true;
            this.DivisionButton.Text = "Division";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.CheckedChanged += new System.EventHandler(this.DivisionButton_CheckedChanged);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AutoSize = true;
            this.MultiplicationButton.Location = new System.Drawing.Point(888, 72);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(169, 29);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.TabStop = true;
            this.MultiplicationButton.Text = "Multiplication";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.CheckedChanged += new System.EventHandler(this.MultiplicationButton_CheckedChanged);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.AutoSize = true;
            this.SubtractionButton.Location = new System.Drawing.Point(556, 72);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(152, 29);
            this.SubtractionButton.TabIndex = 1;
            this.SubtractionButton.TabStop = true;
            this.SubtractionButton.Text = "Subtraction";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.CheckedChanged += new System.EventHandler(this.SubtractionButton_CheckedChanged);
            // 
            // AdditionButton
            // 
            this.AdditionButton.AutoSize = true;
            this.AdditionButton.Location = new System.Drawing.Point(232, 72);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(121, 29);
            this.AdditionButton.TabIndex = 0;
            this.AdditionButton.TabStop = true;
            this.AdditionButton.Text = "Addition";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.CheckedChanged += new System.EventHandler(this.AdditionButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eualLabel);
            this.groupBox2.Controls.Add(this.operatorLabel);
            this.groupBox2.Controls.Add(this.ValueBox3);
            this.groupBox2.Controls.Add(this.ValueBox2);
            this.groupBox2.Controls.Add(this.ValueBox1);
            this.groupBox2.Location = new System.Drawing.Point(21, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1553, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Value Box";
            // 
            // ValueBox3
            // 
            this.ValueBox3.Location = new System.Drawing.Point(1055, 78);
            this.ValueBox3.Name = "ValueBox3";
            this.ValueBox3.Size = new System.Drawing.Size(204, 31);
            this.ValueBox3.TabIndex = 2;
            this.ValueBox3.TextChanged += new System.EventHandler(this.ValueBox3_TextChanged);
            // 
            // ValueBox2
            // 
            this.ValueBox2.Location = new System.Drawing.Point(698, 78);
            this.ValueBox2.Name = "ValueBox2";
            this.ValueBox2.Size = new System.Drawing.Size(204, 31);
            this.ValueBox2.TabIndex = 1;
            this.ValueBox2.TextChanged += new System.EventHandler(this.ValueBox2_TextChanged);
            // 
            // ValueBox1
            // 
            this.ValueBox1.Location = new System.Drawing.Point(335, 78);
            this.ValueBox1.Name = "ValueBox1";
            this.ValueBox1.Size = new System.Drawing.Size(204, 31);
            this.ValueBox1.TabIndex = 0;
            this.ValueBox1.TextChanged += new System.EventHandler(this.ValueBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CloseButton);
            this.groupBox3.Controls.Add(this.CheckButton);
            this.groupBox3.Controls.Add(this.NextButton);
            this.groupBox3.Location = new System.Drawing.Point(21, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1553, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Button Box";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1086, 68);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(135, 43);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(733, 68);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(135, 46);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Am I Right?";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(361, 68);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 43);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResultLabel);
            this.groupBox4.Location = new System.Drawing.Point(21, 654);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1553, 160);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(702, 72);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(176, 25);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Result Pending...";
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel.Location = new System.Drawing.Point(608, 84);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(28, 29);
            this.operatorLabel.TabIndex = 3;
            this.operatorLabel.Text = "+";
            this.operatorLabel.Click += new System.EventHandler(this.operatorLabel_Click);
            // 
            // eualLabel
            // 
            this.eualLabel.AutoSize = true;
            this.eualLabel.Location = new System.Drawing.Point(970, 84);
            this.eualLabel.Name = "eualLabel";
            this.eualLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eualLabel.Size = new System.Drawing.Size(24, 25);
            this.eualLabel.TabIndex = 4;
            this.eualLabel.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 875);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.RadioButton MultiplicationButton;
        private System.Windows.Forms.RadioButton SubtractionButton;
        private System.Windows.Forms.RadioButton AdditionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ValueBox3;
        private System.Windows.Forms.TextBox ValueBox2;
        private System.Windows.Forms.TextBox ValueBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label eualLabel;
        private System.Windows.Forms.Label operatorLabel;
    }
}

