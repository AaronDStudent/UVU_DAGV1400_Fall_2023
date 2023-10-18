using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Gets commands necessary to use User Interface objects.

public class MainMenuScript : MonoBehaviour
{
    public int sceneToLoad;
    
    //Changed from the set MonoBehavior "start" to a custom function. "public" lets the function be accessed from another script outside of this one.
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //Scene to load, which scene are we going to load?
        Debug.Log("New scene loaded!");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }

}
