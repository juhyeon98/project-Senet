using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "Random Teleport", menuName = "Scriptable Objects/Effect/Random Teleport")]
	public class RandomTeleportEffectSO : DiceEffectSO
	{
		#region Descripts
		public string name = "Random Teleport";
		public string descript = "랜덤한 위치로 이동";
		#endregion

		public override void ApplyEffect(Player target)
		{
			// 랜덤한 위치로 이동
		}
	}
}
