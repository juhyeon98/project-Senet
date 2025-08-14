using UnityEngine;

namespace Juhyeon.DiceSystem
{
    public class Dice : MonoBehaviour
    {
        private DiceDataSO m_data;

        public DiceEffectSO RoleDice()
        {
            return m_data.effects[Random.Range(0, 6)];
        }
    }
}
