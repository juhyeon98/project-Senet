using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "Random Teleport", menuName = "Scriptable Objects/Effect/Random Teleport")]
	public class RandomTeleportEffectSO : DiceEffectSO
	{
		public override void ApplyEffect(Player target)
		{
			// 랜덤한 위치로 이동
		}
	}
}
