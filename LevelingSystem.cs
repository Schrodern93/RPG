using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class LevelingSystem
    {
        public int level;
        public int currentExperience;
        public int experienceToNextLevel;

        public LevelingSystem()
        {
            level = 1;
            currentExperience = 0;
            experienceToNextLevel = 100;

        }

        public void AddExperience(int amount)
        {
            currentExperience += amount;
            if (currentExperience >= experienceToNextLevel)
            {
                level++;
                currentExperience -= experienceToNextLevel;
            }
        }

        public int GetLevelNumber()
        {
            return level;
        }

        public float GetExperienceNormalized()
        {
            return (float)currentExperience / experienceToNextLevel;
        }
    }
}
