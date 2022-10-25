using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasView : MonoBehaviour
{
    [SerializeField]
    public TMP_Text _coinsCounterText;

    [SerializeField]
    public TMP_Text _levelCompletedText;

    [SerializeField]
    public TMP_Text _gameOverText;

    [SerializeField]
    private Button _restartButton;

    public int _coinsCounter;
     
    public Button RestartButton => _restartButton;
}
