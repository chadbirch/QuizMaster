using System;
using QuizMasterModels.QuestionMediums;
using QuizMasterModels.Questions;

namespace QuizMasterModels.Categories {
    public class Category {
        public string categoryName { get; set; }
        public Question[] questions { get; set; }
        public Category(string categoryName, Question[] questions) {
            this.categoryName = categoryName;
        }
    }
}