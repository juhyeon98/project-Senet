using UnityEngine;

namespace Juhyeon.DiceSystem
{
	[CreateAssetMenu(fileName = "MOV +4", menuName = "Scriptable Objects/MOV +4")]
	public class Plus4MOVEffectSO : DiceEffectSO
	{
		#region Descripts
		public string name = "MOV +4";
		public string descript = "이동력 +4";
		#endregion

		public override void ApplyEffect(Player target)
		{
			var mov = target.Stat.Base.MOV + 4;
			target.Stat.UpdateMOV(mov);
		}
	}
}
