using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMoveForward : MonoBehaviour
{
    public float speed = 50.0f;
    // Update is called once per frame
    void Update()
    {
        //Moves game object forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
