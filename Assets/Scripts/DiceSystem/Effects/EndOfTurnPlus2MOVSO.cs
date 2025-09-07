using UnityEngine;
using Juhyeon.Units;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "MOV +2 when end of turn", menuName = "Scriptable Objects/Effect/MOV +2 when end of turn")]
	public class EndOfTurnPlus2MOVSO : DiceEffectSO
	{
		#region Descripts
		public string name = "MOV +2 when end of turn";
		public string descript = "턴이 끝날 때 행동력 +2";
		#endregion

		public override void ApplyEffect(Player target)
		{
			if (target.Stat.AP == 1)
			{
				var mov = target.Stat.Base.MOV + 2;
				target.Stat.UpdateMOV(mov);
			}
		}
	}
}
