namespace QuizShowProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnC = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.LblTrue = new System.Windows.Forms.Label();
            this.LblFalse = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblQuestionTrue = new System.Windows.Forms.Label();
            this.LblVote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 119);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(-1, 189);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(158, 33);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Question : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "True : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "False : ";
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Location = new System.Drawing.Point(506, 24);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(19, 20);
            this.LblQuestion.TabIndex = 8;
            this.LblQuestion.Text = "0";
            // 
            // LblTrue
            // 
            this.LblTrue.AutoSize = true;
            this.LblTrue.Location = new System.Drawing.Point(506, 54);
            this.LblTrue.Name = "LblTrue";
            this.LblTrue.Size = new System.Drawing.Size(19, 20);
            this.LblTrue.TabIndex = 9;
            this.LblTrue.Text = "0";
            // 
            // LblFalse
            // 
            this.LblFalse.AutoSize = true;
            this.LblFalse.Location = new System.Drawing.Point(506, 84);
            this.LblFalse.Name = "LblFalse";
            this.LblFalse.Size = new System.Drawing.Size(19, 20);
            this.LblFalse.TabIndex = 10;
            this.LblFalse.Text = "0";
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(408, 120);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(117, 25);
            this.BtnNext.TabIndex = 11;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(208, 189);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(158, 33);
            this.BtnD.TabIndex = 13;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(208, 136);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(158, 33);
            this.BtnB.TabIndex = 14;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(-1, 136);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(158, 33);
            this.BtnA.TabIndex = 15;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(470, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // LblQuestionTrue
            // 
            this.LblQuestionTrue.AutoSize = true;
            this.LblQuestionTrue.Location = new System.Drawing.Point(376, 273);
            this.LblQuestionTrue.Name = "LblQuestionTrue";
            this.LblQuestionTrue.Size = new System.Drawing.Size(57, 20);
            this.LblQuestionTrue.TabIndex = 17;
            this.LblQuestionTrue.Text = "label1";
            // 
            // LblVote
            // 
            this.LblVote.AutoSize = true;
            this.LblVote.Location = new System.Drawing.Point(376, 302);
            this.LblVote.Name = "LblVote";
            this.LblVote.Size = new System.Drawing.Size(57, 20);
            this.LblVote.TabIndex = 18;
            this.LblVote.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.LblVote);
            this.Controls.Add(this.LblQuestionTrue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LblFalse);
            this.Controls.Add(this.LblTrue);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Label LblTrue;
        private System.Windows.Forms.Label LblFalse;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblQuestionTrue;
        private System.Windows.Forms.Label LblVote;
    }
}

