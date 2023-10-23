using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
  public AudioSource button;
  public AudioClip sfx;

  public void ButtonPress()
  {
    button.clip = sfx;
    //button.Play();
  }
}
