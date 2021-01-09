using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace asap
{
    /// <summary>
    /// Partial class <c>finish</c> extending Form for game results screen of the game.
    /// </summary>
    public partial class finish : Form
    {
        /// <summary>
        /// <c>finish</c> form window constructor
        /// </summary>
        public finish(game Game, menu Menu, string language, int scenario, string susp, bool call, List<string> illlist, List<string> suspsym)
        {
            InitializeComponent();

            // setting variable values
            GameWindow = Game;
            MenuWindow = Menu;
            lang = language;
            illnesses = illlist;
            scenario_number = scenario;
            suspected_illness = susp;
            suspected_symptoms = suspsym;
            called = call;

            try
            {
                // reading symptoms from file
                string txt_file_path = "..\\..\\res\\txtres\\" + lang + "\\"; // string with text file resources path
                string[] symp = File.ReadAllLines(txt_file_path + game.scenarios[scenario_number] + "_symptoms.txt"); // reading symptoms for scenario illnes

                foreach (string s in symp)
                {
                    illness_symptoms.Add(s); // adding symptoms to List collection
                }

                // reading first aid info from file and displaying it
                string[] help = File.ReadAllLines(txt_file_path + game.scenarios[scenario_number] + "_help.txt");

                foreach (string h in help)
                {
                    firstAid.Text += "- " + h + "\n\n";
                }

                // adding image from file
                string img_file_path = "..\\..\\res\\graphics\\finish\\";
                image.BackgroundImage = Image.FromFile(img_file_path + game.scenarios[scenario_number] + "_image.jpg");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            displayedText();
            scoreCount();
        }

        /// <summary>
        /// Method <c>displayedText</c> displays the text information about user results, the scenario etc.
        /// </summary>
        private void displayedText()
        {
            string message = "";

            if (lang == "pl") // for Polish language
            {
                if (called) // sets message if user called the ambulance
                {
                    message = "Dzwonisz po pogotowie. ";

                    if (GameWindow.scenario_symptoms.Count > 2) // if there were at least 3 symptoms in the scenario
                    {
                        message += "Karetka została słusznie wezwana.";
                    }
                    else
                    {
                        message += "Nie pojawiły się prawie żadne niepokojące symptomy, karetka została wezwana niesłusznie.";
                    }

                    if (illnesses[scenario_number] == suspected_illness) // if suspected illness guessed correctly
                    {
                        message += "\nUdało ci się poprawnie określić chorobę " + suspected_illness + ".";

                    }
                    else
                    {
                        message += "\nNie udało ci się poprawnie określić choroby";
                        if (suspected_illness != "") // if there was a guess
                        {
                            message += " (twoje oznaczenie: " + suspected_illness + ")";
                        }
                        message += ".";
                    }
                }
                else // if ambulance wasn't called
                {
                    message = "Nie udało ci się zadzwonić w porę po pomoc, przegrywasz.";
                }
            }
            else if (lang == "eng") // English translation
            {
                calledPoints.Text = "Calling for help points: ";
                buttonExit.Text = "Back to the main menu";
                selectedSymptomsLabel.Text = "Selected symptoms:";
                remainingSymptomsLabel.Text = "Illness symptoms that weren't in this scenario:";
                finalScore.Text = "Final points score: ";
                illnessPoints.Text = "Points for selecting the illness: ";
                illnessLabel.Text = "Scenario: ";
                missedSymptomsLabel.Text = "Missed symptoms:";
                firstAidLabel.Text = "First aid:";

                if (called) // sets message if user called the ambulance
                {
                    message = "You've called the emergency. ";

                    if (GameWindow.scenario_symptoms.Count > 2) // if there were at least 3 symptoms in the scenario
                    {
                        message += "You were right to call the ambulance.";
                    }
                    else
                    {
                        message += "There were little or no illness symptoms, the ambulance wasn't needed.";
                    }

                    if (illnesses[scenario_number] == suspected_illness) // if suspected illness guessed correctly
                    {
                        message += "\nYou've corrently identified the illness " + suspected_illness + ".";

                    }
                    else
                    {
                        message += "\nYou didn't correctly identify the illness";
                        if (suspected_illness != "") // if there was a guess
                        {
                            message += " ((your guess: " + suspected_illness + ")";
                        }
                        message += ".";
                    }
                }
                else // if ambulance wasn't called
                {
                    message = "You didn't call the ambulance on time, you lose.";
                }
            }

            resultText.Text = message; // displays message on label
            illnessLabel.Text += illnesses[scenario_number]; // displaying the scenario illness on label

            foreach (string symp in illness_symptoms)
            {
                // displaying remaining symptoms of the illness that were not in the scenario
                if (illness_symptoms.Contains(symp) && !GameWindow.scenario_symptoms.Contains(symp))
                {
                    remainingSymptoms.Text += "- " + symp + "\n";
                }
            }

            foreach (string symp in GameWindow.scenario_symptoms)
            {
                if (!suspected_symptoms.Contains(symp)) // if missed a symptom that appeared in the scenario
                {
                    missedSymptoms.Text += "- " + symp + "\n";
                }
            }
        }

        /// <summary>
        /// Method <c>scoreCount</c> counts the final score of the player.
        /// </summary>
        private void scoreCount()
        {
            if (called & GameWindow.scenario_symptoms.Count > 4) // if ambulance was called before the game ended and there were at least 5 symptoms in the scenario
            {
                score += 1000;

                // bonus points for reaction time
                int time_bonus = (GameWindow.maxtime - GameWindow.time_counter) * 50;
                score += time_bonus;

                if (lang == "eng") // English translation
                {
                    timeBonus.Text = "Time bonus: ";
                }

                calledPoints.Text += "+ 1000";
                timeBonus.Text += "+ " + time_bonus;
            }
            else if (called & GameWindow.scenario_symptoms.Count > 2) // if ambulance was called before the game ended with less than 5 symptoms in the scenario but more than 2
            {
                score += 500;
                calledPoints.Text += "+ 500";
                timeBonus.Text = "";

            }
            else if (called) // if ambulance was called before the game ended but there were no illness symptoms whatsoever
            {
                score += -500;
                calledPoints.Text += "- 500";
                timeBonus.Text = "";
            }
            else
            {
                calledPoints.Text += "- 1000";
                score += -1000;
                timeBonus.Text = "";
            }

            if (illnesses[scenario_number] == suspected_illness) // if the illness was guessed correctly
            {
                score += 500;
                illnessPoints.Text += "+ 500";
            }
            else if (suspected_illness == "") // if there was no guess
            {
                illnessPoints.Text += "0";
            }
            else // if guessed wrong
            {
                score += -200;
                illnessPoints.Text += "- 200";
            }

            foreach (string symp in suspected_symptoms)
            {
                selectedSymptoms.Text += "- " + symp; // displaying all suspected symptoms selected by the user

                if (GameWindow.scenario_symptoms.Contains(symp)) // if suspected symptoms were in the scenario
                {
                    selectedSymptoms.Text += " 👍 +100";
                    score += 100;
                }
                else if (illness_symptoms.Contains(symp)) // if suspected symptoms were not in the scenario, but belong to the illness
                {
                    selectedSymptoms.Text += " ✊ 0";
                }
                else // if the symptom is wrong
                {
                    selectedSymptoms.Text += " 👎 -100";
                    score += -100;
                }

                selectedSymptoms.Text += "\n";
            }

            finalScore.Text += score; // adding final score to label
        }

        /// <summary>
        /// Method <c>buttonExit_Click</c> closes the form upon clicking the button.
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method <c>finish_FormClosing</c> enables menu window and its timer upon closing the finish window.
        /// </summary>
        private void finish_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuWindow.Visible = MenuWindow.Enabled = true;
            MenuWindow.timer.Enabled = true;
        }
    }
}
