using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum ETileType
    {
        None, Wall, Trap, WaterPuddle, PoisionPuddle, Chest
    }

    public class Tile
    {
        public ETileType Type { get; set; }

        public virtual ActivateData ApplyEffect()
        {
            return null;
        }
    }
}
