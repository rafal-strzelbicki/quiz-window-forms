using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            QuizList quizList = new QuizList();
            quizList.InitializeListView(list_quiz_list);
        }

        private void btn_create_quiz_Click(object sender, EventArgs e)
        {
            CreateQuizForm form = new CreateQuizForm();
            form.ShowDialog();
        }

        private void list_quiz_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
