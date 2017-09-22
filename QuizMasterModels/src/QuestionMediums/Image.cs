using System;

namespace QuizMasterModels.QuestionMediums {
    public abstract class Image : Medium {
        public byte[] content { get; set; }
        public string format { get; set; }
        public Image(byte[] content, string format) : base("Image") {
            this.content = content;
            this.format = format;
        }
    }
}