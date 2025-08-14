using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum ETileType
    {
        None, Trap, WaterPuddle, PoisionPuddle, Chest
    }

    public enum EObjectType
    {
        None, Monster, Player
    }

    public class Tile : MonoBehaviour
    {
        public ETileType TileType { get; set; } = ETileType.None;

        public EObjectType Object { get; set; } = EObjectType.None;

        public virtual ActivateData ApplyEffect()
        {
            return null;
        }
    }
}
