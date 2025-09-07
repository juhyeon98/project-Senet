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

#region Test
        public Dice dice;
#endregion

        private void Awake()
        {
            Controller = GetComponent<MovementController>();
            Stat = GetComponent<StatManager>();
            StatusCondition = GetComponent<StatusConditionManager>();
            Inventory = GetComponent<DiceInventory>();

            Stat.RestoreToBase();
            
            #region Test
            Inventory.AddDice(dice);
            foreach (var effect in Inventory.RoleDice())
            {
                Debug.Log(effect.name);
                effect.ApplyEffect(this);
                Stat.ShowAllStat();
            }
            #endregion
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
