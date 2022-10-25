using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private bool _isPositionReached = true;
    private int _positionsCounter = 0;
    private Vector2 _mousePosition;
    private Vector2 _targetPosition;
    private Queue<Vector2> _queue;

    private void Awake()
    {
        _queue = new Queue<Vector2>();
        _targetPosition = transform.position;
    }
    void Update()
    {
        if (_queue.Count > 0)
        {
            MovePlayer();
        }
       
        if (Input.GetMouseButtonDown(0))
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _queue.Enqueue(_mousePosition);
            _isPositionReached = false;
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        if (_isPositionReached)
        {
            _isPositionReached = false;
        }
        else
        {
            var offset = _speed * Time.deltaTime;
            var distance = Vector2.Distance(transform.position, _targetPosition);
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, offset);
            if (distance < 0.1)
            {
                _isPositionReached = true;
                _targetPosition = _queue.Dequeue();
            }
        }
    }
}

