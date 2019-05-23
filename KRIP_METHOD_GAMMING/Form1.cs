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
                //for (; j < key.Length;)
                //{
                //    for (int k = 0; k < ALPHA.Length; k++)
                //    {
                //        if (key[j] == ALPHA[k])
                //        {
                //            m = k;
                //            shifr[i] = ALPHA[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == alpha[k])
                //        {
                //            m = k;
                //            shifr[i] = alpha[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == ALPH[k])
                //        {
                //            m = k;
                //            shifr[i] = ALPH[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == alph[k])
                //        {
                //            m = k;
                //            shifr[i] = alph[(y + m) % 32];
                //            break;
                //        }
                //    }
                //    break;
                //}
                i++;
                j++;
            }

                string text1 = new string(shifr);
                ShifrText.Text = text1;
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
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz1234567".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            //char[] key = keyBox.Text.ToCharArray();
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            

            int[] key = new int[text.Length];
            key[0] = (a + b) % 32;
            for(int k = 1; k < text.Length; k++)
            {
                key[k] = (a * key[k - 1] + b) % 32;
            }

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
                //for (; j < key.Length;)
                //{
                //    for (int k = 0; k < ALPHA.Length; k++)
                //    {
                //        if (key[j] == ALPHA[k])
                //        {
                //            m = k;
                //            shifr[i] = ALPHA[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == alpha[k])
                //        {
                //            m = k;
                //            shifr[i] = alpha[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == ALPH[k])
                //        {
                //            m = k;
                //            shifr[i] = ALPH[(y + m) % 32];
                //            break;
                //        }
                //        if (key[j] == alph[k])
                //        {
                //            m = k;
                //            shifr[i] = alph[(y + m) % 32];
                //            break;
                //        }
                //    }
                //    break;
                //}
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
