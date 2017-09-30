using System;

namespace QuizMasterModels.Structure.Teams {
    public abstract class Team {
        public string name { get; set; }
        public double score { get; set; }

        public Team(string name) {
            this.name = name;
        }
    }
}
