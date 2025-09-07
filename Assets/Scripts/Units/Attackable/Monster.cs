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
            target.Damage(Stat.ATK);
        }

        public void Damage(float atk)
        {
            Stat.UpdateHP(Stat.HP - atk);
            if (Stat.HP == 0) Dead();
        }

        public void Heal(float value)
        {
            Stat.UpdateHP(Stat.HP + value);
        }

        public void Dead()
        {
            gameObject.SetActive(false);
            Debug.Log("Monster Dead");
        }
    }
}
