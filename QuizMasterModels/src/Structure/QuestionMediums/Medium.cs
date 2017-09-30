using System;

namespace QuizMasterModels.Structure.QuestionMediums {
    public abstract class Medium {
        public string name { get; set; }

        public Medium(string name){
            this.name = name;
        }
    }
}