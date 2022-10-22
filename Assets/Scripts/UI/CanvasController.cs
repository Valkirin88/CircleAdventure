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
        _canvasView.GameOverText.gameObject.SetActive(false);
        _canvasView.LevelCompletedText.gameObject.SetActive(false);
        _canvasView.RestartButton.onClick.AddListener(RestartGame);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void ShowGameOver()
    {
        _canvasView.GameOverText.gameObject.SetActive(true);
        _canvasView.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void ShowLevelComplete()
    {
        _canvasView.LevelCompletedText.gameObject.SetActive(true);
        _canvasView.RestartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void GetCoin()
    {
        _canvasView.CoinsCounter++;
        _canvasView.CoinsCounterText.text = $"Coins: {_canvasView.CoinsCounter}";
    }
} 
