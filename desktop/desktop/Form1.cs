using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int klucz = 0;
            
            if (textBox1.Text == "")
            {
                klucz = 0;
            }
            else
            {
                klucz = int.Parse(textBox1.Text);
            }
            string tekst = textBox2.Text;
            string tekstZaszyfrowany = "";
            string alfabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                {
                    tekstZaszyfrowany += ' ';
                }
                else
                {
                    for (int j = 0; j < alfabet.Length; j++)
                    {
                        if (tekst[i] == alfabet[j])
                        {
                            int index = j + klucz;
                            if (index >= alfabet.Length)
                            {
                                index = index - alfabet.Length;
                            }
                            else if (index < 0)
                            {
                                index = index + alfabet.Length;
                            }
                            tekstZaszyfrowany += alfabet[index];
                        }
                    }
                }
            }
            label4.Text = tekstZaszyfrowany;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog plik = new SaveFileDialog();


            plik.Filter = "Pliki txt|*.txt|Wszystkie pliki|*.*";
            if (plik.ShowDialog() == DialogResult.OK)
            {
                string sciezka = plik.FileName;
                File.WriteAllText(sciezka, label4.Text);
            }
             
            
           
        }
    }
}
