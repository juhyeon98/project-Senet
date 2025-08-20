using UnityEngine;

namespace Juhyeon.Units
{
    public class Chest : MonoBehaviour
    {
        public void Interact(IAttackable target)
        {
            if (target is Player player)
            {
                var dice = DiceFactory.MakeDice();
                player.Inventory.AddDice(dice);
            }
        }
    }
}
