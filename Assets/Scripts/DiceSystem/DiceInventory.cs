using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.DiceSystem
{
    public class DiceInventory : MonoBehaviour
    {
        private List<Dice> m_dices = new List<Dice>();
        private int maxSize = 3;

        public void AddDice(Dice dice)
        {
            if (m_dices.Count > maxSize) return;
            m_dices.Add(dice);
        }

        public void PutdownDice(Dice dice)
        {
            if (m_dices.Count == 1) return;
            m_dices.Remove(dice);
        }

        public IEnumerable<Dice> GetAllDice()
        {
            foreach (var dice in m_dices)
            {
                yield return dice;
            }
        }

        public void UpdateMaxSize(int value)
        {
            if (maxSize + value <= 0) maxSize = 1;
            else maxSize = maxSize + value;
        }

        public void RoleDice()
        {
            foreach (var dice in m_dices)
            {
                var resultEffect = dice.RoleDice();
                // apply
            }
        }
    }
}

// TODO
// - 주사위를 굴렸을 때, 적용하기
// - Awake시 기본 주사위 생성