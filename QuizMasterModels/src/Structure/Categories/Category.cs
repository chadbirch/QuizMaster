using System;
using QuizMasterModels.Structure.QuestionMediums;
using QuizMasterModels.Structure.Questions;

namespace QuizMasterModels.Structure.Categories {
    public class Category {
        public string categoryName { get; set; }
        public Question[] questions { get; set; }
        public Category(string categoryName, Question[] questions) {
            this.categoryName = categoryName;
        }
    }
}