using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinsCounterText;

    [SerializeField]
    private TMP_Text _levelCompletedText;

    [SerializeField]
    private TMP_Text _gameOverText;

    [SerializeField]
    private Button _restartButton;

    private int _coinsCounter;
    public TMP_Text CoinsCounterText { get => _coinsCounterText; set => _coinsCounterText = value; }
    public int CoinsCounter { get => _coinsCounter; set => _coinsCounter = value; }
    public Button RestartButton => _restartButton;
    public TMP_Text GameOverText { get => _gameOverText; set => _gameOverText = value; }
    public TMP_Text LevelCompletedText { get => _levelCompletedText; set => _levelCompletedText = value; }
}
