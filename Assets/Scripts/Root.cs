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
    private BonusView _bonusView;

    private SoundController _soundController;
    private CanvasController _canvasController;
    private BonusController _bonusController;


    private void Awake()
    {
        _bonusController = new BonusController(_bonusView);
        _canvasController = new CanvasController(_canvasView, _colliderHandler);
        _soundController = new SoundController(_soundView, _colliderHandler);
        
    }
    private void Update()
    {
        _bonusController.Update();
    }
}
