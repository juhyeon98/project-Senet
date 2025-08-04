using UnityEngine;

namespace Juhyeon.SO
{
    [CreateAssetMenu(fileName = "StatData", menuName = "Scriptable Objects/Stat Data")]
    public class StatDataScriptableObject : ScriptableObject
    {
        public uint id;
        public uint HP;
        public uint AP;
        public uint ATK;
        public GameObject prefab;
    }
}
