using UnityEngine;

[System.Serializable]
public class Sound
{
    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;
    public string name;
    public float volume;
    public bool loop;
    public float pitch;
}
