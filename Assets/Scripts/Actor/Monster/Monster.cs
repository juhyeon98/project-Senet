using UnityEngine;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(AISystemComponent))]
    public class Monster : AActor
    {
        public Juhyeon.SO.MonsterDataScriptableObject stat;
        private AISystemComponent m_aiSystem;

        private void Awake()
        {
            statManger.statData = stat;
            m_aiSystem = GetComponent<AISystemComponent> ();
            if (m_aiSystem == null)
            {
                throw new System.Exception("Monster: AISystemComponent not exist");
            }
        }
    }
}
