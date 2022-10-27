using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private bool _isPositionReached = true;
    private Vector2 _touchPosition;
    private Vector2 _targetPosition;
    private Queue<Vector2> _queue;

    private void Awake()
    {
        _queue = new Queue<Vector2>();
    }
    void Update()
    {
        if (Input.touchCount > 0 )
        {
            SavePosition();
        }

        if (_isPositionReached && _queue.Count > 0)
        {
            _targetPosition = _queue.Dequeue();
            MovePlayer();
        }

        if (!_isPositionReached)
        {
            MovePlayer();
        }
    }

    private void SavePosition()
    {
        _touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        _queue.Enqueue(_touchPosition);
    }
    private void MovePlayer()
    {
        _isPositionReached = false;
        var offset = _speed * Time.deltaTime;
        var distance = Vector2.Distance(transform.position, _targetPosition);
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, offset);
        if (distance < 0.1)
        {
            _isPositionReached = true;
        }
    }
}

