using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTest
{
    public partial class typingTest : Form
    {
        private bool statusChanged = false; //flag to indicate whether the timer has been started or not
        private int secondsElapsed = 0; //int to hold the number of seconds since the user began typing
        private int wordCount = 0; //keep track of the last-computed word count; used to print it out at the end

        public typingTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if (!statusChanged)
            {
                testTimer.Start(); //start the timer if it hasn't been started yet
                statusChanged = true; //set the flag indicating the timer has been started
            }

            //below is where I do the word counting
            //rather than using some standard like "Every five characters is a word," I am using tokens made up of non-whitespace separated by whitespace to represent words

            string text = inputBox.Text.Trim();
            int index = 0;   //i'd like to keep a running tab of the index so that I don't have to start at the beginning each time
            //but I'd also rather not have to do the extra accounting for when the user deletes a bunch of characters, which would invalidate the index
            //luckily, the character count shouldn't get too high, so it doesn't really matter that it goes through the whole text each time the user modifies it

            wordCount = 0; //reset the last-computed word count to zero, so it can be recalculated
            while (index < text.Length)
            {          
                //check if current character is not whitespace; if so, it is a part (or all) of a word; skip through the word til you find whitespace again
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
                    index++;

                wordCount++;    //if a word was just found, increase the word count

                //go through the whitespace until another word is found (or end of text)
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
                    index++;
            }

            wordCountPanel.Text = "Word Count: " + wordCount.ToString();

            //below I will check if the user's input matches the length (in character count) of the prompt   
            //if so, the inputBox is set to read-only and the timer is stopped

            if (inputBox.Text.Length >= promptLabel.Text.Length) //has the user input a number of characters equal to (or greater than, if they copy-paste) those in the prompt?
            {
                //if so, stop them from adding more characters and stop the timer
                inputBox.Enabled = false;
                testTimer.Stop();
                completionLabel.Text = "You have finished the test! Errors are displayed below. The time elapsed, your word-count, words-per-minute, and error percentage are displayed to the right."; //tell them the test is done
                if (secondsElapsed == 0)
                {
                    wordMinuteLabel.Text = "Your typing speed is infinite!"; //if they manage to finish instantly, most likely with copy-paste
                }
                else
                {
                    wordMinuteLabel.Text = "Typing Speed: " + ((wordCount * 60.0f / secondsElapsed)).ToString("F2") + " words per minute."; //calculate the number of words per minute
                }
                highlight_Errors();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            statusLabel.Text = "Seconds Elapsed: " + secondsElapsed.ToString(); //get the label to list the new seconds elapsed count
        }

        private void highlight_Errors()
        {
            int errorCount = 0; //an int to hold the total number of characters that are in error
            for (int i = 0; i < promptLabel.Text.Length; i++)
            { //we let the index go to the length of the prompt, and not the input, as the user may have input something far longer than the prompt via copy and paste
                if (inputBox.Text[i] != promptLabel.Text[i])
                {
                    errorCount++;
                    inputBox.SelectionStart = i;    //chose the errored character for highlighting
                    inputBox.SelectionLength = 1;
                    inputBox.SelectionBackColor = Color.Red;    //highlight the error in red
                }
            }
            inputBox.SelectionStart = 0;    //make sure nothing is being highlighted extraneously when the test is over
            inputBox.SelectionLength = 0;

            errorCount += (inputBox.Text.Length - promptLabel.Text.Length); //any extra input characters due to copy-paste?

            //now we calculate error percentage and display it
            errorPercentLabel.Text = "Error Percentage: " + ( (errorCount * 100.0f) / (promptLabel.Text.Length) ).ToString("F2") + "%";
        }
        
    }
}
