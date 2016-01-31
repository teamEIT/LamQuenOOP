namespace PtForm
{
    partial class FormEquation
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
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonPtb1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPtb2 = new System.Windows.Forms.RadioButton();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonPtb2);
            this.groupBoxMode.Controls.Add(this.radioButtonPtb1);
            this.groupBoxMode.Location = new System.Drawing.Point(66, 46);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMode.Size = new System.Drawing.Size(171, 88);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Chọn một trong hai";
            // 
            // radioButtonPtb1
            // 
            this.radioButtonPtb1.AutoSize = true;
            this.radioButtonPtb1.Location = new System.Drawing.Point(6, 25);
            this.radioButtonPtb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPtb1.Name = "radioButtonPtb1";
            this.radioButtonPtb1.Size = new System.Drawing.Size(131, 19);
            this.radioButtonPtb1.TabIndex = 0;
            this.radioButtonPtb1.TabStop = true;
            this.radioButtonPtb1.Text = "Phương Trình Bậc 1";
            this.radioButtonPtb1.UseVisualStyleBackColor = true;
            this.radioButtonPtb1.CheckedChanged += new System.EventHandler(this.radioButtonPtb1_CheckedChanged);
            // 
            // radioButtonPtb2
            // 
            this.radioButtonPtb2.AutoSize = true;
            this.radioButtonPtb2.Location = new System.Drawing.Point(6, 52);
            this.radioButtonPtb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPtb2.Name = "radioButtonPtb2";
            this.radioButtonPtb2.Size = new System.Drawing.Size(131, 19);
            this.radioButtonPtb2.TabIndex = 1;
            this.radioButtonPtb2.TabStop = true;
            this.radioButtonPtb2.Text = "Phương Trình Bậc 2";
            this.radioButtonPtb2.UseVisualStyleBackColor = true;
            this.radioButtonPtb2.CheckedChanged += new System.EventHandler(this.radioButtonPtb2_CheckedChanged);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(8, 178);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 15);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(8, 146);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(13, 15);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "a";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(8, 206);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(13, 15);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "c";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(8, 236);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 15);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Kết Quả";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(66, 142);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(171, 22);
            this.textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(66, 174);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(171, 22);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(66, 202);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(171, 22);
            this.textBoxC.TabIndex = 7;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(66, 232);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(171, 54);
            this.textBoxResult.TabIndex = 8;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(243, 139);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 29);
            this.buttonCalc.TabIndex = 9;
            this.buttonCalc.Text = "Giải";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(243, 203);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 29);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.groupBoxMode);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEquation";
            this.Text = "FormEquationSolving";
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonPtb2;
        private System.Windows.Forms.RadioButton radioButtonPtb1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonExit;
    }
}

