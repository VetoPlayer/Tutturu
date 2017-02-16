using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerXXX : Singleton<MusicManagerXXX> {

    public AudioClip menuMusic, mainMusic, gameoverMusic;

    public void Start()
    {
        PlayMenuMusic();
    }

    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().clip = clip;
        //GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
    }

    public void PlayMenuMusic()
    {
        Play(menuMusic);
    }

    public void PlayMainMusic()
    {
        Play(mainMusic);
    }

    public void PlayGameOver()
    {
        Play(gameoverMusic);
    }

    public void Stop()
    {
        GetComponent<AudioSource>().Stop();
    }
}
