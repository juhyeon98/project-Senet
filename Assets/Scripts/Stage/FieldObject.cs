using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum EObjectType
    {
        Empty, Monster, Player
    }

    public class FieldObject : MonoBehaviour
    {
        public EObjectType Type { get; set; }
    }
}
