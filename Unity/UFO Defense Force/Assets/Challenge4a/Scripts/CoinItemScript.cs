using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItemScript : MonoBehaviour
{
    public float lowerBounds = -18.0f;
    
    public float speed = 20.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        
        if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
