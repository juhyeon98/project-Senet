using UnityEngine;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(MovementComponent))]
    [RequireComponent (typeof(StatManagerComponent))]
    [RequireComponent (typeof(StatusConditionComponent))]

    public abstract class AActor : MonoBehaviour
    {
        private MovementComponent m_movement;
        private StatManagerComponent m_statManager;
        private StatusConditionComponent m_statusCondition;

        private void Start()
        {
            m_movement = GetComponent<MovementComponent>();
            if (m_movement == null)
            {
                throw new System.Exception("Actor : MovementComponent not exist");
            }

            m_statManager = GetComponent<StatManagerComponent>();
            if (m_statManager == null)
            {
                throw new System.Exception("Actor : StatManagerComponent not exist");
            }

            m_statusCondition = GetComponent<StatusConditionComponent>();
            if (m_statusCondition == null)
            {
                throw new System.Exception("Actor : StatusConditionCompoment not exist");
            }
        }

        // Damage¿Í Attack
    }
}

