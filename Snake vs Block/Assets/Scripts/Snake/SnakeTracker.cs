using Zenject;
using UnityEngine;

public class SnakeTracker : MonoBehaviour
{
    private SnakeHead _snakeHead;
    [SerializeField] private float _speed;
    [SerializeField] private float _offsetY;

    [Inject]
    private void Construct(SnakeHead snakeHead)
    {
        _snakeHead = snakeHead;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, GetTargetPosition(), _speed * Time.fixedDeltaTime);
    }

    private Vector3 GetTargetPosition()
    {
        return new Vector3(transform.position.x, _snakeHead.transform.position.y + _offsetY, transform.position.z);
    }
}
