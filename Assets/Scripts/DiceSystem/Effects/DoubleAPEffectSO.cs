using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "AP x2", menuName = "Scriptable Objects/Effect/AP x2")]
	public class DoubleAPEffectSO : DiceEffectSO
	{
		#region Descripts
		public string name = "AP x2";
		public string descript = "행동력 두배";
		#endregion

		public override void ApplyEffect(Player target)
		{
			var ap = target.Stat.Base.AP * 2;
			target.Stat.UpdateAP(ap);
		}
	}
}