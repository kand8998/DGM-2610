using System;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public GameAction Action;
    private AudioSource audioSource;

    private void Start()
    {
        Action.action += StopMusic;
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
