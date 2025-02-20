﻿using UnityEngine;
using System.Collections;

public class GameDatabase : MonoBehaviour
{
    private static GameDatabase _instance;
    public static GameDatabase Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<GameDatabase>();
            return _instance;
        }

    }

    [SerializeField]
    private SlimeScriptableObject m_slimeDatabase;
    public SlimeScriptableObject SlimeDatabase
    {
        get
        {
            if (m_slimeDatabase == null)
                m_slimeDatabase = new SlimeScriptableObject();
            return m_slimeDatabase;
        }
    }
    [SerializeField]
    private EnemyScriptableObject m_enemyDatabase;
    public EnemyScriptableObject EnemyDatabase
    {
        get
        {
            if (m_enemyDatabase == null)
                m_enemyDatabase = new EnemyScriptableObject();
            return m_enemyDatabase;
        }
    }

    [SerializeField]
    private SkillScriptableObject m_skillDatabase;
    public SkillScriptableObject SkillDatabase
    {
        get
        {
            if (m_skillDatabase == null)
                m_skillDatabase = new SkillScriptableObject();
            return m_skillDatabase;
        }
    }


    [SerializeField]
    private SkillScriptableObject m_myskillDatabase;
    public SkillScriptableObject MySkillDatabase
    {
        get
        {
            if (m_myskillDatabase == null)
                m_myskillDatabase = new SkillScriptableObject();
            return MySkillDatabase;
        }
    }


}
