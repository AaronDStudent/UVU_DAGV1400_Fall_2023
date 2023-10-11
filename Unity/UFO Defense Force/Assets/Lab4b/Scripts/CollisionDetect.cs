using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//Destroys this game object.
        Destroy(other.gameObject);//Destroys the other game object it hits.
    }
}
