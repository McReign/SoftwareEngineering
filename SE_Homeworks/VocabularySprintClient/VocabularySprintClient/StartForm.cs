using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocabularySprintLibrary.Application;

namespace VocabularySprintClient
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            ISprintGame game = new SprintGame(richTextBox1.Text);
            game.StartGame();
            Hide();
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
            Close();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
