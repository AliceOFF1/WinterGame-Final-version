using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavelManager : MonoBehaviour
{
    public void Restart()
    {
        //1-Restart the scene 

        SceneManager.LoadScene(3);

        //2-Reset the player's position 
        //Save the  player's initial position when game start 
        //When respawning simply repositin the player to that init positio  n
    }

}


