using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "MOV +4", menuName = "Scriptable Objects/Effect/MOV +4")]
	public class Plus4MOVEffectSO : DiceEffectSO
	{
		public override void ApplyEffect(Player target)
		{
			var mov = target.Stat.Base.MOV + 4;
			target.Stat.UpdateMOV(mov);
		}
	}
}
