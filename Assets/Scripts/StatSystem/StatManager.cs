using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatSystem
{
    public class StatManager : MonoBehaviour
    {
        #region Fields
        public StatDataSO Base;

        private float m_hp;
        private float m_atk;
        private float m_ap;
        private int m_mov;
        #endregion

        #region Property
        public float HP => m_hp;
        public float ATK => m_atk;
        public float AP => m_ap;
        public int MOV => m_mov;
        #endregion

        #region Stat Manager Methods
        public void RestoreToBase()
        {
            m_hp = Base.HP;
            m_atk = Base.ATK;
            m_ap = Base.AP;
            m_mov = Base.MOV;
        }

        public void UpdateHP(float value) => UpdateValue(ref m_hp, Base.HP, value);

        public void UpdateATK(float value) => UpdateValue(ref m_atk, Base.ATK, value);

        public void UpdateAP(float value) => UpdateValue(ref m_ap, Base.AP, value);

        public void UpdateMOV(int value) => UpdateValue(ref m_mov, Base.MOV, value);

        private void UpdateValue(ref float currentStat, float baseValue, float value)
        {
            currentStat += value;
            if (currentStat > baseValue) currentStat = baseValue;
            else if (currentStat < 0) currentStat = 0;
        }

        private void UpdateValue(ref int currentStat, int baseValue, int value)
        {
            currentStat += value;
            if (currentStat > baseValue) currentStat = baseValue;
            else if (currentStat < 0) currentStat = 0;
        }
        #endregion

        private void Awake()
        {
            RestoreToBase();
        }
    }
}
