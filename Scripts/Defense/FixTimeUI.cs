using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FixTimeUI : MonoBehaviour
{
    public Slider fixtimevalue;
    float fixPoint;
    OneStageWaveSpawner oneStage;

    private void Awake()
    {
        oneStage = GameObject.Find("GameMaster").GetComponent<OneStageWaveSpawner>();
    }

    private void Update()
    {
        fixPoint = oneStage.timeBetweenWaves;


        fixtimevalue.value = fixPoint;


    }
}
