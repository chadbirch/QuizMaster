using System;
using QuizMasterModels.Structure.QuestionMediums;

namespace QuizMasterModels.Structure.QuestionChoices {
    public abstract class Choices {
        public Medium[] choices { get; set; }
        public ChoiceOrder order { get; set; }
        public Choices(Medium[] choices, ChoiceOrder order) {
            this.choices = choices;
            this.order = order;
        }
    }
}