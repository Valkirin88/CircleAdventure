using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField]
    private CanvasView _canvasView;
    [SerializeField]
    private ColliderHandler _colliderHandler;
    [SerializeField]
    private SoundView _soundView;

    private void Awake()
    {
        CanvasController controller = new CanvasController(_canvasView, _colliderHandler);
        SoundController soundController = new SoundController(_soundView, _colliderHandler);
    }
}
