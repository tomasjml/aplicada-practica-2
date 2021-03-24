using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStarter : MonoBehaviour
{
    public GameObject audioManager;
    void Awake()
    {
        if (AudioManager.instance == null)
        {
            Instantiate(audioManager);
        }
        AudioManager.instance.PlayBackgroundMusic(AudioManager.BackgroundMusic.BackgroundMusicMenu);
    }
}
