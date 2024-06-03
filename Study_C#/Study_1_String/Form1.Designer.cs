namespace Study_C_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContain = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.lblSubstr = new System.Windows.Forms.Label();
            this.lblToLower = new System.Windows.Forms.Label();
            this.lblToUpper = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.lbl_Contain = new System.Windows.Forms.Label();
            this.lbl_Equals = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Replace = new System.Windows.Forms.Label();
            this.lbl_Split = new System.Windows.Forms.Label();
            this.lbl_Substring = new System.Windows.Forms.Label();
            this.lbl_ToLower = new System.Windows.Forms.Label();
            this.lbl_ToUpper = new System.Windows.Forms.Label();
            this.lbl_Trim = new System.Windows.Forms.Label();
            this.lbl_Split_2 = new System.Windows.Forms.Label();
            this.lbl_Split_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(137, 15);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Sample, Test, Text ";
            this.lblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContain
            // 
            this.lblContain.AutoSize = true;
            this.lblContain.Location = new System.Drawing.Point(12, 84);
            this.lblContain.Name = "lblContain";
            this.lblContain.Size = new System.Drawing.Size(65, 15);
            this.lblContain.TabIndex = 2;
            this.lblContain.Text = "Contains";
            this.lblContain.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(12, 133);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(51, 15);
            this.lblEquals.TabIndex = 2;
            this.lblEquals.Text = "Equals";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 187);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(13, 244);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(60, 15);
            this.lblReplace.TabIndex = 2;
            this.lblReplace.Text = "Replace";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(12, 298);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(35, 15);
            this.lblSplit.TabIndex = 3;
            this.lblSplit.Text = "Split";
            // 
            // lblSubstr
            // 
            this.lblSubstr.AutoSize = true;
            this.lblSubstr.Location = new System.Drawing.Point(253, 84);
            this.lblSubstr.Name = "lblSubstr";
            this.lblSubstr.Size = new System.Drawing.Size(68, 15);
            this.lblSubstr.TabIndex = 3;
            this.lblSubstr.Text = "Substring";
            // 
            // lblToLower
            // 
            this.lblToLower.AutoSize = true;
            this.lblToLower.Location = new System.Drawing.Point(253, 133);
            this.lblToLower.Name = "lblToLower";
            this.lblToLower.Size = new System.Drawing.Size(63, 15);
            this.lblToLower.TabIndex = 3;
            this.lblToLower.Text = "ToLower";
            // 
            // lblToUpper
            // 
            this.lblToUpper.AutoSize = true;
            this.lblToUpper.Location = new System.Drawing.Point(253, 187);
            this.lblToUpper.Name = "lblToUpper";
            this.lblToUpper.Size = new System.Drawing.Size(62, 15);
            this.lblToUpper.TabIndex = 3;
            this.lblToUpper.Text = "ToUpper";
            this.lblToUpper.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(253, 244);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(33, 15);
            this.lblTrim.TabIndex = 3;
            this.lblTrim.Text = "Trim";
            this.lblTrim.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_Contain
            // 
            this.lbl_Contain.AutoSize = true;
            this.lbl_Contain.Location = new System.Drawing.Point(104, 84);
            this.lbl_Contain.Name = "lbl_Contain";
            this.lbl_Contain.Size = new System.Drawing.Size(15, 15);
            this.lbl_Contain.TabIndex = 4;
            this.lbl_Contain.Text = "-";
            this.lbl_Contain.Click += new System.EventHandler(this.lbl_Contain_Click);
            // 
            // lbl_Equals
            // 
            this.lbl_Equals.AutoSize = true;
            this.lbl_Equals.Location = new System.Drawing.Point(104, 133);
            this.lbl_Equals.Name = "lbl_Equals";
            this.lbl_Equals.Size = new System.Drawing.Size(15, 15);
            this.lbl_Equals.TabIndex = 4;
            this.lbl_Equals.Text = "-";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(104, 187);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(15, 15);
            this.lbl_Length.TabIndex = 5;
            this.lbl_Length.Text = "-";
            // 
            // lbl_Replace
            // 
            this.lbl_Replace.AutoSize = true;
            this.lbl_Replace.Location = new System.Drawing.Point(104, 244);
            this.lbl_Replace.Name = "lbl_Replace";
            this.lbl_Replace.Size = new System.Drawing.Size(15, 15);
            this.lbl_Replace.TabIndex = 5;
            this.lbl_Replace.Text = "-";
            // 
            // lbl_Split
            // 
            this.lbl_Split.AutoSize = true;
            this.lbl_Split.Location = new System.Drawing.Point(104, 298);
            this.lbl_Split.Name = "lbl_Split";
            this.lbl_Split.Size = new System.Drawing.Size(15, 15);
            this.lbl_Split.TabIndex = 5;
            this.lbl_Split.Text = "-";
            // 
            // lbl_Substring
            // 
            this.lbl_Substring.AutoSize = true;
            this.lbl_Substring.Location = new System.Drawing.Point(349, 84);
            this.lbl_Substring.Name = "lbl_Substring";
            this.lbl_Substring.Size = new System.Drawing.Size(15, 15);
            this.lbl_Substring.TabIndex = 4;
            this.lbl_Substring.Text = "-";
            this.lbl_Substring.Click += new System.EventHandler(this.lbl_Contain_Click);
            // 
            // lbl_ToLower
            // 
            this.lbl_ToLower.AutoSize = true;
            this.lbl_ToLower.Location = new System.Drawing.Point(349, 133);
            this.lbl_ToLower.Name = "lbl_ToLower";
            this.lbl_ToLower.Size = new System.Drawing.Size(15, 15);
            this.lbl_ToLower.TabIndex = 4;
            this.lbl_ToLower.Text = "-";
            this.lbl_ToLower.Click += new System.EventHandler(this.lbl_Contain_Click);
            // 
            // lbl_ToUpper
            // 
            this.lbl_ToUpper.AutoSize = true;
            this.lbl_ToUpper.Location = new System.Drawing.Point(349, 187);
            this.lbl_ToUpper.Name = "lbl_ToUpper";
            this.lbl_ToUpper.Size = new System.Drawing.Size(15, 15);
            this.lbl_ToUpper.TabIndex = 4;
            this.lbl_ToUpper.Text = "-";
            this.lbl_ToUpper.Click += new System.EventHandler(this.lbl_Contain_Click);
            // 
            // lbl_Trim
            // 
            this.lbl_Trim.AutoSize = true;
            this.lbl_Trim.Location = new System.Drawing.Point(349, 244);
            this.lbl_Trim.Name = "lbl_Trim";
            this.lbl_Trim.Size = new System.Drawing.Size(15, 15);
            this.lbl_Trim.TabIndex = 4;
            this.lbl_Trim.Text = "-";
            this.lbl_Trim.Click += new System.EventHandler(this.lbl_Contain_Click);
            // 
            // lbl_Split_2
            // 
            this.lbl_Split_2.AutoSize = true;
            this.lbl_Split_2.Location = new System.Drawing.Point(104, 337);
            this.lbl_Split_2.Name = "lbl_Split_2";
            this.lbl_Split_2.Size = new System.Drawing.Size(15, 15);
            this.lbl_Split_2.TabIndex = 6;
            this.lbl_Split_2.Text = "-";
            // 
            // lbl_Split_3
            // 
            this.lbl_Split_3.AutoSize = true;
            this.lbl_Split_3.Location = new System.Drawing.Point(104, 376);
            this.lbl_Split_3.Name = "lbl_Split_3";
            this.lbl_Split_3.Size = new System.Drawing.Size(15, 15);
            this.lbl_Split_3.TabIndex = 6;
            this.lbl_Split_3.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 494);
            this.Controls.Add(this.lbl_Split_3);
            this.Controls.Add(this.lbl_Split_2);
            this.Controls.Add(this.lbl_Split);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Equals);
            this.Controls.Add(this.lbl_Trim);
            this.Controls.Add(this.lbl_ToUpper);
            this.Controls.Add(this.lbl_ToLower);
            this.Controls.Add(this.lbl_Substring);
            this.Controls.Add(this.lbl_Contain);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblToUpper);
            this.Controls.Add(this.lblToLower);
            this.Controls.Add(this.lblSubstr);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Label lblSubstr;
        private System.Windows.Forms.Label lblToLower;
        private System.Windows.Forms.Label lblToUpper;
        private System.Windows.Forms.Label lblContain;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.Label lbl_Contain;
        private System.Windows.Forms.Label lbl_Equals;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Replace;
        private System.Windows.Forms.Label lbl_Split;
        private System.Windows.Forms.Label lbl_Substring;
        private System.Windows.Forms.Label lbl_ToLower;
        private System.Windows.Forms.Label lbl_ToUpper;
        private System.Windows.Forms.Label lbl_Trim;
        private System.Windows.Forms.Label lbl_Split_2;
        private System.Windows.Forms.Label lbl_Split_3;
    }
}

