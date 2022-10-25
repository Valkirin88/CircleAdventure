using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10.0f;
    private bool _isPositionReached = true;
    private int _positionsCounter = 0;
    private Vector2 _mousePosition;
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
        else if(_positionsCounter == 0)
        {
            _targetPosition = transform.position;
        }

        if (Input.GetMouseButtonDown(0))
        {
            _positionsCounter++;
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SavePosition();
            _isPositionReached = false;
            MovePlayer();
        }
    }

    private void SavePosition()
    {
        _positionHandler.AddPosition(_mousePosition);
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
                _targetPosition = GetPosition();
            }
        }
    }

    private Vector2 GetPosition()
    {
      return _positionHandler.GetPosition();
    }
}

