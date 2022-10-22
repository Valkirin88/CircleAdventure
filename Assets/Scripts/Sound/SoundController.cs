using UnityEngine;

public class SoundController 
{
    private SoundView _soundView;
    private ColliderHandler _colliderHandler;

    public SoundController(SoundView soundView, ColliderHandler colliderHandler)
    {
        _soundView = soundView;
        _colliderHandler = colliderHandler;
        _colliderHandler.OnDIed += PlayBurst;
    }

    private void PlayBurst()
    {
        _soundView.AudioSource.PlayOneShot(_soundView.BurstSound);  
    }
}
