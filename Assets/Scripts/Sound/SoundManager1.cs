using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManager1 : MonoBehaviour
{
    public static SoundManager1 Instance;

    [SerializeField]
    private AudioMixer masterAudioMixer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetMusicVolume(float volume)
    {
        masterAudioMixer.SetFloat("MusicVolume",volume);
    }
    public void SetEffectVolume(float volume)
    {
        masterAudioMixer.SetFloat("EffectVolume",volume);
    }
}
