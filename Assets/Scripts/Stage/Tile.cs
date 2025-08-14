using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum ETileType
    {
        None, Trap, WaterPuddle, PoisionPuddle, Chest
    }

    public class Tile : MonoBehaviour
    {
        public ETileType TileType { get; set; } = ETileType.None;

        public IAttackable OnTile { get; set; } = null;

        public virtual ActivateData ApplyEffect()
        {
            return null;
        }
    }
}
