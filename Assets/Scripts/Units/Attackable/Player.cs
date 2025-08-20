using Juhyeon.Behaviour;
using Juhyeon.DiceSystem;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Juhyeon.Units
{
    [RequireComponent (typeof(MovementController))]
    [RequireComponent (typeof(StateMachineBehaviour))]
    [RequireComponent (typeof(StatusConditionManager))]
    [RequireComponent (typeof(DiceInventory))]
    public class Player : MonoBehaviour, IAttackable
    {
        public MovementController Controller { get; private set; }

        public StatManager Stat { get; private set; }

        public StatusConditionManager StatusCondition { get; private set; }

        public DiceInventory Inventory { get; private set; }

        public int Gold { get; private set; } = 0;

        private void Awake()
        {
            Controller = GetComponent<MovementController> ();
            Stat = GetComponent<StatManager> ();
            StatusCondition = GetComponent<StatusConditionManager> ();
            Inventory = GetComponent<DiceInventory> ();
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
            Debug.Log("Player Dead");
        }

        public void OnMove(InputAction.CallbackContext value)
        {
            var input = value.ReadValue<Vector2Int>();

            if (input.x < 0) Controller.Move(Vector2.left);
            else if (input.x > 0) Controller.Move(Vector2.right);
            else if (input.y < 0) Controller.Move(Vector2.up);
            else if (input.y > 0) Controller.Move(Vector2.down);
        }
    }
}
