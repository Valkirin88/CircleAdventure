using UnityEngine;

public class SoundView : MonoBehaviour
{
    [SerializeField]
    private AudioClip _burstSound;

    [SerializeField]
    private AudioClip _coinSound;

    [SerializeField]
    private AudioSource _audioSource;

    public AudioClip BurstSound  => _burstSound;

    public AudioSource AudioSource => _audioSource;

    public AudioClip CoinSound  => _coinSound; 
}
