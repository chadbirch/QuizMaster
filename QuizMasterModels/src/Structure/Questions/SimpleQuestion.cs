using System;
using QuizMasterModels.Structure.QuestionChoices;
using QuizMasterModels.Structure.QuestionAnswers;

namespace QuizMasterModels.Structure.Questions {
    public class SimpleQuestion : Question {

        public SimpleQuestion(string question, Answers answer) : base("Simple", question, answer) { }
    }
}