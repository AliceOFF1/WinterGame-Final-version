using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{
    public float currentHealth;
    public float currentFreazen;
    public float currentEat;
    public float[] position;



    public PlayerData(PlayerController playerController)
    {
        currentHealth = playerController.currentHealth;
        currentFreazen = playerController.currentFreazen;
        currentEat = playerController.currentEat;




        position = new float[3];
        position[0] = playerController.transform.position.x;
        position[1] = playerController.transform.position.y;
        position[2] = playerController.transform.position.z;


    }







}