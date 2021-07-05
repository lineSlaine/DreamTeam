using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    public Sprite _offVolume, _onVolume;
    public GameObject _сanvas;
    AudioSource _music;
    Image _VolumeImage;
    void Start()
    {
        _VolumeImage = GetComponent<Image>();
        _music = _сanvas.GetComponent<AudioSource>();
        _music.mute = true;
        SwitchMute();
    }
    void Update()
    {
        
    }
    public void SwitchMute()
    {
        _music.mute = !_music.mute;
        if(_music.mute) _VolumeImage.sprite = _offVolume;
        else _VolumeImage.sprite = _onVolume;
    }
}

