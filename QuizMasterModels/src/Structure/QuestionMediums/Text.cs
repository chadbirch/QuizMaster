using System;

namespace QuizMasterModels.Structure.QuestionMediums {
    public abstract class Text : Medium {
        public string content { get; set; }
        public Text(string content) : base("Text") {
            this.content = content;
        }
    }
}