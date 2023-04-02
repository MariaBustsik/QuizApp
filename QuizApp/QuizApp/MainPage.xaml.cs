using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        int correctAnswerCount = 0;
        public MainPage()
        {
            InitializeComponent();
            imagePob.Opacity = 0;

        }
        async void buttonStartQuiz_Clicked(object sender, EventArgs e)
        {
            RefreshAnswers();
            // QUESTION 1
            string q1Answer = await DisplayActionSheet("Столица Австрии? ", "Отмена", null, "Стамбул", "Рига", "Вена");
            if (q1Answer == "Вена")
            {
                labelQ1Answer.Text = "Верно, Вена - это правильный ответ";
                correctAnswerCount++;
            }
            else if (q1Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ1Answer.Text = "Неверно, правильный ответ - Вена";
            }

            // QUESTION 2
            string q2Answer = await DisplayActionSheet("Столица Эстонии? ", "Отмена", null, "Таллинн", "Вильнюс", "Москва");
            if (q2Answer == "Таллинн")
            {
                labelQ2Answer.Text = "Верно, Таллинн - это правильный ответ";
                correctAnswerCount++;
            }
            else if (q2Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ2Answer.Text = "Неверно, правильный ответ - Таллинн";
            }

            // QUESTION 3
            string q3Answer = await DisplayActionSheet("Столица Латвии? ", "Отмена", null, "Барселона", "Париж", "Рига");
            if (q3Answer == "Рига")
            {
                labelQ3Answer.Text = "Верно, Рига - это правильный ответ";
                correctAnswerCount++;
            }
            else if (q3Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ3Answer.Text = "Неверно, правильный ответ - Рига";
            }

            // QUESTION 4
            string q4Answer = await DisplayActionSheet("Столица Франции? ", "Отмена", null, "Вильнюс", "Париж", "Малага");
            if (q4Answer == "Париж")
            {
                labelQ4Answer.Text = "Верно, Париж - это правильный ответ";
                correctAnswerCount++;
            }
            else if (q4Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ4Answer.Text = "Неверно, правильный ответ - Париж";
            }
            if (correctAnswerCount == 4)
            {
                imagePob.Opacity = 100;
            }
        }

        void RefreshAnswers()
        {
            labelQ1Answer.Text = "";
            labelQ2Answer.Text = "";
            labelQ3Answer.Text = "";
            labelQ4Answer.Text = "";
            correctAnswerCount = 0;
            imagePob.Opacity = 0;
        }


    }
}
