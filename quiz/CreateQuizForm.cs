using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace quiz
{
    public partial class CreateQuizForm : Form
    {
        public CreateQuizForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string quizFolderPath = "quizes/";

            if (input_quiz_name.Text == "")
            {
                MessageBox.Show("You must type quiz name!");
            }

            if (input_quiz_name.Text == "quiz.txt")
            {
                File.Create(quizFolderPath + input_quiz_name.Text);
                this.Close();
                MessageBox.Show("Quiz has been created");
            }
        }

        private void input_quiz_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateQuizForm_Load(object sender, EventArgs e)
        {

        }
    }
}
