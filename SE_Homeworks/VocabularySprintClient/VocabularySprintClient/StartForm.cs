using System;
using System.Linq;
using System.Windows.Forms;
using VocabularySprintLibrary;
using VocabularySprintLibrary.Application;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintClient
{
    public partial class StartForm : Form
    {

        public ISprintGame game;
        public IWord word;

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            game = new SprintGame(richTextBox1.Text);

            label3.Hide();
            label2.Hide();
            button1.Hide();
            button2.Hide();


        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            game.StartGame();

            label1.Hide();
            richTextBox1.Hide();
            button3.Hide();

            label3.Show();
            label2.Show();
            button1.Show();
            button2.Show();

            ShowWord();
        }

        private void ShowWord()
        {
            string[] randomValuesForWord = game.vocabularyService.GetRandomWord();

            word = new Word(randomValuesForWord[0], randomValuesForWord[1]);


            label2.Text = word.Value;
            label3.Text = word.Translation;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = game.vocabularyService.CheckingAnswer(
                game.currentUser.vocabulary.UnlearnedWords.ToList().Find(current => current.Value == word.Value),
                    Convert.ToBoolean(this.Text)).ToString();
            ShowWord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = game.vocabularyService.CheckingAnswer(
                game.currentUser.vocabulary.UnlearnedWords.ToList().Find(current => current.Value == word.Value),
                    Convert.ToBoolean(this.Text)).ToString();
            ShowWord();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
