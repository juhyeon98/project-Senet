using Juhyeon.Units;
using Juhyeon.StageSystem;
using System.Collections;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Juhyeon.Behaviour
{
    public enum EMovementType
    {
        None, Move, Attack
    }

    public class MovementController : MonoBehaviour
    {
        #region Fields
        private Animator m_animator;
        private SpriteRenderer m_spriteRenderer;
        private Vector2Int m_fieldPosition;
        private bool b_isMoving = false;

        public float movingSpeed = 5f;
        public float attackSpeed = 5f;
        #endregion

        #region Movement Methods
        public EMovementType Move(Vector2 direction)
        {
            if (b_isMoving == true)
            {
                return EMovementType.None;
            }

            Vector2Int nextFieldPosition = m_fieldPosition;
            if (direction == Vector2Int.left) nextFieldPosition.x--;
            else if (direction == Vector2Int.right) nextFieldPosition.x++;
            else if (direction == Vector2Int.up) nextFieldPosition.y--;
            else if (direction == Vector2Int.down) nextFieldPosition.y++;

            // Stage ���� ������ ���� ���⿡ �׽�Ʈ�� �ڷ�ƾ�� �ۼ�
             StartCoroutine(MoveAnimation(direction, nextFieldPosition));

            if (StageManager.Instance.Stage.GetTileType(nextFieldPosition) == ETileType.Wall)
            {
                return EMovementType.None;
            }

            var obj = StageManager.Instance.Stage.GetObject(nextFieldPosition);
            if (obj is Monster)
            {
                StartCoroutine(AttackAnimation(direction));
                return EMovementType.Attack;
            }
            
            StartCoroutine(MoveAnimation(direction, nextFieldPosition));
            return EMovementType.Move;
        }

        private IEnumerator MoveAnimation(Vector2 direction, Vector2Int nextFieldPosition)
        {
            b_isMoving = true;

            Vector2 start = transform.position;
            Vector2 destination = (Vector2)transform.position + direction * 2;

            yield return StartCoroutine(Lerp(start, destination, movingSpeed));

            m_fieldPosition = nextFieldPosition;
            b_isMoving = false;
        }

        private IEnumerator AttackAnimation(Vector2 direction)
        {
            b_isMoving = true;
            
            Vector2 start = transform.position;
            Vector2 destination = (Vector2)transform.position + direction;

            yield return StartCoroutine(Lerp(start, destination, attackSpeed));

            destination = start;
            start = transform.position;

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
                transform.position = Vector2.Lerp(start, destination, fractionLerp);
                yield return null;
            }
            transform.position = destination;
        }
        #endregion

        private void Awake()
        {
            m_animator = GetComponent<Animator>();
            m_spriteRenderer = GetComponent<SpriteRenderer>();
            m_fieldPosition = new Vector2Int((int)transform.position.x, (int)transform.position.y);
        }
    }
}
