using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public float musicVol,effectsVol;
    public static SoundManager Instance;

    [Serializable]
    public struct PrefabData
    {
        [Tooltip("音乐名字")]
        public string _clipName;
        [Tooltip("音乐资源")]
        public AudioClip _clipSource;
    }
    [Tooltip("可以使用字符串绑定相应的音乐资源，方便统一调用和录入")]
    public List<PrefabData> _soundClipList = new List<PrefabData>();

    public Dictionary<string, AudioClip> soundClip = new Dictionary<string, AudioClip>();
    private Dictionary<AudioClip, float> soundTime = new Dictionary<AudioClip, float>();

    private void Start()
    {
        // 字典内容添加
        for (int i = 0; i < _soundClipList.Count; i++)
        {
            soundClip.Add(_soundClipList[i]._clipName, _soundClipList[i]._clipSource);
            soundTime.Add(_soundClipList[i]._clipSource, 0f);
        }
        musicVol = _musicSource.volume;
        effectsVol = _effectsSource.volume;
    }


    [SerializeField] private AudioSource _musicSource, _effectsSource;

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


    public void MusciPlayClip(AudioClip clip)
    {
        if (_musicSource.clip != null) soundTime[_musicSource.clip] = _musicSource.time;
        _musicSource.Stop();
        _musicSource.clip = clip;
        _musicSource.Play();
        _musicSource.time = soundTime[clip];
    }

    public void EffectPlayClip(AudioClip clip)
    {
        _effectsSource.Stop();
        _effectsSource.PlayOneShot(clip);
    }

    public void ChangeVolumeMusic(float value)
    {
        _musicSource.volume = value;
        musicVol = value;
    }
    public void ChangeVolumeEffects(float value)
    {
        _effectsSource.volume = value;
        effectsVol = value;
    }

    public void ToggleEffects()
    {
        _effectsSource.mute = !_effectsSource.mute;
    }
    public void ToggleMusic()
    {

        _musicSource.mute = !_musicSource.mute;
    }

    public void MuscilPlayStr(string str)
    {
        if (soundClip.ContainsKey(str)) MusciPlayClip(soundClip[str]);
    }
    public void EffectPlayStr(string str)
    {
        if (soundClip.ContainsKey(str)) EffectPlayClip(soundClip[str]);
    }
}
