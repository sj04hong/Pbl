namespace PasswardBreaker
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
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_EndText = new System.Windows.Forms.TextBox();
            this.txtBox_StartText = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_SpecialText = new System.Windows.Forms.CheckBox();
            this.chk_Number = new System.Windows.Forms.CheckBox();
            this.chk_LowerText = new System.Windows.Forms.CheckBox();
            this.chk_UpperText = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Execution = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Location = new System.Drawing.Point(24, 62);
            this.txtBox_Path.Multiline = true;
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.ReadOnly = true;
            this.txtBox_Path.Size = new System.Drawing.Size(332, 25);
            this.txtBox_Path.TabIndex = 0;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(362, 62);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(96, 29);
            this.btn_SelectFile.TabIndex = 1;
            this.btn_SelectFile.Text = "파일 선택";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "지원 파일 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ZIP, 7Z, RAR, PDF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBox_EndText);
            this.panel1.Controls.Add(this.txtBox_StartText);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chk_SpecialText);
            this.panel1.Controls.Add(this.chk_Number);
            this.panel1.Controls.Add(this.chk_LowerText);
            this.panel1.Controls.Add(this.chk_UpperText);
            this.panel1.Location = new System.Drawing.Point(24, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 195);
            this.panel1.TabIndex = 4;
            // 
            // txtBox_EndText
            // 
            this.txtBox_EndText.Location = new System.Drawing.Point(277, 65);
            this.txtBox_EndText.Multiline = true;
            this.txtBox_EndText.Name = "txtBox_EndText";
            this.txtBox_EndText.Size = new System.Drawing.Size(120, 27);
            this.txtBox_EndText.TabIndex = 13;
            // 
            // txtBox_StartText
            // 
            this.txtBox_StartText.Location = new System.Drawing.Point(277, 25);
            this.txtBox_StartText.Multiline = true;
            this.txtBox_StartText.Name = "txtBox_StartText";
            this.txtBox_StartText.Size = new System.Drawing.Size(120, 27);
            this.txtBox_StartText.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(277, 148);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(277, 106);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "최대 글자 수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "최소 글자 수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "종료 문자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "시작 문자";
            // 
            // chk_SpecialText
            // 
            this.chk_SpecialText.AutoSize = true;
            this.chk_SpecialText.Location = new System.Drawing.Point(15, 154);
            this.chk_SpecialText.Name = "chk_SpecialText";
            this.chk_SpecialText.Size = new System.Drawing.Size(89, 19);
            this.chk_SpecialText.TabIndex = 3;
            this.chk_SpecialText.Text = "특수문자";
            this.chk_SpecialText.UseVisualStyleBackColor = true;
            // 
            // chk_Number
            // 
            this.chk_Number.AutoSize = true;
            this.chk_Number.Location = new System.Drawing.Point(15, 112);
            this.chk_Number.Name = "chk_Number";
            this.chk_Number.Size = new System.Drawing.Size(115, 19);
            this.chk_Number.TabIndex = 2;
            this.chk_Number.Text = "숫자 [0 ~ 9]";
            this.chk_Number.UseVisualStyleBackColor = true;
            // 
            // chk_LowerText
            // 
            this.chk_LowerText.AutoSize = true;
            this.chk_LowerText.Location = new System.Drawing.Point(15, 73);
            this.chk_LowerText.Name = "chk_LowerText";
            this.chk_LowerText.Size = new System.Drawing.Size(127, 19);
            this.chk_LowerText.TabIndex = 1;
            this.chk_LowerText.Text = "소문자 [a - z]";
            this.chk_LowerText.UseVisualStyleBackColor = true;
            // 
            // chk_UpperText
            // 
            this.chk_UpperText.AutoSize = true;
            this.chk_UpperText.Location = new System.Drawing.Point(15, 33);
            this.chk_UpperText.Name = "chk_UpperText";
            this.chk_UpperText.Size = new System.Drawing.Size(129, 19);
            this.chk_UpperText.TabIndex = 0;
            this.chk_UpperText.Text = "대문자 [A - Z]";
            this.chk_UpperText.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 301);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(434, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btn_Execution
            // 
            this.btn_Execution.Location = new System.Drawing.Point(362, 335);
            this.btn_Execution.Name = "btn_Execution";
            this.btn_Execution.Size = new System.Drawing.Size(96, 29);
            this.btn_Execution.TabIndex = 6;
            this.btn_Execution.Text = "작업 실행";
            this.btn_Execution.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 394);
            this.Controls.Add(this.btn_Execution);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.txtBox_Path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_SpecialText;
        private System.Windows.Forms.CheckBox chk_Number;
        private System.Windows.Forms.CheckBox chk_LowerText;
        private System.Windows.Forms.CheckBox chk_UpperText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtBox_EndText;
        private System.Windows.Forms.TextBox txtBox_StartText;
        private System.Windows.Forms.Button btn_Execution;
    }
}

