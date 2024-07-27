using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class AudioScript : MonoBehaviour
    {
        AudioSource m_MyAudioSource;
        float m_MySliderValue;

        void Start()
        {
            m_MySliderValue = 1f;
            m_MyAudioSource = GetComponent<AudioSource>();
            m_MyAudioSource.Play();
        }

        void OnGUI()
        {
            Slider SoundSlider = GameObject.Find("Music_Slider").GetComponent<Slider>();
            m_MySliderValue = SoundSlider.value;
            m_MyAudioSource.volume = m_MySliderValue;
        }
    }

