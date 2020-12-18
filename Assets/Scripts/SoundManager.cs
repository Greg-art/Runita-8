using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip _portalClip;
    [SerializeField] private AudioClip _deathClip;
    [SerializeField] private AudioClip _pickupClip;
    [SerializeField] private AudioClip _dragonClip;
    [SerializeField] private AudioClip _song1;
    [SerializeField] private AudioClip _song2;
    [SerializeField] private AudioSource _audioSource;

    public static SoundManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            SoundManager.Instance.PlaySong(1, 1f);
        }

        _audioSource = GetComponent<AudioSource>();

    }

    public void PlayDeathClip()
    {
        _audioSource.PlayOneShot(_deathClip, 5.0f);
    }

    public void PlayDragonClip()
    {
        _audioSource.PlayOneShot(_dragonClip, 0f);
    }

    public void PlayPickupClip()
    {
        _audioSource.PlayOneShot(_pickupClip);
    }

    public void PlayPortalClip()
    {
        _audioSource.PlayOneShot(_portalClip);
    }

    public void PlaySong(int songNumber, float pitchModifier)
    {
        if (songNumber <= 1)
        {
            _audioSource.Stop();
            _audioSource.clip = _song1;
            _audioSource.pitch = pitchModifier;
            _audioSource.Play();
        }
        else
        {
            _audioSource.Stop();
            _audioSource.clip = _song2;
            _audioSource.Play();
        }
    }
}
