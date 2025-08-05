using Juhyeon.Actor;
using Juhyeon.SO;
using UnityEngine;

namespace Juhyeon.Dice
{
    public class Dice : MonoBehaviour
    {
        private EffectDataScriptableObject[] m_effects = new EffectDataScriptableObject[6];

        public ActivateEffectData SelectEffect()
        {
            var selected = m_effects[Random.Range(0, m_effects.Length)];
            return new ActivateEffectData(selected);
        }
    }
}
