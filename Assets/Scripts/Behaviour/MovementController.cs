using System.Collections;
using UnityEditor.SceneManagement;
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
        private bool b_isMoving = false;

        public float movingSpeed = 5f;
        public float attackSpeed = 5f;
        #endregion

        #region Movement Methods
        public EObjectType Move(Vector2 direction)
        {
            if (b_isMoving == false)
            {
                return EObjectType.None;
            }

            Vector2Int nextFieldPosition = m_fieldPosition;
            if (direction == Vector2Int.left) nextFieldPosition.x--;
            else if (direction == Vector2Int.right) nextFieldPosition.x++;
            else if (direction == Vector2Int.up) nextFieldPosition.y--;
            else if (direction == Vector2Int.down) nextFieldPosition.y++;
            
            EObjectType obj = Stage.GetObject(nextFieldPosition);
            switch(obj)
            {
                case EObjectType.Monster:
                    StartCoroutine(AttackAnimation(direction));
                    break;
                case EObjectType.Empty:
                    StartCoroutine(MoveAnimation(direction, nextFieldPosition));
                    break;
            }
            return obj;
        }

        private IEnumerator MoveAnimation(Vector2 direction, Vector2Int nextFieldPosition)
        {
            b_isMoving = true;

            Vector2 start = m_rigidbody.position;
            Vector2 destination = m_rigidbody.position + direction * 2;

            yield return StartCoroutine(Lerp(start, destination, movingSpeed));

            m_fieldPosition = nextFieldPosition;
            b_isMoving = false;
        }

        private IEnumerator AttackAnimation(Vector2 direction)
        {
            b_isMoving = true;
            
            Vector2 start = m_rigidbody.position;
            Vector2 destination = m_rigidbody.position + direction;

            yield return StartCoroutine(Lerp(start, destination, attackSpeed));

            destination = start;
            start = m_rigidbody.position;

            yield return StartCoroutine(Lerp(start, destination, attackSpeed));

            b_isMoving = false;
        }

        private IEnumerator Lerp(Vector2 start, Vector2 destination, float speed)
        {
            float journeyTime = Vector2.Distance(start, destination) / speed;
            float elapsedTime = 0f;

            while (elapsedTime < journeyTime)
            {
                elapsedTime += Time.deltaTime;
                float fractionLerp = Mathf.Clamp01(elapsedTime / journeyTime);
                m_rigidbody.MovePosition(Vector2.Lerp(start, destination, fractionLerp));
                yield return null;
            }
            m_rigidbody.MovePosition(destination);
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
