using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip _portalClip;
    [SerializeField] private AudioClip _deathClip;
    [SerializeField] private AudioClip _pickupClip;
    [SerializeField] private AudioClip _dragonClip;
    [SerializeField] private AudioSource _audioSource;

    private SoundManager Instance;

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
        }

        _audioSource = GetComponent<AudioSource>();

    }
}
