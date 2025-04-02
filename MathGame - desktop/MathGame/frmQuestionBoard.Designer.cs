namespace MathGame
{
    partial class frmQuestionBoard
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbQuesationNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumberOfQuesation = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.txInput = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quesation  :";
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.Location = new System.Drawing.Point(12, 159);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(112, 49);
            this.lbNum1.TabIndex = 1;
            this.lbNum1.Text = "Num1 ";
            // 
            // lbQuesationNumber
            // 
            this.lbQuesationNumber.AutoSize = true;
            this.lbQuesationNumber.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuesationNumber.Location = new System.Drawing.Point(201, 88);
            this.lbQuesationNumber.Name = "lbQuesationNumber";
            this.lbQuesationNumber.Size = new System.Drawing.Size(46, 49);
            this.lbQuesationNumber.TabIndex = 2;
            this.lbQuesationNumber.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 56);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            // 
            // lbNumberOfQuesation
            // 
            this.lbNumberOfQuesation.AutoSize = true;
            this.lbNumberOfQuesation.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfQuesation.Location = new System.Drawing.Point(280, 88);
            this.lbNumberOfQuesation.Name = "lbNumberOfQuesation";
            this.lbNumberOfQuesation.Size = new System.Drawing.Size(46, 49);
            this.lbNumberOfQuesation.TabIndex = 4;
            this.lbNumberOfQuesation.Text = "N";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperation.Location = new System.Drawing.Point(130, 220);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(65, 49);
            this.lbOperation.TabIndex = 6;
            this.lbOperation.Text = "Op";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 49);
            this.label8.TabIndex = 7;
            this.label8.Text = "________________";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.Location = new System.Drawing.Point(12, 220);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(109, 49);
            this.lbNum2.TabIndex = 5;
            this.lbNum2.Text = "Num2";
            // 
            // txInput
            // 
            this.txInput.Location = new System.Drawing.Point(21, 321);
            this.txInput.Multiline = true;
            this.txInput.Name = "txInput";
            this.txInput.Size = new System.Drawing.Size(302, 51);
            this.txInput.TabIndex = 8;
            this.txInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btCheck
            // 
            this.btCheck.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(21, 410);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(302, 62);
            this.btCheck.TabIndex = 9;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 56);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quizz";
            // 
            // frmQuesationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.txInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNumberOfQuesation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQuesationNumber);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuesationBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions Board";
            this.Load += new System.EventHandler(this.frmQuesationBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbQuesationNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumberOfQuesation;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox txInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label2;
    }
}