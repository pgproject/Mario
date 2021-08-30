using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[Serializable, CreateAssetMenu(fileName = "PlayerData", menuName = "GeneralStats/PlayerStats", order = 1)]
public class PlayerStats : ScriptableObject
{
    [SerializeField] private int m_startHp;
    public int StartHp => m_startHp;

    [SerializeField] private int m_hp;
    public int Hp => m_hp;

    [SerializeField] private int m_maxHp;
    public int MaxHp => m_maxHp;

    [SerializeField] private int m_damage;
    public int Damage => m_damage;
    
    public void OnGui()
    {
        m_startHp = EditorGUILayout.IntField("Start Hp", m_startHp);
        m_hp = EditorGUILayout.IntField("Hp", m_hp);
        m_maxHp = EditorGUILayout.IntField("Max Hp", m_maxHp);
        m_damage = EditorGUILayout.IntField("Damage", m_damage);
    }
}
