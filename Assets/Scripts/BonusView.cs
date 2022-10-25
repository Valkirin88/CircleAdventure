using UnityEngine;

public class BonusView : MonoBehaviour, IBonus
{
    private Vector3 _bonusPosition;
    private Vector3 _offsetPosition;
    private float _offset = 0.5f;

    private void Start()
    {
        _bonusPosition = transform.position;
        _offsetPosition = new Vector3(transform.position.x, transform.position.y + _offset, transform.position.z);

    }

    private void Update()
    {
        transform.position = Vector3.Lerp(_bonusPosition, _offsetPosition, Mathf.PingPong(Time.time, _offset));

    }
}
