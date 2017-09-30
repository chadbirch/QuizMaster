using System;
using QuizMasterModels.Structure.QuestionChoices;
using QuizMasterModels.Structure.QuestionAnswers;

namespace QuizMasterModels.Structure.Questions {
    public class MultipleChoice : Question {
        public Choices choices { get; set; }
        
        public MultipleChoice(string question, Choices choices, Answers answer) : base("Simple", question, answer) {
            this.choices = choices;
        }
    }
}