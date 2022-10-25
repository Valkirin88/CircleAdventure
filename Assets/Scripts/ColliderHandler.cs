using System;
using UnityEngine;
using System.Linq;

public class ColliderHandler : MonoBehaviour
{
    public Action OnDIed;
    public Action OnAllBonusGot;
    public Action OnBonusGot;
    private int _bonusAmount;
    private float _deathTimer = 1f;

    private void Start()
    {
        _bonusAmount = FindObjectsOfType<MonoBehaviour>().OfType<IBonus>().ToArray().Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent(typeof(IBonus)))
        {
            _bonusAmount--;
            if(_bonusAmount <= 0)
            {
                OnAllBonusGot?.Invoke();
            }
            Destroy(collision.gameObject);
            OnBonusGot?.Invoke();
        }
        else if (collision.GetComponent(typeof(IEnemy)))
        {
            Destroy(gameObject, _deathTimer);
            OnDIed?.Invoke();
        }
    }
}
