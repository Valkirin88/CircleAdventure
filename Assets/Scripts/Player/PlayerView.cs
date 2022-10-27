using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private Sprite _burstSprite;
    public SpriteRenderer SpriteRenderer;
    [SerializeField]
    private float _speed = 10.0f;

    public float Speed => _speed;

    public Sprite BurstSprite  => _burstSprite;

    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
