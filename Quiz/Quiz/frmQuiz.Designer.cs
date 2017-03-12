namespace Quiz
{
    partial class frmQuiz
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
            this.components = new System.ComponentModel.Container();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnStartRestart = new System.Windows.Forms.Button();
            this.lblNumAndQuestion = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tmrInterval = new System.Windows.Forms.Timer(this.components);
            this.lblPreviousQuestionTitle = new System.Windows.Forms.Label();
            this.lblPreviousQuestionInfo = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblDispScore = new System.Windows.Forms.Label();
            this.lblQuestionTimePassedTitle = new System.Windows.Forms.Label();
            this.lblQuestionTimePassed = new System.Windows.Forms.Label();
            this.lblAveTimePerQuestionTitle = new System.Windows.Forms.Label();
            this.lblAveTimePerQuestion = new System.Windows.Forms.Label();
            this.lblNumOfCorrectTitle = new System.Windows.Forms.Label();
            this.lblNumOfCorrect = new System.Windows.Forms.Label();
            this.lblFastestRightAnswerTitle = new System.Windows.Forms.Label();
            this.lblFastestRightAnswer = new System.Windows.Forms.Label();
            this.lblHighScoreTitle = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnGetAns = new System.Windows.Forms.Button();
            this.lblShowAnswerTitle = new System.Windows.Forms.Label();
            this.lblShowAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Viner Hand ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameTitle.Location = new System.Drawing.Point(3, 40);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(430, 78);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "The Nature Quiz";
            // 
            // btnStartRestart
            // 
            this.btnStartRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnStartRestart.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRestart.Location = new System.Drawing.Point(452, 61);
            this.btnStartRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartRestart.Name = "btnStartRestart";
            this.btnStartRestart.Size = new System.Drawing.Size(207, 35);
            this.btnStartRestart.TabIndex = 1;
            this.btnStartRestart.Text = "START/RESTART";
            this.btnStartRestart.UseVisualStyleBackColor = false;
            this.btnStartRestart.Click += new System.EventHandler(this.btnStartRestart_Click);
            // 
            // lblNumAndQuestion
            // 
            this.lblNumAndQuestion.AutoSize = true;
            this.lblNumAndQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblNumAndQuestion.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAndQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumAndQuestion.Location = new System.Drawing.Point(14, 182);
            this.lblNumAndQuestion.Name = "lblNumAndQuestion";
            this.lblNumAndQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblNumAndQuestion.TabIndex = 2;
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswers.Location = new System.Drawing.Point(14, 219);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(0, 20);
            this.lblAnswers.TabIndex = 3;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblInputTitle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInputTitle.Location = new System.Drawing.Point(12, 378);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(254, 20);
            this.lblInputTitle.TabIndex = 4;
            this.lblInputTitle.Text = "Answer (letter beside answer):";
            this.lblInputTitle.Visible = false;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserAnswer.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(283, 375);
            this.txtUserAnswer.MaxLength = 1;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(100, 27);
            this.txtUserAnswer.TabIndex = 5;
            this.txtUserAnswer.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(398, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tmrInterval
            // 
            this.tmrInterval.Interval = 1000;
            this.tmrInterval.Tick += new System.EventHandler(this.tmrInterval_Tick);
            // 
            // lblPreviousQuestionTitle
            // 
            this.lblPreviousQuestionTitle.AutoSize = true;
            this.lblPreviousQuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviousQuestionTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblPreviousQuestionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreviousQuestionTitle.Location = new System.Drawing.Point(848, 148);
            this.lblPreviousQuestionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreviousQuestionTitle.Name = "lblPreviousQuestionTitle";
            this.lblPreviousQuestionTitle.Size = new System.Drawing.Size(178, 22);
            this.lblPreviousQuestionTitle.TabIndex = 8;
            this.lblPreviousQuestionTitle.Text = "Previous Question:";
            this.lblPreviousQuestionTitle.Visible = false;
            // 
            // lblPreviousQuestionInfo
            // 
            this.lblPreviousQuestionInfo.AutoSize = true;
            this.lblPreviousQuestionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviousQuestionInfo.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblPreviousQuestionInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreviousQuestionInfo.Location = new System.Drawing.Point(1115, 148);
            this.lblPreviousQuestionInfo.Name = "lblPreviousQuestionInfo";
            this.lblPreviousQuestionInfo.Size = new System.Drawing.Size(0, 22);
            this.lblPreviousQuestionInfo.TabIndex = 9;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreTitle.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.ForeColor = System.Drawing.Color.Red;
            this.lblScoreTitle.Location = new System.Drawing.Point(848, 48);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(107, 32);
            this.lblScoreTitle.TabIndex = 10;
            this.lblScoreTitle.Text = "Score:";
            this.lblScoreTitle.Visible = false;
            // 
            // lblDispScore
            // 
            this.lblDispScore.AutoSize = true;
            this.lblDispScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDispScore.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold);
            this.lblDispScore.ForeColor = System.Drawing.Color.Red;
            this.lblDispScore.Location = new System.Drawing.Point(1115, 48);
            this.lblDispScore.Name = "lblDispScore";
            this.lblDispScore.Size = new System.Drawing.Size(0, 32);
            this.lblDispScore.TabIndex = 11;
            // 
            // lblQuestionTimePassedTitle
            // 
            this.lblQuestionTimePassedTitle.AutoSize = true;
            this.lblQuestionTimePassedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionTimePassedTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblQuestionTimePassedTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionTimePassedTitle.Location = new System.Drawing.Point(848, 198);
            this.lblQuestionTimePassedTitle.Name = "lblQuestionTimePassedTitle";
            this.lblQuestionTimePassedTitle.Size = new System.Drawing.Size(239, 22);
            this.lblQuestionTimePassedTitle.TabIndex = 12;
            this.lblQuestionTimePassedTitle.Text = "Time Since Last Question:";
            this.lblQuestionTimePassedTitle.Visible = false;
            // 
            // lblQuestionTimePassed
            // 
            this.lblQuestionTimePassed.AutoSize = true;
            this.lblQuestionTimePassed.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionTimePassed.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblQuestionTimePassed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionTimePassed.Location = new System.Drawing.Point(1115, 198);
            this.lblQuestionTimePassed.Name = "lblQuestionTimePassed";
            this.lblQuestionTimePassed.Size = new System.Drawing.Size(0, 22);
            this.lblQuestionTimePassed.TabIndex = 13;
            // 
            // lblAveTimePerQuestionTitle
            // 
            this.lblAveTimePerQuestionTitle.AutoSize = true;
            this.lblAveTimePerQuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAveTimePerQuestionTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblAveTimePerQuestionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAveTimePerQuestionTitle.Location = new System.Drawing.Point(848, 248);
            this.lblAveTimePerQuestionTitle.Name = "lblAveTimePerQuestionTitle";
            this.lblAveTimePerQuestionTitle.Size = new System.Drawing.Size(256, 22);
            this.lblAveTimePerQuestionTitle.TabIndex = 14;
            this.lblAveTimePerQuestionTitle.Text = "Average Time Per Question:";
            this.lblAveTimePerQuestionTitle.Visible = false;
            // 
            // lblAveTimePerQuestion
            // 
            this.lblAveTimePerQuestion.AutoSize = true;
            this.lblAveTimePerQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblAveTimePerQuestion.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblAveTimePerQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAveTimePerQuestion.Location = new System.Drawing.Point(1115, 248);
            this.lblAveTimePerQuestion.Name = "lblAveTimePerQuestion";
            this.lblAveTimePerQuestion.Size = new System.Drawing.Size(0, 22);
            this.lblAveTimePerQuestion.TabIndex = 15;
            // 
            // lblNumOfCorrectTitle
            // 
            this.lblNumOfCorrectTitle.AutoSize = true;
            this.lblNumOfCorrectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfCorrectTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblNumOfCorrectTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumOfCorrectTitle.Location = new System.Drawing.Point(848, 298);
            this.lblNumOfCorrectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfCorrectTitle.Name = "lblNumOfCorrectTitle";
            this.lblNumOfCorrectTitle.Size = new System.Drawing.Size(263, 22);
            this.lblNumOfCorrectTitle.TabIndex = 16;
            this.lblNumOfCorrectTitle.Text = "Number Of Correct Answers:";
            this.lblNumOfCorrectTitle.Visible = false;
            // 
            // lblNumOfCorrect
            // 
            this.lblNumOfCorrect.AutoSize = true;
            this.lblNumOfCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfCorrect.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblNumOfCorrect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumOfCorrect.Location = new System.Drawing.Point(1115, 297);
            this.lblNumOfCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfCorrect.Name = "lblNumOfCorrect";
            this.lblNumOfCorrect.Size = new System.Drawing.Size(0, 22);
            this.lblNumOfCorrect.TabIndex = 17;
            // 
            // lblFastestRightAnswerTitle
            // 
            this.lblFastestRightAnswerTitle.AutoSize = true;
            this.lblFastestRightAnswerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFastestRightAnswerTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblFastestRightAnswerTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFastestRightAnswerTitle.Location = new System.Drawing.Point(848, 348);
            this.lblFastestRightAnswerTitle.Name = "lblFastestRightAnswerTitle";
            this.lblFastestRightAnswerTitle.Size = new System.Drawing.Size(222, 22);
            this.lblFastestRightAnswerTitle.TabIndex = 18;
            this.lblFastestRightAnswerTitle.Text = "Fastest Correct Answer:";
            this.lblFastestRightAnswerTitle.Visible = false;
            // 
            // lblFastestRightAnswer
            // 
            this.lblFastestRightAnswer.AutoSize = true;
            this.lblFastestRightAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblFastestRightAnswer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblFastestRightAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFastestRightAnswer.Location = new System.Drawing.Point(1115, 348);
            this.lblFastestRightAnswer.Name = "lblFastestRightAnswer";
            this.lblFastestRightAnswer.Size = new System.Drawing.Size(0, 22);
            this.lblFastestRightAnswer.TabIndex = 19;
            // 
            // lblHighScoreTitle
            // 
            this.lblHighScoreTitle.AutoSize = true;
            this.lblHighScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScoreTitle.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold);
            this.lblHighScoreTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblHighScoreTitle.Location = new System.Drawing.Point(848, 98);
            this.lblHighScoreTitle.Name = "lblHighScoreTitle";
            this.lblHighScoreTitle.Size = new System.Drawing.Size(183, 32);
            this.lblHighScoreTitle.TabIndex = 20;
            this.lblHighScoreTitle.Text = "High Score:";
            this.lblHighScoreTitle.Visible = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold);
            this.lblHighScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblHighScore.Location = new System.Drawing.Point(1115, 98);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 32);
            this.lblHighScore.TabIndex = 21;
            // 
            // btnGetAns
            // 
            this.btnGetAns.Location = new System.Drawing.Point(848, 378);
            this.btnGetAns.Name = "btnGetAns";
            this.btnGetAns.Size = new System.Drawing.Size(107, 43);
            this.btnGetAns.TabIndex = 22;
            this.btnGetAns.Text = "Get Answer";
            this.btnGetAns.UseVisualStyleBackColor = true;
            this.btnGetAns.Visible = false;
            this.btnGetAns.Click += new System.EventHandler(this.btnGetAns_Click);
            // 
            // lblShowAnswerTitle
            // 
            this.lblShowAnswerTitle.AutoSize = true;
            this.lblShowAnswerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAnswerTitle.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblShowAnswerTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowAnswerTitle.Location = new System.Drawing.Point(848, 397);
            this.lblShowAnswerTitle.Name = "lblShowAnswerTitle";
            this.lblShowAnswerTitle.Size = new System.Drawing.Size(80, 22);
            this.lblShowAnswerTitle.TabIndex = 23;
            this.lblShowAnswerTitle.Text = "Answer:";
            this.lblShowAnswerTitle.Visible = false;
            // 
            // lblShowAns
            // 
            this.lblShowAns.AutoSize = true;
            this.lblShowAns.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAns.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.lblShowAns.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShowAns.Location = new System.Drawing.Point(1115, 398);
            this.lblShowAns.Name = "lblShowAns";
            this.lblShowAns.Size = new System.Drawing.Size(0, 22);
            this.lblShowAns.TabIndex = 24;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources.done3;
            this.ClientSize = new System.Drawing.Size(1261, 428);
            this.Controls.Add(this.lblShowAns);
            this.Controls.Add(this.lblShowAnswerTitle);
            this.Controls.Add(this.btnGetAns);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreTitle);
            this.Controls.Add(this.lblFastestRightAnswer);
            this.Controls.Add(this.lblFastestRightAnswerTitle);
            this.Controls.Add(this.lblNumOfCorrect);
            this.Controls.Add(this.lblNumOfCorrectTitle);
            this.Controls.Add(this.lblAveTimePerQuestion);
            this.Controls.Add(this.lblAveTimePerQuestionTitle);
            this.Controls.Add(this.lblQuestionTimePassed);
            this.Controls.Add(this.lblQuestionTimePassedTitle);
            this.Controls.Add(this.lblDispScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblPreviousQuestionInfo);
            this.Controls.Add(this.lblPreviousQuestionTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblInputTitle);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.lblNumAndQuestion);
            this.Controls.Add(this.btnStartRestart);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "frmQuiz";
            this.Text = "The Nature Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnStartRestart;
        private System.Windows.Forms.Label lblNumAndQuestion;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer tmrInterval;
        private System.Windows.Forms.Label lblPreviousQuestionTitle;
        private System.Windows.Forms.Label lblPreviousQuestionInfo;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblDispScore;
        private System.Windows.Forms.Label lblQuestionTimePassedTitle;
        private System.Windows.Forms.Label lblQuestionTimePassed;
        private System.Windows.Forms.Label lblAveTimePerQuestionTitle;
        private System.Windows.Forms.Label lblAveTimePerQuestion;
        private System.Windows.Forms.Label lblNumOfCorrectTitle;
        private System.Windows.Forms.Label lblNumOfCorrect;
        private System.Windows.Forms.Label lblFastestRightAnswerTitle;
        private System.Windows.Forms.Label lblFastestRightAnswer;
        private System.Windows.Forms.Label lblHighScoreTitle;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnGetAns;
        private System.Windows.Forms.Label lblShowAnswerTitle;
        private System.Windows.Forms.Label lblShowAns;
    }
}

