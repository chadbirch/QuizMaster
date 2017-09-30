using System;
using QuizMasterModels.Structure.Questions;
using QuizMasterModels.Structure.Teams;
using QuizMasterModels.Structure.Categories;

namespace QuizMater.Games
{
    public abstract class Game {
        public Category[] categories { get; set; }
        public Team[] teams { get; set; }

        public Game(Category[] categories, Team[] teams) {
            this.categories = categories;
            this.teams = teams;
        }
    }
}