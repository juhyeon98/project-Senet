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
            // 임시
            m_field = new Tile[16, 16];
        }
        public void Reset()
        {
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

// TODO
// stage 필드 init 및 reset 로직 구현