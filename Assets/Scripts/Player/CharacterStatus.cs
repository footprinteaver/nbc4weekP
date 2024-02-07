using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

