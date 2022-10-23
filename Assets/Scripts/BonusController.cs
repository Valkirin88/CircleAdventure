using UnityEngine;

public class BonusController
{
    private BonusView _bonusView;
    [SerializeField]
    private float _movingDistance = 0.3f;
    [SerializeField]
    private float _speed = 1f;

    private Vector3 _endPosition;
    private Vector3 _coinPosition;
    private float _offset = 1f;
 
    public BonusController(BonusView bonusView)
    {
        _bonusView = bonusView;
        _coinPosition = _bonusView.GetComponent<Transform>().position;
        _endPosition = new Vector3(_coinPosition.x, _coinPosition.y + _offset, _coinPosition.z);

    }

    public void Update()
    {
        
        if (_bonusView != null)
        {
            
            var pos = Vector3.Lerp(_endPosition, _coinPosition, Mathf.PingPong(Time.time, _movingDistance));
            _coinPosition = pos;
            //_coinPosition.y = _coinPosition.y + Mathf.PingPong(Time.deltaTime * _speed, _movingDistance);
            _bonusView.transform.position = _coinPosition;
        }

        //_bonusView.GetComponent<Transform>().position.y = Mathf.PingPong(Time.deltaTime * _speed, _movingDistance);
        //_bonusView.BonusTransform.position.y= _bonusView.BonusTransform.position.y + Mathf.PingPong(Time.deltaTime * _speed, _movingDistance);
    }
}
