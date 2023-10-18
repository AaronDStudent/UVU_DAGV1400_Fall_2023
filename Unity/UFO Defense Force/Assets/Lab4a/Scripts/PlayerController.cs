using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange;

    public Transform blaster;
    public GameObject laserBolt;

    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager script on GameManager object.
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        //Moves player left and right.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keep player within bonds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //If spacebar is pressed, fire laser bolt.
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) //Second condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes true.
        {
            //Creates laserbolt at blaster transform position, maintaining the objects rotation.
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }

    [SerializeField] private GameObject[] inventory;
    
    //Delete any object with a trigger that hits the player.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Items")
        {
            inventory[0] = other.gameObject;
            for (int i = 0; i < inventory.Length; i++)
            {
                Debug.Log(inventory[i]);
            }
            Destroy(other.gameObject);
        }
        
    }
}