using Juhyeon.SO;

namespace Juhyeon.Dice
{
    public class ActivateEffectData
    {
        public EffectDataScriptableObject effectDataRefernce;

        public ActivateEffectData(EffectDataScriptableObject EffectData)
        {
            effectDataRefernce = EffectData;
        }

        public void Activate() { }
    }
}
