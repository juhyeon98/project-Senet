using UnityEngine;

namespace Juhyeon.DiceSystem
{
    public class Dice : MonoBehaviour
    {
        public DiceDataSO Data;

        public DiceEffectSO RoleDice()
        {
            return Data?.effects[Random.Range(0, 6)];
        }
    }
}
