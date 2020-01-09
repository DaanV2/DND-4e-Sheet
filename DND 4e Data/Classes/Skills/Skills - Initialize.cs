namespace DaanV2.DND {
    ///DOLATER <summary>add description for class: Skills</summary>
    public partial class Skills {
        /// <summary>Creates a new instance of <see cref="Skills"/></summary>
        public Skills(Details details, AbilityScores Scores) {
            this.Acrobatics = new SkillScore(details, Scores.Dexterity);
            this.Arcana = new SkillScore(details, Scores.Intelligence);
            this.Athletics = new SkillScore(details, Scores.Strength);
            this.Bluff = new SkillScore(details, Scores.Charisma);
            this.Diplomacy = new SkillScore(details, Scores.Charisma);
            this.Dungeoneering = new SkillScore(details, Scores.Wisdom);
            this.Endurance = new SkillScore(details, Scores.Constitution);
            this.Heal = new SkillScore(details, Scores.Wisdom);
            this.History = new SkillScore(details, Scores.Intelligence);
            this.Insight = new SkillScore(details, Scores.Wisdom);
            this.Intimidate = new SkillScore(details, Scores.Charisma);
            this.Nature = new SkillScore(details, Scores.Wisdom);
            this.Perception = new SkillScore(details, Scores.Wisdom);
            this.Religion = new SkillScore(details, Scores.Intelligence);
            this.Stealth = new SkillScore(details, Scores.Dexterity);
            this.Streetwise = new SkillScore(details, Scores.Charisma);
            this.Thievery = new SkillScore(details, Scores.Dexterity);
        }
    }
}
