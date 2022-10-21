using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController 
{
    [SerializeField]
    private ColliderHandler _colliderHandler;

    private CanvasView _canvasView;
   

    public CanvasController(CanvasView canvasView)
    {
        _canvasView = canvasView;
        _colliderHandler.OnBonusGot += GetCoin;
    }

    public void GetCoin()
    {
        _canvasView.CoinsCounter++;
        _canvasView.CoinsCounterText.text = $"Coins: {_canvasView.CoinsCounter}";
    }
}
