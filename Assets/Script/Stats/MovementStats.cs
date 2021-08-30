using System;
using UnityEditor;
using UnityEngine;

namespace Movment.Stats
{

    [Serializable, CreateAssetMenu(menuName = "GeneralStats/MovementStats", fileName = "MovementData", order = 2)]
    public class MovementStats : ScriptableObject
    {

        private float m_speedWalking;
        public float SpeedWalking => m_speedWalking;

        private float m_heightOfJump;
        public float HeightOfJump => m_heightOfJump;

        private float m_speedInAir;
        public float SpeedInAir => m_speedInAir;


        public void OnGui()
        {
            m_speedWalking = EditorGUILayout.FloatField("Speed walking", m_speedWalking);
        }
    }
}