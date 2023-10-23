using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource SFXSource;

    public AudioClip beep;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
