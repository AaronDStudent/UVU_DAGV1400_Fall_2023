using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndTheInspector : MonoBehaviour
{
    public string myName = "none";
    // Use this for initialization.
    void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}
