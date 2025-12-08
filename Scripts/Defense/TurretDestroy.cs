using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDestroy : MonoBehaviour
{
    public float gameTime = 7;

   
    // Update is called once per frame
    void Update()
    {
        if (!OneStageWaveSpawner.dragnow)
        {
            return;
        }    
        else
        {
            gameTime -= Time.deltaTime;
        }
   

        if (gameTime <= 0)
        {
            Destroy(gameObject);
        }


    }
}
