using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpHandler
{
    private int currentLevel = 1;
    private float currentExperience = 0f;
    private float maxExperience = 1000f;
    public int CurrentLevel
    {
        get { return currentLevel; }
        private set { currentLevel = value; }
    }
    public float MaxExperience
    {
        get { return maxExperience; }
        private set { maxExperience = value; }
    }
    public float CurrentExperience
    {
        get { return currentExperience; }
        set { currentExperience = Mathf.Clamp(value, 0f, maxExperience); }
    }
    public void GainExperience(float experienceToAdd)
    {
        currentExperience += experienceToAdd;
        if (currentExperience >= maxExperience)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        currentLevel++;
        currentExperience = 0f;
        maxExperience *= 1.5f; // Increase max experience by 50% on each level up
                               // Additional actions on level up (e.g., reward skill points, update UI)
    }
}

