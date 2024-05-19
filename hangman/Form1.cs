using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        Word word;
        List<string> szavak = new List<string>();
        int hibak = 0;
        int maxHibak = 20;
        Button[] gombok;

        public Form1()
        {
            InitializeComponent();

            string[] billentyuk = {
                "1234567890üó",
                "qwertzuiopõú",
                "asdfghjkléáû",
                "íyxcvbnm,.-",
                " "
            };

            int x = 10, y = 70;
            int buttonWidth = 40, buttonHeight = 40;

            gombok = new Button[billentyuk.Length * billentyuk[0].Length];
            int gombIndex = 0;

            foreach (string sor in billentyuk)
            {
                foreach (char karakter in sor)
                {
                    Button button = new Button();
                    button.Text = karakter.ToString();
                    button.Location = new System.Drawing.Point(x, y);
                    button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    button.Click += ButtonClick;
                    Controls.Add(button);
                    gombok[gombIndex++] = button;
                    x += buttonWidth + 5;
                }
                x = 10;
                y += buttonHeight + 5;
            }

            KeyPress += Form1_KeyPress;
        }

        private void UjJatek()
        {
            Random random = new Random();
            int randomIndex = random.Next(szavak.Count);
            string randomSzo = szavak[randomIndex];
            word = new Word(randomSzo);
            label1.Text = word.WordMask;
            hibak = 0;
            UpdateHibaLabel();

            foreach (Button button in gombok)
            {
                if (button == null) return;
                button.BackColor = SystemColors.ButtonFace;
                button.Enabled = true;
            }

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (!word.Guess(clickedButton.Text[0]))
            {
                hibak++;
                UpdateHibaLabel();
                clickedButton.BackColor = Color.Red;
                clickedButton.Enabled = false;
                if (hibak >= maxHibak)
                {
                    MessageBox.Show($"Vesztettél! A szó: {word.wordToGuess}");
                    UjJatek();
                }
            }
            else
            {
                clickedButton.BackColor = Color.Green;
                clickedButton.Enabled = false;
            }

            label1.Text = word.WordMask;
            if (word.IsSolved())
            {
                MessageBox.Show("Nyertél!");
                UjJatek();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        szavak.Add(sor);
                    }
                    sr.Close();
                    UjJatek();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Close();
            }
        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button button in gombok)
            {
                if (button.Text.ToUpper() == e.KeyChar.ToString().ToUpper() && button.Enabled)
                {
                    ButtonClick(button, null); 
                    break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UjJatek();

        }



        private void UpdateHibaLabel()
        {
            label3.Text = $"Hibák: {hibak}/{maxHibak}";
        }
    }
}

   

