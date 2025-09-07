using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "AP -2", menuName = "Scriptable Objects/Effect/AP -2")]
	public class Minus2APSO : DiceEffectSO
	{
		#region Descripts
		public string name = "AP -2";
		public string descript = "행동력 -2";
		#endregion

		public override void ApplyEffect(Player target)
		{
			var ap = target.Stat.Base.AP - 2;
			target.Stat.UpdateAP(ap);
		}
	}
}