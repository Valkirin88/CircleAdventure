using System;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public Action OnDIed;
    public Action OnAllBonusGot;
    public Action OnBonusGot;
    private int _bonusAmount = 0;
    private float _deathTimer = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<BonusView>())
        {
            _bonusAmount++;
            if(_bonusAmount == 7)
            {
                OnAllBonusGot?.Invoke();
            }
            Destroy(collision.gameObject);
            OnBonusGot?.Invoke();
        }
        else if (collision.GetComponent<EnemyView>())
        {
            Destroy(gameObject, _deathTimer);
            OnDIed?.Invoke();
        }
    }
}
