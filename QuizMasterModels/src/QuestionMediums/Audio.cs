using System;

namespace QuizMasterModels.QuestionMediums {
    public abstract class Audio : Medium {
        public byte[] content { get; set; }
        public string format { get; set; }
        public Audio(byte[] content, string format) : base("Audio") {
            this.content = content;
            this.format = format;
        }
    }
}