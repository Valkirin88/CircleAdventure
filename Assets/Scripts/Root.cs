using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField]
    private CanvasView _canvasView;
    [SerializeField]
    private ColliderHandler _colliderHandler;
    [SerializeField]
    private SoundView _soundView;

    private SoundController _soundController;
    private CanvasController _canvasController;

    private void Awake()
    {
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _soundController = new SoundController(_soundView, _colliderHandler);
    }
 }
