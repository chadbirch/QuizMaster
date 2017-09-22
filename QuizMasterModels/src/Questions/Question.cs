using System;
using QuizMasterModels.QuestionChoices;
using QuizMasterModels.QuestionAnswers;

namespace QuizMasterModels.Questions {
    public abstract class Question {
        public string type { get; set; }
        public string question { get; set; }
        public Answers answer { get; set; }

        public Question(string type, string question, Answers answer) {
            this.type = type;
            this.question = question;
            this.answer = answer;
        }
    }
}