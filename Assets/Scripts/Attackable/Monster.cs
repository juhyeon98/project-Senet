using UnityEngine;
using Juhyeon.Behaviour;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;

namespace Juhyeon.Attackable
{
    [RequireComponent(typeof(AIBehaviour))]
    public class Monster : MonoBehaviour, IAttackable
    {
        #region Feild
        private MovementController m_movementController;
        private StatManager m_statManager;
        private StatusConditionManager m_statusConditionManager;
        private AIBeauvour m_aiBeauvour;
        #endregion

        #region Override
        public ActivateData Attack()
        {
        }

        public void Damage(ActivateData data) => ApplyEffect(data);

        public void ApplyeEffect(ActivateData data)
        {
        }

        public void OnDead() => gameObject.SetActive(false);
        #endregion

        private void Awake()
        {
            m_movementController = GetComponent<MovementController>();
            m_statManager = GetComponent<StatManager>();
            m_statusConditionManager = GetComponent<StatusConditionManager>();
            m_aiBeauvour = GetComponent<AIBehaviour>();
        }
    }
}
