using System;
using QuizMasterModels.QuestionChoices;
using QuizMasterModels.QuestionAnswers;

namespace QuizMasterModels.Questions {
    public class SimpleQuestion : Question {

        public SimpleQuestion(string question, Answers answer) : base("Simple", question, answer) { }
    }
}