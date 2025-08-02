using UnityEngine;
using UnityEngine.InputSystem;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(DiceInventoryComponent))]
    public class Player : AActor
    {
        private DiceInventoryComponent m_diceInventory;

        private void Start()
        {
            m_diceInventory = GetComponent<DiceInventoryComponent>();
            if (m_diceInventory == null)
            {
                throw new System.Exception("Player: DiceInventory not exist");
            }
        }

        public void OnMoveInput(InputAction.CallbackContext context)
        {
            Vector2 input = context.ReadValue<Vector2>();
            Vector2 direction = Vector2.zero;

            if (input.x < 0) direction = Vector2.left;
            else if (input.x > 0) direction = Vector2.right;
            else if (input.y < 0) direction = Vector2.up;
            else if (input.y > 0) direction = Vector2.down;

            movement.MoveTo(direction);
        }

        // RoleDice

        // GetDice -> 주사위를 얻었을 때

        // PutDownDice -> 주사위를 버릴 때
    }
}
