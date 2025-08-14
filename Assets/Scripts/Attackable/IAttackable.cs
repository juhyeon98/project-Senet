using UnityEngine;

namespace Juhyeon.Attackable
{
    public interface IAttackable
    {
        ActivateData Attack();

        void Damage(ActivateData data);
        
        void ApplyEffect(ActivateData data);

        void OnDead();
    }
}
