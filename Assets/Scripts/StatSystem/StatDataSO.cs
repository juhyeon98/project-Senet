using UnityEngine;

namespace Juhyeon.StatSystem
{
    public enum EStatType
    {
        HP, AP, MOV, ATK
    }

    [CreateAssetMenu(fileName = "StatData", menuName = "Scriptable Objects/Stat Data")]
    public class StatDataSO : ScriptableObject
    {
        #region Descirption
        public string name;
        public string description;
        #endregion

        #region Data
        [Range(0, 100)] public byte HP;
        [Range(0, 100)] public byte AP;
        [Range(0, 100)] public byte MOV;
        [Range(0, 100)] public byte ATK;
        #endregion

        public GameObject prefab;
    }
}
