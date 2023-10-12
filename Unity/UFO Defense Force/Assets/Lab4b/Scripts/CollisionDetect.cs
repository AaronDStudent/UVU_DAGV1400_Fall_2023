using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void Awake()
    {
        Time.timeScale = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(gameObject);//Destroys this game object.
            Destroy(other.gameObject);//Destroys the other game object it hits.
        }

    }
}
