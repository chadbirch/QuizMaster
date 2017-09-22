using System;
using QuizMasterModels.QuestionMediums;

namespace QuizMasterModels.QuestionAnswers {
    public abstract class Answers {
        public Medium[] answers { get; set; }
        public AnswerOrder order { get; set; }
        public Answers(Medium[] answers, AnswerOrder order) {
            this.answers = answers;
            this.order = order;
        }
    }
}