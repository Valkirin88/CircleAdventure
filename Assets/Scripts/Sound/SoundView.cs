using UnityEngine;

public class SoundView : MonoBehaviour
{
    [SerializeField]
    private AudioClip _burstSound;

    [SerializeField]
    private AudioClip _coinSound;

    [SerializeField]
    private AudioClip _winSound;

    [SerializeField]
    private AudioSource _audioSource;

    public AudioClip BurstSound => _burstSound;

    public AudioSource AudioSource => _audioSource;

    public AudioClip CoinSound => _coinSound;

    public AudioClip WinSound => _winSound;
}
