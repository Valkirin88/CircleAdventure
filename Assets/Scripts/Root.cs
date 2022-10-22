using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField]
    private CanvasView _canvasView;
    [SerializeField]
    private ColliderHandler _colliderHandler;

    private void Awake()
    {
        CanvasController controller = new CanvasController(_canvasView, _colliderHandler);
    }
}
