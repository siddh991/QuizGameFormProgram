//Author: Siddharth Surana
//File Name: frmQuiz.cs
//Project Name: Quiz
//Creation Date: Nov. 7, 2015
//Modified Date: Nov. 15, 2015
//Description: This program is a quiz game on the topic of Nature that will ask the user 15 questions. A score will
//             be given to the user based on their answers' speed, question difficulty and if it is correct or not.
//             BONUS: sound effects for correct and incorrect answers
//             BONUS: background image 
//             BONUS: system that allows the user to get the answer one time throughout the game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frmQuiz : Form
    {
        //variables that will play sound files that can be used throughout the game
        System.Media.SoundPlayer correctAnsSound = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wrongAnsSound = new System.Media.SoundPlayer();

        //global variables that hold stats or are used to calculate stats
        byte questionNum;
        byte rightAnswerCount;
        int userScore = 0;
        int highScore = 0;
        int timePassed = 0;
        int totalTimePassed;
        int aveTimePerQuestion;
        int shortestRightAnswerTime;
        bool isAnswerValid;
        
        //constants that hold the ending question number of the easy, medium and hard sections
        const byte EASY_QUESTION_END = 5;
        const byte MED_QUESTION_END = 10;
        const byte HARD_QUESTION_END = 15;

        //string arrays that hold the questions, all answers and the correct answers are defined here
        string[] questions = new string[15];
        string[] questionAnswers = new string[60];
        string[] correctAnswers = new string[15];

        public frmQuiz()
        {
            InitializeComponent();

            //save the sound location to the variable
            correctAnsSound.SoundLocation = "correctAnsSound.wav";
            wrongAnsSound.SoundLocation = "wrongAnsSound.wav";

            //each element of the questions array is assigned a string value which are the questions
            questions[0] = "What types of trees have pine needles rather than leaves?";
            questions[1] = "What types of trees are found in warmer climates with wider leaves rather than pine needles?";
            questions[2] = "What tree species is known to grow the tallest?";
            questions[3] = "What do trees do to produce energy?";
            questions[4] = "Which country has the most trees?";
            questions[5] = "What is the definition subduction of plates?";
            questions[6] = "How fast does the north American plate move each year?";
            questions[7] = "Which ocean is shrinking due to north American plate tectonics?";
            questions[8] = "What is plate divergence? ";
            questions[9] = "In what country is the mid-Atlantic ridge exposed on land?";
            questions[10] = "How fast are water levels rising per year(on average)?";
            questions[11] = "What contains heat to the earth 25 times better than carbon dioxide?";
            questions[12] = "How much of the world’s carbon dioxide does USA produce?";
            questions[13] = "Which city is in threat of sinking due to global warming?";
            questions[14] = "What percent of Rocky Mountain glaciers may be gone by 2100 if current trends continue?";

            //each element of the questionAnswers array is assigned a string value which are all the possible answers
            questionAnswers[0] = "A - Spiky Trees";
            questionAnswers[1] = "B - Coniferous Trees";
            questionAnswers[2] = "C - Needle Trees";
            questionAnswers[3] = "D - Canadian Trees";
            questionAnswers[4] = "A - Deciduous Trees";
            questionAnswers[5] = "B - Leafy Trees";
            questionAnswers[6] = "C - Primary Trees";
            questionAnswers[7] = "D - Secondary Trees";
            questionAnswers[8] = "A - Palm Trees";
            questionAnswers[9] = "B - Christmas Trees";
            questionAnswers[10] = "C - Coast Redwoods";
            questionAnswers[11] = "D - Dandelion";
            questionAnswers[12] = "A - Eat Meat";
            questionAnswers[13] = "B - Eat Soil";
            questionAnswers[14] = "C - Photosynthesis";
            questionAnswers[15] = "D - Breath Oxygen";
            questionAnswers[16] = "A - India";
            questionAnswers[17] = "B - China";
            questionAnswers[18] = "C - Japan";
            questionAnswers[19] = "D - Russia";
            questionAnswers[20] = "A - The upward movement of a plate";
            questionAnswers[21] = "B - The downward and sideways movement of a plate into the mantle";
            questionAnswers[22] = "C - The upward and sideways movement of a city into the mantle";
            questionAnswers[23] = "D - The addition of land by cooling lava";
            questionAnswers[24] = "A - 1 inch";
            questionAnswers[25] = "B - 10 miles";
            questionAnswers[26] = "C - 700 inches";
            questionAnswers[27] = "D - half a mile";
            questionAnswers[28] = "A - Atlantic Ocean";
            questionAnswers[29] = "B - Pacific Ocean";
            questionAnswers[30] = "C - Arctic Ocean";
            questionAnswers[31] = "D - Indian Ocean";
            questionAnswers[32] = "A - Plates moving together";
            questionAnswers[33] = "B - Plates moving apart";
            questionAnswers[34] = "C - Plates moving up";
            questionAnswers[35] = "D - Touching plates moving against each other ";
            questionAnswers[36] = "A - Italy";
            questionAnswers[37] = "B - Japan";
            questionAnswers[38] = "C - Canada";
            questionAnswers[39] = "D - Iceland";
            questionAnswers[40] = "A - 2.75mm per year";
            questionAnswers[41] = "B - 100mm per year";
            questionAnswers[42] = "C - 2mm per year";
            questionAnswers[43] = "D - 20mm per year";
            questionAnswers[44] = "A - Carbon Monoxide";
            questionAnswers[45] = "B - Methane";
            questionAnswers[46] = "C - Nitrous Oxide";
            questionAnswers[47] = "D - Ozone";
            questionAnswers[48] = "A - 21%";
            questionAnswers[49] = "B - 23%";
            questionAnswers[50] = "C - 25%";
            questionAnswers[51] = "D - 26%";
            questionAnswers[52] = "A - Mexico City";
            questionAnswers[53] = "B - Bombay";
            questionAnswers[54] = "C - Nuuk";
            questionAnswers[55] = "D - Toronto";
            questionAnswers[56] = "A - 80%";
            questionAnswers[57] = "B - 95%";
            questionAnswers[58] = "C - 89%";
            questionAnswers[59] = "D - 90%";

            //each element of the correctAnswers array is assigned a string value which are all the correct answers
            correctAnswers[0] = "B";
            correctAnswers[1] = "A";
            correctAnswers[2] = "C";
            correctAnswers[3] = "C";
            correctAnswers[4] = "D";
            correctAnswers[5] = "B";
            correctAnswers[6] = "A";
            correctAnswers[7] = "B";
            correctAnswers[8] = "B";
            correctAnswers[9] = "D";
            correctAnswers[10] = "A";
            correctAnswers[11] = "B";
            correctAnswers[12] = "C";
            correctAnswers[13] = "A";
            correctAnswers[14] = "D";
        }

        //this subprogram will run if the start/restart button is clicked
        private void btnStartRestart_Click(object sender, EventArgs e)
        {
            //all display fields are cleared excpet for the high score
            lblAnswers.Text = "";
            lblDispScore.Text = "";
            lblPreviousQuestionInfo.Text = "";
            lblQuestionTimePassed.Text = "";
            lblAveTimePerQuestion.Text = "";
            lblNumOfCorrect.Text = "";
            lblFastestRightAnswer.Text = "";

            //all counters and stats are set to their starting value which is either 0 or 1
            questionNum = 1;
            userScore = 0;
            timePassed = 0;
            totalTimePassed = 0;
            aveTimePerQuestion = 0;           
            rightAnswerCount = 0;
            shortestRightAnswerTime = 0;

            //The stats and the submit section are displayed to the user
            lblInputTitle.Visible = true;
            txtUserAnswer.Visible = true;
            btnSubmit.Visible = true;
            lblScoreTitle.Visible = true;
            lblHighScoreTitle.Visible = true;
            lblPreviousQuestionTitle.Visible = true;
            lblQuestionTimePassedTitle.Visible = true;
            lblAveTimePerQuestionTitle.Visible = true;
            lblNumOfCorrectTitle.Visible = true;
            lblFastestRightAnswerTitle.Visible = true;
            btnGetAns.Visible = true;

            //a subprogram is run and the question number, the quesiton and the possible answers are sent to it
            DislpayQuestion(questionNum, questions, questionAnswers);
        }

        //this subprogram runs when the submit button is clicked and it checks if the answer is correct, calculates the average
        //time spent per question, continues to the next question and finally it displays the high score at the end of the game
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //checks if the answer submitted by the user is valid and correct through the function called CheckIfCorrect. It sends
            //the question number, correct answer and the users answer
            isAnswerValid = CheckIfCorrect(questionNum, correctAnswers[questionNum - 1], txtUserAnswer.Text);

            //checks if the answer submitted is valid
            if (isAnswerValid == true)
            {
                //clear the display area for question and the answers and the bonus given answer (one time use) section
                lblNumAndQuestion.Text = "";
                lblAnswers.Text = "";
                lblShowAns.Text = "";
                lblShowAnswerTitle.Visible = false;

                //checks if time passed is 0, and if it is, change it to 1 to prevent miscalculations 
                if (timePassed == 0)
                {
                    timePassed = 1;
                }

                //calculates the total time passed  
                totalTimePassed = totalTimePassed + timePassed;

                //set time passed to 0 for the next round and stop counting the time being passed
                timePassed = 0;
                tmrInterval.Enabled = false;

                //calculate the average time spent per question by dividing the total time passed by the number of completed questions
                aveTimePerQuestion = totalTimePassed / questionNum;

                //display the average time passed to the user
                lblAveTimePerQuestion.Text = Convert.ToString(aveTimePerQuestion) + " second(s)";

                //check if the game has not finished all 15 questions
                if (questionNum < HARD_QUESTION_END)
                {
                    //increase the current question number by one for the next question
                    questionNum++;

                    //call the DisplayQuestion subprogram to display the next question and the possible answers for it
                    DislpayQuestion(questionNum, questions, questionAnswers);
                }
                else
                {
                    //if the current question is the final question of the game, remove any input options
                    lblInputTitle.Visible = false;
                    txtUserAnswer.Visible = false;
                    btnSubmit.Visible = false;
                    btnGetAns.Visible = false;
                    
                    //check if the players final score is higher than the current high score
                    if (highScore < userScore)
                    {
                        //make the players score the new high score
                        highScore = userScore;

                        //display the new high score
                        lblHighScore.Text = Convert.ToString(highScore);
                    }

                    //display the final score to the user at the end of the game in a message box
                    MessageBox.Show("Your Final Score: " + userScore + "!");
                }
            }
        }

        //this subprogram will run when the user uses the get answer button which has a one time use
        private void btnGetAns_Click(object sender, EventArgs e)
        {
            //remove the button to give the answer because it is a one time use
            btnGetAns.Visible = false;

            //Show the title of the correct answer
            lblShowAnswerTitle.Visible = true;

            //show the current correct answer
            lblShowAns.Text = correctAnswers[questionNum - 1];
        }

        //this subprogram is used to calculate the amount of time that has passed since it is first called
        private void tmrInterval_Tick(object sender, EventArgs e)
        {
            //add one to the counter of the amount of time passed
            timePassed++;

            //display the amount of time passed to the user
            lblQuestionTimePassed.Text = Convert.ToString(timePassed) + " second(s)";
        }

        //this subprogram is used to present the question and possible answers to the user 
        private void DislpayQuestion(byte questionNum, string[] questions, string[] questionAnswers)
        {
            //clear whats in the user's answer box
            txtUserAnswer.Text = "";

            //start counting the time being passed
            tmrInterval.Enabled = true;

            //display the question number and question to the user
            lblNumAndQuestion.Text = "" + questionNum + ") " + questions[questionNum - 1];
            
            //display the four possible answers to the user 
            for (byte questionChange = 4; questionChange > 0; questionChange--)
            {
                lblAnswers.Text += "" + questionAnswers[(questionNum * 4) - questionChange] + "\n";
            }
        }

        //this function checks if the users answer is correct using the current question number, the correct answer, 
        //and the users answer
        private bool CheckIfCorrect(byte questionNum, string correctAnswer, string userAnswer)
        {
            //a variable that holds increase or decrease to the users score for each question
            int scoreAdjustment;

            //constants that hold the values of the score multipliers
            const byte EASY_SCORE_MULTIPLIER = 1;
            const byte MED_SCORE_MULTIPLIER = 2;
            const byte HARD_SCORE_MULTIPLIER = 3;
            const byte GENERAL_SCORE_MULTIPLIER = 100;

            //check if the users answer is a valid option (either A, B, C or D)
            if (userAnswer == "A" || userAnswer == "B" || userAnswer == "C" || userAnswer == "D")
            {
                //check if the user's answer is the correct answer
                if (correctAnswer == userAnswer)
                {
                    //checks if time passed is 0, and if it is, change it to 1 to prevent miscalculations 
                    if (timePassed == 0)
                    {
                        timePassed = 1;
                    }

                    //checks if the question is in the easy, medium or hard catagory
                    if (questionNum <= EASY_QUESTION_END)
                    {
                        //calculate the score increase by multiplying the question difficulty by 100 and dividing by time 
                        scoreAdjustment = (EASY_SCORE_MULTIPLIER * GENERAL_SCORE_MULTIPLIER) / timePassed;

                        //add the increase in score to the overall score
                        userScore += scoreAdjustment;

                        //display that the answer was correct and the score increase
                        lblPreviousQuestionInfo.Text = "Correct +" + scoreAdjustment;
                    }
                    else if (questionNum <= MED_QUESTION_END)
                    {
                        //calculate the score increase by multiplying the question difficulty by 100 and dividing by time 
                        scoreAdjustment = (MED_SCORE_MULTIPLIER * GENERAL_SCORE_MULTIPLIER) / timePassed;

                        //add the increase in score to the overall score
                        userScore += scoreAdjustment;

                        //display that the answer was correct and the score increase
                        lblPreviousQuestionInfo.Text = "Correct +" + scoreAdjustment;
                    }
                    else if (questionNum <= HARD_QUESTION_END)
                    {
                        //calculate the score increase by multiplying the question difficulty by 100 and dividing by time 
                        scoreAdjustment = (HARD_SCORE_MULTIPLIER * GENERAL_SCORE_MULTIPLIER) / timePassed;

                        //add the increase in score to the overall score
                        userScore += scoreAdjustment;

                        //display that the answer was correct and the score increase
                        lblPreviousQuestionInfo.Text = "Correct +" + scoreAdjustment;
                    }

                    //increase the total count of correct answers
                    rightAnswerCount++;

                    //play the sound effect for a correct answer
                    correctAnsSound.Play();

                    //display the new number of correct answers
                    lblNumOfCorrect.Text = Convert.ToString(rightAnswerCount);

                    //check if this question was the fastest correct answer 
                    if (shortestRightAnswerTime == 0 || timePassed < shortestRightAnswerTime)
                    {
                        //make the time passed the new fastest correct answer
                        shortestRightAnswerTime = timePassed;

                        //display the new fastest correct answer
                        lblFastestRightAnswer.Text = Convert.ToString(shortestRightAnswerTime) + " second(s)";

                    }
                }
                else
                {
                    //change the score adjustment to 10
                    scoreAdjustment = 10;

                    //subtract scoreAdjustment from  the user's score
                    userScore = userScore - scoreAdjustment;

                    //display that the answer was incorrect and the score decrease
                    lblPreviousQuestionInfo.Text = "Incorrect -10";

                    //play the sound effect for an incorrect answer
                    wrongAnsSound.Play();
                }

                //display the new score of the user
                lblDispScore.Text = Convert.ToString(userScore);

                //return a true value to where the function was called so it is known that the answer was valid
                return true;
            }
            else
            {
                //display a message box stating that the entered answer is invalid
                MessageBox.Show("INVALID INPUT\nPlease choose a letter representing a given answer");

                //return a false value to where the function was called so it is known that the answer was invalid
                return false;
            }
        }
    }
}