using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [Tooltip("直接把相应的Slider控件(音效/音乐)挂过来就行")]
    [SerializeField] private Slider _slider;

    [Tooltip("挂到哪个点哪个//挂载到音效控制上就是effect||挂载到音乐控制上就是muisc")]
    [SerializeField] private bool _toggleEffects, _toggleMusic, _enenvironment;
    void Start()
    {
        if (_slider != null && _toggleEffects || _enenvironment != false)
        {
            SoundManager.Instance.ChangeVolumeEffects(_slider.value);
            _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVolumeEffects(val));
        }
        if (_slider != null && _toggleMusic != false)
        {
            SoundManager.Instance.ChangeVolumeMusic(_slider.value);
            _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeVolumeMusic(val));
        }
    }



    public void Toggle()
    {
        if (_toggleEffects) SoundManager.Instance.ToggleEffects();
        if (_toggleMusic) SoundManager.Instance.ToggleMusic();
    }

}
