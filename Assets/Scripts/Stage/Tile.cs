using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum ETileType
    {
        None, Trap, WaterPuddle, PoisionPuddle, Chest
    }

    public class Tile : MonoBehaviour
    {
        public ETileType Type { get; set; }

        public virtual ActivateData ApplyEffect()
        {
            return null;
        }
    }
}
