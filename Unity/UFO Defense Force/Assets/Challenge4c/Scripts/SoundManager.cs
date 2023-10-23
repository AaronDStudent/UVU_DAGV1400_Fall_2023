using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource SFXSource;

    public AudioClip explosionUFO;
    public AudioClip gameOverSound;
    public AudioClip laserBoltSound;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
