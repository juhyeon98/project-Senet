using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Juhyeon.Behaviour;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;
using Juhyeon.DiceSystem;

namespace Juhyeon.Attackable
{
    [RequireComponent(typeof(MovementController))]
    [RequireComponent(typeof(StatManager))]
    [RequireComponent(typeof(StatusConditionManager))]
    [RequireComponent(typeof(DiceInventory))]
    public class Player : MonoBehaviour, IAttackable
    {
        #region Field
        private MovementController m_movementController;
        private StatManager m_statManager;
        private StatusConditionManager m_statusConditionManager;
        private DiceInventory m_diceInventory;
        private List<DiceEffectSO> m_diceEffects = new List<DiceEffectSO>();
        public int Gold { get; private set; }
        #endregion

        #region Override
        public ActivateData Attack(IAttackable attackable)
        {
            return null;
        }

        public void Damage(ActivateData data) => ApplyEffect(data);

        public void Damage(uint damage)
        {
            m_statManager.UpdateCurrentStatValue(EStatType.HP, (int)damage * -1);
            if (m_statManager.GetCurrentStatValue(EStatType.HP) <= 0)
            {
                OnDead();
            }
        }

        public void ApplyEffect(ActivateData data)
        {
        }

        public void OnDead() => gameObject.SetActive(false);

        public uint GetHP() => (uint)m_statManager.GetCurrentStatValue(EStatType.HP);
        #endregion

        #region Player Methods
        public void RoleDice()
        {
            m_diceEffects.Clear();
            foreach (var effect in m_diceInventory.RoleDice())
            {
                m_diceEffects.Add(effect);
            }
            // apply
        }

        public List<DiceEffectSO> DiceEffects => m_diceEffects;

        public void OnMove(InputAction.CallbackContext value)
        {
            Vector2 input = value.ReadValue<Vector2>();
            if (input.x < 0) m_movementController.Move(Vector2.left);
            else if (input.x > 0) m_movementController.Move(Vector2.right);
            else if (input.y < 0) m_movementController.Move(Vector2.down);
            else if (input.y > 0) m_movementController.Move(Vector2.up);
            m_statusConditionManager.UpdateStatusCondition();
        }
        #endregion

        private void Awake()
        {
            m_movementController = GetComponent<MovementController>();
            m_statManager = GetComponent<StatManager>();
            m_statusConditionManager = GetComponent<StatusConditionManager>();
            m_diceInventory = GetComponent<DiceInventory>();

        }

        private void Start()
        {
            // 상태 이상 적용은 Start 이후부터 해야함
        }
    }
}

// TODO
// - Attack 구체화
// - ApplyEffect 구체화
// - OnDead 구체화
// - RoleDice 주사위 효과 적용하기