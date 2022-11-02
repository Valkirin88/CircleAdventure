using UnityEngine;
using Zenject;

public class Root : MonoBehaviour
{
    [SerializeField]
    private CanvasView _canvasView;
    private ColliderHandler _colliderHandler;
    [SerializeField]
    private SoundView _soundView;
    [SerializeField]
    private PlayerView _playerView;

    private SoundController _soundController;
    private CanvasController _canvasController;
   
   
    private PlayerController _playerController;

    

    private void Update()
    {
        _playerController.Update();
    }

    [Inject]
    private void Constructor(ColliderHandler colliderHandler)
    {
        _colliderHandler = colliderHandler;
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _soundController = new SoundController(_soundView, _colliderHandler);
        _playerController = new PlayerController(_playerView, _colliderHandler);
    }
}
