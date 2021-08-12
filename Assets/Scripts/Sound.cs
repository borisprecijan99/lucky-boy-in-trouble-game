using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;
    public string name;
    public float volume;
    public bool loop;
    public float pitch;
}
