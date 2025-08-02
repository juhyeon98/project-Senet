using UnityEngine;

namespace Juhyeon.SO
{
    [CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable Objects/MonsterDataScriptableObject")]
    public class MonsterDataScriptableObject : ScriptableObject
    {
        public uint id;
        public string name;
        public string description;
        public GameObject prefab;
        public uint HP;
        public uint AP;
        public uint ATK;

        // 이후에 반환값을 ActivateEffectData로 변경
        public virtual void Attack() { }
    }
}
