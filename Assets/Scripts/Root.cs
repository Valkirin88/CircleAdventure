using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField]
    private CanvasView _canvasView;
    [SerializeField]
    private ColliderHandler _colliderHandler;
    [SerializeField]
    private SoundView _soundView;
    [SerializeField]
    private PlayerView _playerView;

    private SoundController _soundController;
    private CanvasController _canvasController;
    private PlayerController _playerController;

    private void Awake()
    {
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _soundController = new SoundController(_soundView, _colliderHandler);
        _playerController = new PlayerController(_playerView, _colliderHandler);
    }

    private void Update()
    {
        _playerController.Update();
    }
}
