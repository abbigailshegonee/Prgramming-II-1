using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class MainForm : Form
    {
        private Form myParent;
        public MainForm(Form prt, string type)
        {
            InitializeComponent();
            myParent = prt;
            label1.Text = type;
            //Caeser Cipher
            //Morse Code
            //Binary Code
            //A1Z26
            //leet / l337
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myParent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myParent.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string OutputText = " ";
            int caeserShift = 0;

            

            if (label1.Text == "Caeser Cipher") {
                try {
                    caeserShift = int.Parse(textBox2.Text);
                    if (caeserShift >= 26 || caeserShift <= -26) MessageBox.Show("Please select shift less than 26 and greater than -26", "Error");
                    else textBox3.Text = CaeserCipher(textBox1.Text, caeserShift);
                } catch (Exception ex) {MessageBox.Show("Please enter valid integer", "Error");}
                
            } if (label1.Text == "Morse Code") textBox3.Text = MorseCode(textBox1.Text);
            if (label1.Text == "leet / l337") textBox3.Text = l337(textBox1.Text);

        }
        //Caeser Cipher - Done
        private string CaeserCipher(string text, int shift)
        {
            string output = string.Empty;
            string text2 = text.ToLower();
            for (int lcv = 0; lcv < text.Length; lcv++) {
                if (text2[lcv] >= 'a' && text2[lcv] <= 'z') {
                    int let = text[lcv] + shift;
                    if ((text2[lcv] + shift) < 'a') let += 26;
                    else if ((text2[lcv] + shift > 'z')) let -= 26;
                    output += Convert.ToChar(let);  
                } else output += text[lcv];
            }
            return output;
        }

        //Morse Code - Done
        private string MorseCode(string text)
        {
            char[] morseAlphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',', '?',
                                    '\'', '!', '/', '(', ')', '&', ':', ';', '=', '+', '-', '_', '"',
                                    '$', '@', ' '}; //55
            string[] Morse = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ",
                               ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", "--.- ", ".-. ",
                               "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", ".---- ",
                               "..--- ", "...--", "....-", ".....", "-.... ", "--... ", "---.. ", "----. ",
                               "----- ", ".-.-.- ", "--..-- ", "..--.. ", ".----. ", "-.-.-- ", "-..-. ",
                               "-.--. ", "-.--.- ", ".-... ", "---... ", "-.-.-. ", "-...- ", ".-.-. ",
                               "-....- ", "..--.- ", ".-..-. ", "...-..- ", ".--.-. ", "/ "};
            string text2 = text.ToLower();
            string output = string.Empty;
            if (radioButton1.Checked == true) {
                for (int lcv = 0; lcv < text.Length; lcv++) {
                    char letter = text2[lcv];
                    if (morseAlphabet.Contains(letter) == false) {
                        MessageBox.Show("Some characters are untranslateable and will be replaced with" + 
                                        "\"..........\" (morse for error).", "Error");
                        output += "........ ";
                    } for (int lcv2 = 0; lcv2 < morseAlphabet.Length; lcv2++){
                        if (letter == morseAlphabet[lcv2] && letter != ' ') output += Morse[lcv2];
                    } if (letter != text[text.Length - 1]) {
                        if (letter == ' ' && text2[lcv + 1] != ' ') output += "/";
                    }
                } 
            }

            else if (radioButton2.Checked == true) {
                string morseLetter = string.Empty;
                for (int i = 0; i < text.Length; i++) {
                    if ((text[i] == '.' || text[i] == '-')) {
                        morseLetter += text[i];

                    } 
                    else if (text[i] == ' '){
                        morseLetter += ' ';
                        if (Morse.Contains(morseLetter)) {
                            int letterIndex = 0;
                            for (int y = 0; y < Morse.Length; y++)
                            {
                                if (morseLetter == Morse[y]) letterIndex = y;
                            } output += morseAlphabet[letterIndex];
                            morseLetter = string.Empty;
                        }
                        else if (morseLetter.Length > 1) output += "#"; morseLetter = string.Empty;

                    } else if (text[i] == '/' ) output += " ";
                    else if (text[i] != '.' && text[i] != '-' && text[i] != '/' && text[i] != ' ') {
                        output += "#"; 
                        morseLetter = string.Empty;
                    } if (i == text.Length - 1) {
                        morseLetter += " ";
                        if (Morse.Contains(morseLetter) == false && morseLetter.Length > 1) output += "#";
                    }   
                } if (output.Contains("#"))MessageBox.Show("Some characters weren't morse or some morse was inccorect." +
                                                           " Such Instsances will be translated to \"#\".", "Error");
            }
            return output.ToUpper();
        }

        //Leet / L337 - Done
        private string BasicLeetAlphabet(char letter)
        {
            if (letter == 'a' || letter == 'A') return "4";
            else if (letter == 'b' || letter == 'B') return "8";
            else if (letter == 'e' || letter == 'E') return "3";
            else if (letter == 'g' || letter == 'G') return "6";
            else if (letter == 'i' || letter == 'I') return "1";
            else if (letter == 'o' || letter == 'O') return "0";
            else if (letter == 'r' || letter == 'R') return "2";
            else if (letter == 's' || letter == 'S') return "5";
            else if (letter == 'l' || letter == 'L') return "7";
            if (letter >= 'A' && letter <= 'Z') return letter.ToString();
            else if (letter >= 'a' && letter <= 'z') return (Convert.ToChar(letter - 32)).ToString();
            return letter.ToString();
        }
        private string ExtremeLeetAlphabet(char letter){
            if      (letter == 'a' || letter == 'A') return "@";
            else if (letter == 'b' || letter == 'B') return "|3";
            else if (letter == 'c' || letter == 'C') return "©";
            else if (letter == 'd' || letter == 'D') return "|)";
            else if (letter == 'e' || letter == 'E') return "€";
            else if (letter == 'f' || letter == 'F') return "|=";
            else if (letter == 'g' || letter == 'G') return "9";
            else if (letter == 'h' || letter == 'H') return "#";
            else if (letter == 'i' || letter == 'I') return "!";
            else if (letter == 'j' || letter == 'J') return "¿";
            else if (letter == 'k' || letter == 'K') return "|{";
            else if (letter == 'l' || letter == 'L') return "|_";
            else if (letter == 'm' || letter == 'M') return "^^";
            else if (letter == 'n' || letter == 'N') return "|V";
            else if (letter == 'o' || letter == 'O') return "°";
            else if (letter == 'p' || letter == 'P') return "|*";
            else if (letter == 'q' || letter == 'Q') return "O_";
            else if (letter == 'r' || letter == 'R') return "я";
            else if (letter == 's' || letter == 'S') return "$";
            else if (letter == 't' || letter == 'T') return "+";
            else if (letter == 'u' || letter == 'U') return "µ";
            else if (letter == 'v' || letter == 'V') return "|/";
            else if (letter == 'w' || letter == 'W') return "uu";
            else if (letter == 'x' || letter == 'X') return ")(";
            else if (letter == 'y' || letter == 'Y') return "`/";
            else if (letter == 'z' || letter == 'Z') return "'/_";
            else return letter.ToString();
        }
        private string l337(string text)
        {
            string output = string.Empty;
            if (radioButton1.Checked == true) {
                
                if (radioButton1.Checked == true) {
                    for (int lcv = 0; lcv < text.Length; lcv++) {
                        char letter = text[lcv];
                        output += BasicLeetAlphabet(letter);
                    }
                }
            }
            else if (radioButton2.Checked == true){
                for (int lcv = 0; lcv < text.Length; lcv++){
                    char letter = text[lcv];
                    output += ExtremeLeetAlphabet(letter);
                }

            }
            return output;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            if (label1.Text == "Caeser Cipher"){
                button1.Location = new Point(183, 76);
                textBox2.Location = new Point(57, 82);
                label5.Location = new Point(39, 56);
                groupBox1.Hide();
            }
            else{
                button1.Location = new Point(52, 81);
                groupBox1.Location = new Point(166, 52);
                label5.Hide();
                textBox2.Hide();
            }

            if (label1.Text == "leet / l337") {
                radioButton1.Text = "Basic Leet";
                radioButton2.Text = "Extreme Leet";
            }
            
        }

    }
}
