using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticleScript : MonoBehaviour
{
    private SoundManager soundManager;
    
    private void Awake()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //soundManager.PlaySFX(soundManager.explosionUFO);
    }
}
