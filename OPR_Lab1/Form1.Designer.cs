namespace OPR_Lab1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.XinputLabel = new System.Windows.Forms.Label();
            this.YinputLabel = new System.Windows.Forms.Label();
            this.XinputTextBox = new System.Windows.Forms.TextBox();
            this.YinputTextBox = new System.Windows.Forms.TextBox();
            this.RsultLable = new System.Windows.Forms.Label();
            this.ResultOutputLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestStepInputTextBox = new System.Windows.Forms.TextBox();
            this.WorkStepInputTextBox = new System.Windows.Forms.TextBox();
            this.VectorsInputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutPutXLabel = new System.Windows.Forms.Label();
            this.OutPutYLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function";
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Location = new System.Drawing.Point(6, 43);
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.Size = new System.Drawing.Size(100, 20);
            this.FunctionTextBox.TabIndex = 1;
            // 
            // XinputLabel
            // 
            this.XinputLabel.AutoSize = true;
            this.XinputLabel.Location = new System.Drawing.Point(118, 26);
            this.XinputLabel.Name = "XinputLabel";
            this.XinputLabel.Size = new System.Drawing.Size(14, 13);
            this.XinputLabel.TabIndex = 2;
            this.XinputLabel.Text = "X";
            // 
            // YinputLabel
            // 
            this.YinputLabel.AutoSize = true;
            this.YinputLabel.Location = new System.Drawing.Point(179, 26);
            this.YinputLabel.Name = "YinputLabel";
            this.YinputLabel.Size = new System.Drawing.Size(14, 13);
            this.YinputLabel.TabIndex = 3;
            this.YinputLabel.Text = "Y";
            // 
            // XinputTextBox
            // 
            this.XinputTextBox.Location = new System.Drawing.Point(121, 43);
            this.XinputTextBox.Name = "XinputTextBox";
            this.XinputTextBox.Size = new System.Drawing.Size(47, 20);
            this.XinputTextBox.TabIndex = 4;
            this.XinputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XinputTextBox_KeyPress);
            // 
            // YinputTextBox
            // 
            this.YinputTextBox.Location = new System.Drawing.Point(182, 43);
            this.YinputTextBox.Name = "YinputTextBox";
            this.YinputTextBox.Size = new System.Drawing.Size(47, 20);
            this.YinputTextBox.TabIndex = 5;
            this.YinputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XinputTextBox_KeyPress);
            // 
            // RsultLable
            // 
            this.RsultLable.AutoSize = true;
            this.RsultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RsultLable.Location = new System.Drawing.Point(15, 146);
            this.RsultLable.Name = "RsultLable";
            this.RsultLable.Size = new System.Drawing.Size(59, 20);
            this.RsultLable.TabIndex = 6;
            this.RsultLable.Text = "Result:";
            // 
            // ResultOutputLable
            // 
            this.ResultOutputLable.AutoSize = true;
            this.ResultOutputLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultOutputLable.Location = new System.Drawing.Point(80, 146);
            this.ResultOutputLable.Name = "ResultOutputLable";
            this.ResultOutputLable.Size = new System.Drawing.Size(18, 20);
            this.ResultOutputLable.TabIndex = 7;
            this.ResultOutputLable.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TestStep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Work Step";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vectors";
            // 
            // TestStepInputTextBox
            // 
            this.TestStepInputTextBox.Location = new System.Drawing.Point(9, 97);
            this.TestStepInputTextBox.Name = "TestStepInputTextBox";
            this.TestStepInputTextBox.Size = new System.Drawing.Size(47, 20);
            this.TestStepInputTextBox.TabIndex = 11;
            this.TestStepInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XinputTextBox_KeyPress);
            // 
            // WorkStepInputTextBox
            // 
            this.WorkStepInputTextBox.Location = new System.Drawing.Point(65, 97);
            this.WorkStepInputTextBox.Name = "WorkStepInputTextBox";
            this.WorkStepInputTextBox.Size = new System.Drawing.Size(55, 20);
            this.WorkStepInputTextBox.TabIndex = 12;
            this.WorkStepInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XinputTextBox_KeyPress);
            // 
            // VectorsInputTextBox
            // 
            this.VectorsInputTextBox.Location = new System.Drawing.Point(133, 97);
            this.VectorsInputTextBox.Name = "VectorsInputTextBox";
            this.VectorsInputTextBox.Size = new System.Drawing.Size(47, 20);
            this.VectorsInputTextBox.TabIndex = 13;
            this.VectorsInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XinputTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Start Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveCheckBox
            // 
            this.SaveCheckBox.AutoSize = true;
            this.SaveCheckBox.Checked = true;
            this.SaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveCheckBox.Location = new System.Drawing.Point(181, 241);
            this.SaveCheckBox.Name = "SaveCheckBox";
            this.SaveCheckBox.Size = new System.Drawing.Size(77, 17);
            this.SaveCheckBox.TabIndex = 15;
            this.SaveCheckBox.Text = "Save Data";
            this.SaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FunctionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.XinputLabel);
            this.groupBox1.Controls.Add(this.VectorsInputTextBox);
            this.groupBox1.Controls.Add(this.YinputLabel);
            this.groupBox1.Controls.Add(this.WorkStepInputTextBox);
            this.groupBox1.Controls.Add(this.XinputTextBox);
            this.groupBox1.Controls.Add(this.TestStepInputTextBox);
            this.groupBox1.Controls.Add(this.YinputTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 131);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input params";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y:";
            // 
            // OutPutXLabel
            // 
            this.OutPutXLabel.AutoSize = true;
            this.OutPutXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPutXLabel.Location = new System.Drawing.Point(43, 166);
            this.OutPutXLabel.Name = "OutPutXLabel";
            this.OutPutXLabel.Size = new System.Drawing.Size(18, 20);
            this.OutPutXLabel.TabIndex = 19;
            this.OutPutXLabel.Text = "0";
            // 
            // OutPutYLabel
            // 
            this.OutPutYLabel.AutoSize = true;
            this.OutPutYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPutYLabel.Location = new System.Drawing.Point(43, 186);
            this.OutPutYLabel.Name = "OutPutYLabel";
            this.OutPutYLabel.Size = new System.Drawing.Size(18, 20);
            this.OutPutYLabel.TabIndex = 20;
            this.OutPutYLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 268);
            this.Controls.Add(this.OutPutYLabel);
            this.Controls.Add(this.OutPutXLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultOutputLable);
            this.Controls.Add(this.RsultLable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.Label XinputLabel;
        private System.Windows.Forms.Label YinputLabel;
        private System.Windows.Forms.TextBox XinputTextBox;
        private System.Windows.Forms.TextBox YinputTextBox;
        private System.Windows.Forms.Label RsultLable;
        private System.Windows.Forms.Label ResultOutputLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TestStepInputTextBox;
        private System.Windows.Forms.TextBox WorkStepInputTextBox;
        private System.Windows.Forms.TextBox VectorsInputTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SaveCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OutPutXLabel;
        private System.Windows.Forms.Label OutPutYLabel;
    }
}

