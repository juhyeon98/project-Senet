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

        #region Test
        public void ShowAllStat()
        {
            Debug.Log($"HP : {m_hp}\nATK : {m_atk}\nAP : {m_ap}\nMOV : {m_mov}");
        }
        #endregion

        #region Stat Manager Methods
        public void RestoreToBase()
        {
            m_hp = Base.HP;
            m_atk = Base.ATK;
            m_ap = Base.AP;
            m_mov = Base.MOV;
        }

        public void UpdateHP(float value) => m_hp = Mathf.Clamp(value, 0, Base.HP);

        public void UpdateATK(float value)
        {
            m_atk = value;
            if (m_atk <= 0) m_atk = 1;
        }

        public void UpdateAP(float value)
        {
            m_ap = value;
            if (m_ap <= 0) m_ap = 1;
        }

        public void UpdateMOV(int value)
        {
            m_mov = value;
            if (m_mov <= 0) m_mov = 1;
        }

        #endregion
    }
}
