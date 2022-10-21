using System;
using UnityEngine;

public class ColliderHandler : MonoBehaviour
{
    public Action OnDIed;
    public Action OnAllBonusGot;
    public Action OnBonusGot;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<BonusView>())
        {
            Destroy(collision.gameObject);
            OnBonusGot?.Invoke();
        }
        else if (collision.GetComponent<EnemyView>())
        {
            Destroy(gameObject);
            OnDIed?.Invoke();
        }
    }
}
