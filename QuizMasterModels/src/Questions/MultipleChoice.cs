using System;
using QuizMasterModels.QuestionChoices;
using QuizMasterModels.QuestionAnswers;

namespace QuizMasterModels.Questions {
    public class MultipleChoice : Question {
        public Choices choices { get; set; }
        
        public MultipleChoice(string question, Choices choices, Answers answer) : base("Simple", question, answer) {
            this.choices = choices;
        }
    }
}