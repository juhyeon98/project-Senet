using Juhyeon.Stage;
using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class Stage : MonoBehaviour
    {
        private Tile[,] m_field;
        private Tile m_exitTile;

        public void Initialize()
        {
            m_field = new Tile[16, 16];
        }

        public bool IsPlayerExit()
        {
            return m_exitTile?.Unit is Player;
        }

        public IUnit GetOnTile(uint x, uint y)
        {
            return m_field[y, x].Unit;
        }
    }
}
