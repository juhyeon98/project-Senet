using System.Collections;
using UnityEngine;

namespace Juhyeon.Behaviour
{
    public class MovementController : MonoBehaviour
    {
        #region Fields
        private Rigidbody2D m_rigidbody;
        private Animator m_animator;
        private SpriteRenderer m_spriteRenderer;
        private Vector2Int m_fieldPosition;

        public float movingSpeed = 5f;
        #endregion

        #region Movement Methods
        public EObjectType Move(Vector2 direction)
        {

        }

        public IEnumerable MoveSmooth(Vector2 direction)
        {
        }
        #endregion

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody2D>();
            m_animator = GetComponent<Animator>();
            m_spriteRenderer = GetComponent<SpriteRenderer>();
            m_fieldPosition = new Vector2Int((int)m_rigidbody.position.x, (int)m_rigidbody.position.y);
        }
    }
}
