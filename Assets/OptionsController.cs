﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.6f;

    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 1f;

    void Start()
    {
        volumeSlider.value = PlayPrefsController.GetMasterVolume();
        difficultySlider.value = PlayPrefsController.GetDifficulty();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found.. Make sure to start from Splash Screen");
        }
    }

    public void SaveAndExit()
    {
        PlayPrefsController.SetMasterVolume(volumeSlider.value);
        PlayPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
