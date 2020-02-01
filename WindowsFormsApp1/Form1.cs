using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int prevCount = 0;
        int nextCount = 0;

        // Decided to use List as it seemed more convenient and easy-to-use than array
        List<string> outputsList = new List<string>();
        

        // Unused (empty) methods
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Translation button click method
        private void translitButton_Click(object sender, EventArgs e)
        {
            // outputBox = result box
            // inputBox = user input box
            outputBox.Text = inputBox.Text;

            string input = inputBox.Text;
            // Making an array of characters for a length of all the characters user entered in inputBox
            char[] inputs = new Char[input.Length];

            // Looping through every character to fill the array with characters user entered
            for (int i = 0; i < input.Length; i++)
            {
               inputs[i] = input[i];
            }

            /* Checking which mode is set in the modeBox menuand translating characters 
             * corresponding a method, which is described further */
           if(modeBox.Text == "EN >> RU")
            {
                ENtoRU(inputs);
            }
           else if(modeBox.Text == "LT >> RU")
            {
                LTtoRU(inputs);
            }
            else if (modeBox.Text == "RU >> LT")
            {
                RUtoLT(inputs);
            }
            else if (modeBox.Text == "EN >> LT")
            {
                ENtoLT(inputs);
            }

           /* Converting character array into a string
            * and adding the output to the results-history list outputsList */

            string output = new string(inputs);
            string empty = "";

            outputBox.Text = output;

            // making a first result to be always empty
            if(prevCount == 0)
            {
                outputsList.Add(empty);
                outputsList.Add(output);
            } else
            {
                outputsList.Add(output);
            }

            prevCount++;
            prevButton.Text = "Prev(" + prevCount + ")";


        }

        /* When pressing prev() button, controlling counts and getting relevant output 
         * out of the output-history list outputsList */
        private void prevButton_Click(object sender, EventArgs e)
        {
            if(prevCount > 0)
            {
                int count = prevCount - 1;
                outputBox.Text = outputsList[count];
                prev();
            }
        }

        /* When pressing next() button, controlling counts and getting relevant output 
         * out of the output-history list outputsList */
        private void nextButton_Click(object sender, EventArgs e)
        {
            if(nextCount > 0)
            {
                int count = prevCount + 1;
                outputBox.Text = outputsList[count];
                next();
            }
        }

        // Prev count controls
        public void prev()
        {
            prevCount--;
            prevButton.Text = "Prev(" + prevCount + ")";
            nextCount++;
            nextButton.Text = "Next(" + nextCount + ")";
        }

        // Next count controls
        public void next()
        {
            prevCount++;
            prevButton.Text = "Prev(" + prevCount + ")";
            nextCount--;
            nextButton.Text = "Next(" + nextCount + ")";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* When pressing "Last" button, controlling counts and getting last recorded output 
         * out of the output-history list outputsList */
        private void lastButton_Click(object sender, EventArgs e)
        {
            int count = outputsList.Count();
            nextCount = 0;
            nextButton.Text = "Next(" + nextCount + ")";
            prevCount = count - 1;
            prevButton.Text = "Prev(" + prevCount + ")";
            outputBox.Text = outputsList[count - 1];
        }


        // Switch statement which searched for the corresponding char and converting them
        public char[] ENtoRU(char[] inputs)
        {
            for (int j = 0; j < inputs.Length; j++)
            {
                switch (inputs[j])
                {
                    case '`':
                    case '~':
                        inputs[j] = 'ё';
                        break;
                    case 'Q':
                    case 'q':
                        inputs[j] = 'й';
                        break;
                    case 'W':
                    case 'w':
                        inputs[j] = 'ц';
                        break;
                    case 'E':
                    case 'e':
                        inputs[j] = 'у';
                        break;
                    case 'R':
                    case 'r':
                        inputs[j] = 'к';
                        break;
                    case 'T':
                    case 't':
                        inputs[j] = 'е';
                        break;
                    case 'Y':
                    case 'y':
                        inputs[j] = 'н';
                        break;
                    case 'U':
                    case 'u':
                        inputs[j] = 'г';
                        break;
                    case 'I':
                    case 'i':
                        inputs[j] = 'ш';
                        break;
                    case 'O':
                    case 'o':
                        inputs[j] = 'щ';
                        break;
                    case 'P':
                    case 'p':
                        inputs[j] = 'з';
                        break;
                    case '{':
                    case '[':
                        inputs[j] = 'х';
                        break;
                    case '}':
                    case ']':
                        inputs[j] = 'ъ';
                        break;
                    case 'A':
                    case 'a':
                        inputs[j] = 'ф';
                        break;
                    case 'S':
                    case 's':
                        inputs[j] = 'ы';
                        break;
                    case 'D':
                    case 'd':
                        inputs[j] = 'в';
                        break;
                    case 'F':
                    case 'f':
                        inputs[j] = 'а';
                        break;
                    case 'G':
                    case 'g':
                        inputs[j] = 'п';
                        break;
                    case 'H':
                    case 'h':
                        inputs[j] = 'р';
                        break;
                    case 'J':
                    case 'j':
                        inputs[j] = 'о';
                        break;
                    case 'K':
                    case 'k':
                        inputs[j] = 'л';
                        break;
                    case 'L':
                    case 'l':
                        inputs[j] = 'д';
                        break;
                    case ':':
                    case ';':
                        inputs[j] = 'ж';
                        break;
                    case '"':
                    case '\'':
                        inputs[j] = 'э';
                        break;
                    case 'Z':
                    case 'z':
                        inputs[j] = 'я';
                        break;
                    case 'X':
                    case 'x':
                        inputs[j] = 'ч';
                        break;
                    case 'C':
                    case 'c':
                        inputs[j] = 'с';
                        break;
                    case 'V':
                    case 'v':
                        inputs[j] = 'м';
                        break;
                    case 'B':
                    case 'b':
                        inputs[j] = 'и';
                        break;
                    case 'N':
                    case 'n':
                        inputs[j] = 'т';
                        break;
                    case 'M':
                    case 'm':
                        inputs[j] = 'ь';
                        break;
                    case '<':
                    case ',':
                        inputs[j] = 'б';
                        break;
                    case '>':
                    case '.':
                        inputs[j] = 'ю';
                        break;
                    case '?':
                    case '/':
                        inputs[j] = '.';
                        break;
                    case ' ':
                        inputs[j] = ' ';
                        break;





                    default:
                        break;
                }
            }
            return inputs;
        }

        public char[] LTtoRU(char[] inputs)
        {
            for (int j = 0; j < inputs.Length; j++)
            {
                switch (inputs[j])
                {
                    case '`':
                    case '~':
                        inputs[j] = 'ё';
                        break;
                    case 'Q':
                    case 'q':
                        inputs[j] = 'й';
                        break;
                    case 'W':
                    case 'w':
                        inputs[j] = 'ц';
                        break;
                    case 'E':
                    case 'e':
                        inputs[j] = 'у';
                        break;
                    case 'R':
                    case 'r':
                        inputs[j] = 'к';
                        break;
                    case 'T':
                    case 't':
                        inputs[j] = 'е';
                        break;
                    case 'Y':
                    case 'y':
                        inputs[j] = 'н';
                        break;
                    case 'U':
                    case 'u':
                        inputs[j] = 'г';
                        break;
                    case 'I':
                    case 'i':
                        inputs[j] = 'ш';
                        break;
                    case 'O':
                    case 'o':
                        inputs[j] = 'щ';
                        break;
                    case 'P':
                    case 'p':
                        inputs[j] = 'з';
                        break;
                    case '{':
                    case '[':
                        inputs[j] = 'х';
                        break;
                    case '}':
                    case ']':
                        inputs[j] = 'ъ';
                        break;
                    case 'A':
                    case 'a':
                        inputs[j] = 'ф';
                        break;
                    case 'S':
                    case 's':
                        inputs[j] = 'ы';
                        break;
                    case 'D':
                    case 'd':
                        inputs[j] = 'в';
                        break;
                    case 'F':
                    case 'f':
                        inputs[j] = 'а';
                        break;
                    case 'G':
                    case 'g':
                        inputs[j] = 'п';
                        break;
                    case 'H':
                    case 'h':
                        inputs[j] = 'р';
                        break;
                    case 'J':
                    case 'j':
                        inputs[j] = 'о';
                        break;
                    case 'K':
                    case 'k':
                        inputs[j] = 'л';
                        break;
                    case 'L':
                    case 'l':
                        inputs[j] = 'д';
                        break;
                    case ':':
                    case ';':
                        inputs[j] = 'ж';
                        break;
                    case '"':
                    case '\'':
                        inputs[j] = 'э';
                        break;
                    case 'Z':
                    case 'z':
                        inputs[j] = 'я';
                        break;
                    case 'X':
                    case 'x':
                        inputs[j] = 'ч';
                        break;
                    case 'C':
                    case 'c':
                        inputs[j] = 'с';
                        break;
                    case 'V':
                    case 'v':
                        inputs[j] = 'м';
                        break;
                    case 'B':
                    case 'b':
                        inputs[j] = 'и';
                        break;
                    case 'N':
                    case 'n':
                        inputs[j] = 'т';
                        break;
                    case 'M':
                    case 'm':
                        inputs[j] = 'ь';
                        break;
                    case '<':
                    case ',':
                        inputs[j] = 'б';
                        break;
                    case '>':
                    case '.':
                        inputs[j] = 'ю';
                        break;
                    case '?':
                    case '/':
                        inputs[j] = '.';
                        break;
                    case 'Ą':
                        inputs[j] = '!';
                        break;
                    case 'ą':
                        inputs[j] = '1';
                        break;
                    case 'Č':
                        inputs[j] = '"';
                        break;
                    case 'č':
                        inputs[j] = '2';
                        break;
                    case 'Ę':
                        inputs[j] = '№';
                        break;
                    case 'ę':
                        inputs[j] = '3';
                        break;
                    case 'Ė':
                        inputs[j] = ';';
                        break;
                    case 'ė':
                        inputs[j] = '4';
                        break;
                    case 'Į':
                        inputs[j] = '%';
                        break;
                    case 'į':
                        inputs[j] = '5';
                        break;
                    case 'Š':
                        inputs[j] = ':';
                        break;
                    case 'š':
                        inputs[j] = '6';
                        break;
                    case 'Ų':
                        inputs[j] = '?';
                        break;
                    case 'ų':
                        inputs[j] = '7';
                        break;
                    case 'Ū':
                        inputs[j] = '*';
                        break;
                    case 'ū':
                        inputs[j] = '8';
                        break;
                    case 'Ž':
                        inputs[j] = '+';
                        break;
                    case 'ž':
                        inputs[j] = '=';
                        break;
                    case ' ':
                        inputs[j] = ' ';
                        break;





                    default:
                        break;
                }
            }
            return inputs;
        }

        public char[] RUtoLT(char[] inputs)
        {
            for (int j = 0; j < inputs.Length; j++)
            {
                switch (inputs[j])
                {
                    case 'Ё':
                        inputs[j] = '~';
                        break;
                    case 'ё':
                        inputs[j] = '`';
                        break;
                    case 'Й':
                        inputs[j] = 'Q';
                        break;
                    case 'й':
                        inputs[j] = 'q';
                        break;
                    case 'Ц':
                        inputs[j] = 'W';
                        break;
                    case 'ц':
                        inputs[j] = 'w';
                        break;
                    case 'У':
                        inputs[j] = 'E';
                        break;
                    case 'у':
                        inputs[j] = 'e';
                        break;
                    case 'К':
                        inputs[j] = 'R';
                        break;
                    case 'к':
                        inputs[j] = 'r';
                        break;
                    case 'Е':
                        inputs[j] = 'T';
                        break;
                    case 'е':
                        inputs[j] = 't';
                        break;
                    case 'Н':
                        inputs[j] = 'Y';
                        break;
                    case 'н':
                        inputs[j] = 'y';
                        break;
                    case 'Г':
                        inputs[j] = 'U';
                        break;
                    case 'г':
                        inputs[j] = 'u';
                        break;
                    case 'Ш':
                        inputs[j] = 'I';
                        break;
                    case 'ш':
                        inputs[j] = 'i';
                        break;
                    case 'Щ':
                        inputs[j] = 'O';
                        break;
                    case 'щ':
                        inputs[j] = 'o';
                        break;
                    case 'З':
                        inputs[j] = 'P';
                        break;
                    case 'з':
                        inputs[j] = 'p';
                        break;
                    case 'Х':
                        inputs[j] = '{';
                        break;
                    case 'х':
                        inputs[j] = '[';
                        break;
                    case 'Ъ':
                        inputs[j] = '}';
                        break;
                    case 'ъ':
                        inputs[j] = ']';
                        break;
                    case 'Ф':
                        inputs[j] = 'A';
                        break;
                    case 'ф':
                        inputs[j] = 'a';
                        break;
                    case 'Ы':
                        inputs[j] = 'S';
                        break;
                    case 'ы':
                        inputs[j] = 's';
                        break;
                    case 'В':
                        inputs[j] = 'D';
                        break;
                    case 'в':
                        inputs[j] = 'd';
                        break;
                    case 'А':
                        inputs[j] = 'F';
                        break;
                    case 'а':
                        inputs[j] = 'f';
                        break;
                    case 'П':
                        inputs[j] = 'G';
                        break;
                    case 'п':
                        inputs[j] = 'g';
                        break;
                    case 'Р':
                        inputs[j] = 'H';
                        break;
                    case 'р':
                        inputs[j] = 'h';
                        break;
                    case 'О':
                        inputs[j] = 'J';
                        break;
                    case 'о':
                        inputs[j] = 'j';
                        break;
                    case 'Л':
                        inputs[j] = 'K';
                        break;
                    case 'л':
                        inputs[j] = 'k';
                        break;
                    case 'Д':
                        inputs[j] = 'L';
                        break;
                    case 'д':
                        inputs[j] = 'l';
                        break;
                    case 'Ж':
                        inputs[j] = ':';
                        break;
                    case 'ж':
                        inputs[j] = ';';
                        break;
                    case 'Э':
                        inputs[j] = '"';
                        break;
                    case 'э':
                        inputs[j] = '\'';
                        break;
                    case 'Я':
                        inputs[j] = 'Z';
                        break;
                    case 'я':
                        inputs[j] = 'z';
                        break;
                    case 'Ч':
                        inputs[j] = 'X';
                        break;
                    case 'ч':
                        inputs[j] = 'x';
                        break;
                    case 'С':
                        inputs[j] = 'C';
                        break;
                    case 'с':
                        inputs[j] = 'c';
                        break;
                    case 'М':
                        inputs[j] = 'V';
                        break;
                    case 'м':
                        inputs[j] = 'v';
                        break;
                    case 'И':
                        inputs[j] = 'B';
                        break;
                    case 'и':
                        inputs[j] = 'b';
                        break;
                    case 'Т':
                        inputs[j] = 'N';
                        break;
                    case 'т':
                        inputs[j] = 'n';
                        break;
                    case 'Ь':
                        inputs[j] = 'M';
                        break;
                    case 'ь':
                        inputs[j] = 'm';
                        break;
                    case 'Б':
                        inputs[j] = '<';
                        break;
                    case 'б':
                        inputs[j] = ',';
                        break;
                    case 'Ю':
                        inputs[j] = '>';
                        break;
                    case 'ю':
                        inputs[j] = '.';
                        break;
                    case ',':
                        inputs[j] = '?';
                        break;
                    case '.':
                        inputs[j] = '/';
                        break;
                    case '!':
                        inputs[j] = 'Ą';
                        break;
                    case '1':
                        inputs[j] = 'ą';
                        break;
                    case '"':
                        inputs[j] = 'Č';
                        break;
                    case '2':
                        inputs[j] = 'č';
                        break;
                    case '№':
                        inputs[j] = 'Ę';
                        break;
                    case '3':
                        inputs[j] = 'ę';
                        break;
                    case ';':
                        inputs[j] = 'Ė';
                        break;
                    case '4':
                        inputs[j] = 'ė';
                        break;
                    case '%':
                        inputs[j] = 'Į';
                        break;
                    case '5':
                        inputs[j] = 'į';
                        break;
                    case ':':
                        inputs[j] = 'Š';
                        break;
                    case '6':
                        inputs[j] = 'š';
                        break;
                    case '?':
                        inputs[j] = 'Ų';
                        break;
                    case '7':
                        inputs[j] = 'ų';
                        break;
                    case '*':
                        inputs[j] = 'Ū';
                        break;
                    case '8':
                        inputs[j] = 'ū';
                        break;
                    case '+':
                        inputs[j] = 'Ž';
                        break;
                    case '=':
                        inputs[j] = 'ž';
                        break;
                    case '-':
                        inputs[j] = '–';
                        break;
                    case ' ':
                        inputs[j] = ' ';
                        break;
                        




                    default:
                        break;
                }
            }
            return inputs;
        }

        public char[] ENtoLT(char[] inputs)
        {
            for (int j = 0; j < inputs.Length; j++)
            {
                switch (inputs[j])
                {                  
                    case '!':
                        inputs[j] = 'Ą';
                        break;
                    case '1':
                        inputs[j] = 'ą';
                        break;
                    case '@':
                        inputs[j] = 'Č';
                        break;
                    case '2':
                        inputs[j] = 'č';
                        break;
                    case '#':
                        inputs[j] = 'Ę';
                        break;
                    case '3':
                        inputs[j] = 'ę';
                        break;
                    case '$':
                        inputs[j] = 'Ė';
                        break;
                    case '4':
                        inputs[j] = 'ė';
                        break;
                    case '%':
                        inputs[j] = 'Į';
                        break;
                    case '5':
                        inputs[j] = 'į';
                        break;
                    case '^':
                        inputs[j] = 'Š';
                        break;
                    case '6':
                        inputs[j] = 'š';
                        break;
                    case '&':
                        inputs[j] = 'Ų';
                        break;
                    case '7':
                        inputs[j] = 'ų';
                        break;
                    case '*':
                        inputs[j] = 'Ū';
                        break;
                    case '8':
                        inputs[j] = 'ū';
                        break;
                    case '+':
                        inputs[j] = 'Ž';
                        break;
                    case '=':
                        inputs[j] = 'ž';
                        break;
                    case '-':
                        inputs[j] = '–';
                        break;
                    default:
                        break;
                }
            }
            return inputs;
        }
    }
}
