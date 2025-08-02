using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float movingSpeed = 5f;
    private bool b_isMoving = false;

    public bool MoveTo(Vector2 direction)
    {
        if (b_isMoving)
        {
            return false;
        }
        // direction 방향으로 갈수 있는지 확인

        Vector2 targetPosition = (Vector2)transform.position + direction * 2;
        StartCoroutine(SmoothMoving(targetPosition));
        return true;
    }

    private IEnumerator SmoothMoving(Vector2 targetPosition)
    {
        b_isMoving = true;
        Vector2 position = transform.position;
        float startTime = Time.time;

        while ((Vector2)transform.position != targetPosition)
        {
            float distance = (Time.time - startTime) * movingSpeed;
            float distanceRatio = distance / Vector2.Distance(position, targetPosition);
            transform.position = Vector2.Lerp(position, targetPosition, distanceRatio);
            yield return null;
        }
        b_isMoving = false;
    }

    /* TO DO */
    // MoveTo 에서 field를 확인하는 로직 추가(이후 Stage에서 static 변수인 field를 참조)
}
