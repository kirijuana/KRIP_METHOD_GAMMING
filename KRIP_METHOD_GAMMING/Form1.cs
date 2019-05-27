using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIP_METHOD_GAMMING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Shifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz1234567".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();


            int a = Convert.ToInt32(textBoxA.Text);
            int b = Convert.ToInt32(textBoxB.Text);


            int[] key = new int[text.Length];
            key[0] = (a + b) % 32;
            for (int k = 1; k < text.Length; k++)
            {
                key[k] = (a * key[k - 1] + b) % 32;
            }

            string text_key = key[0].ToString();

            for(int k =1; k < text.Length; k++)
            {
                text_key = text_key + " " + key[k].ToString();
            }

        //    text1 = Convert.ToString(key);
            keyBox.Text = text_key;

            int i = 0, y = 0, m = 0, j = 0;
            while (i < text.Length)
            {
                for (; i < text.Length;)
                {
                    for (int k = 0; k < ALPHA.Length; k++)
                    {
                        if (text[i] == ALPHA[k])
                        {
                            y = k;
                            shifr[i] = ALPHA[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == alpha[k])
                        {
                            y = k;
                            shifr[i] = alpha[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == ALPH[k])
                        {
                            y = k;
                            shifr[i] = ALPH[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == alph[k])
                        {
                            y = k;
                            shifr[i] = alph[(y + key[i]) % 32];
                            break;
                        }
                    }
                    break;
                }
                i++;
                j++;
            }

                string text2 = new string(shifr);
                ShifrText.Text = text2;
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_unShifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();
            char[] text_key = keyBox.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz1234567".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            //char[] key = keyBox.Text.ToCharArray();
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            

            int[] key = new int[text.Length];
            string conv_int = "  ";
            char conv_char = ' ';
            
            for(int k = 0, m = 0, p = 0; k < text_key.Length; k++)
            {
                while (text_key[k] != ' ')
                {
                    conv_char = text_key[k];
                    conv_int = conv_int.Remove(m, 1).Insert(m, conv_char.ToString());
                    if(k < text_key.Length)
                    0++;
                    m++;
                }

                key[p] = Convert.ToInt32(conv_int);
                p++;
                conv_int = "  ";
                m = 0;


            }

            int i = 0, y = 0, j = 0;
            while (i < text.Length)
            {
                for (; i < text.Length;)
                {
                    for (int k = 0; k < ALPHA.Length; k++)
                    {
                        if (text[i] == ALPHA[k])
                        {
                            y = k;
                            shifr[i] = ALPHA[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == alpha[k])
                        {
                            y = k;
                            shifr[i] = alpha[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == ALPH[k])
                        {
                            y = k;
                            shifr[i] = ALPH[(y + key[i]) % 32];
                            break;
                        }
                        if (text[i] == alph[k])
                        {
                            y = k;
                            shifr[i] = alph[(y + key[i]) % 32];
                            break;
                        }
                    }
                    break;
                }
                i++;
                j++;
            }

            string text1 = new string(shifr);
            ShifrText.Text = text1;
        }

        private void ShifrText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
