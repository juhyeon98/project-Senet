using UnityEngine;

namespace Juhyeon.StatSystem
{
    [CreateAssetMenu(fileName = "StatData", menuName = "Scriptable Objects/Stat Data")]
    public class StatDataSO : ScriptableObject
    {
        #region Descirption
        public string name;
        public string description;
        #endregion

        #region Data
        [Range(0, 100)] public float HP;
        [Range(0, 100)] public float AP;
        [Range(0, 100)] public int MOV;
        [Range(0, 100)] public float ATK;
        #endregion

        public GameObject prefab;
    }
}
