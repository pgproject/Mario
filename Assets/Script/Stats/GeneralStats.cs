using System.Collections;
using System.Collections.Generic;
using Movment.PlayerStates;
using Movment.Stats;
using UnityEngine;

public sealed class GeneralStats
{
    private PlayerStats m_palyerStats;
    public PlayerStats PlayerStats => m_palyerStats;

    private MovementStats m_movementStats;

    public MovementStats MovementStats => m_movementStats;
    
    private static GeneralStats m_instance = null;

    public static GeneralStats Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new GeneralStats();
                Instance.CreateInstance();
            }
            return m_instance;
        }
    }

    public void CreateInstance()
    {
        m_movementStats = Resources.Load<MovementStats>("MovementData");        
        m_palyerStats = Resources.Load<PlayerStats>("PlayerData");
    }
}
