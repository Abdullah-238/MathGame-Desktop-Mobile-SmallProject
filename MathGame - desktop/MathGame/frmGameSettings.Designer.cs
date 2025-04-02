namespace MathGame
{
    partial class Form2
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
            this.lbMathGame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMathGame
            // 
            this.lbMathGame.AutoSize = true;
            this.lbMathGame.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMathGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMathGame.Location = new System.Drawing.Point(14, 210);
            this.lbMathGame.Name = "lbMathGame";
            this.lbMathGame.Size = new System.Drawing.Size(323, 42);
            this.lbMathGame.TabIndex = 2;
            this.lbMathGame.Text = "Select Quesation Level :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Operation Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 82);
            this.label2.TabIndex = 5;
            this.label2.Text = "Math Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(590, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "How many Quesation do you want to answer ?";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F);
            this.numericUpDown1.Location = new System.Drawing.Point(600, 135);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 49);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMix);
            this.groupBox1.Controls.Add(this.rbDiv);
            this.groupBox1.Controls.Add(this.rbMult);
            this.groupBox1.Controls.Add(this.rbSub);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Location = new System.Drawing.Point(333, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMix.Location = new System.Drawing.Point(430, 14);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(69, 36);
            this.rbMix.TabIndex = 20;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDiv.Location = new System.Drawing.Point(333, 14);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(66, 36);
            this.rbDiv.TabIndex = 19;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "Div";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMult.Location = new System.Drawing.Point(221, 14);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(81, 36);
            this.rbMult.TabIndex = 18;
            this.rbMult.TabStop = true;
            this.rbMult.Text = "Multi";
            this.rbMult.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSub.Location = new System.Drawing.Point(117, 14);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(73, 36);
            this.rbSub.TabIndex = 17;
            this.rbSub.TabStop = true;
            this.rbSub.Text = "Sub";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAdd.Location = new System.Drawing.Point(13, 14);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(73, 36);
            this.rbAdd.TabIndex = 16;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHard);
            this.groupBox2.Controls.Add(this.rbMed);
            this.groupBox2.Controls.Add(this.rbEasy);
            this.groupBox2.Location = new System.Drawing.Point(337, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 54);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbHard.Location = new System.Drawing.Point(418, 12);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(81, 36);
            this.rbHard.TabIndex = 11;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMed.Location = new System.Drawing.Point(218, 12);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(77, 36);
            this.rbMed.TabIndex = 10;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Med";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbEasy.Location = new System.Drawing.Point(9, 12);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(86, 36);
            this.rbEasy.TabIndex = 9;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy ";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMathGame);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMathGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbEasy;
    }
}