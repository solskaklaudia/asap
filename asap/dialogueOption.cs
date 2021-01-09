using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Class <c>dialogueOption</c> describes dialogue option objects properties and their functionality
    /// </summary>
    class dialogueOption
    {
        /// <summary>Collection with all the dialogue options</summary>
        public static List<dialogueOption> dialogueList = new List<dialogueOption>();
        /// <summary>Text of the dialogue option</summary>
        public string text;
        /// <summary>Array containing the numbers of next dialogue options from dialogueList</summary>
        string[] nextDialogueOptions = new string[2];
        /// <summary>What the character will say after clicking this option</summary>
        string characterText;
        /// <summary>What character image to display after clicking this option</summary>
        string characterImage;
        /// <summary>If clicking this option will reveal some symptom</summary>
        string characterSymptom;

        /// <summary>
        /// <c>dialogueOption</c> constructor
        /// </summary>
        public dialogueOption(string txt, string d1, string d2, string chartxt, string charim, string charsym)
        {
            // setting object parameter values
            this.text = txt;
            this.nextDialogueOptions[0] = d1;
            this.nextDialogueOptions[1] = d2;
            this.characterText = chartxt;
            this.characterImage = charim;
            this.characterSymptom = charsym;

            dialogueList.Add(this); // adding the dialogue object to collection
        }

        /// <summary>
        /// Method <c>nextDialogue</c> loads new dialogue options, character text and character expression; adds new symptom to the list if present
        /// </summary>
        /// <param name="number"></param> number of the chosen dialogue option
        /// <param name="gameWindow"></param> game window form
        /// <param name="scenario"></param> active scenario short name
        public static void nextDialogue(int number, game gameWindow, string scenario)
        {
            // setting the text for character
            gameWindow.charText.Text = dialogueList[number].characterText;

            // setting the character expression image
            string file_path = "..\\..\\res\\graphics\\game\\char\\" + scenario + "\\" + dialogueList[number].characterImage + ".png"; ;
            try
            {
                gameWindow.character.BackgroundImage = Image.FromFile(file_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // adding the character symptom to the list of scenario symptoms (if present)
            if (dialogueList[number].characterSymptom != "")
            {
                if (!gameWindow.scenario_symptoms.Contains(dialogueList[number].characterSymptom)) // if scenario doesn't contain the symptom already
                {
                    gameWindow.scenario_symptoms.Add(dialogueList[number].characterSymptom);
                }
            }

            // setting the text for next dialuge options
            gameWindow.dialogue1.Text = dialogueList[Int32.Parse(dialogueList[number].nextDialogueOptions[0])].text;
            gameWindow.dialogue2.Text = dialogueList[Int32.Parse(dialogueList[number].nextDialogueOptions[1])].text;

            // setting AccessibleDescription parameter for each dialogue option
            gameWindow.dialogue1.AccessibleDescription = dialogueList[number].nextDialogueOptions[0];
            gameWindow.dialogue2.AccessibleDescription = dialogueList[number].nextDialogueOptions[1];
        }

        /// <summary>
        /// Method <c>generateDialogues</c> generates dialogue objects for a scenario
        /// </summary>
        /// <param name="lang"></param> game language
        /// <param name="scenario"></param> illness scenario 
        public static void generateDialogues(string lang, string scenario)
        {
            dialogueOption.dialogueList.Clear(); // clears the dialogue list

            string file_path = "..\\..\\res\\txtres\\" + lang + "\\" + scenario + "_scenario.txt";
            try
            {
                string[] scn_lines = File.ReadAllLines(file_path); // reading text lines from file
                int count = 0; // line counter

                // variables to read parameters from text file
                string text = "";
                string d1 = "";
                string d2 = "";
                string chartxt = "";
                string charim = "";
                string charsym = "";

                foreach (string line in scn_lines)
                {
                    count++;

                    switch (count) // reading parameters from array to variables
                    {
                        case 1:
                            text = line;
                            break;
                        case 2:
                            d1 = line;
                            break;
                        case 3:
                            d2 = line;
                            break;
                        case 4:
                            chartxt = line;
                            break;
                        case 5:
                            charim = line;
                            break;
                        case 6:
                            charsym = line;
                            dialogueOption dial = new dialogueOption(text, d1, d2, chartxt, charim, charsym); // creating a dialogue object
                            count = 0; // reseting the counter
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
