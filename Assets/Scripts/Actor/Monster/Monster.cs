using Juhyeon.SO;
using UnityEngine;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(AISystemComponent))]
    public class Monster : AActor
    {
        private AISystemComponent m_aiSystem;

        private void Awake()
        {
            m_aiSystem = GetComponent<AISystemComponent> ();
            if (m_aiSystem == null)
            {
                throw new System.Exception("Monster: AISystemComponent not exist");
            }
        }
    }
}
