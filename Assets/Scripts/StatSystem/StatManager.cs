using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatSystem
{
    public class StatManager : MonoBehaviour
    {
        #region Fields
        public StatDataSO statData;

        public float CurrentHP { get; private set; }

        public float CurrentAP { get; private set; }

        public float CurrentMOV { get; private set; }

        public float CurrentATK { get; private set; }
        #endregion

        #region Stat Manager Methods
        public void UpdateCurrentHP(float value)
        {
            CurrentHP += value;
            if (CurrentHP <= 0) CurrentHP = 0;
            else if (CurrentHP >= statData.HP) CurrentHP = statData.HP;
        }

        public bool IsHPZero()
        {
            return CurrentHP <= 0;
        }
        #endregion

        private void Awake()
        {
            CurrentHP = statData.HP;
            CurrentAP = statData.AP;
            CurrentMOV = statData.MOV;
            CurrentATK = statData.ATK;
        }
    }
}
