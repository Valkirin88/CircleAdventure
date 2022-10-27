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
            _colliderHandler.OnAllBonusGot += PlayWin;
        }

        private void PlayBurst()
        {
            _soundView.AudioSource.PlayOneShot(_soundView.BurstSound);
        }

        private void PlayCoin()
        {
            _soundView.AudioSource.PlayOneShot(_soundView.CoinSound);
        }

        private void PlayWin()
        {
            _soundView.AudioSource.PlayOneShot(_soundView.WinSound);
        }
    }

