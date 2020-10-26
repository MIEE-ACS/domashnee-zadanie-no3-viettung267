using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TUNGDZ3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTclick_Click(object sender, RoutedEventArgs e)
        {
            String s = Input.Text;
            s = s.Trim();
            s = s.ToUpper();
            String result = "";
            String RusAlphabet = "абвгдежзийклмнопрстуфхцщыьчшъэюя";
            String BigWordRusAlphabet = RusAlphabet.ToUpper();
            String LatinAlphabet = "abwgdevzijklmnoprstufhcqyx";
            String BigWordLantinAlphabet = LatinAlphabet.ToUpper();
            String alpha = "";

            if (BigWordRusAlphabet.IndexOf(s[0]) != -1)
            {
                alpha = BigWordRusAlphabet;
            }
            else if (BigWordLantinAlphabet.IndexOf(s[0]) != -1)
            {
                alpha = BigWordLantinAlphabet;
            }

            String[] Morse = new string[32];
            Morse[0] = ".-";
            Morse[1] = "-...";
            Morse[2] = ".--";
            Morse[3] = "--.";
            Morse[4] = "-..";
            Morse[5] = ".";
            Morse[6] = "...-";
            Morse[7] = "--..";
            Morse[8] = "..";
            Morse[9] = ".---";
            Morse[10] = "-.-";
            Morse[11] = ".-..";
            Morse[12] = "--";
            Morse[13] = "-.";
            Morse[14] = "---";
            Morse[15] = ".--.";
            Morse[16] = ".-.";
            Morse[17] = "...";
            Morse[18] = "-";
            Morse[19] = "..-";
            Morse[20] = "..-.";
            Morse[21] = "....";
            Morse[22] = "-.-.";
            Morse[23] = "--.-";
            Morse[24] = "-.--";
            Morse[25] = "-..-";
            Morse[26] = "---.";
            Morse[27] = "----";
            Morse[28] = "--.--";
            Morse[29] = "..-..";
            Morse[30] = "..--";
            Morse[31] = ".-.-";

            for (int i = 0; i < s.Length; i++)
            {
                int a = alpha.IndexOf(s[i]);
                if (s[i] == ' ')
                {
                    String c = "| ";
                    result = (String)result + c;
                }
                else if (a!=-1) result = (String)result + Morse[a]+" ";
            }
            Output.Text = $"{result}";
        }
    }
}
