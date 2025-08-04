using UnityEngine;

namespace Juhyeon.SO
{
    [CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable Objects/Monster Data")]
    public class MonsterDataScriptableObject : StatDataScriptableObject
    {
        [Tooltip("몬스터의 이름")]
        public new string name;

        [Tooltip("몬스터에 대한 설명 및 특이사항")]
        public string description;

        // 이후에 반환값을 ActivateEffectData로 변경
        public virtual void Attack() { }
    }
}
