using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownSlider : MonoBehaviour
{
    public Slider countTimeValue;
    float countTemp;
    OneStageWaveSpawner oneStage;

    private void Awake()
    {
        oneStage = GameObject.Find("GameMaster").GetComponent<OneStageWaveSpawner>();
    }

    private void Update()
    {
        countTemp = oneStage.countdown;


        countTimeValue.value = countTemp;


    }
}
