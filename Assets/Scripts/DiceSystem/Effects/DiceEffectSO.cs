using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.DiceSystem
{
    [CreateAssetMenu(fileName = "DiceEffect", menuName = "Scriptable Objects/Dice Effect")]
    public class DiceEffectSO : ScriptableObject
    {
        #region Descripts
        public string name;
        public string descirpt;
        #endregion

        public virtual void ApplyEffect(Player target) { }
    }
}

