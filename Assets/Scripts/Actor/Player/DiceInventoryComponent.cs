using UnityEngine;
using System.Collections.Generic;
using Juhyeon.Dice;

public class DiceInventoryComponent : MonoBehaviour
{
    private List<Dice> m_dices = new List<Dice>();
    private uint m_maxSize = 3;

    private void Start()
    {
        // Dice List에 기본 주사위 하나 추가
    }

    public IEnumerable<ActivateEffectData> RoleAllDice()
    {
        foreach (var dice in m_dices)
        {
            yield return dice.SelectEffect();
        }
    }

    public bool AddOneDice(Dice dice)
    {
        if (m_dices.Count == m_maxSize) return false;
        m_dices.Add(dice);
        return true;
    }

    public bool RemoveDice(Dice dice)
    {
        if (m_dices.Count <= 1) return false;
        return m_dices.Remove(dice);
    }

    public IEnumerable<Dice> GetDices()
    {
        foreach (var dice in m_dices)
        {
            yield return dice;
        }
    }
}
