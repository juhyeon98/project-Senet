using UnityEngine;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(MovementComponent))]
    [RequireComponent (typeof(StatManagerComponent))]
    [RequireComponent (typeof(StatusConditionComponent))]

    public abstract class AActor : MonoBehaviour
    {
        protected MovementComponent movement;
        protected StatManagerComponent statManger;
        protected StatusConditionComponent statusCondition;

        protected virtual void Awake()
        {
            movement = GetComponent<MovementComponent>();
            if (movement == null)
            {
                throw new System.Exception("Actor : MovementComponent not exist");
            }

            statManger = GetComponent<StatManagerComponent>();
            if (statManger == null)
            {
                throw new System.Exception("Actor : StatManagerComponent not exist");
            }

            statusCondition = GetComponent<StatusConditionComponent>();
            if (statusCondition == null)
            {
                throw new System.Exception("Actor : StatusConditionCompoment not exist");
            }
        }

        // Damage¿Í Attack
    }
}

