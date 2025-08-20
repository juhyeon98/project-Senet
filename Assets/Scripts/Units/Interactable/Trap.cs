using UnityEngine;

namespace Juhyeon.Units
{
    public class Trap : MonoBehaviour, IInteractable
    {
        public float damage;

        public void Interact(IAttackable target)
        {
            target.Damage(damage);
            target.Controller.GoBack();
        }
    }
}
