using System.Collections.Generic;
using UnityEngine;

public class PlayerController 
{
   
    [SerializeField]
    private PlayerView _playerView;

    private bool _isPositionReached = true;
    private ColliderHandler _colliderHandler;
    private Vector2 _mousePosition;
    private Vector2 _targetPosition;
    private Queue<Vector2> _queue;
   
    public PlayerController(PlayerView playerView, ColliderHandler colliderHandler)
    {
        _queue = new Queue<Vector2>();
        _playerView = playerView;   
        _colliderHandler = colliderHandler;
        colliderHandler.OnDIed += ChangeSprite;
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SavePosition();
        }

        if (_isPositionReached && _queue.Count > 0)
        {
            _targetPosition = _queue.Dequeue();
            MovePlayer();
        }

        if(!_isPositionReached)
        {
            MovePlayer();
        }
    }

    private void SavePosition()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _queue.Enqueue(_mousePosition);
    }
    private void MovePlayer()
    {
            _isPositionReached = false;
            var offset = _playerView.Speed * Time.deltaTime;
            var distance = Vector2.Distance(_playerView.transform.position, _targetPosition);
            _playerView.transform.position = Vector2.MoveTowards(_playerView.transform.position, _targetPosition, offset);
            if (distance < 0.1)
            {
                _isPositionReached = true;
            }
    }

    private void ChangeSprite()
    {
        _playerView.SpriteRenderer.sprite = _playerView.BurstSprite;
    }
}

