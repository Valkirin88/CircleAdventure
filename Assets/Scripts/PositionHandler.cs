using System.Collections.Generic;
using UnityEngine;

public class PositionHandler 
{
    private List<Vector2> _position;
    private int _index = 0;
    private int _currentIndex;

    public PositionHandler()
    {
        _position = new List<Vector2>();
    }

    public List<Vector2> Position => _position;

    public void AddPosition(Vector2 position)
    {
        Position.Add(position);
    }

    public Vector2 GetPosition()
    {
        if (Position.Count > _index)
        {
            _currentIndex = _index;
            _index++;
            return Position[_currentIndex];
        }
        else 
            return Position[_currentIndex];
    }
}
