using UnityEngine;

namespace Juhyeon.DiceSystem
{
    [CreateAssetMenu(fileName = "DiceData", menuName = "Scriptable Objects/Dice Data")]
    public class DiceDataSO : ScriptableObject
    {
        #region Descriptions
        public string name;
        public string description;
        #endregion

        #region Data
        public DiceEffectSO[] effects = new DiceEffectSO[6];
        #endregion

        public GameObject prefab;
    }
}
