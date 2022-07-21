using System;

namespace consollapp222
{
   class Question
    {

        public string Text { get; set; }

        public string[] Choice { get; set; }

        public string Answer { get; set; }

        public Question(string text, string[] choice,string answer)
        {
            this.Text = text;
            this.Choice = choice;
            this.Answer = answer;
        }

       public bool CheckAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    class Quiz
    {
        public Question[] Exam { get; set; }

        public int QuestionIndeks { get; set; }

        public Quiz(Question[] exam)
        {
           this.Exam = exam;
           this.QuestionIndeks = 0;
        }

        public void DisplayQuiz()
        {
            var quiz = this.GetQuestion();

            Console.WriteLine(quiz.Text);

            foreach (var item in quiz.Choice )
            {
                Console.WriteLine($"-{item}");
            }

            Console.WriteLine("Cevabınız : ");
            string result = Console.ReadLine();

            Console.WriteLine(quiz.CheckAnswer(result));

            this.QuestionIndeks++;

            if (this.Exam.Length == this.QuestionIndeks)
            {
                Console.WriteLine("sınav bitti");
            }
            else
            {
                DisplayQuiz();
            }

            


        }

        public Question GetQuestion()
        {
            return this.Exam[this.QuestionIndeks];
        }
    }


    
    internal class Program
    {

        static void Main(string[] args)
        {
            var q1 = new Question("En iyi programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "Go" }, "C#");
            var q2 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "Go" }, "C#");
            var q3 = new Question("En kolay programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "Go" }, "Python");


            Question[] questions = new Question[] { q1, q2, q3 };

            var quiz = new Quiz(questions);

            quiz.DisplayQuiz();
            





        }
    }
}


