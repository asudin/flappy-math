using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSounds : MonoBehaviour
{
    private static MusicSounds backgroundMusic;

    void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}