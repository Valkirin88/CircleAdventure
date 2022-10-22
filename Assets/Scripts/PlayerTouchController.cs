using UnityEngine;

public class PlayerTouchController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private bool _isPositionReached = true;
    private int _positionsCounter = 0;
    private Vector2 _touchPosition;
    private Vector2 _targetPosition;
    private PositionHandler _positionHandler;

    private void Awake()
    {
        _positionHandler = new PositionHandler();
    }
    void Update()
    {
        if (_positionsCounter > 0)
        {
            MovePlayer();
        }
        else if (_positionsCounter == 0)
        {
            _targetPosition = transform.position;
        }
        if (Input.touchCount > 0)
        {
               _positionsCounter++;
                _touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                SavePosition();
                _isPositionReached = false;
                MovePlayer();
        }
    }

    private void SavePosition()
    {
        _positionHandler.AddPosition(_touchPosition);
    }

    private void MovePlayer()
    {
        if (!_isPositionReached)
        {
            var offset = _speed * Time.deltaTime;
            var distance = Vector2.Distance(transform.position, _targetPosition);
            transform.position = Vector2.MoveTowards(transform.position, _targetPosition, offset);
            if (distance < 0.1)
            {
                _isPositionReached = true;
                _targetPosition = GetPosition();
            }
        }
        else if (_isPositionReached)
        {
            _isPositionReached = false;
            return;
        }
    }

    private Vector2 GetPosition()
    {
        return _positionHandler.GetPosition();
    }
}

