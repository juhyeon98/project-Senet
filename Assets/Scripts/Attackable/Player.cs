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
        public int Gold { get; private set; }
        #endregion

        #region Override
        public ActivateData Attack(IAttackable attackable)
        {
            return null;
        }

        public void Damage(ActivateData data) => ApplyEffect(data);

        public void ApplyEffect(ActivateData data)
        {
        }

        public void OnDead() => gameObject.SetActive(false);
        #endregion

        #region Player Methods
        public void RoleDice() => m_diceInventory.RoleDice();

        public void OnMove(InputAction.CallbackContext value)
        {
            Vector2 input = value.ReadValue<Vector2>();
            if (input.x < 0) m_movementController.Move(Vector2.left);
            else if (input.x > 0) m_movementController.Move(Vector2.right);
            else if (input.y < 0) m_movementController.Move(Vector2.down);
            else if (input.y > 0) m_movementController.Move(Vector2.up);
        }
        #endregion

        private void Awake()
        {
            m_movementController = GetComponent<MovementController>();
            m_statManager = GetComponent<StatManager>();
            m_statusConditionManager = GetComponent<StatusConditionManager>();
            m_diceInventory = GetComponent<DiceInventory>();
        }
    }
}

// TODO
// - Attack 구체화
// - ApplyEffect 구체화
// - OnDead 구체화