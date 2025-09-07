using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "MOV -2", menuName = "Scriptable Objects/Effect/MOV -2")]
	public class Minus2MOVEffectSO : DiceEffectSO
	{
		public override void ApplyEffect(Player target)
		{
			var mov = target.Stat.Base.MOV - 2;
			target.Stat.UpdateMOV(mov);
		}
	}
}