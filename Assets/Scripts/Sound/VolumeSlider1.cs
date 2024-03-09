using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider1 : MonoBehaviour
{
    public void SetMusicVolume(float volume)
    {
        SoundManager1.Instance.SetMusicVolume(volume);
    }
    public void SetEffectVolume(float volume)
    {
        SoundManager1.Instance.SetEffectVolume(volume);
    }
}
