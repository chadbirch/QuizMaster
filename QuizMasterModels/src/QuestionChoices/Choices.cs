using System;
using QuizMasterModels.QuestionMediums;

namespace QuizMasterModels.QuestionChoices {
    public abstract class Choices {
        public Medium[] choices { get; set; }
        public ChoiceOrder order { get; set; }
        public Choices(Medium[] choices, ChoiceOrder order) {
            this.choices = choices;
            this.order = order;
        }
    }
}