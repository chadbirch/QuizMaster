using System;

namespace QuizMasterModels.Structure.QuestionMediums {
    public abstract class Video : Medium {
        public byte[] content { get; set; }
        public string format { get; set; }
        public Video(byte[] content, string format) : base("Video") {
            this.content = content;
            this.format = format;
        }
    }
}