using UnityEngine;

namespace Juhyeon.Attackable
{
    public interface IAttackable
    {
        ActivateData Attack(IAttackable attackable);

        void Damage(ActivateData data);

        void Damage(uint damage);
        
        void ApplyEffect(ActivateData data);

        void OnDead();

        uint GetHP();
    }
}


// TODO
// - Player, Monster의 Attack 구현
// - Player, Monster의 ApplyEffect 구현