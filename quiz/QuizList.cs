using System;
using System.Collections.Generic;
using System.Text;

namespace quiz
{
    //TODO: pass quiz folder path as constructor argument
    class QuizList
    {
        public void InitializeListView(System.Windows.Forms.ListView listView)
        {
            string[] quizList = System.IO.Directory.GetFiles("quizes");

            foreach (string quiz in quizList)
            {
                listView.Items.Add(quiz);
            }
        }
    }
}
