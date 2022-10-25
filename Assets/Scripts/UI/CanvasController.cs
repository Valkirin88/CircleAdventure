using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController
{
    private ColliderHandler _colliderHandler;
    private CanvasView _canvasView;

    public CanvasController(CanvasView canvasView, ColliderHandler colliderHandler)
    {
        _canvasView = canvasView;
        _colliderHandler = colliderHandler;
        _colliderHandler.OnBonusGot += GetCoin;
        _colliderHandler.OnAllBonusGot += ShowLevelComplete;
        _colliderHandler.OnDIed += ShowGameOver;
        _canvasView.RestartButton.gameObject.SetActive(false);
        _canvasView._gameOverText.gameObject.SetActive(false);
        _canvasView._levelCompletedText.gameObject.SetActive(false);
        _canvasView.RestartButton.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void ShowGameOver()
    {
        _canvasView._gameOverText.gameObject.SetActive(true);
        _canvasView.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void ShowLevelComplete()
    {
        _canvasView._levelCompletedText.gameObject.SetActive(true);
        _canvasView.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void GetCoin()
    {
        _canvasView._coinsCounter++;
        _canvasView._coinsCounterText.text = $"Coins: {_canvasView._coinsCounter}";
    }
} 
