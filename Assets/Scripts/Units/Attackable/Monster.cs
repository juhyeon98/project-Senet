using Juhyeon.Behaviour;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;
using UnityEngine;

namespace Juhyeon.Units
{
    [RequireComponent(typeof(MovementController))]
    [RequireComponent(typeof(StateMachineBehaviour))]
    [RequireComponent(typeof(StatusConditionManager))]
    [RequireComponent(typeof(AIBehaviour))]
    public class Monster : MonoBehaviour, IAttackable
    {
        private AIBehaviour m_behaivour;

        public MovementController Controller { get; private set; }

        public StatManager Stat { get; private set; }

        public StatusConditionManager StatusCondition { get; private set; }

        private void Awake()
        {
            Controller = GetComponent<MovementController>();
            Stat = GetComponent<StatManager>();
            StatusCondition = GetComponent<StatusConditionManager>();
            m_behaivour = GetComponent<AIBehaviour>();
        }

        public void Attack(IAttackable target)
        {
            target.Damage(Stat.CurrentATK);
        }

        public void Damage(float atk)
        {
            Stat.UpdateCurrentHP(-atk);
            if (Stat.IsHPZero()) Dead();
        }

        public void Heal(float value)
        {
            Stat.UpdateCurrentHP(value);
        }

        public void Dead()
        {
            gameObject.SetActive(false);
            Debug.Log("Monster Dead");
        }
    }
}
