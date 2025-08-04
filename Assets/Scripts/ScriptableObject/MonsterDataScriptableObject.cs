using UnityEngine;

namespace Juhyeon.SO
{
    [CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable Objects/Monster Data")]
    public class MonsterDataScriptableObject : StatDataScriptableObject
    {
        public uint id;

        [Tooltip("몬스터의 이름")]
        public string name;

        [Tooltip("몬스터에 대한 설명 및 특이사항")]
        public string description;

        [Tooltip("몬스터 채력")]
        public uint HP;

        [Tooltip("몬스터 행동력 - 한 번에 몇 칸을 움직이는지")]
        public uint AP;

        [Tooltip("몬스터 공격력")]
        public uint ATK;

        public GameObject prefab;

        // 이후에 반환값을 ActivateEffectData로 변경
        public virtual void Attack() { }
    }
}
