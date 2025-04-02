namespace MathGame
{
    partial class frmResult
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRestartGame = new System.Windows.Forms.Button();
            this.lbMathGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNumberOfQuesations = new System.Windows.Forms.Label();
            this.lbQuesationLevel = new System.Windows.Forms.Label();
            this.lbOperationLevel = new System.Windows.Forms.Label();
            this.lbRigthQuesation = new System.Windows.Forms.Label();
            this.lbWrongQuesation = new System.Windows.Forms.Label();
            this.lbFinalResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "Number of Quesation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 82);
            this.label2.TabIndex = 23;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Operation Type :";
            // 
            // lbRestartGame
            // 
            this.lbRestartGame.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestartGame.Location = new System.Drawing.Point(122, 595);
            this.lbRestartGame.Name = "lbRestartGame";
            this.lbRestartGame.Size = new System.Drawing.Size(323, 54);
            this.lbRestartGame.TabIndex = 21;
            this.lbRestartGame.Text = "Restart Game";
            this.lbRestartGame.UseVisualStyleBackColor = true;
            this.lbRestartGame.Click += new System.EventHandler(this.lbRestartGame_Click);
            // 
            // lbMathGame
            // 
            this.lbMathGame.AutoSize = true;
            this.lbMathGame.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMathGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMathGame.Location = new System.Drawing.Point(60, 271);
            this.lbMathGame.Name = "lbMathGame";
            this.lbMathGame.Size = new System.Drawing.Size(237, 42);
            this.lbMathGame.TabIndex = 20;
            this.lbMathGame.Text = "Quesation Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 42);
            this.label4.TabIndex = 25;
            this.label4.Text = "Right Quesation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(60, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 42);
            this.label5.TabIndex = 26;
            this.label5.Text = "Wrong Quesation :";
            // 
            // lbNumberOfQuesations
            // 
            this.lbNumberOfQuesations.AutoSize = true;
            this.lbNumberOfQuesations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumberOfQuesations.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfQuesations.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNumberOfQuesations.Location = new System.Drawing.Point(392, 187);
            this.lbNumberOfQuesations.Name = "lbNumberOfQuesations";
            this.lbNumberOfQuesations.Size = new System.Drawing.Size(78, 49);
            this.lbNumberOfQuesations.TabIndex = 27;
            this.lbNumberOfQuesations.Text = "N/A";
            // 
            // lbQuesationLevel
            // 
            this.lbQuesationLevel.AutoSize = true;
            this.lbQuesationLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuesationLevel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuesationLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbQuesationLevel.Location = new System.Drawing.Point(392, 268);
            this.lbQuesationLevel.Name = "lbQuesationLevel";
            this.lbQuesationLevel.Size = new System.Drawing.Size(78, 49);
            this.lbQuesationLevel.TabIndex = 28;
            this.lbQuesationLevel.Text = "N/A";
            // 
            // lbOperationLevel
            // 
            this.lbOperationLevel.AutoSize = true;
            this.lbOperationLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbOperationLevel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperationLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbOperationLevel.Location = new System.Drawing.Point(392, 349);
            this.lbOperationLevel.Name = "lbOperationLevel";
            this.lbOperationLevel.Size = new System.Drawing.Size(78, 49);
            this.lbOperationLevel.TabIndex = 29;
            this.lbOperationLevel.Text = "N/A";
            // 
            // lbRigthQuesation
            // 
            this.lbRigthQuesation.AutoSize = true;
            this.lbRigthQuesation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRigthQuesation.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRigthQuesation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRigthQuesation.Location = new System.Drawing.Point(392, 430);
            this.lbRigthQuesation.Name = "lbRigthQuesation";
            this.lbRigthQuesation.Size = new System.Drawing.Size(78, 49);
            this.lbRigthQuesation.TabIndex = 30;
            this.lbRigthQuesation.Text = "N/A";
            // 
            // lbWrongQuesation
            // 
            this.lbWrongQuesation.AutoSize = true;
            this.lbWrongQuesation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWrongQuesation.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongQuesation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbWrongQuesation.Location = new System.Drawing.Point(392, 511);
            this.lbWrongQuesation.Name = "lbWrongQuesation";
            this.lbWrongQuesation.Size = new System.Drawing.Size(78, 49);
            this.lbWrongQuesation.TabIndex = 31;
            this.lbWrongQuesation.Text = "N/A";
            // 
            // lbFinalResult
            // 
            this.lbFinalResult.AutoSize = true;
            this.lbFinalResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFinalResult.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFinalResult.Location = new System.Drawing.Point(392, 103);
            this.lbFinalResult.Name = "lbFinalResult";
            this.lbFinalResult.Size = new System.Drawing.Size(78, 49);
            this.lbFinalResult.TabIndex = 33;
            this.lbFinalResult.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(60, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 42);
            this.label7.TabIndex = 32;
            this.label7.Text = "Final Result :";
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 683);
            this.Controls.Add(this.lbFinalResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbWrongQuesation);
            this.Controls.Add(this.lbRigthQuesation);
            this.Controls.Add(this.lbOperationLevel);
            this.Controls.Add(this.lbQuesationLevel);
            this.Controls.Add(this.lbNumberOfQuesations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRestartGame);
            this.Controls.Add(this.lbMathGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbRestartGame;
        private System.Windows.Forms.Label lbMathGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNumberOfQuesations;
        private System.Windows.Forms.Label lbQuesationLevel;
        private System.Windows.Forms.Label lbOperationLevel;
        private System.Windows.Forms.Label lbRigthQuesation;
        private System.Windows.Forms.Label lbWrongQuesation;
        private System.Windows.Forms.Label lbFinalResult;
        private System.Windows.Forms.Label label7;
    }
}