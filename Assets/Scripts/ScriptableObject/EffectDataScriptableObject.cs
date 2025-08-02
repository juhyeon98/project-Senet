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

    [CreateAssetMenu(fileName = "EffectData", menuName = "Scriptable Objects/EffectDataScriptableObject")]
    public class EffectDataScriptableObject : ScriptableObject
    {
        public uint id;
        public string name;
        public string description;
        public EStatType statType;
        public float applyAmount;
        public EApplyType applyType;
        public uint applyCount;
        public float probabillity;

        // 이후에 반환값을 ActivateEffectData로 변경
        public virtual void ApplyEffect(GameObject target) { }
    }
}
