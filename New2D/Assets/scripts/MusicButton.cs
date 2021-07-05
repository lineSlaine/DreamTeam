using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    public Sprite _offVolume, _onVolume;
    Image _VolumeImage;
    void Start()
    {
        _VolumeImage = GetComponent<Image>();
        _VolumeImage.sprite = _onVolume; 
    }
    void Update()
    {
        
    }
    public void SwitchSpriteVolume()
    {
        if(_VolumeImage.sprite == _onVolume) _VolumeImage.sprite = _offVolume;
        else _VolumeImage.sprite = _onVolume;
    }
}

