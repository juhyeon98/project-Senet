using UnityEngine;
using UnityEngine.InputSystem;

namespace Juhyeon.Attackable
{
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
        public ActivateData Attack()
        {
        }

        public void Damange(ActivateData data) => ApplyEffect(data);

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
    }
}

// TODO
// - Attack 구체화
// - ApplyEffect 구체화
// - OnDead 구체화