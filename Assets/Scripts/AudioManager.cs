using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    public AudioSource[] music;
    public AudioSource[] sfx;

    private void Awake()
    {
        instance = this;
    }

    public void PlayMusic(int musicIndex)
    {
        music[musicIndex].Play();
    }

    public void PlaySfx(int sfxIndex)
    {
        sfx[sfxIndex].Play();
    }

    public void StopMusic()
    {
        foreach(AudioSource clip in music)
        {
            clip.Stop();
        }
    }

    public void StopSFX()
    {
        foreach (AudioSource clip in sfx)
        {
            clip.Stop();
        }
    }
}
