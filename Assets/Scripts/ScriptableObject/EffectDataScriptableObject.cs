using UnityEngine;

namespace Juhyeon.SO
{
    public enum EStatType
    {
        HP, AP, MOV, ATK
    }

    public enum EApplyType
    {
        PLUS, MINUS, MULTIPLE
    }

    [CreateAssetMenu(fileName = "EffectData", menuName = "Scriptable Objects/Effect Data")]
    public class EffectDataScriptableObject : ScriptableObject
    {
        public uint id;

        [Tooltip("효과의 이름")]
        public string name;

        [Tooltip("효과에 대한 설명 및 특이사항")]
        public string description;

        [Tooltip("적용할 스탯이 어느 스탯인지")]
        public EStatType statType;

        [Tooltip("적용할 양을 어느정도로 할지")]
        public float applyAmount;

        [Tooltip("적용할때 어떤 방식으로 적용할 건지")]
        public EApplyType applyType;

        [Tooltip("몇 턴까지 적용할 건지")]
        public uint applyCount;

        [Tooltip("발동 확률")]
        public float probabillity;

        // 이후에 반환값을 ActivateEffectData로 변경
        public virtual void ApplyEffect(GameObject target) { }
    }
}
