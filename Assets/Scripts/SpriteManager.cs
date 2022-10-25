using UnityEngine;

public class SpriteManager : MonoBehaviour
{
   [SerializeField]
    private Sprite _burstSprite;
    private SpriteRenderer _spriteRenderer;
    private ColliderHandler _colliderHandler;

    private void Awake()
    {
        _colliderHandler = GetComponent<ColliderHandler>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _colliderHandler.OnDIed += ChangeSprite;
    }

    private void ChangeSprite()
    {
        _spriteRenderer.sprite = _burstSprite;
    }
}
