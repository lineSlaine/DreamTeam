using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScripts : MonoBehaviour
{
    AudioSource _music;
    void Start()
    {
        _music = GetComponent<AudioSource>();
        _music.mute = false;
    }

    public void MusicSwitchMute()
    {
        _music.mute = !_music.mute;
    }

}
