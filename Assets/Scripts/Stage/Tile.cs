using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum ETileType
    {
        None, Wall, Trap, WaterPuddle, PoisionPuddle, Chest, Exit
    }

    public class Tile : MonoBehaviour
    {
        public ETileType TileType { get; set; } = ETileType.None;

        public IAttackable OnTile { get; set; } = null;
        
        public void Reset()
        {
            TileType = ETileType.None;
            OnTile = null;
        }

        public virtual ActivateData ApplyEffect()
        {
            return null;
        }

    }
}
