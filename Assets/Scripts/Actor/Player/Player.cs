using Juhyeon.Dice;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Juhyeon.Actor
{
    [RequireComponent (typeof(DiceInventoryComponent))]
    public class Player : AActor
    {
        private DiceInventoryComponent m_diceInventory;

        protected override void Awake()
        {
            base.Awake();
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

        public void RoleDice()
        {
            foreach (var effect in m_diceInventory.RoleAllDice())
            {
                EffectManager.ApplyEffect(effect, this);
            }
        }

        public void GetDice(Juhyeon.Dice.Dice dice)
        {
            m_diceInventory.AddOneDice(dice);
            // AddOneDice의 결과가 false -> 하나를 골라 교체
        }

        public void PutDownDice(Juhyeon.Dice.Dice dice)
        {
            // 먼저 하나를 선택
            m_diceInventory.RemoveDice(dice);
        }
    }
}
