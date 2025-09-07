using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "AP x2", menuName = "Scriptable Objects/Effect/AP x2")]
	public class DoubleAPEffectSO : DiceEffectSO
	{
		public override void ApplyEffect(Player target)
		{
			var ap = target.Stat.Base.AP * 2;
			target.Stat.UpdateAP(ap);
		}
	}
}