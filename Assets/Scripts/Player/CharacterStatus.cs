using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Stats
{
    [HideInInspector]
    public float curValue;
    public float maxValue;
    public float startValue;
    public Image uiBar;

public void Add(float amount)
{
    curValue = Mathf.Min(curValue + amount, maxValue);
}

public void Subtract(float amount)
{
    curValue = Mathf.Max(curValue - amount, 0.0f);
}

public float GetPercentage()
{
    return curValue / maxValue;
}

}

public class CharacterStatus : MonoBehaviour
{
    public enum StatsChangeType
    {
        Add,
        Multiple,
        Override,
    }

    [Serializable]
    public class CharacterStats
    {
        public StatsChangeType statsChangeType;
        public int Health;
        public int atk;
        public int def;
        public int crt;

    }
}

