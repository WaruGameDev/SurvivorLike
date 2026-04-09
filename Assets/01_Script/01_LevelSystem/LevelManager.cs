using System;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int actuallevel = 1;
    public float expToNextLevel= 100;
    public float currentExp=0;
    public Action onLevelUp;

    public GameObject particlesLevelUp;

    void Awake()
    {
        instance = this;
    }

    public void AddExp(float exp)
    {
        currentExp += exp;
        if(currentExp >= expToNextLevel)
        {
            currentExp -= expToNextLevel;
            LevelUp();
        }
    }

    public void LevelUp()
    {
        actuallevel++;
        expToNextLevel += 100;
        onLevelUp?.Invoke();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddExp(10);
        }
    }
}
