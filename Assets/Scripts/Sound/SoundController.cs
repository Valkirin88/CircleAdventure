
public class SoundController 
{
    private SoundView _soundView;
    private ColliderHandler _colliderHandler;

    public SoundController(SoundView soundView, ColliderHandler colliderHandler)
    {
        _soundView = soundView;
        _colliderHandler = colliderHandler;
        _colliderHandler.OnDIed += PlayBurst;
        _colliderHandler.OnBonusGot += PlayCoin;
    }

    private void PlayCoin()
    {
        _soundView.AudioSource.PlayOneShot(_soundView.CoinSound);
    }

    private void PlayBurst()
    {
        _soundView.AudioSource.PlayOneShot(_soundView.BurstSound);  
    }
}
