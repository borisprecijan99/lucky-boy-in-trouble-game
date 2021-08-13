using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Sound[] sounds;
    private PauseMenu pauseMenu;

    void Start()
    {
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;
            sound.source.pitch = sound.pitch;
        }
        pauseMenu = FindObjectOfType<PauseMenu>();
    }

    public void Play(string name)
    {
        if (!pauseMenu.IsPaused())
        {
            Sound sound = Array.Find(sounds, sound => sound.name == name);
            if (!sound.source.isPlaying)
                sound.source.Play();
        }
    }

    public void PlayIfIsPlaying(string name)
    {
        if (!pauseMenu.IsPaused())
        {
            Sound sound = Array.Find(sounds, sound => sound.name == name);
            sound.source.Play();
        }
    }

    public void Stop(string name)
    {
        Sound sound = Array.Find(sounds, sound => sound.name == name);
        if (sound.source.isPlaying)
            sound.source.Stop();
    }
}
